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
            this.button_cadSaida = new System.Windows.Forms.Button();
            this.button_CadastrarEntrada = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_cadPlaca = new System.Windows.Forms.TextBox();
            this.textBox_veiculosEstacionados = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGrid_veiculosEstacionados = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_veiculosEstacionados)).BeginInit();
            this.SuspendLayout();
            // 
            // button_menu
            // 
            this.button_menu.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_menu.ForeColor = System.Drawing.Color.White;
            this.button_menu.Location = new System.Drawing.Point(29, 13);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(108, 37);
            this.button_menu.TabIndex = 0;
            this.button_menu.Text = "Menu Iniciar";
            this.button_menu.UseMnemonic = false;
            this.button_menu.UseVisualStyleBackColor = false;
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            // 
            // button_cadSaida
            // 
            this.button_cadSaida.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_cadSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cadSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cadSaida.ForeColor = System.Drawing.Color.White;
            this.button_cadSaida.Location = new System.Drawing.Point(270, 276);
            this.button_cadSaida.Name = "button_cadSaida";
            this.button_cadSaida.Size = new System.Drawing.Size(97, 54);
            this.button_cadSaida.TabIndex = 2;
            this.button_cadSaida.Text = "Cadastrar Saída";
            this.button_cadSaida.UseVisualStyleBackColor = false;
            // 
            // button_CadastrarEntrada
            // 
            this.button_CadastrarEntrada.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_CadastrarEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CadastrarEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CadastrarEntrada.ForeColor = System.Drawing.Color.White;
            this.button_CadastrarEntrada.Location = new System.Drawing.Point(29, 214);
            this.button_CadastrarEntrada.Name = "button_CadastrarEntrada";
            this.button_CadastrarEntrada.Size = new System.Drawing.Size(97, 54);
            this.button_CadastrarEntrada.TabIndex = 17;
            this.button_CadastrarEntrada.Text = "Cadastrar";
            this.button_CadastrarEntrada.UseVisualStyleBackColor = false;
            this.button_CadastrarEntrada.Click += new System.EventHandler(this.button_CadastrarEntrada_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Placa do Carro";
            // 
            // textBox_cadPlaca
            // 
            this.textBox_cadPlaca.Location = new System.Drawing.Point(12, 157);
            this.textBox_cadPlaca.Name = "textBox_cadPlaca";
            this.textBox_cadPlaca.Size = new System.Drawing.Size(138, 20);
            this.textBox_cadPlaca.TabIndex = 14;
            // 
            // textBox_veiculosEstacionados
            // 
            this.textBox_veiculosEstacionados.Location = new System.Drawing.Point(208, 46);
            this.textBox_veiculosEstacionados.Multiline = true;
            this.textBox_veiculosEstacionados.Name = "textBox_veiculosEstacionados";
            this.textBox_veiculosEstacionados.Size = new System.Drawing.Size(240, 221);
            this.textBox_veiculosEstacionados.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(464, 46);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 221);
            this.textBox2.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.button_CadastrarEntrada);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_cadPlaca);
            this.panel1.Controls.Add(this.button_menu);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 453);
            this.panel1.TabIndex = 20;
            // 
            // dataGrid_veiculosEstacionados
            // 
            this.dataGrid_veiculosEstacionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_veiculosEstacionados.Location = new System.Drawing.Point(464, 46);
            this.dataGrid_veiculosEstacionados.Name = "dataGrid_veiculosEstacionados";
            this.dataGrid_veiculosEstacionados.Size = new System.Drawing.Size(240, 221);
            this.dataGrid_veiculosEstacionados.TabIndex = 21;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::_8_desafioWindowsFormOOArquivo.Properties.Resources._2;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGrid_veiculosEstacionados);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox_veiculosEstacionados);
            this.Controls.Add(this.button_cadSaida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_veiculosEstacionados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Button button_cadSaida;
        private System.Windows.Forms.Button button_CadastrarEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_cadPlaca;
        private System.Windows.Forms.TextBox textBox_veiculosEstacionados;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGrid_veiculosEstacionados;
    }
}