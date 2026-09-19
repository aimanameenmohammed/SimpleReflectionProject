using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ReflectionProject
{
    public class clsUIManager
    {


        public static void GenerateInput(ParameterInfo[] SelectedParameters, ref FlowLayoutPanel flowLayoutPanel)
        {


            foreach (ParameterInfo parameter in SelectedParameters)
            {

                Panel panel = new Panel();
                panel.Width = 5000;
                panel.Height = 45;


                Label label = new Label();
                label.Width = 100;
                label.Location = new Point(0, 10);


                label.Text = parameter.Name;
                label.AutoSize = true;

                Control Input;



                if (parameter.ParameterType == typeof(DateTime))
                    Input = new DateTimePicker();
                else if (parameter.ParameterType == typeof(TimeSpan))
                {
                    DateTimePicker Picker = new DateTimePicker();
                    Picker.Format = DateTimePickerFormat.Time;
                    Picker.ShowUpDown = true;
                    Input = Picker;

                }
                else if (parameter.ParameterType == typeof(int) || parameter.ParameterType == typeof(byte))
                {
                    NumericUpDown numericUpDown = new NumericUpDown();
                    numericUpDown.Maximum = 2000;
                    Input = numericUpDown;
                }
                else if (parameter.ParameterType == typeof(Int16))
                {
                    NumericUpDown numericUpDown = new NumericUpDown();
                    if (parameter.Name == "Gender" || parameter.Name == "Gendor")
                    {
                        numericUpDown.Maximum = 1;
                    }

                    Input = numericUpDown;
                }
                else if (parameter.ParameterType == typeof(bool))
                    Input = new CheckBox();
                else
                    Input = new TextBox();


                Input.Width = 250;
                Input.Location = new Point(155, 6);


                panel.Controls.Add(label);
                panel.Controls.Add(Input);

                flowLayoutPanel.Controls.Add(panel);
            }

        }

        public static object[] GetValuesFromUI(ParameterInfo[] SelectedParameters,FlowLayoutPanel flyParameters)
        {
            object[] Values = new object[SelectedParameters.Length];

            for (int i = 0; i < SelectedParameters.Length; i++)
            {



                ParameterInfo parameterInfo = SelectedParameters[i];
                Panel panel = (Panel)flyParameters.Controls[i];
                Control Input = panel.Controls[1];


                if (parameterInfo.ParameterType == typeof(DateTime))
                    Values[i] = ((DateTimePicker)Input).Value;
                else if (parameterInfo.ParameterType == typeof(TimeSpan))
                    Values[i] = ((DateTimePicker)Input).Value;
                else if (parameterInfo.ParameterType == typeof(int))
                    Values[i] = int.Parse(Input.Text);
                else if (parameterInfo.ParameterType == typeof(byte))
                    Values[i] = byte.Parse(Input.Text);
                else if (parameterInfo.ParameterType == typeof(Int16))
                {
                    Values[i] = Int16.Parse(Input.Text);
                }

                else if (parameterInfo.ParameterType == typeof(bool))
                    Values[i] = ((CheckBox)Input).Checked;
                else
                    Values[i] = Input.Text;


            }

          return Values;


        }


    }
}
