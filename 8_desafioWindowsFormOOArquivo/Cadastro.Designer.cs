namespace _8_desafioWindowsFormOOArquivo
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.button_menu = new System.Windows.Forms.Button();
            this.button_cadEntrada = new System.Windows.Forms.Button();
            this.button_cadSaida = new System.Windows.Forms.Button();
            this.button_consultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_menu
            // 
            this.button_menu.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_menu.ForeColor = System.Drawing.Color.White;
            this.button_menu.Location = new System.Drawing.Point(12, 12);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(127, 62);
            this.button_menu.TabIndex = 0;
            this.button_menu.Text = "Menu Iniciar";
            this.button_menu.UseMnemonic = false;
            this.button_menu.UseVisualStyleBackColor = false;
            // 
            // button_cadEntrada
            // 
            this.button_cadEntrada.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_cadEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cadEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cadEntrada.ForeColor = System.Drawing.Color.White;
            this.button_cadEntrada.Location = new System.Drawing.Point(12, 80);
            this.button_cadEntrada.Name = "button_cadEntrada";
            this.button_cadEntrada.Size = new System.Drawing.Size(127, 62);
            this.button_cadEntrada.TabIndex = 1;
            this.button_cadEntrada.Text = "Cadastrar Entrada";
            this.button_cadEntrada.UseVisualStyleBackColor = false;
            // 
            // button_cadSaida
            // 
            this.button_cadSaida.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_cadSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cadSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cadSaida.ForeColor = System.Drawing.Color.White;
            this.button_cadSaida.Location = new System.Drawing.Point(12, 148);
            this.button_cadSaida.Name = "button_cadSaida";
            this.button_cadSaida.Size = new System.Drawing.Size(126, 62);
            this.button_cadSaida.TabIndex = 2;
            this.button_cadSaida.Text = "Cadastrar Saída";
            this.button_cadSaida.UseVisualStyleBackColor = false;
            // 
            // button_consultar
            // 
            this.button_consultar.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_consultar.ForeColor = System.Drawing.Color.White;
            this.button_consultar.Location = new System.Drawing.Point(13, 216);
            this.button_consultar.Name = "button_consultar";
            this.button_consultar.Size = new System.Drawing.Size(126, 62);
            this.button_consultar.TabIndex = 3;
            this.button_consultar.Text = "Consultar";
            this.button_consultar.UseVisualStyleBackColor = false;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_8_desafioWindowsFormOOArquivo.Properties.Resources._2;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_consultar);
            this.Controls.Add(this.button_cadSaida);
            this.Controls.Add(this.button_cadEntrada);
            this.Controls.Add(this.button_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Button button_cadEntrada;
        private System.Windows.Forms.Button button_cadSaida;
        private System.Windows.Forms.Button button_consultar;
    }
}