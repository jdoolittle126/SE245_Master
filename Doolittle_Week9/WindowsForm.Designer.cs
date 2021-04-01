using DoolittleSE245.VisualComponents;

namespace DoolittleSE245
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupbox_input = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.groupbox_contact = new System.Windows.Forms.GroupBox();
            this.textbox_phone_mobile = new DoolittleSE245.VisualComponents.FeedbackTextBox();
            this.textbox_instagramURL = new DoolittleSE245.VisualComponents.FeedbackTextBox();
            this.textbox_phone = new DoolittleSE245.VisualComponents.FeedbackTextBox();
            this.textbox_email = new DoolittleSE245.VisualComponents.FeedbackTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupbox_address = new System.Windows.Forms.GroupBox();
            this.textbox_zip = new DoolittleSE245.VisualComponents.FeedbackTextBox();
            this.textbox_state = new DoolittleSE245.VisualComponents.FeedbackTextBox();
            this.textbox_street2 = new DoolittleSE245.VisualComponents.FeedbackTextBox();
            this.textbox_street1 = new DoolittleSE245.VisualComponents.FeedbackTextBox();
            this.textbox_city = new DoolittleSE245.VisualComponents.FeedbackTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupbox_name = new System.Windows.Forms.GroupBox();
            this.textbox_name_last = new DoolittleSE245.VisualComponents.FeedbackTextBox();
            this.textbox_name_middle = new DoolittleSE245.VisualComponents.FeedbackTextBox();
            this.textbox_name_first = new DoolittleSE245.VisualComponents.FeedbackTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupbox_input.SuspendLayout();
            this.groupbox_contact.SuspendLayout();
            this.groupbox_address.SuspendLayout();
            this.groupbox_name.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox_input
            // 
            this.groupbox_input.Controls.Add(this.label12);
            this.groupbox_input.Controls.Add(this.label11);
            this.groupbox_input.Controls.Add(this.button_submit);
            this.groupbox_input.Controls.Add(this.groupbox_contact);
            this.groupbox_input.Controls.Add(this.groupbox_address);
            this.groupbox_input.Controls.Add(this.groupbox_name);
            this.groupbox_input.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold);
            this.groupbox_input.Location = new System.Drawing.Point(12, 12);
            this.groupbox_input.Name = "groupbox_input";
            this.groupbox_input.Size = new System.Drawing.Size(669, 624);
            this.groupbox_input.TabIndex = 0;
            this.groupbox_input.TabStop = false;
            this.groupbox_input.Text = "Input";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(39, 608);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 14;
            // 
            // button_submit
            // 
            this.button_submit.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit.Location = new System.Drawing.Point(350, 564);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(145, 28);
            this.button_submit.TabIndex = 12;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // groupbox_contact
            // 
            this.groupbox_contact.Controls.Add(this.textbox_phone_mobile);
            this.groupbox_contact.Controls.Add(this.textbox_instagramURL);
            this.groupbox_contact.Controls.Add(this.textbox_phone);
            this.groupbox_contact.Controls.Add(this.textbox_email);
            this.groupbox_contact.Controls.Add(this.label10);
            this.groupbox_contact.Controls.Add(this.label9);
            this.groupbox_contact.Controls.Add(this.label16);
            this.groupbox_contact.Controls.Add(this.label17);
            this.groupbox_contact.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold);
            this.groupbox_contact.Location = new System.Drawing.Point(32, 409);
            this.groupbox_contact.Name = "groupbox_contact";
            this.groupbox_contact.Size = new System.Drawing.Size(631, 135);
            this.groupbox_contact.TabIndex = 11;
            this.groupbox_contact.TabStop = false;
            this.groupbox_contact.Text = "Contact";
            // 
            // textbox_phone_mobile
            // 
            this.textbox_phone_mobile.DataType = DoolittleSE245.VisualComponents.InputDataType.None;
            this.textbox_phone_mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textbox_phone_mobile.Location = new System.Drawing.Point(267, 97);
            this.textbox_phone_mobile.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textbox_phone_mobile.Name = "textbox_phone_mobile";
            this.textbox_phone_mobile.Size = new System.Drawing.Size(235, 27);
            this.textbox_phone_mobile.TabIndex = 18;
            // 
            // textbox_instagramURL
            // 
            this.textbox_instagramURL.DataType = DoolittleSE245.VisualComponents.InputDataType.None;
            this.textbox_instagramURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textbox_instagramURL.Location = new System.Drawing.Point(22, 97);
            this.textbox_instagramURL.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textbox_instagramURL.Name = "textbox_instagramURL";
            this.textbox_instagramURL.Size = new System.Drawing.Size(235, 27);
            this.textbox_instagramURL.TabIndex = 17;
            // 
            // textbox_phone
            // 
            this.textbox_phone.DataType = DoolittleSE245.VisualComponents.InputDataType.None;
            this.textbox_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textbox_phone.Location = new System.Drawing.Point(267, 43);
            this.textbox_phone.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textbox_phone.Name = "textbox_phone";
            this.textbox_phone.Size = new System.Drawing.Size(235, 27);
            this.textbox_phone.TabIndex = 16;
            // 
            // textbox_email
            // 
            this.textbox_email.DataType = DoolittleSE245.VisualComponents.InputDataType.None;
            this.textbox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textbox_email.Location = new System.Drawing.Point(22, 43);
            this.textbox_email.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.Size = new System.Drawing.Size(235, 27);
            this.textbox_email.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(329, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Home Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(89, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Email";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(329, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 19);
            this.label16.TabIndex = 12;
            this.label16.Text = "Mobile Phone";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(60, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 19);
            this.label17.TabIndex = 10;
            this.label17.Text = "Instagram URL";
            // 
            // groupbox_address
            // 
            this.groupbox_address.Controls.Add(this.textbox_zip);
            this.groupbox_address.Controls.Add(this.textbox_state);
            this.groupbox_address.Controls.Add(this.textbox_street2);
            this.groupbox_address.Controls.Add(this.textbox_street1);
            this.groupbox_address.Controls.Add(this.textbox_city);
            this.groupbox_address.Controls.Add(this.label8);
            this.groupbox_address.Controls.Add(this.label7);
            this.groupbox_address.Controls.Add(this.label6);
            this.groupbox_address.Controls.Add(this.label2);
            this.groupbox_address.Controls.Add(this.label1);
            this.groupbox_address.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold);
            this.groupbox_address.Location = new System.Drawing.Point(32, 141);
            this.groupbox_address.Name = "groupbox_address";
            this.groupbox_address.Size = new System.Drawing.Size(631, 249);
            this.groupbox_address.TabIndex = 10;
            this.groupbox_address.TabStop = false;
            this.groupbox_address.Text = "Address";
            // 
            // textbox_zip
            // 
            this.textbox_zip.DataType = DoolittleSE245.VisualComponents.InputDataType.None;
            this.textbox_zip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textbox_zip.Location = new System.Drawing.Point(181, 206);
            this.textbox_zip.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textbox_zip.Name = "textbox_zip";
            this.textbox_zip.Size = new System.Drawing.Size(126, 27);
            this.textbox_zip.TabIndex = 14;
            // 
            // textbox_state
            // 
            this.textbox_state.DataType = DoolittleSE245.VisualComponents.InputDataType.None;
            this.textbox_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textbox_state.Location = new System.Drawing.Point(22, 206);
            this.textbox_state.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textbox_state.Name = "textbox_state";
            this.textbox_state.Size = new System.Drawing.Size(117, 27);
            this.textbox_state.TabIndex = 13;
            // 
            // textbox_street2
            // 
            this.textbox_street2.DataType = DoolittleSE245.VisualComponents.InputDataType.None;
            this.textbox_street2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_street2.Location = new System.Drawing.Point(22, 104);
            this.textbox_street2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textbox_street2.Name = "textbox_street2";
            this.textbox_street2.Size = new System.Drawing.Size(593, 27);
            this.textbox_street2.TabIndex = 11;
            // 
            // textbox_street1
            // 
            this.textbox_street1.DataType = DoolittleSE245.VisualComponents.InputDataType.None;
            this.textbox_street1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_street1.Location = new System.Drawing.Point(22, 56);
            this.textbox_street1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textbox_street1.Name = "textbox_street1";
            this.textbox_street1.Size = new System.Drawing.Size(593, 27);
            this.textbox_street1.TabIndex = 10;
            // 
            // textbox_city
            // 
            this.textbox_city.DataType = DoolittleSE245.VisualComponents.InputDataType.None;
            this.textbox_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textbox_city.Location = new System.Drawing.Point(22, 153);
            this.textbox_city.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textbox_city.Name = "textbox_city";
            this.textbox_city.Size = new System.Drawing.Size(285, 27);
            this.textbox_city.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(177, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Zip Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "City / Province / Region";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address Line 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Address Line 1";
            // 
            // groupbox_name
            // 
            this.groupbox_name.Controls.Add(this.textbox_name_last);
            this.groupbox_name.Controls.Add(this.textbox_name_middle);
            this.groupbox_name.Controls.Add(this.textbox_name_first);
            this.groupbox_name.Controls.Add(this.label5);
            this.groupbox_name.Controls.Add(this.label4);
            this.groupbox_name.Controls.Add(this.label3);
            this.groupbox_name.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_name.Location = new System.Drawing.Point(32, 26);
            this.groupbox_name.Name = "groupbox_name";
            this.groupbox_name.Size = new System.Drawing.Size(631, 88);
            this.groupbox_name.TabIndex = 9;
            this.groupbox_name.TabStop = false;
            this.groupbox_name.Text = "Name";
            // 
            // textbox_name_last
            // 
            this.textbox_name_last.DataType = DoolittleSE245.VisualComponents.InputDataType.None;
            this.textbox_name_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textbox_name_last.Location = new System.Drawing.Point(420, 50);
            this.textbox_name_last.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textbox_name_last.Name = "textbox_name_last";
            this.textbox_name_last.Size = new System.Drawing.Size(195, 27);
            this.textbox_name_last.TabIndex = 11;
            // 
            // textbox_name_middle
            // 
            this.textbox_name_middle.DataType = DoolittleSE245.VisualComponents.InputDataType.None;
            this.textbox_name_middle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textbox_name_middle.Location = new System.Drawing.Point(215, 49);
            this.textbox_name_middle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textbox_name_middle.Name = "textbox_name_middle";
            this.textbox_name_middle.Size = new System.Drawing.Size(195, 27);
            this.textbox_name_middle.TabIndex = 10;
            this.textbox_name_middle.Tag = "";
            // 
            // textbox_name_first
            // 
            this.textbox_name_first.DataType = DoolittleSE245.VisualComponents.InputDataType.None;
            this.textbox_name_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textbox_name_first.Location = new System.Drawing.Point(10, 49);
            this.textbox_name_first.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textbox_name_first.Name = "textbox_name_first";
            this.textbox_name_first.Size = new System.Drawing.Size(195, 27);
            this.textbox_name_first.TabIndex = 9;
            this.textbox_name_first.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(416, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(211, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Middle Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 569);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(292, 19);
            this.label11.TabIndex = 13;
            this.label11.Text = "Click submit to send to our database!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 648);
            this.Controls.Add(this.groupbox_input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Person Editor";
            this.groupbox_input.ResumeLayout(false);
            this.groupbox_input.PerformLayout();
            this.groupbox_contact.ResumeLayout(false);
            this.groupbox_contact.PerformLayout();
            this.groupbox_address.ResumeLayout(false);
            this.groupbox_address.PerformLayout();
            this.groupbox_name.ResumeLayout(false);
            this.groupbox_name.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox_input;
        private System.Windows.Forms.GroupBox groupbox_address;
        private System.Windows.Forms.GroupBox groupbox_name;
        private System.Windows.Forms.GroupBox groupbox_contact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private FeedbackTextBox textbox_city;
        private FeedbackTextBox textbox_name_first;
        private FeedbackTextBox textbox_name_last;
        private FeedbackTextBox textbox_name_middle;
        private FeedbackTextBox textbox_zip;
        private FeedbackTextBox textbox_state;
        private FeedbackTextBox textbox_street2;
        private FeedbackTextBox textbox_street1;
        private FeedbackTextBox textbox_phone_mobile;
        private FeedbackTextBox textbox_instagramURL;
        private FeedbackTextBox textbox_phone;
        private FeedbackTextBox textbox_email;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}

