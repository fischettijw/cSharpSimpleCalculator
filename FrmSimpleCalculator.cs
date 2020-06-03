using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpSimpleCalculator
{
    public partial class FrmSimpleCalculator : Form
    {
        public FrmSimpleCalculator()
        {
            InitializeComponent();
        }

        private void FrmSimpleCalculator_Load(object sender, EventArgs e)
        {
            TxtFirstNum.Text = "0";
            TxtSecondNum.Text = "0";
            LblAnswer.Text = "0";
            ResetButtons();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ResetButtons();
            int first = Convert.ToInt32(TxtFirstNum.Text);
            int second = Convert.ToInt32(TxtSecondNum.Text);
            LblAnswer.Text = (first + second).ToString();
            BtnAdd.BackColor = Color.LightYellow;
            RbAdd.Checked = true;
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            ResetButtons();
            int first = Convert.ToInt32(TxtFirstNum.Text);
            int second = Convert.ToInt32(TxtSecondNum.Text);
            LblAnswer.Text = (first - second).ToString();
            BtnSub.BackColor = Color.LightYellow;
            RbSub.Checked = true;
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            ResetButtons();
            int first = Convert.ToInt32(TxtFirstNum.Text);
            int second = Convert.ToInt32(TxtSecondNum.Text);
            LblAnswer.Text = (first * second).ToString();
            BtnMult.BackColor = Color.LightYellow;
            RbMult.Checked = true;
        }

        private void TxtFirstNum_TextChanged(object sender, EventArgs e)
        {
            LblAnswer.Text = "";
            ResetButtons();
            RbHidden.Checked = true;
        }

        private void TxtSecondNum_TextChanged(object sender, EventArgs e)
        {
            LblAnswer.Text = "";
            ResetButtons();
            RbHidden.Checked = true;
        }

        private void ResetButtons()
        {
            BtnAdd.BackColor = SystemColors.Control;
            BtnSub.BackColor = SystemColors.Control;
            BtnMult.BackColor = SystemColors.Control;
        }

        private void RbAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (RbAdd.Checked) BtnAdd.PerformClick();
        }

        private void RbSub_CheckedChanged(object sender, EventArgs e)
        {
            if (RbSub.Checked) BtnSub.PerformClick();
        }

        private void RbMult_CheckedChanged(object sender, EventArgs e)
        {
            if (RbMult.Checked) BtnMult.PerformClick();
        }
    }
}
