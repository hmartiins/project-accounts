namespace WindowsFormsApp1
{
    partial class frmPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cd_userLabel;
            System.Windows.Forms.Label nm_nameLabel;
            System.Windows.Forms.Label cd_levelLabel;
            System.Windows.Forms.Label nm_loginLabel;
            System.Windows.Forms.Label passwordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.database1DataSet1 = new WindowsFormsApp1.Database1DataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tb_userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_userTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.tb_userTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.Database1DataSetTableAdapters.TableAdapterManager();
            this.cd_userTextBox = new System.Windows.Forms.TextBox();
            this.nm_nameTextBox = new System.Windows.Forms.TextBox();
            this.cd_levelTextBox = new System.Windows.Forms.TextBox();
            this.nm_loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            cd_userLabel = new System.Windows.Forms.Label();
            nm_nameLabel = new System.Windows.Forms.Label();
            cd_levelLabel = new System.Windows.Forms.Label();
            nm_loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_userLabel
            // 
            cd_userLabel.AutoSize = true;
            cd_userLabel.Location = new System.Drawing.Point(110, 36);
            cd_userLabel.Name = "cd_userLabel";
            cd_userLabel.Size = new System.Drawing.Size(43, 13);
            cd_userLabel.TabIndex = 10;
            cd_userLabel.Text = "Usuário";
            // 
            // nm_nameLabel
            // 
            nm_nameLabel.AutoSize = true;
            nm_nameLabel.Location = new System.Drawing.Point(110, 62);
            nm_nameLabel.Name = "nm_nameLabel";
            nm_nameLabel.Size = new System.Drawing.Size(35, 13);
            nm_nameLabel.TabIndex = 12;
            nm_nameLabel.Text = "Nome";
            // 
            // cd_levelLabel
            // 
            cd_levelLabel.AutoSize = true;
            cd_levelLabel.Location = new System.Drawing.Point(110, 88);
            cd_levelLabel.Name = "cd_levelLabel";
            cd_levelLabel.Size = new System.Drawing.Size(86, 13);
            cd_levelLabel.TabIndex = 14;
            cd_levelLabel.Text = "Nível de Acesso";
            // 
            // nm_loginLabel
            // 
            nm_loginLabel.AutoSize = true;
            nm_loginLabel.Location = new System.Drawing.Point(110, 114);
            nm_loginLabel.Name = "nm_loginLabel";
            nm_loginLabel.Size = new System.Drawing.Size(33, 13);
            nm_loginLabel.TabIndex = 16;
            nm_loginLabel.Text = "Login";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(110, 140);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(38, 13);
            passwordLabel.TabIndex = 18;
            passwordLabel.Text = "Senha";
            // 
            // btn3
            // 
            this.btn3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn3.Location = new System.Drawing.Point(113, 238);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 0;
            this.btn3.Text = "Anterior";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn4.Location = new System.Drawing.Point(194, 238);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 0;
            this.btn4.Text = "Próximo";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn5.Location = new System.Drawing.Point(275, 238);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 23);
            this.btn5.TabIndex = 0;
            this.btn5.Text = "Novo";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn6.Location = new System.Drawing.Point(356, 238);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 23);
            this.btn6.TabIndex = 0;
            this.btn6.Text = "Alterar";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn7.Location = new System.Drawing.Point(113, 267);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 23);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "Salvar";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn8.Location = new System.Drawing.Point(194, 267);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 23);
            this.btn8.TabIndex = 0;
            this.btn8.Text = "Cancelar";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn9.Location = new System.Drawing.Point(275, 267);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 23);
            this.btn9.TabIndex = 0;
            this.btn9.Text = "Pesquisar";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn10
            // 
            this.btn10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn10.Location = new System.Drawing.Point(356, 267);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(75, 23);
            this.btn10.TabIndex = 0;
            this.btn10.Text = "Imprimir";
            this.btn10.UseVisualStyleBackColor = true;
            // 
            // btn11
            // 
            this.btn11.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn11.Location = new System.Drawing.Point(437, 267);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(75, 23);
            this.btn11.TabIndex = 0;
            this.btn11.Text = "Sair";
            this.btn11.UseVisualStyleBackColor = true;
            // 
            // btn12
            // 
            this.btn12.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn12.Location = new System.Drawing.Point(437, 238);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(75, 23);
            this.btn12.TabIndex = 0;
            this.btn12.Text = "Excluir";
            this.btn12.UseVisualStyleBackColor = true;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_userBindingSource
            // 
            this.tb_userBindingSource.DataMember = "tb_user";
            this.tb_userBindingSource.DataSource = this.database1DataSet1;
            // 
            // tb_userTableAdapter
            // 
            this.tb_userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_userTableAdapter = this.tb_userTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cd_userTextBox
            // 
            this.cd_userTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_userBindingSource, "cd_user", true));
            this.cd_userTextBox.Location = new System.Drawing.Point(159, 33);
            this.cd_userTextBox.Name = "cd_userTextBox";
            this.cd_userTextBox.Size = new System.Drawing.Size(346, 20);
            this.cd_userTextBox.TabIndex = 11;
            // 
            // nm_nameTextBox
            // 
            this.nm_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_userBindingSource, "nm_name", true));
            this.nm_nameTextBox.Location = new System.Drawing.Point(159, 59);
            this.nm_nameTextBox.Name = "nm_nameTextBox";
            this.nm_nameTextBox.Size = new System.Drawing.Size(346, 20);
            this.nm_nameTextBox.TabIndex = 13;
            // 
            // cd_levelTextBox
            // 
            this.cd_levelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_userBindingSource, "cd_level", true));
            this.cd_levelTextBox.Location = new System.Drawing.Point(202, 85);
            this.cd_levelTextBox.Name = "cd_levelTextBox";
            this.cd_levelTextBox.Size = new System.Drawing.Size(35, 20);
            this.cd_levelTextBox.TabIndex = 15;
            // 
            // nm_loginTextBox
            // 
            this.nm_loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_userBindingSource, "nm_login", true));
            this.nm_loginTextBox.Location = new System.Drawing.Point(159, 111);
            this.nm_loginTextBox.Name = "nm_loginTextBox";
            this.nm_loginTextBox.Size = new System.Drawing.Size(346, 20);
            this.nm_loginTextBox.TabIndex = 17;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_userBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(159, 137);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(346, 20);
            this.passwordTextBox.TabIndex = 19;
            // 
            // frmPrincipal
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(606, 318);
            this.Controls.Add(cd_userLabel);
            this.Controls.Add(this.cd_userTextBox);
            this.Controls.Add(nm_nameLabel);
            this.Controls.Add(this.nm_nameTextBox);
            this.Controls.Add(cd_levelLabel);
            this.Controls.Add(this.cd_levelTextBox);
            this.Controls.Add(nm_loginLabel);
            this.Controls.Add(this.nm_loginTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn3);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "user";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private Database1DataSet database1DataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource tb_userBindingSource;
        private Database1DataSetTableAdapters.tb_userTableAdapter tb_userTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cd_userTextBox;
        private System.Windows.Forms.TextBox nm_nameTextBox;
        private System.Windows.Forms.TextBox cd_levelTextBox;
        private System.Windows.Forms.TextBox nm_loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}

