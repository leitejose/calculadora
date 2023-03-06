namespace calculadora
{
    partial class Form1
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
            this.boxResultado = new System.Windows.Forms.TextBox();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnPonto = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxResultado
            // 
            this.boxResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.boxResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxResultado.ForeColor = System.Drawing.Color.White;
            this.boxResultado.Location = new System.Drawing.Point(12, 12);
            this.boxResultado.Multiline = true;
            this.boxResultado.Name = "boxResultado";
            this.boxResultado.ReadOnly = true;
            this.boxResultado.Size = new System.Drawing.Size(331, 101);
            this.boxResultado.TabIndex = 0;
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.IndianRed;
            this.btnIgual.FlatAppearance.BorderSize = 0;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIgual.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIgual.ForeColor = System.Drawing.Color.White;
            this.btnIgual.Location = new System.Drawing.Point(264, 371);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(78, 163);
            this.btnIgual.TabIndex = 1;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.BackColor = System.Drawing.Color.Gray;
            this.btnSomar.FlatAppearance.BorderSize = 0;
            this.btnSomar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSomar.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSomar.ForeColor = System.Drawing.Color.IndianRed;
            this.btnSomar.Location = new System.Drawing.Point(264, 287);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(78, 78);
            this.btnSomar.TabIndex = 2;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = false;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.Color.Gray;
            this.btnSubtrair.FlatAppearance.BorderSize = 0;
            this.btnSubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubtrair.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubtrair.ForeColor = System.Drawing.Color.IndianRed;
            this.btnSubtrair.Location = new System.Drawing.Point(264, 203);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(78, 78);
            this.btnSubtrair.TabIndex = 3;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.Gray;
            this.btnDividir.FlatAppearance.BorderSize = 0;
            this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDividir.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDividir.ForeColor = System.Drawing.Color.IndianRed;
            this.btnDividir.Location = new System.Drawing.Point(180, 119);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(78, 78);
            this.btnDividir.TabIndex = 5;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.Gray;
            this.btnMultiplicar.FlatAppearance.BorderSize = 0;
            this.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiplicar.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplicar.ForeColor = System.Drawing.Color.IndianRed;
            this.btnMultiplicar.Location = new System.Drawing.Point(264, 119);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(78, 78);
            this.btnMultiplicar.TabIndex = 6;
            this.btnMultiplicar.Text = "x";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.Color.Gray;
            this.btnPercent.FlatAppearance.BorderSize = 0;
            this.btnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPercent.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPercent.ForeColor = System.Drawing.Color.IndianRed;
            this.btnPercent.Location = new System.Drawing.Point(96, 119);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(78, 78);
            this.btnPercent.TabIndex = 4;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = false;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.Gray;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnC.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnC.ForeColor = System.Drawing.Color.IndianRed;
            this.btnC.Location = new System.Drawing.Point(12, 119);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(78, 78);
            this.btnC.TabIndex = 7;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnSete
            // 
            this.btnSete.BackColor = System.Drawing.Color.DimGray;
            this.btnSete.FlatAppearance.BorderSize = 0;
            this.btnSete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSete.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSete.ForeColor = System.Drawing.Color.White;
            this.btnSete.Location = new System.Drawing.Point(12, 203);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(78, 78);
            this.btnSete.TabIndex = 8;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = false;
            this.btnSete.Click += new System.EventHandler(this.btnSete_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.BackColor = System.Drawing.Color.DimGray;
            this.btnSeis.FlatAppearance.BorderSize = 0;
            this.btnSeis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeis.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeis.ForeColor = System.Drawing.Color.White;
            this.btnSeis.Location = new System.Drawing.Point(180, 287);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(78, 78);
            this.btnSeis.TabIndex = 9;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnUm
            // 
            this.btnUm.BackColor = System.Drawing.Color.DimGray;
            this.btnUm.FlatAppearance.BorderSize = 0;
            this.btnUm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUm.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUm.ForeColor = System.Drawing.Color.White;
            this.btnUm.Location = new System.Drawing.Point(12, 372);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(78, 78);
            this.btnUm.TabIndex = 10;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = false;
            this.btnUm.Click += new System.EventHandler(this.btnUm_Click);
            // 
            // btnDois
            // 
            this.btnDois.BackColor = System.Drawing.Color.DimGray;
            this.btnDois.FlatAppearance.BorderSize = 0;
            this.btnDois.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDois.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDois.ForeColor = System.Drawing.Color.White;
            this.btnDois.Location = new System.Drawing.Point(96, 372);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(78, 78);
            this.btnDois.TabIndex = 11;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = false;
            this.btnDois.Click += new System.EventHandler(this.btnDois_Click);
            // 
            // btnTres
            // 
            this.btnTres.BackColor = System.Drawing.Color.DimGray;
            this.btnTres.FlatAppearance.BorderSize = 0;
            this.btnTres.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTres.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTres.ForeColor = System.Drawing.Color.White;
            this.btnTres.Location = new System.Drawing.Point(180, 372);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(78, 78);
            this.btnTres.TabIndex = 12;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.DimGray;
            this.btnZero.FlatAppearance.BorderSize = 0;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZero.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnZero.ForeColor = System.Drawing.Color.White;
            this.btnZero.Location = new System.Drawing.Point(12, 456);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(78, 78);
            this.btnZero.TabIndex = 13;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click_1);
            // 
            // btnPonto
            // 
            this.btnPonto.BackColor = System.Drawing.Color.DimGray;
            this.btnPonto.FlatAppearance.BorderSize = 0;
            this.btnPonto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPonto.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPonto.ForeColor = System.Drawing.Color.White;
            this.btnPonto.Location = new System.Drawing.Point(96, 456);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(78, 78);
            this.btnPonto.TabIndex = 14;
            this.btnPonto.Text = ".";
            this.btnPonto.UseVisualStyleBackColor = false;
            this.btnPonto.Click += new System.EventHandler(this.btnPonto_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.DimGray;
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApagar.ForeColor = System.Drawing.Color.White;
            this.btnApagar.Location = new System.Drawing.Point(180, 456);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(78, 78);
            this.btnApagar.TabIndex = 15;
            this.btnApagar.Text = "<";
            this.btnApagar.UseVisualStyleBackColor = false;
            // 
            // btnOito
            // 
            this.btnOito.BackColor = System.Drawing.Color.DimGray;
            this.btnOito.FlatAppearance.BorderSize = 0;
            this.btnOito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOito.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOito.ForeColor = System.Drawing.Color.White;
            this.btnOito.Location = new System.Drawing.Point(96, 203);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(78, 78);
            this.btnOito.TabIndex = 16;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = false;
            this.btnOito.Click += new System.EventHandler(this.btnOito_Click);
            // 
            // btnNove
            // 
            this.btnNove.BackColor = System.Drawing.Color.DimGray;
            this.btnNove.FlatAppearance.BorderSize = 0;
            this.btnNove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNove.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNove.ForeColor = System.Drawing.Color.White;
            this.btnNove.Location = new System.Drawing.Point(180, 203);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(78, 78);
            this.btnNove.TabIndex = 17;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = false;
            this.btnNove.Click += new System.EventHandler(this.btnNove_Click);
            // 
            // btnQuatro
            // 
            this.btnQuatro.BackColor = System.Drawing.Color.DimGray;
            this.btnQuatro.FlatAppearance.BorderSize = 0;
            this.btnQuatro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuatro.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuatro.ForeColor = System.Drawing.Color.White;
            this.btnQuatro.Location = new System.Drawing.Point(12, 287);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(78, 78);
            this.btnQuatro.TabIndex = 18;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = false;
            this.btnQuatro.Click += new System.EventHandler(this.btnQuatro_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.BackColor = System.Drawing.Color.DimGray;
            this.btnCinco.FlatAppearance.BorderSize = 0;
            this.btnCinco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCinco.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCinco.ForeColor = System.Drawing.Color.White;
            this.btnCinco.Location = new System.Drawing.Point(96, 287);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(78, 78);
            this.btnCinco.TabIndex = 19;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(354, 546);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnPonto);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.boxResultado);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox boxResultado;
        private Button btnIgual;
        private Button btnSomar;
        private Button btnSubtrair;
        private Button btnDividir;
        private Button btnMultiplicar;
        private Button btnPercent;
        private Button btnC;
        private Button btnSete;
        private Button btnSeis;
        private Button btnUm;
        private Button btnDois;
        private Button btnTres;
        private Button btnZero;
        private Button btnPonto;
        private Button btnApagar;
        private Button btnOito;
        private Button btnNove;
        private Button btnQuatro;
        private Button btnCinco;
    }
}