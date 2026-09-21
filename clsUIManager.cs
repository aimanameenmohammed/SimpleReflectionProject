using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflectionProject
{
    public class clsUIManager
    {


       
        private static void GenerateMethodsInputParameters(ParameterInfo[] Parameters, ref FlowLayoutPanel flowLayoutPanel)
        {


            foreach (ParameterInfo parameter in Parameters)
            {
                GenerateInputs(parameter.ParameterType, parameter.Name, ref flowLayoutPanel);
            }

        }

        private static void GeneratePropertyInput(PropertyInfo property, ref FlowLayoutPanel flowLayoutPanel)
        {
            if(property.CanWrite)
            GenerateInputs(property.PropertyType, property.Name, ref flowLayoutPanel);


        }

        private static void GenerateInputs(Type type,string Name, ref FlowLayoutPanel flowLayoutPanel)
        {
          

                Panel panel = new Panel();
                panel.Width = 5000;
                panel.Height = 45;


                Label label = new Label();
                label.Width = 100;
                label.Location = new Point(0, 10);


                label.Text = Name;
                label.AutoSize = true;

                Control Input;



            if (type == typeof(DateTime))
                Input = new DateTimePicker();
            else if (type == typeof(TimeSpan))
            {
                DateTimePicker Picker = new DateTimePicker();
                Picker.Format = DateTimePickerFormat.Time;
                Picker.ShowUpDown = true;
                Input = Picker;

            }
            else if (type == typeof(int) || type == typeof(byte))
            {
                NumericUpDown numericUpDown = new NumericUpDown();
                numericUpDown.Maximum = 2000;
                Input = numericUpDown;
            }
            else if (type == typeof(Int16))
            {
                NumericUpDown numericUpDown = new NumericUpDown();
                if (Name == "Gender" || Name == "Gendor")
                {
                    numericUpDown.Maximum = 1;
                }

                Input = numericUpDown;
            }
            else if (type == typeof(bool))
                Input = new CheckBox();
            else
                Input = new TextBox();


                Input.Width = 250;
                Input.Location = new Point(155, 6);


                panel.Controls.Add(label);
                panel.Controls.Add(Input);

                flowLayoutPanel.Controls.Add(panel);
            

        }

        public static void GenerateInputs(MemberInfo Member, ref FlowLayoutPanel flowLayoutPanel)
        {

            if (Member is MethodInfo method)
                GenerateMethodsInputParameters(method.GetParameters(), ref flowLayoutPanel);
            else if (Member is PropertyInfo property)
                GeneratePropertyInput(property, ref flowLayoutPanel);

        }

        private static object[] GetMethodParameterValues(ParameterInfo[] SelectedParameters, FlowLayoutPanel flyParameters)
        {

            object[] Values = new object[SelectedParameters.Length];

            for (int i = 0; i < SelectedParameters.Length; i++)
            {

                Values[i] = GetValuesFromUI(SelectedParameters[i].ParameterType,(Panel)flyParameters.Controls[i]);

            }

            return Values;

        }
        private static object[] GetPropertyInputValue(PropertyInfo property, FlowLayoutPanel flyParameters)
        {

            object[] Values = new object[1];

            Values[0] = GetValuesFromUI(property.PropertyType, (Panel)flyParameters.Controls[0]);
            
            return Values;

        }
           
        private static object GetValuesFromUI(Type type, Panel panel)
        {

            object Values = new object();

            
            Control Input = panel.Controls[1];


            if (type == typeof(DateTime))
                Values = ((DateTimePicker)Input).Value;
            else if (type == typeof(TimeSpan))
                Values = ((DateTimePicker)Input).Value;
            else if (type == typeof(int))
                Values = int.Parse(Input.Text);
            else if (type == typeof(byte))
                Values = byte.Parse(Input.Text);
            else if (type == typeof(Int16))
            {
                Values = Int16.Parse(Input.Text);
            }

            else if (type == typeof(bool))
                Values= ((CheckBox)Input).Checked;
            else
                Values= Input.Text;


            return Values;
        }

        public static object[] GetValuesFromUI(MemberInfo Member, FlowLayoutPanel flyParameters)
        {

            if (Member is MethodInfo method)
                return GetMethodParameterValues(method.GetParameters(), flyParameters);
            else if (Member is PropertyInfo property)
                return GetPropertyInputValue(property, flyParameters);


            return null;
        }


    }
}
