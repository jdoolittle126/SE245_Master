using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace DoolittleSE245.VisualComponents
{

    public enum InputDataType
    {
        Name, Street, City, State, Zip, Email, Phone, Instagram, None
    }

    public partial class FeedbackTextBox : UserControl
    {

        public InputDataType DataType { get; set; } = InputDataType.None;

        public FeedbackTextBox()
        {
            InitializeComponent();
            HintVisable(false);
        }

        public void SetDataHint(InputDataType data, string hint, int hintColor = 0xD3D3D3, int textColor = 0x000000)
        {
            DataType = data;
            SetHint(hint, hintColor, textColor);
        }

        public HintTextBox GetTextBox()
        {
            return TextBox;
        }

        public void SetFeedback(string hint)
        {
            FeedbackResponse.SetToolTip(Feedback, hint);
        }

        public void HintVisable(bool visable)
        {
            //Feedback.ForeColor = TextBox.ErrorColor;
            Feedback.Visible = visable;
        }

        public string GetText()
        {
            
            return TextBox.GetText();
        }

        public void SetText(string s)
        {
            TextBox.SetText(s);
        }

        public void Preload(string s)
        {
            TextBox.SetText(s);
            TextBox.Preload();
        }

        public void SetHint(string hint)
        {
            TextBox.SetHint(hint);
        }


        public void SetHint(string hint, int hintColor = 0xD3D3D3, int textColor = 0x000000)
        {
            TextBox.SetHint(hint, hintColor, textColor);
        }

        private void Feedback_Click(object sender, EventArgs e)
        {
        }
    }

}
