using DoolittleSE245.Core;
using DoolittleSE245.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoolittleSE245
{



    public partial class SearchForm : Form
    {
        SQLCommandBuilder command;
        SqlCommand comm;
        List<string> filter_list;
        int filters;

        public SearchForm()
        {
            InitializeComponent();
            this.textbox_search.SetHint("Enter a search term...");
            SearchFilter.Filters.ForEach(filter => combobox_filters.Items.Add(filter));
            comboBox1.Items.Add("Contains");
            comboBox1.Items.Add("Does not contain");
            comboBox1.SelectedIndex = 0;
            combobox_filters.SelectedIndex = 0;
            Init();
        }

        private void UpdateFilterString()
        {
            label2.Text = "Filters:";
            if (filter_list.Count == 0) label2.Text += " [NONE]";
            else
            {
                filter_list.ForEach(s => label2.Text += $" [{s}]");
            }
        }

        private void Init()
        {
            filter_list = new List<string>();
            filters = 0;
            comm = new SqlCommand();
            command = new SQLCommandBuilder(); 
            command.EditCommand("SELECT");
            command.AddParams("PersonID, FirstName, MiddleName, LastName, Street1, Street2, City, State, Zip, HomePhone, Email, MobilePhone, InstagramURL");
            command.EditCommand("FROM", "People");
            command.EditCommand("WHERE", "0=0 ");

            RefreshView();
            UpdateFilterString();

        }

        private void RefreshView()
        {
            DataSet result = (filters > 0) ? Program.database.SearchRequest(comm) : Program.database.SearchRequest(command.GetSQL(), "parameter", textbox_search.GetText());
        
            dataGridView1.DataSource = result;
            dataGridView1.DataMember = result.Tables["Search Results"].ToString();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            
            if(comboBox1.SelectedItem.Equals("Contains")) command.BooleanQuickBuild("OR", "LIKE", (combobox_filters.SelectedItem as SearchFilter).Columns, $"@parameter{filters}", true);
            else command.BooleanQuickBuild("AND", "NOT LIKE", (combobox_filters.SelectedItem as SearchFilter).Columns, $"@parameter{filters}", true);



            filter_list.Add($"{combobox_filters.SelectedItem.ToString().Replace("Search by", "").Replace("Search", "").ToUpper()} {comboBox1.SelectedItem.ToString().ToLower()} {textbox_search.GetText()}");
            comm.CommandText = command.GetSQL();
            comm.Parameters.AddWithValue($"@parameter{filters}", "%" + textbox_search.GetText() + "%");
            filters++;
            RefreshView();

            
            UpdateFilterString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form1 tmp = new Form1(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            tmp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Init();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Form1 tmp = new Form1(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                tmp.ShowDialog();
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {dataGridView1.SelectedRows.Count} records?", "WARNING", MessageBoxButtons.YesNo);
                if(result.Equals(DialogResult.Yes))
                {
                    for(int i =0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        Program.database.DropPerson(dataGridView1.SelectedRows[i].Cells[0].Value.ToString(), out _);
                    }
                }
                RefreshView();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 tmp = new Form1();
            tmp.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (filters > 0) RefreshView();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TablePopulator.PopulateRandom(100);
            RefreshView();
        }
    }
}
