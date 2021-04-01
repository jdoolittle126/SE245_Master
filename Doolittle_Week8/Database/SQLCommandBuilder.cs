using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoolittleSE245.Database
{

    //WIP
    class SQLCommandBuilder
    {


        private Dictionary<string, string> commands = new Dictionary<string, string>();
        private string active;
        public SQLCommandBuilder()
        {

        }

        public void EditCommand(string c)
        {
            active = c;
            if (!commands.ContainsKey(c)) commands.Add(c, "");
        }

        public void EditCommand(string c, string arg)
        {
            active = c;
            if (commands.ContainsKey(c)) commands[c] = arg;
            else commands.Add(c, arg);
        }

        public void AddParams(string param)
        {
            commands[active] += param + " ";
        }

        public void BooleanQuickBuild(string term, string command, List<string> items, string parameter, bool ignfirst = false)
        {
            string final = " AND (";
            items.ForEach(item => {
                if (ignfirst)
                {
                    final += " " + item + " " + command + " " + parameter;
                    ignfirst = false;
                } else
                {
                    final += " " + term + " " + item + " " + command + " " + parameter;

                }
                
            
            });
            final += ")";
            EditCommand("");
            AddParams(final);
        }

        public string GetSQL()
        {
            string final = "";
            foreach(KeyValuePair<string, string> link in commands)
            {
                final += link.Key + " " + link.Value + " ";
            }
            return final;
        }



    }
}
