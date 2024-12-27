using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalAppPROGPOE
{
    public partial class Rewards : Form
    {
        public Rewards()
        {
            // 1 3 5 8 10
            InitializeComponent();

            int rewardsCount = Form1.multiMapIssues.Count;

            if (rewardsCount >= 10)
            { Reward5.Visible = true; Reward4.Visible = true; Reward3.Visible = true; Reward2.Visible = true; Reward1.Visible = true; }
            else if (rewardsCount > 7)
            { Reward4.Visible = true; Reward3.Visible = true; Reward2.Visible = true; Reward1.Visible = true; }
            else if (rewardsCount > 4)
            { Reward3.Visible = true; Reward2.Visible = true; Reward1.Visible = true; }
            else if (rewardsCount > 2)
            { Reward2.Visible = true; Reward1.Visible = true; }
            else if (rewardsCount > 0)
            { Reward1.Visible = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You recieved 5 units of power!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You recieved 5 more units of power!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You recieved 5 more units of power!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You recieved 5 more units of power!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You recieved 5 more units of power!");
        }
    }
}
