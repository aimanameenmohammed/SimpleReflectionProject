using FontAwesome.Sharp;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        bool IsStatic=false;
        MemberInfo _SelectedMember;
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

      

        void BuildInputs()
        {

            flyParameters.Controls.Clear();
            clsUIManager.GenerateInputs(_SelectedMember, ref flyParameters);

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





 
        void ShowMethodParameters(ParameterInfo[] Parameters)
        {
            dgvShowParameters.Rows.Clear();

            foreach(var Parameter in Parameters)
            {
                dgvShowParameters.Rows.Add(Parameter.Name, Parameter.ParameterType.Name, Parameter.IsOptional);
            }

        }


        void ShowDetail<T, U, K>(T Name, U ReturnType, K IsStatic) 
        {

            lblSelectedName.Text = Name.ToString();
            lblSelectedReturnType.Text =ReturnType.ToString();
            lblIsSelectedStatic.Text = IsStatic.ToString();

        }



        void PrintAllSelectedClassDetails()
        {

            lbMethodList.Items.Clear();
            MemberInfo[] Members = _SelectedClass.GetMembers();

            foreach (MemberInfo Member in Members)
            {

                if(Member is MethodInfo Method && !Method.IsSpecialName)
                {
                    lbMethodList.Items.Add(new clsMemberItem { member = Method, Name = Method.Name, Type = "Method" });
                }

                else if (Member is PropertyInfo property)
                {
                    lbMethodList.Items.Add(new clsMemberItem { member = property, Name = property.Name, Type = "Property" });
                }
            }
        }


        private void lbMethodList_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakeSomeContorlsEmpty();

            int Index = lbMethodList.SelectedIndex;
            if (Index != -1)
            {


                _SelectedMember = ((clsMemberItem)lbMethodList.SelectedItem).member;


                if (_SelectedMember is MethodInfo Method)
                {
                    IsStatic= Method.IsStatic;

                    ShowDetail(Method.Name, Method.ReturnType, IsStatic);
                    ShowMethodParameters(Method.GetParameters());
                   
                }
                else if(_SelectedMember is PropertyInfo property)
                {
                    if (!property.CanWrite)
                        MessageBox.Show(@"this Property Read-only and cannot be assigned a value");
                    else
                        IsStatic = (property.SetMethod.IsStatic);

                    ShowDetail(property.Name, property.PropertyType, IsStatic);

                }

                BuildInputs();
            }



        }

        private object ExecuteMember()
        {
            if (_SelectedMember is MethodInfo method)
                return method?.Invoke(_Instance, _Values);
            else if (_SelectedMember is PropertyInfo property)
            {
                property.SetValue(_Instance, _Values.GetValue(0));
                return property.GetValue(_Instance);
            }

            return null;
        }

        void Execute()
        {
            lblResult.Text = "";    

            if (!IsStatic)
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

                foreach(PropertyInfo property in PropertiesInfo)
                {



                    object Value = property.GetValue(Result);
                    lblResult.Text += property.Name + " : " + Value + Environment.NewLine;

                }

            }
            else
                lblResult.Text = Result?.ToString();

        }




        void GetValuesFromUI()
        {
            _Values = clsUIManager.GetValuesFromUI(_SelectedMember, flyParameters);

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
            lblSelectedName.Text = string.Empty;
            lblSelectedReturnType.Text = string.Empty;
            lblIsSelectedStatic.Text = string.Empty;

            txtDLLPath.Text= string.Empty;

        }
    }
}
