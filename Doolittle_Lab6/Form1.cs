using LibValidation;
using System;
using System.Drawing;
using System.Windows.Forms;



namespace Doolittle_Lab5
{
    /* I created my own component called a HintTextBox, since I felt like it made sense but I couldn't find a built in component to do the job
     */

    public partial class Form1 : Form
    {
        private PersonV2 person;

        public Form1()
        {
            InitializeComponent();

        }

        private void Validate(in HintTextBox t)
        {
            bool x = false;
                switch (t.Tag)
                {
                   case "Name":
                        x = Validation.IsValidateName(t.GetText());
                        break;
                    case "Street":
                    x = Validation.IsValidateStreet(t.GetText());
                    break;
                    case "City":
                    x = Validation.IsValidateCity(t.GetText());
                    break;
                    case "State":
                    x = Validation.IsValidateState(t.GetText());
                    break;
                    case "Zip":
                    x = Validation.IsValidateZipCode(t.GetText());
                    break;
                    case "Email":
                    x = Validation.IsValidateEmail(t.GetText());
                    break;
                    case "Phone":
                    x = Validation.IsValidatePhone(t.GetText());
                    break;
                    case "Instagram":
                    x = Validation.IsSiteURL(t.GetText(), "instagram.com/");
                    break;
                }
            if (!x) t.ShowInvalidData();
            
        }


        private void ShowVisualError(Control control)
        {
            foreach (Control j in control.Controls)
            {

                if (j is GroupBox group)
                {
                    ShowVisualError(group);
                }
                else if (j is HintTextBox)
                {
                   Validate((HintTextBox)j);
                }
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            
            person = new PersonV2(textbox_name_first.GetText(), textbox_name_middle.GetText(), textbox_name_last.GetText(), textbox_street1.GetText(), 
                textbox_street2.GetText(), textbox_city.GetText(), textbox_state.GetText(), textbox_zip.GetText(), textbox_phone.GetText(),  textbox_email.GetText(), textbox_phone_mobile.GetText(), textbox_instagramURL.GetText());

            ShowVisualError(groupbox_input);

            textbox_output.Text = person.ToString();
        }
    }
}
