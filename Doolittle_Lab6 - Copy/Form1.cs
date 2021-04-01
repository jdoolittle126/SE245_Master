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
        private Customer person;

        public Form1()
        {
            InitializeComponent();
            this.textbox_phone.SetHint("(000) 000-0000");
            this.textbox_phone_mobile.SetHint("(000) 000-0000");
            this.textbox_instagramURL.SetHint("https://www.instagram.com/johndoe");
            this.textbox_email.SetHint("johndoe@example.com");
            this.textbox_zip.SetHint("01234");
            this.textbox_state.SetHint("RI");
            this.textbox_city.SetHint("Providence");
            this.textbox_street2.SetHint("Apartment 2E");
            this.textbox_street1.SetHint("123 Example St.");
            this.textbox_name_last.SetHint("Doe");
            this.textbox_name_middle.SetHint("Michael");
            this.textbox_name_first.SetHint("John");

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
                    case "Positive":
                    x = Validation.IsPositive(t.GetText());
                    break;
                    case "Reward":
                    x = Validation.IsPositive(t.GetText()) && int.TryParse(t.GetText(), out _);
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
            
            person = new Customer(textbox_name_first.GetText(), textbox_name_middle.GetText(), textbox_name_last.GetText(), textbox_street1.GetText(), 
                textbox_street2.GetText(), textbox_city.GetText(), textbox_state.GetText(), textbox_zip.GetText(), textbox_phone.GetText(),  textbox_email.GetText(), textbox_phone_mobile.GetText(), textbox_instagramURL.GetText(),
                 dateTimePicker1.Value, textbox_totalpurchase.GetText(), checkbox_custSince.Checked,  textbox_rewards.GetText());

            ShowVisualError(groupbox_input);

            textbox_output.Text = person.ToString();
        }

    }
}
