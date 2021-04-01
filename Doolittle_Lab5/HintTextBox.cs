using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doolittle_Lab5
{
    public partial class HintTextBox : TextBox
    {
        public Color TextBox_Hint_Color { get; set; }
        public Color TextBox_Text_Color { get; set; }

        public string HintText { get; set; }
        public bool IsHint { get; set; }

        public bool Valid { get; set; }
        public HintTextBox()
        {
            TextBox_Hint_Color = Color.LightGray;
            TextBox_Text_Color = Color.Black;
            InitializeComponent();  
        }

        private void SetHint()
        {
            this.ForeColor = TextBox_Hint_Color;
            this.Text = HintText;
            this.IsHint = true;
        }

        private void DelHint()
        {
            this.ForeColor = TextBox_Text_Color;
            this.Text = "";
            this.IsHint = false;
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
            if(this.TextLength == 0) SetHint();
            base.OnLeave(e);
        }

        protected override void OnEnter(EventArgs e)
        {
            if (IsHint) DelHint();
            base.OnEnter(e);
        }

    }
}
