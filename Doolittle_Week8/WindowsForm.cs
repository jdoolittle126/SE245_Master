using DoolittleSE245.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DoolittleSE245;
using DoolittleSE245.VisualComponents;
using DoolittleSE245.DataValidation;
using DoolittleSE245.Database;
using DoolittleSE245.Core;

namespace DoolittleSE245
{
    /* I created my own component called a HintTextBox, since I felt like it made sense but I couldn't find a built in component to do the job
     */

    public partial class Form1 : Form
    {
        private PersonV2 person;
        private bool isUpdate;
        private string updateID;

        public Form1()
        {
            isUpdate = false;
            InitializeComponent();
            Init();

        }

        public Form1(string GUID)
        {
            updateID = GUID;
            isUpdate = true;
            InitializeComponent();
            Init();
            LoadPerson(Program.database.GetPerson(GUID));
        }

        private void LoadPerson(PersonV2 p)
        {
            this.textbox_phone.Preload(p.Phone);
            this.textbox_phone_mobile.Preload(p.Mobile);
            this.textbox_instagramURL.Preload(p.InstagramURL);
            this.textbox_email.Preload(p.Email);
            this.textbox_zip.Preload(p.Zip);
            this.textbox_state.Preload(p.State);
            this.textbox_city.Preload(p.City);
            this.textbox_street2.Preload(p.Street2);
            this.textbox_street1.Preload(p.Street1);
            this.textbox_name_last.Preload(p.NameLast);
            this.textbox_name_middle.Preload(p.NameMiddle);
            this.textbox_name_first.Preload(p.NameFirst);
        }

        private void Init()
        {
            if (isUpdate)
            {
                button_submit.Text = "Update";
                label11.Text = "Click update to update our database!";
            }
            this.textbox_phone.SetDataHint(InputDataType.Phone, "(000) 000-0000");
            this.textbox_phone_mobile.SetDataHint(InputDataType.Phone, "(000) 000-0000");
            this.textbox_instagramURL.SetDataHint(InputDataType.Instagram, "https://www.instagram.com/johndoe");
            this.textbox_email.SetDataHint(InputDataType.Email, "johndoe@example.com");
            this.textbox_zip.SetDataHint(InputDataType.Zip, "01234");
            this.textbox_state.SetDataHint(InputDataType.State, "RI");
            this.textbox_city.SetDataHint(InputDataType.City, "Providence");
            this.textbox_street2.SetDataHint(InputDataType.None, "Apartment 2E"); //Does not need to be filled to be valid
            this.textbox_street1.SetDataHint(InputDataType.Street, "123 Example St.");
            this.textbox_name_last.SetDataHint(InputDataType.Name, "Doe");
            this.textbox_name_middle.SetDataHint(InputDataType.None, "Michael"); //Does not need to be filled to be valid
            this.textbox_name_first.SetDataHint(InputDataType.Name, "John");
        }

        private void Validate(in FeedbackTextBox t)
        {
            (bool valid, string feedback) x = (true, "");
                switch (t.DataType)
                {
                case InputDataType.None:
                    break;
                case InputDataType.Name:
                        x = Validation.IsValidateName(t.GetText());
                        break;
                    case InputDataType.Street:
                        x = Validation.IsValidateStreet(t.GetText());
                        break;
                    case InputDataType.City:
                        x = Validation.IsValidateCity(t.GetText());
                        break;
                    case InputDataType.State:
                        x = Validation.IsValidateState(t.GetText());
                        break;
                    case InputDataType.Zip:
                        x = Validation.IsValidateZipCode(t.GetText());
                        break;
                    case InputDataType.Email:
                         x = Validation.IsValidateEmail(t.GetText());
                        break;
                    case InputDataType.Phone:
                        x = Validation.IsValidatePhone(t.GetText());
                        break;
                    case InputDataType.Instagram:
                        x = Validation.IsSiteURL(t.GetText(), "instagram.com/");
                        break;
                }


            t.SetFeedback(x.feedback);
            t.HintVisable(!x.valid);
            t.GetTextBox().IsValid = x.valid;

            
        }


        private void ShowVisualError(Control control)
        {
            foreach (Control j in control.Controls)
            {

                if (j is GroupBox group)
                {
                    ShowVisualError(group);
                }
                else if (j is FeedbackTextBox)
                {
                   Validate((FeedbackTextBox)j);
                }
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            
            person = new PersonV2(textbox_name_first.GetText(), textbox_name_middle.GetText(), textbox_name_last.GetText(), textbox_street1.GetText(), 
                textbox_street2.GetText(), textbox_city.GetText(), textbox_state.GetText(), textbox_zip.GetText(), textbox_phone.GetText(),  textbox_email.GetText(), textbox_phone_mobile.GetText(), textbox_instagramURL.GetText());

            ShowVisualError(groupbox_input);


            if (person.GetValidity())
            {
                bool status;
                string db_feedback;
                if(isUpdate)
                {
                    db_feedback = Program.database.EditPerson(person, updateID, out status);

                } else
                {
                    db_feedback = Program.database.AddPerson(person, out status);

                }
                label12.Text = db_feedback.Substring(0, (db_feedback.Length > 50) ? 50 : db_feedback.Length);
                label12.ForeColor = (status) ? Color.Green : Color.Red;


            }

            this.Refresh();



        }
    }
}
