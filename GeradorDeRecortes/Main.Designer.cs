namespace GeradorDeRecortes
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnGerarArquivo = new System.Windows.Forms.Button();
            this.TBQuantidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBTamanhoMaximo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBTamanhoMinimo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBPalavraEspecífica = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBFonteMinima = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TBFonteMaxima = new System.Windows.Forms.TextBox();
            this.CBMaiuscula = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnGerarArquivo
            // 
            this.BtnGerarArquivo.Location = new System.Drawing.Point(11, 228);
            this.BtnGerarArquivo.Name = "BtnGerarArquivo";
            this.BtnGerarArquivo.Size = new System.Drawing.Size(240, 23);
            this.BtnGerarArquivo.TabIndex = 0;
            this.BtnGerarArquivo.Text = "Gerar arquivo";
            this.BtnGerarArquivo.UseVisualStyleBackColor = true;
            this.BtnGerarArquivo.Click += new System.EventHandler(this.BtnGerarArquivo_Click);
            // 
            // TBQuantidade
            // 
            this.TBQuantidade.Location = new System.Drawing.Point(152, 6);
            this.TBQuantidade.Name = "TBQuantidade";
            this.TBQuantidade.Size = new System.Drawing.Size(100, 23);
            this.TBQuantidade.TabIndex = 1;
            this.TBQuantidade.Text = "50";
            this.TBQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBQuantidade_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantidade de palavras:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tamanho máximo:";
            // 
            // TBTamanhoMaximo
            // 
            this.TBTamanhoMaximo.Location = new System.Drawing.Point(152, 35);
            this.TBTamanhoMaximo.Name = "TBTamanhoMaximo";
            this.TBTamanhoMaximo.Size = new System.Drawing.Size(100, 23);
            this.TBTamanhoMaximo.TabIndex = 3;
            this.TBTamanhoMaximo.Text = "0";
            this.TBTamanhoMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBTamanhoMaximo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tamanho mínimo:";
            // 
            // TBTamanhoMinimo
            // 
            this.TBTamanhoMinimo.Location = new System.Drawing.Point(152, 64);
            this.TBTamanhoMinimo.Name = "TBTamanhoMinimo";
            this.TBTamanhoMinimo.Size = new System.Drawing.Size(100, 23);
            this.TBTamanhoMinimo.TabIndex = 5;
            this.TBTamanhoMinimo.Text = "0";
            this.TBTamanhoMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBTamanhoMinimo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Palavra específica:";
            // 
            // TBPalavraEspecífica
            // 
            this.TBPalavraEspecífica.Location = new System.Drawing.Point(151, 93);
            this.TBPalavraEspecífica.Name = "TBPalavraEspecífica";
            this.TBPalavraEspecífica.Size = new System.Drawing.Size(100, 23);
            this.TBPalavraEspecífica.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(11, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fonte";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tamanho mínimo:";
            // 
            // TBFonteMinima
            // 
            this.TBFonteMinima.Location = new System.Drawing.Point(151, 199);
            this.TBFonteMinima.Name = "TBFonteMinima";
            this.TBFonteMinima.Size = new System.Drawing.Size(100, 23);
            this.TBFonteMinima.TabIndex = 12;
            this.TBFonteMinima.Text = "23";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tamanho máximo:";
            // 
            // TBFonteMaxima
            // 
            this.TBFonteMaxima.Location = new System.Drawing.Point(151, 170);
            this.TBFonteMaxima.Name = "TBFonteMaxima";
            this.TBFonteMaxima.Size = new System.Drawing.Size(100, 23);
            this.TBFonteMaxima.TabIndex = 10;
            this.TBFonteMaxima.Text = "48";
            // 
            // CBMaiuscula
            // 
            this.CBMaiuscula.AutoSize = true;
            this.CBMaiuscula.Location = new System.Drawing.Point(12, 127);
            this.CBMaiuscula.Name = "CBMaiuscula";
            this.CBMaiuscula.Size = new System.Drawing.Size(130, 19);
            this.CBMaiuscula.TabIndex = 14;
            this.CBMaiuscula.Text = "Somente maiúscula";
            this.CBMaiuscula.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 263);
            this.Controls.Add(this.CBMaiuscula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBFonteMinima);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBFonteMaxima);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBPalavraEspecífica);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBTamanhoMinimo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBTamanhoMaximo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBQuantidade);
            this.Controls.Add(this.BtnGerarArquivo);
            this.Name = "Main";
            this.Text = "Gerador de Recortes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnGerarArquivo;
        private TextBox TBQuantidade;
        private Label label1;
        private Label label2;
        private TextBox TBTamanhoMaximo;
        private Label label3;
        private TextBox TBTamanhoMinimo;
        private Label label4;
        private TextBox TBPalavraEspecífica;
        private Label label5;
        private Label label6;
        private TextBox TBFonteMinima;
        private Label label7;
        private TextBox TBFonteMaxima;
        private CheckBox CBMaiuscula;
    }
}