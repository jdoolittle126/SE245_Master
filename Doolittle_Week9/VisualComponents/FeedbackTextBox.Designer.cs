namespace DoolittleSE245.VisualComponents
{
    partial class FeedbackTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TextBox = new DoolittleSE245.VisualComponents.HintTextBox();
            this.Feedback = new System.Windows.Forms.Label();
            this.FeedbackResponse = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox.ErrorColor = System.Drawing.Color.Red;
            this.TextBox.IsValid = true;
            this.TextBox.Location = new System.Drawing.Point(0, 3);
            this.TextBox.Margin = new System.Windows.Forms.Padding(0);
            this.TextBox.Name = "TextBox";
            this.TextBox.ReValidateOnEnter = true;
            this.TextBox.Size = new System.Drawing.Size(396, 20);
            this.TextBox.TabIndex = 0;
            this.TextBox.TextBox_Hint_Color = System.Drawing.Color.Empty;
            this.TextBox.TextBox_Text_Color = System.Drawing.Color.Empty;
            // 
            // Feedback
            // 
            this.Feedback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Feedback.AutoSize = true;
            this.Feedback.BackColor = System.Drawing.Color.Transparent;
            this.Feedback.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Feedback.Location = new System.Drawing.Point(409, 5);
            this.Feedback.Name = "Feedback";
            this.Feedback.Size = new System.Drawing.Size(16, 15);
            this.Feedback.TabIndex = 1;
            this.Feedback.Text = "?";
            this.Feedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Feedback.Click += new System.EventHandler(this.Feedback_Click);
            // 
            // FeedbackResponse
            // 
            this.FeedbackResponse.AutoPopDelay = 5000;
            this.FeedbackResponse.InitialDelay = 50;
            this.FeedbackResponse.ReshowDelay = 100;
            // 
            // FeedbackTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Feedback);
            this.Controls.Add(this.TextBox);
            this.Name = "FeedbackTextBox";
            this.Size = new System.Drawing.Size(433, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HintTextBox TextBox;
        private System.Windows.Forms.Label Feedback;
        private System.Windows.Forms.ToolTip FeedbackResponse;
    }
}
