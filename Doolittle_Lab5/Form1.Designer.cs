namespace Doolittle_Lab5
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupbox_input = new System.Windows.Forms.GroupBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.groupbox_contact = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupbox_address = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupbox_name = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupbox_data = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textbox_output = new System.Windows.Forms.RichTextBox();
            this.textbox_phone = new Doolittle_Lab5.HintTextBox();
            this.textbox_email = new Doolittle_Lab5.HintTextBox();
            this.textbox_zip = new Doolittle_Lab5.HintTextBox();
            this.textbox_state = new Doolittle_Lab5.HintTextBox();
            this.textbox_city = new Doolittle_Lab5.HintTextBox();
            this.textbox_street2 = new Doolittle_Lab5.HintTextBox();
            this.textbox_street1 = new Doolittle_Lab5.HintTextBox();
            this.textbox_name_last = new Doolittle_Lab5.HintTextBox();
            this.textbox_name_middle = new Doolittle_Lab5.HintTextBox();
            this.textbox_name_first = new Doolittle_Lab5.HintTextBox();
            this.groupbox_input.SuspendLayout();
            this.groupbox_contact.SuspendLayout();
            this.groupbox_address.SuspendLayout();
            this.groupbox_name.SuspendLayout();
            this.groupbox_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox_input
            // 
            this.groupbox_input.Controls.Add(this.button_submit);
            this.groupbox_input.Controls.Add(this.groupbox_contact);
            this.groupbox_input.Controls.Add(this.groupbox_address);
            this.groupbox_input.Controls.Add(this.groupbox_name);
            this.groupbox_input.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold);
            this.groupbox_input.Location = new System.Drawing.Point(12, 12);
            this.groupbox_input.Name = "groupbox_input";
            this.groupbox_input.Size = new System.Drawing.Size(527, 555);
            this.groupbox_input.TabIndex = 0;
            this.groupbox_input.TabStop = false;
            this.groupbox_input.Text = "Input";
            // 
            // button_submit
            // 
            this.button_submit.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit.Location = new System.Drawing.Point(195, 513);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(145, 28);
            this.button_submit.TabIndex = 12;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // groupbox_contact
            // 
            this.groupbox_contact.Controls.Add(this.label10);
            this.groupbox_contact.Controls.Add(this.label9);
            this.groupbox_contact.Controls.Add(this.textbox_phone);
            this.groupbox_contact.Controls.Add(this.textbox_email);
            this.groupbox_contact.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold);
            this.groupbox_contact.Location = new System.Drawing.Point(32, 409);
            this.groupbox_contact.Name = "groupbox_contact";
            this.groupbox_contact.Size = new System.Drawing.Size(463, 94);
            this.groupbox_contact.TabIndex = 11;
            this.groupbox_contact.TabStop = false;
            this.groupbox_contact.Text = "Contact";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(319, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Phone";
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
            // groupbox_address
            // 
            this.groupbox_address.Controls.Add(this.label8);
            this.groupbox_address.Controls.Add(this.label7);
            this.groupbox_address.Controls.Add(this.textbox_zip);
            this.groupbox_address.Controls.Add(this.textbox_state);
            this.groupbox_address.Controls.Add(this.label6);
            this.groupbox_address.Controls.Add(this.label2);
            this.groupbox_address.Controls.Add(this.label1);
            this.groupbox_address.Controls.Add(this.textbox_city);
            this.groupbox_address.Controls.Add(this.textbox_street2);
            this.groupbox_address.Controls.Add(this.textbox_street1);
            this.groupbox_address.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold);
            this.groupbox_address.Location = new System.Drawing.Point(32, 141);
            this.groupbox_address.Name = "groupbox_address";
            this.groupbox_address.Size = new System.Drawing.Size(469, 249);
            this.groupbox_address.TabIndex = 10;
            this.groupbox_address.TabStop = false;
            this.groupbox_address.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(131, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Zip Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 184);
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
            this.groupbox_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupbox_name.Controls.Add(this.textbox_name_last);
            this.groupbox_name.Controls.Add(this.label5);
            this.groupbox_name.Controls.Add(this.textbox_name_middle);
            this.groupbox_name.Controls.Add(this.label4);
            this.groupbox_name.Controls.Add(this.textbox_name_first);
            this.groupbox_name.Controls.Add(this.label3);
            this.groupbox_name.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_name.Location = new System.Drawing.Point(32, 29);
            this.groupbox_name.Name = "groupbox_name";
            this.groupbox_name.Size = new System.Drawing.Size(469, 88);
            this.groupbox_name.TabIndex = 9;
            this.groupbox_name.TabStop = false;
            this.groupbox_name.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(351, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Middle Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name";
            // 
            // groupbox_data
            // 
            this.groupbox_data.Controls.Add(this.textbox_output);
            this.groupbox_data.Controls.Add(this.label14);
            this.groupbox_data.Controls.Add(this.label13);
            this.groupbox_data.Controls.Add(this.label12);
            this.groupbox_data.Controls.Add(this.label11);
            this.groupbox_data.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold);
            this.groupbox_data.Location = new System.Drawing.Point(571, 13);
            this.groupbox_data.Name = "groupbox_data";
            this.groupbox_data.Size = new System.Drawing.Size(299, 554);
            this.groupbox_data.TabIndex = 1;
            this.groupbox_data.TabStop = false;
            this.groupbox_data.Text = "Data";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 19);
            this.label11.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(112, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 19);
            this.label12.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(201, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 19);
            this.label13.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(95, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 19);
            this.label14.TabIndex = 3;
            this.label14.Text = "Person Object";
            // 
            // textbox_output
            // 
            this.textbox_output.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_output.Location = new System.Drawing.Point(38, 77);
            this.textbox_output.Name = "textbox_output";
            this.textbox_output.ReadOnly = true;
            this.textbox_output.Size = new System.Drawing.Size(235, 425);
            this.textbox_output.TabIndex = 4;
            this.textbox_output.Text = "";
            // 
            // textbox_phone
            // 
            this.textbox_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_phone.ForeColor = System.Drawing.Color.LightGray;
            this.textbox_phone.HintText = "(000) 000-0000";
            this.textbox_phone.IsHint = true;
            this.textbox_phone.Location = new System.Drawing.Point(246, 50);
            this.textbox_phone.Name = "textbox_phone";
            this.textbox_phone.Size = new System.Drawing.Size(196, 20);
            this.textbox_phone.TabIndex = 11;
            this.textbox_phone.Tag = "Phone";
            this.textbox_phone.Text = "(000) 000-0000";
            this.textbox_phone.TextBox_Hint_Color = System.Drawing.Color.LightGray;
            this.textbox_phone.TextBox_Text_Color = System.Drawing.Color.Black;
            this.textbox_phone.Valid = false;
            // 
            // textbox_email
            // 
            this.textbox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_email.ForeColor = System.Drawing.Color.LightGray;
            this.textbox_email.HintText = "johndoe@example.com";
            this.textbox_email.IsHint = true;
            this.textbox_email.Location = new System.Drawing.Point(22, 50);
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.Size = new System.Drawing.Size(196, 20);
            this.textbox_email.TabIndex = 10;
            this.textbox_email.Tag = "Email";
            this.textbox_email.Text = "johndoe@example.com";
            this.textbox_email.TextBox_Hint_Color = System.Drawing.Color.LightGray;
            this.textbox_email.TextBox_Text_Color = System.Drawing.Color.Black;
            this.textbox_email.Valid = false;
            // 
            // textbox_zip
            // 
            this.textbox_zip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_zip.ForeColor = System.Drawing.Color.LightGray;
            this.textbox_zip.HintText = "01234";
            this.textbox_zip.IsHint = true;
            this.textbox_zip.Location = new System.Drawing.Point(117, 206);
            this.textbox_zip.Name = "textbox_zip";
            this.textbox_zip.Size = new System.Drawing.Size(101, 20);
            this.textbox_zip.TabIndex = 7;
            this.textbox_zip.Tag = "Zip";
            this.textbox_zip.Text = "01234";
            this.textbox_zip.TextBox_Hint_Color = System.Drawing.Color.LightGray;
            this.textbox_zip.TextBox_Text_Color = System.Drawing.Color.Black;
            this.textbox_zip.Valid = false;
            // 
            // textbox_state
            // 
            this.textbox_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_state.ForeColor = System.Drawing.Color.LightGray;
            this.textbox_state.HintText = "RI";
            this.textbox_state.IsHint = true;
            this.textbox_state.Location = new System.Drawing.Point(26, 206);
            this.textbox_state.Name = "textbox_state";
            this.textbox_state.Size = new System.Drawing.Size(50, 20);
            this.textbox_state.TabIndex = 6;
            this.textbox_state.Tag = "State";
            this.textbox_state.Text = "RI";
            this.textbox_state.TextBox_Hint_Color = System.Drawing.Color.LightGray;
            this.textbox_state.TextBox_Text_Color = System.Drawing.Color.Black;
            this.textbox_state.Valid = false;
            // 
            // textbox_city
            // 
            this.textbox_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_city.ForeColor = System.Drawing.Color.LightGray;
            this.textbox_city.HintText = "Providence";
            this.textbox_city.IsHint = true;
            this.textbox_city.Location = new System.Drawing.Point(22, 154);
            this.textbox_city.Name = "textbox_city";
            this.textbox_city.Size = new System.Drawing.Size(196, 20);
            this.textbox_city.TabIndex = 2;
            this.textbox_city.Tag = "City";
            this.textbox_city.Text = "Providence";
            this.textbox_city.TextBox_Hint_Color = System.Drawing.Color.LightGray;
            this.textbox_city.TextBox_Text_Color = System.Drawing.Color.Black;
            this.textbox_city.Valid = false;
            // 
            // textbox_street2
            // 
            this.textbox_street2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_street2.ForeColor = System.Drawing.Color.LightGray;
            this.textbox_street2.HintText = "Apt. 2E";
            this.textbox_street2.IsHint = true;
            this.textbox_street2.Location = new System.Drawing.Point(22, 103);
            this.textbox_street2.Name = "textbox_street2";
            this.textbox_street2.Size = new System.Drawing.Size(407, 20);
            this.textbox_street2.TabIndex = 1;
            this.textbox_street2.Tag = "Street";
            this.textbox_street2.Text = "Apt. 2E";
            this.textbox_street2.TextBox_Hint_Color = System.Drawing.Color.LightGray;
            this.textbox_street2.TextBox_Text_Color = System.Drawing.Color.Black;
            this.textbox_street2.Valid = false;
            // 
            // textbox_street1
            // 
            this.textbox_street1.BackColor = System.Drawing.SystemColors.Window;
            this.textbox_street1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_street1.ForeColor = System.Drawing.Color.LightGray;
            this.textbox_street1.HintText = "123 Example Lane";
            this.textbox_street1.IsHint = true;
            this.textbox_street1.Location = new System.Drawing.Point(22, 52);
            this.textbox_street1.Name = "textbox_street1";
            this.textbox_street1.Size = new System.Drawing.Size(407, 20);
            this.textbox_street1.TabIndex = 0;
            this.textbox_street1.Tag = "Street";
            this.textbox_street1.Text = "123 Example Lane";
            this.textbox_street1.TextBox_Hint_Color = System.Drawing.Color.LightGray;
            this.textbox_street1.TextBox_Text_Color = System.Drawing.Color.Black;
            this.textbox_street1.Valid = false;
            // 
            // textbox_name_last
            // 
            this.textbox_name_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_name_last.ForeColor = System.Drawing.Color.LightGray;
            this.textbox_name_last.HintText = "Doe";
            this.textbox_name_last.IsHint = true;
            this.textbox_name_last.Location = new System.Drawing.Point(318, 49);
            this.textbox_name_last.Name = "textbox_name_last";
            this.textbox_name_last.Size = new System.Drawing.Size(145, 20);
            this.textbox_name_last.TabIndex = 8;
            this.textbox_name_last.Tag = "Name";
            this.textbox_name_last.Text = "Doe";
            this.textbox_name_last.TextBox_Hint_Color = System.Drawing.Color.LightGray;
            this.textbox_name_last.TextBox_Text_Color = System.Drawing.Color.Black;
            this.textbox_name_last.Valid = false;
            // 
            // textbox_name_middle
            // 
            this.textbox_name_middle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_name_middle.ForeColor = System.Drawing.Color.LightGray;
            this.textbox_name_middle.HintText = "Lee";
            this.textbox_name_middle.IsHint = true;
            this.textbox_name_middle.Location = new System.Drawing.Point(163, 49);
            this.textbox_name_middle.Name = "textbox_name_middle";
            this.textbox_name_middle.Size = new System.Drawing.Size(145, 20);
            this.textbox_name_middle.TabIndex = 7;
            this.textbox_name_middle.Tag = "Name";
            this.textbox_name_middle.Text = "Lee";
            this.textbox_name_middle.TextBox_Hint_Color = System.Drawing.Color.LightGray;
            this.textbox_name_middle.TextBox_Text_Color = System.Drawing.Color.Black;
            this.textbox_name_middle.Valid = false;
            // 
            // textbox_name_first
            // 
            this.textbox_name_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_name_first.ForeColor = System.Drawing.Color.LightGray;
            this.textbox_name_first.HintText = "John";
            this.textbox_name_first.IsHint = true;
            this.textbox_name_first.Location = new System.Drawing.Point(6, 49);
            this.textbox_name_first.Name = "textbox_name_first";
            this.textbox_name_first.Size = new System.Drawing.Size(145, 20);
            this.textbox_name_first.TabIndex = 1;
            this.textbox_name_first.Tag = "Name";
            this.textbox_name_first.Text = "John";
            this.textbox_name_first.TextBox_Hint_Color = System.Drawing.Color.LightGray;
            this.textbox_name_first.TextBox_Text_Color = System.Drawing.Color.Black;
            this.textbox_name_first.Valid = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.groupbox_data);
            this.Controls.Add(this.groupbox_input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Jonathan Doolittle - Lab 5";
            this.groupbox_input.ResumeLayout(false);
            this.groupbox_contact.ResumeLayout(false);
            this.groupbox_contact.PerformLayout();
            this.groupbox_address.ResumeLayout(false);
            this.groupbox_address.PerformLayout();
            this.groupbox_name.ResumeLayout(false);
            this.groupbox_name.PerformLayout();
            this.groupbox_data.ResumeLayout(false);
            this.groupbox_data.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox_input;
        private HintTextBox textbox_name_first;
        private HintTextBox textbox_name_last;
        private HintTextBox textbox_name_middle;
        private System.Windows.Forms.GroupBox groupbox_address;
        private System.Windows.Forms.GroupBox groupbox_name;
        private System.Windows.Forms.GroupBox groupbox_contact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private HintTextBox textbox_city;
        private HintTextBox textbox_street2;
        private HintTextBox textbox_street1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private HintTextBox textbox_state;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private HintTextBox textbox_phone;
        private HintTextBox textbox_email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private HintTextBox textbox_zip;
        private System.Windows.Forms.GroupBox groupbox_data;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.RichTextBox textbox_output;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}

