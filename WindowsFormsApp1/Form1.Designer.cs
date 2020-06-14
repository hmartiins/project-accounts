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
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrintOut = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
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
            cd_userLabel.Location = new System.Drawing.Point(9, 83);
            cd_userLabel.Name = "cd_userLabel";
            cd_userLabel.Size = new System.Drawing.Size(43, 13);
            cd_userLabel.TabIndex = 10;
            cd_userLabel.Text = "Usuário";
            // 
            // nm_nameLabel
            // 
            nm_nameLabel.AutoSize = true;
            nm_nameLabel.Location = new System.Drawing.Point(9, 109);
            nm_nameLabel.Name = "nm_nameLabel";
            nm_nameLabel.Size = new System.Drawing.Size(35, 13);
            nm_nameLabel.TabIndex = 12;
            nm_nameLabel.Text = "Nome";
            // 
            // cd_levelLabel
            // 
            cd_levelLabel.AutoSize = true;
            cd_levelLabel.Location = new System.Drawing.Point(9, 136);
            cd_levelLabel.Name = "cd_levelLabel";
            cd_levelLabel.Size = new System.Drawing.Size(86, 13);
            cd_levelLabel.TabIndex = 14;
            cd_levelLabel.Text = "Nível de Acesso";
            // 
            // nm_loginLabel
            // 
            nm_loginLabel.AutoSize = true;
            nm_loginLabel.Location = new System.Drawing.Point(9, 164);
            nm_loginLabel.Name = "nm_loginLabel";
            nm_loginLabel.Size = new System.Drawing.Size(33, 13);
            nm_loginLabel.TabIndex = 16;
            nm_loginLabel.Text = "Login";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(9, 187);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(38, 13);
            passwordLabel.TabIndex = 18;
            passwordLabel.Text = "Senha";
            // 
            // btnPrevious
            // 
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnPrevious.Location = new System.Drawing.Point(224, 283);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "Anterior";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnNext.Location = new System.Drawing.Point(389, 283);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Próximo";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnNew.Location = new System.Drawing.Point(470, 283);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnChange
            // 
            this.btnChange.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnChange.Location = new System.Drawing.Point(305, 283);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "Alterar";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSave.Location = new System.Drawing.Point(327, 213);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCancel.Location = new System.Drawing.Point(143, 283);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSearch.Location = new System.Drawing.Point(519, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnPrintOut
            // 
            this.btnPrintOut.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnPrintOut.Location = new System.Drawing.Point(12, 12);
            this.btnPrintOut.Name = "btnPrintOut";
            this.btnPrintOut.Size = new System.Drawing.Size(75, 23);
            this.btnPrintOut.TabIndex = 0;
            this.btnPrintOut.Text = "Imprimir";
            this.btnPrintOut.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnExit.Location = new System.Drawing.Point(62, 283);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnDelete.Location = new System.Drawing.Point(246, 213);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
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
            this.cd_userTextBox.Location = new System.Drawing.Point(56, 80);
            this.cd_userTextBox.Name = "cd_userTextBox";
            this.cd_userTextBox.Size = new System.Drawing.Size(346, 20);
            this.cd_userTextBox.TabIndex = 11;
            // 
            // nm_nameTextBox
            // 
            this.nm_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_userBindingSource, "nm_name", true));
            this.nm_nameTextBox.Location = new System.Drawing.Point(56, 106);
            this.nm_nameTextBox.Name = "nm_nameTextBox";
            this.nm_nameTextBox.Size = new System.Drawing.Size(346, 20);
            this.nm_nameTextBox.TabIndex = 13;
            // 
            // cd_levelTextBox
            // 
            this.cd_levelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_userBindingSource, "cd_level", true));
            this.cd_levelTextBox.Location = new System.Drawing.Point(101, 133);
            this.cd_levelTextBox.Name = "cd_levelTextBox";
            this.cd_levelTextBox.Size = new System.Drawing.Size(35, 20);
            this.cd_levelTextBox.TabIndex = 15;
            // 
            // nm_loginTextBox
            // 
            this.nm_loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_userBindingSource, "nm_login", true));
            this.nm_loginTextBox.Location = new System.Drawing.Point(56, 161);
            this.nm_loginTextBox.Name = "nm_loginTextBox";
            this.nm_loginTextBox.Size = new System.Drawing.Size(346, 20);
            this.nm_loginTextBox.TabIndex = 17;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_userBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(56, 187);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
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
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrintOut);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnPrevious);
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
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPrintOut;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
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

