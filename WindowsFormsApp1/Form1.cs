using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmPrincipal : Form
    {
        private void Enable()
        {
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            cd_userTextBox.Enabled = true;
            nm_nameTextBox.Enabled = true;
            cd_levelTextBox.Enabled = true;
            nm_loginTextBox.Enabled = true;
            passwordTextBox.Enabled = true;
            btnPrintOut.Enabled = false;
            btnSearch.Enabled = false;
            btnExit.Enabled = false;
            btnPrevious.Enabled = false;
            btnChange.Enabled = false;
            btnNext.Enabled = false;
            btnNew.Enabled = false;
        }
        private void Disable()
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            cd_userTextBox.Enabled = false;
            nm_nameTextBox.Enabled = false;
            cd_levelTextBox.Enabled = false;
            nm_loginTextBox.Enabled = false;
            passwordTextBox.Enabled = false;
            btnPrintOut.Enabled = true;
            btnSearch.Enabled = true;
            btnExit.Enabled = true;
            btnPrevious.Enabled = true;
            btnChange.Enabled = true;
            btnNext.Enabled = true;
            btnNew.Enabled = true;
        }
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet1.tb_user'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_userTableAdapter.Fill(this.database1DataSet1.tb_user);
            Disable();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Disable();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Disable();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Enable();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (tb_userBindingSource.Count > 0)
            {
                Enable();
            }
        }
    }
}
