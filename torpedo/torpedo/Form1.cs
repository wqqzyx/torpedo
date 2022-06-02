using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace torpedo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sor = 11;
        int oszlop = 11;
        static int kor=0;
        static int hp1 = 5;
        static int hp2 = 5;
        private void tablabeallitas(int sor, int oszlop)
        {
            dgv.RowCount = sor;
            dgv.ColumnCount = oszlop;
            dgv.ColumnHeadersVisible = false;
            dgv.RowHeadersVisible = false;
            for (int i = 0; i < 11; i++)
            {
                dgv.Rows[i].Height = 20;
            }
            for (int i = 0; i < 11; i++)
            {
                dgv.Columns[i].Width = 32;
            }
            string[] abc = new string[] {"A","B", "C", "D", "E", "F", "G", "H", "I", "J", "K"};
            dgv.Height = 20 * 11;
            dgv.Width = (int)(20 * 17.5);
            dgv.ScrollBars = ScrollBars.None;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.BackgroundColor = Color.DarkBlue;
            int x = 0;
            for (int i = 0; i < 11; i++)
            {
                dgv.Rows[i].DefaultCellStyle.BackColor = Color.CornflowerBlue;
                dgv.Rows[i].DefaultCellStyle.ForeColor = Color.GhostWhite;
                for (int j = 0; j < 11; j++)
                {
                    dgv.Rows[i].Cells[j].Value = abc[i]+$"{x+=1}";
                }
                x = 1;
            }
            foreach (DataGridViewColumn item in dgv.Columns)
            {
                item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                item.DefaultCellStyle.Font = new Font("Myanmar Text",9);
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tablabeallitas(sor, oszlop);
            /*Form f2 = new Form();
            f2.ShowDialog();
            */
            hajok();
        }
        int sorIndex;
        int oszlopIndex;
        public void hajok()
        {
            string[] hajok= new string[] {"Destroyer", "Submarine", "Cruiser", "Battleship", "Carrier"};
        }
        public void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sorIndex = e.RowIndex;
            oszlopIndex = e.ColumnIndex;
            if (szelesseg == 0)
            {
                MessageBox.Show("Először válassz egy hajót!");
            }
            duel();
        }
        public void duel()
        {
            if (kor==0)
            {
                if (dgv.Rows[sorIndex].Cells[oszlopIndex].Value.ToString() == "X")
                {
                    MessageBox.Show("NEM JO!!");
                    kezdoErtek++;
                }
                else
                {
                for (int i = -1; i < sorIndex; i++)
                {
                    for (int j = -1; j < oszlopIndex; j++)
                    {
                        for (int k = 0; k < szelesseg; k++)
                        {
                        dgv.Rows[sorIndex].Cells[oszlopIndex].Value = "X";
                        szelesseg--;
                        dgv.Rows[sorIndex].Cells[oszlopIndex+szelesseg].Value = "X";
                        }
                    }
                }
                }
            }
        }
        static int szelesseg=0;
        static int kezdoErtek = 5;
        public void nincs()
        {
            if (kezdoErtek<=0)
            {
                MessageBox.Show("Hol a kola kola");
            }
        }
        private void b1_Click(object sender, EventArgs e)
        {
            kezdoErtek--;
            szelesseg = 2;
            nincs();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            kezdoErtek--;
            szelesseg = 3;
            nincs();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            kezdoErtek--;
            szelesseg = 3;
            nincs();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            kezdoErtek--;
            szelesseg = 4;
            nincs();
        }
        private void b5_Click(object sender, EventArgs e)
        {
            kezdoErtek--;
            szelesseg = 5;
            nincs();
        }
        private void bForgat_Click(object sender, EventArgs e)
        {

        }

    }
}