namespace DoolittleSE245
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.combobox_filters = new System.Windows.Forms.ComboBox();
            this.button_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textbox_search = new DoolittleSE245.VisualComponents.HintTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(948, 372);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // combobox_filters
            // 
            this.combobox_filters.FormattingEnabled = true;
            this.combobox_filters.Location = new System.Drawing.Point(513, 62);
            this.combobox_filters.Name = "combobox_filters";
            this.combobox_filters.Size = new System.Drawing.Size(170, 21);
            this.combobox_filters.TabIndex = 2;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(702, 62);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(86, 23);
            this.button_search.TabIndex = 3;
            this.button_search.Text = "Add Filter";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Database Search";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(43, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(102, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(806, 63);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(81, 23);
            this.button_reset.TabIndex = 8;
            this.button_reset.Text = "Reset Filters";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filters: [None]";
            // 
            // button_update
            // 
            this.button_update.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.Blue;
            this.button_update.Location = new System.Drawing.Point(50, 554);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(252, 38);
            this.button_update.TabIndex = 10;
            this.button_update.Text = "Update Selected Row";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Verdana", 12F);
            this.button_delete.ForeColor = System.Drawing.Color.Red;
            this.button_delete.Location = new System.Drawing.Point(746, 554);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(252, 38);
            this.button_delete.TabIndex = 11;
            this.button_delete.Text = "Delete Selected Rows";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 91);
            this.label3.TabIndex = 12;
            this.label3.Text = ">\r\n>\r\nSelect \r\nRows \r\nHere\r\n>\r\n>\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(911, 63);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(82, 23);
            this.button_refresh.TabIndex = 13;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Verdana", 12F);
            this.button_add.ForeColor = System.Drawing.Color.ForestGreen;
            this.button_add.Location = new System.Drawing.Point(400, 554);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(238, 38);
            this.button_add.TabIndex = 14;
            this.button_add.Text = "Add a Person";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button5_Click);
            // 
            // textbox_search
            // 
            this.textbox_search.ErrorColor = System.Drawing.Color.Red;
            this.textbox_search.IsValid = true;
            this.textbox_search.Location = new System.Drawing.Point(163, 63);
            this.textbox_search.Name = "textbox_search";
            this.textbox_search.ReValidateOnEnter = true;
            this.textbox_search.Size = new System.Drawing.Size(326, 20);
            this.textbox_search.TabIndex = 4;
            this.textbox_search.TextBox_Hint_Color = System.Drawing.Color.Empty;
            this.textbox_search.TextBox_Text_Color = System.Drawing.Color.Empty;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "[DEV] Add 100 Random People";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 635);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_search);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.combobox_filters);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchForm";
            this.Text = "Searching People";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox combobox_filters;
        private System.Windows.Forms.Button button_search;
        private VisualComponents.HintTextBox textbox_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button1;
    }
}