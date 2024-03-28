using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable DataTable = new DataTable();
        int selectedRow;
        private void Form1_Load(object sender, EventArgs e)
        {

            DataTable.Columns.Add("ID", typeof(int));
            DataTable.Columns.Add("Name", typeof(string));
            DataTable.Columns.Add("Age", typeof(int));
            dataGridView1.DataSource=DataTable;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                ID.Text = row.Cells[0].Value.ToString();
                NAME.Text = row.Cells[1].Value.ToString();
                AGE.Text = row.Cells[2].Value.ToString();


            }
        }
        private bool Empty()
        {
            if (ID.Text == "" || NAME.Text == "" || AGE.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool IsNum()
        {
            int n;
            if (int.TryParse(ID.Text, out n) && int.TryParse(AGE.Text, out n))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void ADD_Click(object sender, EventArgs e)
        {
            if(Empty())
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            if(!IsNum())
            {
                MessageBox.Show("ID and Age must be numbers");
                return;
            }
            DataTable.Rows.Add(ID.Text, NAME.Text, AGE.Text);
            EmptyFields();

        }
        private void EmptyFields()
        {
            ID.Text = "";
            NAME.Text = "";
            AGE.Text = "";
        }   

        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (Empty())
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            if (!IsNum())
            {
                MessageBox.Show("ID and Age must be numbers");
                return;
            }
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            row.Cells[0].Value = ID.Text;
            row.Cells[1].Value = NAME.Text;
            row.Cells[2].Value = AGE.Text;

        }
       
        private void DELETE_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("There are no rows to delete");
                return;
            }
            if (Empty()) {
                MessageBox.Show("There are no rows to delete");

            }
            
            if (selectedRow >= 0)
            {
                selectedRow = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(selectedRow);
                selectedRow --;
            }
            else
            {
                MessageBox.Show("Please select a row to delete");
            }

        }
    }
}
