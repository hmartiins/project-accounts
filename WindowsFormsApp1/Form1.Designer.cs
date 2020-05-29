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
            this.SuspendLayout();
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
            // frmPrincipal
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(606, 318);
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
            this.Text = "Anterior";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

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
    }
}

