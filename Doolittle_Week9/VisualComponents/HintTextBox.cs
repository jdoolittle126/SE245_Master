using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoolittleSE245.VisualComponents
{

    //Needs work
    public partial class HintTextBox : ValidationTextBox
    {
        public Color TextBox_Hint_Color { get; set; }
        public Color TextBox_Text_Color { get; set; }

        private String hintText;
        private bool isHint;
        private bool showingInvalid = false;

        public string HintText { get => hintText; }
        public bool IsHint { get => isHint; }

        public HintTextBox() : base()
        {
        }

        public void SetHint(String hint, int hintColor = 0xD3D3D3, int textColor = 0x000000)
        {
            hintText = hint;
            isHint = true;
            TextBox_Hint_Color = Color.FromArgb(255, Color.FromArgb(hintColor));
            TextBox_Text_Color = Color.FromArgb(255, Color.FromArgb(textColor));
        }


        public void Preload()
        {
            this.isHint = false;
        }

        public String GetText()
        {
            return (isHint) ? "" : Text;
        }

        private void SetHint()
        {
            this.ForeColor = TextBox_Hint_Color;
            this.Text = HintText;
            this.isHint = true;
        }

        private void DelHint()
        {
            this.ForeColor = TextBox_Text_Color;
            this.Text = "";
            this.isHint = false;
        }

        public void ShowInvalidData()
        {
            this.ForeColor = Color.Red;
            showingInvalid = true;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            if (!IsHint) this.ForeColor = this.TextBox_Text_Color;
            base.OnPaint(pe);
        }

        protected override void OnCreateControl()
        {
            if (this.TextLength == 0) SetHint();
            base.OnCreateControl();
        }

        protected override void OnLeave(EventArgs e)
        {
            if (this.TextLength == 0) SetHint();
            base.OnLeave(e);
        }

        protected override void OnEnter(EventArgs e)
        {
            if (IsHint) DelHint();
            if (showingInvalid) this.ForeColor = this.TextBox_Text_Color;
            base.OnEnter(e);
        }


    }
}
