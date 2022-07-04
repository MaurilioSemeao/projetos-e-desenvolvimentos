namespace ValidadorCpfCnpj
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
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
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.Cpf = new System.Windows.Forms.Label();
            this.lblFalse = new System.Windows.Forms.Label();
            this.btnVarifcar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSaida = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbEst4 = new System.Windows.Forms.RadioButton();
            this.rdbEst0 = new System.Windows.Forms.RadioButton();
            this.rdbEst1 = new System.Windows.Forms.RadioButton();
            this.rdbEst9 = new System.Windows.Forms.RadioButton();
            this.rdbEst2 = new System.Windows.Forms.RadioButton();
            this.rdbEst8 = new System.Windows.Forms.RadioButton();
            this.rdbEst3 = new System.Windows.Forms.RadioButton();
            this.rdbEst7 = new System.Windows.Forms.RadioButton();
            this.rdbEst5 = new System.Windows.Forms.RadioButton();
            this.rdbEst6 = new System.Windows.Forms.RadioButton();
            this.btnGerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(188, 68);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(176, 29);
            this.txtCpf.TabIndex = 0;
            this.txtCpf.TextChanged += new System.EventHandler(this.txtCpf_TextChanged);
            // 
            // Cpf
            // 
            this.Cpf.AutoSize = true;
            this.Cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cpf.Location = new System.Drawing.Point(152, 3);
            this.Cpf.Name = "Cpf";
            this.Cpf.Size = new System.Drawing.Size(274, 26);
            this.Cpf.TabIndex = 1;
            this.Cpf.Text = "Digite o cpf a ser verificado";
            // 
            // lblFalse
            // 
            this.lblFalse.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFalse.Location = new System.Drawing.Point(192, 130);
            this.lblFalse.Name = "lblFalse";
            this.lblFalse.Size = new System.Drawing.Size(172, 32);
            this.lblFalse.TabIndex = 3;
            this.lblFalse.Text = "......?";
            this.lblFalse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVarifcar
            // 
            this.btnVarifcar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnVarifcar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVarifcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVarifcar.Location = new System.Drawing.Point(188, 189);
            this.btnVarifcar.Name = "btnVarifcar";
            this.btnVarifcar.Size = new System.Drawing.Size(176, 38);
            this.btnVarifcar.TabIndex = 2;
            this.btnVarifcar.Text = "Verificar";
            this.btnVarifcar.UseVisualStyleBackColor = true;
            this.btnVarifcar.Click += new System.EventHandler(this.btnVarifcar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(627, 333);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.btnVarifcar);
            this.tabPage1.Controls.Add(this.lblFalse);
            this.tabPage1.Controls.Add(this.Cpf);
            this.tabPage1.Controls.Add(this.txtCpf);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(619, 307);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Validador de Cpf";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.txtSaida);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnGerar);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtEntrada);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(619, 307);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gerador de CPF";
            // 
            // txtSaida
            // 
            this.txtSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaida.Location = new System.Drawing.Point(21, 139);
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(143, 24);
            this.txtSaida.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbEst4);
            this.groupBox1.Controls.Add(this.rdbEst0);
            this.groupBox1.Controls.Add(this.rdbEst1);
            this.groupBox1.Controls.Add(this.rdbEst9);
            this.groupBox1.Controls.Add(this.rdbEst2);
            this.groupBox1.Controls.Add(this.rdbEst8);
            this.groupBox1.Controls.Add(this.rdbEst3);
            this.groupBox1.Controls.Add(this.rdbEst7);
            this.groupBox1.Controls.Add(this.rdbEst5);
            this.groupBox1.Controls.Add(this.rdbEst6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(270, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 291);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione estado Referencia para o Cpf";
            // 
            // rdbEst4
            // 
            this.rdbEst4.AutoSize = true;
            this.rdbEst4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEst4.Location = new System.Drawing.Point(0, 111);
            this.rdbEst4.Name = "rdbEst4";
            this.rdbEst4.Size = new System.Drawing.Size(315, 19);
            this.rdbEst4.TabIndex = 7;
            this.rdbEst4.TabStop = true;
            this.rdbEst4.Text = "Pernambuco, Rio Grande do Norte, Paraíba e Alagoa";
            this.rdbEst4.UseVisualStyleBackColor = true;
            // 
            // rdbEst0
            // 
            this.rdbEst0.AutoSize = true;
            this.rdbEst0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEst0.Location = new System.Drawing.Point(0, 261);
            this.rdbEst0.Name = "rdbEst0";
            this.rdbEst0.Size = new System.Drawing.Size(126, 19);
            this.rdbEst0.TabIndex = 13;
            this.rdbEst0.TabStop = true;
            this.rdbEst0.Text = "Rio Grande do Sul";
            this.rdbEst0.UseVisualStyleBackColor = true;
            // 
            // rdbEst1
            // 
            this.rdbEst1.AutoSize = true;
            this.rdbEst1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEst1.Location = new System.Drawing.Point(0, 39);
            this.rdbEst1.Name = "rdbEst1";
            this.rdbEst1.Size = new System.Drawing.Size(326, 19);
            this.rdbEst1.TabIndex = 0;
            this.rdbEst1.TabStop = true;
            this.rdbEst1.Text = "Distrito Federal, Goiás, Mato Grosso do Sul e Tocantins";
            this.rdbEst1.UseVisualStyleBackColor = true;
            // 
            // rdbEst9
            // 
            this.rdbEst9.AutoSize = true;
            this.rdbEst9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEst9.Location = new System.Drawing.Point(0, 236);
            this.rdbEst9.Name = "rdbEst9";
            this.rdbEst9.Size = new System.Drawing.Size(159, 19);
            this.rdbEst9.TabIndex = 12;
            this.rdbEst9.TabStop = true;
            this.rdbEst9.Text = "Paraná e Santa Catarina";
            this.rdbEst9.UseVisualStyleBackColor = true;
            // 
            // rdbEst2
            // 
            this.rdbEst2.AutoSize = true;
            this.rdbEst2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEst2.Location = new System.Drawing.Point(0, 62);
            this.rdbEst2.Name = "rdbEst2";
            this.rdbEst2.Size = new System.Drawing.Size(311, 19);
            this.rdbEst2.TabIndex = 5;
            this.rdbEst2.TabStop = true;
            this.rdbEst2.Text = "Pará, Amazonas, Acre, Amapá, Rondônia e Roraima";
            this.rdbEst2.UseVisualStyleBackColor = true;
            // 
            // rdbEst8
            // 
            this.rdbEst8.AutoSize = true;
            this.rdbEst8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEst8.Location = new System.Drawing.Point(0, 211);
            this.rdbEst8.Name = "rdbEst8";
            this.rdbEst8.Size = new System.Drawing.Size(82, 19);
            this.rdbEst8.TabIndex = 11;
            this.rdbEst8.TabStop = true;
            this.rdbEst8.Text = "São Paulo";
            this.rdbEst8.UseVisualStyleBackColor = true;
            // 
            // rdbEst3
            // 
            this.rdbEst3.AutoSize = true;
            this.rdbEst3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEst3.Location = new System.Drawing.Point(0, 88);
            this.rdbEst3.Name = "rdbEst3";
            this.rdbEst3.Size = new System.Drawing.Size(162, 19);
            this.rdbEst3.TabIndex = 6;
            this.rdbEst3.TabStop = true;
            this.rdbEst3.Text = "Ceará, Maranhão e Piauí";
            this.rdbEst3.UseVisualStyleBackColor = true;
            // 
            // rdbEst7
            // 
            this.rdbEst7.AutoSize = true;
            this.rdbEst7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEst7.Location = new System.Drawing.Point(0, 186);
            this.rdbEst7.Name = "rdbEst7";
            this.rdbEst7.Size = new System.Drawing.Size(194, 19);
            this.rdbEst7.TabIndex = 10;
            this.rdbEst7.TabStop = true;
            this.rdbEst7.Text = "Rio de Janeiro e Espírito Santo";
            this.rdbEst7.UseVisualStyleBackColor = true;
            // 
            // rdbEst5
            // 
            this.rdbEst5.AutoSize = true;
            this.rdbEst5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEst5.Location = new System.Drawing.Point(0, 136);
            this.rdbEst5.Name = "rdbEst5";
            this.rdbEst5.Size = new System.Drawing.Size(116, 19);
            this.rdbEst5.TabIndex = 8;
            this.rdbEst5.TabStop = true;
            this.rdbEst5.Text = "Bahia; e Sergipe";
            this.rdbEst5.UseVisualStyleBackColor = true;
            // 
            // rdbEst6
            // 
            this.rdbEst6.AutoSize = true;
            this.rdbEst6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEst6.Location = new System.Drawing.Point(0, 161);
            this.rdbEst6.Name = "rdbEst6";
            this.rdbEst6.Size = new System.Drawing.Size(98, 19);
            this.rdbEst6.TabIndex = 9;
            this.rdbEst6.TabStop = true;
            this.rdbEst6.Text = "Minas Gerais";
            this.rdbEst6.UseVisualStyleBackColor = true;
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(21, 206);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(133, 42);
            this.btnGerar.TabIndex = 4;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite os 8 primeiros digitos\r\npara gerar um Cpf";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.Location = new System.Drawing.Point(21, 63);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(146, 24);
            this.txtEntrada.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 357);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label Cpf;
        private System.Windows.Forms.Button btnVarifcar;
        private System.Windows.Forms.Label lblFalse;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtSaida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbEst4;
        private System.Windows.Forms.RadioButton rdbEst0;
        private System.Windows.Forms.RadioButton rdbEst1;
        private System.Windows.Forms.RadioButton rdbEst9;
        private System.Windows.Forms.RadioButton rdbEst2;
        private System.Windows.Forms.RadioButton rdbEst8;
        private System.Windows.Forms.RadioButton rdbEst3;
        private System.Windows.Forms.RadioButton rdbEst7;
        private System.Windows.Forms.RadioButton rdbEst5;
        private System.Windows.Forms.RadioButton rdbEst6;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntrada;
    }
}

