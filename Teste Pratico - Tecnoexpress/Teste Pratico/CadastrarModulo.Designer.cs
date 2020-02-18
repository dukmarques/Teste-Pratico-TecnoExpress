namespace Teste_Pratico
{
    partial class CadastrarModulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarModulo));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.checkModBasico = new System.Windows.Forms.CheckBox();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPreco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.BackColor = System.Drawing.Color.White;
            this.textBoxDescricao.Location = new System.Drawing.Point(97, 87);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(266, 20);
            this.textBoxDescricao.TabIndex = 2;
            // 
            // checkModBasico
            // 
            this.checkModBasico.AutoSize = true;
            this.checkModBasico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkModBasico.ForeColor = System.Drawing.Color.White;
            this.checkModBasico.Location = new System.Drawing.Point(15, 111);
            this.checkModBasico.Name = "checkModBasico";
            this.checkModBasico.Size = new System.Drawing.Size(127, 22);
            this.checkModBasico.TabIndex = 4;
            this.checkModBasico.Text = "Módulo Básico";
            this.checkModBasico.UseVisualStyleBackColor = true;
            this.checkModBasico.CheckedChanged += new System.EventHandler(this.checkModBasico_CheckedChanged);
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.BackColor = System.Drawing.Color.White;
            this.textBoxPreco.Location = new System.Drawing.Point(225, 113);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(62, 20);
            this.textBoxPreco.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(13, 178);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(351, 36);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar Módulo";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Preencha as informações do Módulo";
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreco.ForeColor = System.Drawing.Color.White;
            this.labelPreco.Location = new System.Drawing.Point(167, 113);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(52, 18);
            this.labelPreco.TabIndex = 9;
            this.labelPreco.Text = "Preço:";
            // 
            // CadastrarModulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(379, 226);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.checkModBasico);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(395, 265);
            this.Name = "CadastrarModulo";
            this.Text = "Cadastrar Módulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.CheckBox checkModBasico;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPreco;
    }
}