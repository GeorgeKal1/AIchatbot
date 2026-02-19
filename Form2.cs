using System;
using System.Data;
using System.Windows.Forms;

namespace AIChatBot
{
    public partial class Form2 : Form
    {
        private string conneectionString = "Data Source=chatbot.db;Version=3;";
        private int lastExpandedRow = -1;
        private const int normalRowHeight = 28;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = DatabaseHelper.LoadChats();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = dataGridView1.Rows[e.RowIndex];

            // collapse to keli an eixe idi megalwsei 
            if (lastExpandedRow == e.RowIndex)
            {
                row.Height = normalRowHeight;
                row.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
                lastExpandedRow = -1;
                return;
            }

            // collapse to keli pou eixe megalwsei prin 
            if (lastExpandedRow >= 0 && lastExpandedRow < dataGridView1.Rows.Count)
            {
                dataGridView1.Rows[lastExpandedRow].Height = normalRowHeight;
                dataGridView1.Rows[lastExpandedRow].DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            }

            // expand to keli
            row.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoResizeRow(e.RowIndex, DataGridViewAutoSizeRowMode.AllCells);
            lastExpandedRow = e.RowIndex;
        }

    }
}
