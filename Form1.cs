using FontAwesome.Sharp;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflectionProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string _DLLpath;
        Assembly _assembly;
        Type[] _types;
        Type _SelectedClass;
        MethodInfo[] _AllSelectedClassMethods;
        MethodInfo _SelectedMethodInfo;
        MemberInfo _SelectedMemberInfo;
        ParameterInfo[] _SelectedParameters;
        object[] _Values;
        object _Instance=null;
        void ShowClasses()
        {

            lbClassList.Items.Clear();  

            _assembly = Assembly.LoadFrom(_DLLpath);
             _types = _assembly.GetTypes();

            if (_types == null)
            {
                MessageBox.Show("This Assembly is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            foreach(Type type in _types)
            {
                lbClassList.Items.Add(type.Name);
            }

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "DLL Files (*.dll)|*.dll";

            openFileDialog1.Title = "Select DLL File";



            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {

                txtDLLPath.Text = openFileDialog1.FileName;
                _DLLpath = @"" + txtDLLPath.Text;
                ShowClasses();

            }
        }

        void PrintAllSelectedClassDetails()
        {

            lbMethodList.Items.Clear();
            _AllSelectedClassMethods = _SelectedClass.GetMethods();
            foreach (var method in _AllSelectedClassMethods)
            {

                lbMethodList.Items.Add(method.Name);
            }


           
        }


        void BuildInputs()
        {

            flyParameters.Controls.Clear();
            clsUIManager.GenerateInput(_SelectedParameters,ref flyParameters);
   
        }

        private void lbClassList_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakeSomeContorlsEmpty();
            int Index = lbClassList.SelectedIndex;
            if (Index != -1)
            {

                _SelectedClass = _types[Index];

                if (_SelectedClass != null)
                {

                    PrintAllSelectedClassDetails();
                }
            }

        }






        void ShowParameters()
        {
            dgvShowParameters.Rows.Clear();

            _SelectedParameters=_SelectedMethodInfo.GetParameters();
            foreach(var Parameter in _SelectedParameters)
            {
                dgvShowParameters.Rows.Add(Parameter.Name, Parameter.ParameterType.Name, Parameter.IsOptional);
            }
            BuildInputs();

        }


        void ShowDetail(MethodInfo method)
        {

            lblMethodName.Text = method.Name;
            lblMethodReturnType.Text = method.ReturnType.ToString();
            lblisStatic.Text = method.IsStatic.ToString();

        }

        private void lbMethodList_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakeSomeContorlsEmpty();


            int Index = lbMethodList.SelectedIndex;
            if (Index != -1)
            {

                _SelectedMemberInfo = _AllSelectedClassMethods[Index];
                _SelectedMethodInfo = _AllSelectedClassMethods[Index];
                ShowDetail(_SelectedMethodInfo);     
                ShowParameters();
            }



        }

        private object ExecuteMember()
        {
            if (_SelectedMemberInfo is MethodInfo method)
                return method?.Invoke(_Instance, _Values);
            else if (_SelectedMemberInfo is PropertyInfo property)
            {
                property.SetValue(_Instance, _Values);
                return property.GetValue(_Instance);
            }

            return null;
        }

        void Execute()
        {
            lblResult.Text = "";    

            if (!_SelectedMethodInfo.IsStatic || _SelectedMemberInfo is PropertyInfo Property)
                _Instance = Activator.CreateInstance(_SelectedClass);
           

            object Result = ExecuteMember();

            if (Result==null)
            {
                MessageBox.Show("No Value Returned", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if(Result is DataTable datatable)
            {


                dataGridView1.Visible = true;
                dataGridView1 .DataSource = datatable;
                lblResult.Visible = false;

                return;
            }
            else
            {
                lblResult.Visible = true;
                dataGridView1.Visible=false;
            }



            PropertyInfo[] PropertiesInfo = Result.GetType().GetProperties();
            if (PropertiesInfo.Length>0)
            {

                foreach(var Property in PropertiesInfo)
                {



                    object Value = Property.GetValue(Result);
                    lblResult.Text += Property.Name + " : " + Value + Environment.NewLine;

                }

            }
            else
                lblResult.Text = Result?.ToString();

        }




        void GetValuesFromUI()
        {
            _Values = clsUIManager.GetValuesFromUI(_SelectedParameters, flyParameters);

            Execute();


        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {

            GetValuesFromUI();

        }


        void MakeSomeContorlsEmpty()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Visible = false;
            dataGridView1.Visible = false;
            lblResult.Text = string.Empty;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            lbClassList.Items.Clear();
            lbMethodList.Items.Clear();
            dgvShowParameters.Rows.Clear();
            flyParameters.Controls.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Visible = false;
            lblResult.Text = string.Empty;
            lblMethodName.Text = string.Empty;
            lblMethodReturnType.Text = string.Empty;
            lblisStatic.Text = string.Empty;

            txtDLLPath.Text= string.Empty;

        }
    }
}
