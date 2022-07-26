using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        int counter = 0;
        Random rnd;
        char[] spec_char = new char[] { '%', '*', ')', '?', '!', '#', '$', '^', '&', '~'};
        Dictionary<string, double> metrica;
        public MainForm()
        {
            metrica = new Dictionary<string, double>();
            metrica.Add("mm", 1);
            metrica.Add("sm", 10);
            metrica.Add("dm", 100);
            metrica.Add("m", 1000);
            metrica.Add("km", 1000000);
            metrica.Add("mile", 1609344);

            InitializeComponent();
            rnd = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadNotepad();
            clbPass.SetItemChecked(0, true);
        }

        private void оПрогреаммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа мои утилиты содержит ряд небольших програм, которые могут пригодиться в жизни. А гравное научить меня основам программирования на C#.\n Автор: Заур Гусейнзаде.", "О программе");
        }

        private void помощToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnPluse_Click(object sender, EventArgs e)
        {
            counter++;
            labelCount.Text = counter.ToString();
        }

        private void btnMinuse_Click(object sender, EventArgs e)
        {
            counter--;
            labelCount.Text = counter.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            counter = 0;
            labelCount.Text = counter.ToString();
        }

        private void btnRand_Click(object sender, EventArgs e)
        {
            int n;
            int p = Convert.ToInt32(numericUpDown1.Value);
            int r = Convert.ToInt32(numericUpDown2.Value);
            if (p > r)
            {
                n = rnd.Next(r,p);
            }
            else
            {
                n = rnd.Next(p, r);
            }
            
            lblRand.Text = n.ToString();
            if (cbRand.Checked)
            {
                int i = 0;
                while (tbRand.Text.IndexOf(n.ToString()) != -1)
                {
                    if (p > r)
                    {
                        n = rnd.Next(r, p);
                    }
                    else
                    {
                        n = rnd.Next(p, r);
                    }
                    i++;
                    if (i > 1000) break;
                }
                if(i<=1000)tbRand.AppendText(n + ", ");
            }
            else { tbRand.AppendText(n + ", "); }
            
        }

        private void tsmiInsertDate_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortDateString() + "\n");
        }

        private void tsmiIstertTime_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortTimeString() + "\n");
        }

        private void вставитьДатуИВремяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\n");
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
                rtbNotepad.SaveFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Error saving prosses");
            }
            
        }

        void LoadNotepad()
        {
            try
            {
                rtbNotepad.LoadFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Error opening Prosses");
            }
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            LoadNotepad();
            
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            if (clbPass.CheckedItems.Count == 0) return;
            string password = "";
            for (int i = 0; i < nudPass.Value; i++)
            {
                int n = rnd.Next(0, clbPass.CheckedItems.Count);
                string s = clbPass.CheckedItems[n].ToString();
                switch (s)
                {
                    case "Цифры": password += rnd.Next(10).ToString();
                        break;
                    case "Прописные буквы": password += Convert.ToChar(rnd.Next(65,88));
                        break;
                    case "Строчные буквы":
                        password += Convert.ToChar(rnd.Next(97, 122));
                        break;
                    default:
                        password += spec_char[rnd.Next(spec_char.Length)];
                        break;
                }
                tbPass.Text = password;
                Clipboard.SetText(password);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double m1 = metrica[cmFrom.Text];
            double m2 = metrica[cmTo.Text];
            double n = Convert.ToDouble(tbFrom.Text);
            tbTo.Text = (n * m1 / m2).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t = cmFrom.Text;
            cmFrom.Text = cmTo.Text;
            cmTo.Text = t;
        }

        private void cmMetrics_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmMetrics.Text)
            {
                case "Длинна":
                    metrica.Clear();
                    metrica.Add("mm", 1);
                    metrica.Add("sm", 10);
                    metrica.Add("dm", 100);
                    metrica.Add("m", 1000);
                    metrica.Add("km", 1000000);
                    metrica.Add("mile", 1609344);
                    cmFrom.Items.Add("mm");
                    cmFrom.Items.Add("sm");
                    cmFrom.Items.Add("dm");
                    cmFrom.Items.Add("m");
                    cmFrom.Items.Add("km");
                    cmFrom.Items.Add("mile");
                    cmTo.Items.Add("mm");
                    cmTo.Items.Add("sm");
                    cmTo.Items.Add("dm");
                    cmTo.Items.Add("m");
                    cmTo.Items.Add("km");
                    cmTo.Items.Add("mile");
                    cmFrom.Text = "mm";
                    cmTo.Text = "mm";
                    break;
                case "Вес":
                    metrica.Clear();
                    metrica.Add("g", 1);
                    metrica.Add("kg", 1000);
                    metrica.Add("t", 1000000);
                    metrica.Add("lb", 453.6);
                    metrica.Add("oz", 283);
                    cmFrom.Items.Add("g");
                    cmFrom.Items.Add("kg");
                    cmFrom.Items.Add("t");
                    cmFrom.Items.Add("lb");
                    cmFrom.Items.Add("oz");
                    cmTo.Items.Add("g");
                    cmTo.Items.Add("kg");
                    cmTo.Items.Add("t");
                    cmTo.Items.Add("lb");
                    cmTo.Items.Add("oz");
                    cmFrom.Text = "g";
                    cmTo.Text = "g";
                    break;
                default:
                    break;
            }
        }
    }
}
