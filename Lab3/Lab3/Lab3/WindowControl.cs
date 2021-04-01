using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace Lab3
{

    /*
     * 
     * FRAMEWORK FOR FUTURE LAB
     * 
     */

    class ConsoleSection
    {
        int x, y, w, h, cursor_pos_x, cursor_pos_y;
        bool wrap;

        public ConsoleSection(int x, int y, int w, int h, bool wrap)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            this.wrap = wrap;
            cursor_pos_x = x;
            cursor_pos_y = y;
        }

        private void InitWriting()
        {
        }

        public void WriteToSection(string val)
        {
            if(val.Length > w)
            {
                if (wrap)
                {
                    //val.Substring()
                }
                else
                {

                }

            }
            //segment.PadRight(w);

        }

        public void NewLine()
        {
            cursor_pos_x = x;
            cursor_pos_y++;
        }





    }

    class ConsoleController
    {

        readonly char BORDER_X = '-';
        readonly char BORDER_Y = '|';
        readonly char BORDER_INTERSECTION = '+';


        public ConsoleController(int screenX, int screenY)
        {

        }




    }
}
