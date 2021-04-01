using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DoolittleSE245.VisualComponents
{
    public partial class ValidationTextBox : TextBox
    {

        //The textbox does not have a paint method, all credit for this and the WndProc method goes to Reza Aghaei
        [DllImport("user32")]
        private static extern IntPtr GetWindowDC(IntPtr hwnd);
        private const int WM_NCPAINT = 0x85;
        // --------------

        private bool isValid;
        private Color errorColor;
        private Pen errorPen;

  
        public Color ErrorColor { 
            get => errorColor; 
            
            set {
                errorColor = value;
                errorPen = new Pen(errorColor);
            }
        }

        public bool IsValid { 
            get => isValid;

            set
            {
                this.isValid = value;
                //Refresh();
            }
        } 

        public bool ReValidateOnEnter { get; set; }

        public void SetText(string s)
        {
            this.Text = s;
        }
        public ValidationTextBox() : base()
        {
            LoadDefaults();
            
        }

        private void PaintError(Graphics e)
        {
            Rectangle error_box = new Rectangle(0, 0, Width-1, Height-1);
            e.DrawRectangle(errorPen, error_box);
            
        }


        private void LoadDefaults()
        {
            isValid = true;
            ReValidateOnEnter = true;
            ErrorColor = Color.Red;

        }

        //! NOT MINE -----------
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCPAINT)
            {
                var dc = GetWindowDC(Handle);
                using (Graphics g = Graphics.FromHdc(dc))
                {
                    if(!isValid) PaintError(g);
                }
            }
        }
        // ! NOT MINE ----------

        protected override void OnPaint(PaintEventArgs e)
        {
            //if(!isValid) PaintError(g);
            base.OnPaint(e);
        }
        protected override void OnEnter(EventArgs e)
        {
            if(ReValidateOnEnter) IsValid = true;
            base.OnEnter(e);

        }

    }
}
