using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Doolittle_Lab5
{
    /* I created my own component called a HintTextBox, since I felt like it made sense but I couldn't find a built in component to do the job
     */

    public partial class Form1 : Form
    {
        private static readonly string INVALID_TEXT = "INVALID";

        private Person person;

         
        public Form1()
        {
            InitializeComponent();

        }

        private bool Validate(in HintTextBox t)
        {
            
            bool valid;
            if (t.IsHint)
            {
                valid = false;
            }
            else
            {
                switch (t.Tag)
                {
                    case "Name":
                        valid = Basic_Tools.ValidateName(t.Text);
                        break;
                    case "Street":
                        valid = Basic_Tools.ValidateStreet(t.Text);
                        break;
                    case "City":
                        valid = Basic_Tools.ValidateCity(t.Text);
                        break;
                    case "State":
                        valid = Basic_Tools.ValidateState(t.Text);
                        break;
                    case "Zip":
                        valid = Basic_Tools.ValidateZipCode(t.Text);
                        break;
                    case "Email":
                        valid = Basic_Tools.ValidateEmail(t.Text);
                        break;
                    case "Phone":
                        valid = Basic_Tools.ValidatePhone(t.Text);
                        break;
                    default:
                        valid = false;
                        break;
                }
            }
            if (!valid)
            {
                t.ForeColor = Color.Red;
            }
            t.Valid = valid;
            return valid;
        }

        private bool ValidControlSearch(Control control)
        {
            bool valid = true;
            foreach (Control j in control.Controls)
            {
                
                if (j is GroupBox group)
                {
                    valid = ValidControlSearch(group);
                } else if (j is HintTextBox)
                {
                    valid = Validate((HintTextBox) j) & valid;
                }
            }
            return valid;
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            person = new Person();
            ValidControlSearch(groupbox_input);

            person.NameFirst = (textbox_name_first.Valid) ? textbox_name_first.Text : INVALID_TEXT;
            person.NameMiddle = (textbox_name_middle.Valid) ? textbox_name_middle.Text : INVALID_TEXT;
            person.NameLast = (textbox_name_last.Valid) ? textbox_name_last.Text : INVALID_TEXT;
            person.Street1 = (textbox_street1.Valid) ? textbox_street1.Text : INVALID_TEXT;
            person.Street2 = (textbox_street2.Valid) ? textbox_street2.Text : INVALID_TEXT;
            person.State = (textbox_state.Valid) ? textbox_state.Text : INVALID_TEXT;
            person.Zip = (textbox_zip.Valid) ? textbox_zip.Text : INVALID_TEXT;
            person.City = (textbox_city.Valid) ? textbox_city.Text : INVALID_TEXT;
            person.Email = (textbox_email.Valid) ? textbox_email.Text : INVALID_TEXT;
            person.Phone = (textbox_phone.Valid) ? textbox_phone.Text : INVALID_TEXT;

            textbox_output.Text = person.Print();
        }
    }
}
