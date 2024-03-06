using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ИМ_Лаб3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Grid.RowCount++;
            for (int i = 0; i <= N - 1; i++)
            {
                Grid.ColumnCount++;
                Grid.Columns[i].Width = 29;
                old_mass[i] = '0';
                new_mass[i] = '0';
            } 
            old_mass[N - 1] = '0';
            new_mass[N - 1] = '0';
            Grid.Columns[N - 1].Width = 29;

            new_lib();
        }

        const int N = 20;
        char[] old_mass = new char[N];
        char[] new_mass = new char[N];
        Dictionary<string, char> key;
        int count_rows = 0;
        string rule = "0";

        private void new_lib()
        {
            rule = Convert.ToString((int)el_Rule.Value, 2); // конвертация в бинарный вид
            while (rule.Length != 8)
            {
                rule = "0" + rule;
            }
            key = new Dictionary<string, char>() // создание коллекции
            {
                {"111", rule[0]},
                {"110", rule[1]},
                {"101", rule[2]},
                {"100", rule[3]},
                {"011", rule[4]},
                {"010", rule[5]},
                {"001", rule[6]},
                {"000", rule[7]}
            };
        }

        private void el_Rule_ValueChanged(object sender, EventArgs e)
        {
            Grid.RowCount++;
            count_rows++;
            for (int i = 0; i < N; i++)
            {
                old_mass[i] = '0';
                new_mass[i] = '0';
            }

            old_mass[6] = old_mass[7] = old_mass[11] = '1';
            Grid.Rows[count_rows].Cells[6].Style.BackColor = System.Drawing.Color.YellowGreen;
            Grid.Rows[count_rows].Cells[7].Style.BackColor = System.Drawing.Color.YellowGreen;
            Grid.Rows[count_rows].Cells[11].Style.BackColor = System.Drawing.Color.YellowGreen;

            new_lib();
        }

        private void bt_Start_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Grid.RowCount++;
            count_rows++;
            new_mass[0] = key[$"{old_mass[N - 1]}{old_mass[0]}{old_mass[1]}"];
            new_mass[N - 1] = key[$"{old_mass[N - 2]}{old_mass[N - 1]}{old_mass[0]}"];
            for (int i = 0; i < N; i++)
            {
                if (i != 0 && i < N - 1)
                {
                    new_mass[i] = key[$"{old_mass[i - 1]}{old_mass[i]}{old_mass[i + 1]}"]; 
                }
                if (new_mass[i] == '1')
                {
                    Grid.Rows[count_rows].Cells[i].Style.BackColor = System.Drawing.Color.YellowGreen;
                }
            }
            for (int i = 0; i < N; i++)
            {
                old_mass[i] = new_mass[i];
            }
        }
    }
}
