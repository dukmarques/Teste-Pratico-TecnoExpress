namespace Teste_Pratico
{
    partial class Form_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Principal));
            this.btnAdd = new System.Windows.Forms.Button();
            this.cadastrarModulo = new System.Windows.Forms.Button();
            this.cadastrarFuncionalidade = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cadastrarModulo
            // 
            this.cadastrarModulo.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.cadastrarModulo, "cadastrarModulo");
            this.cadastrarModulo.Name = "cadastrarModulo";
            this.cadastrarModulo.UseVisualStyleBackColor = false;
            this.cadastrarModulo.Click += new System.EventHandler(this.cadastrarModulo_Click);
            // 
            // cadastrarFuncionalidade
            // 
            this.cadastrarFuncionalidade.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.cadastrarFuncionalidade, "cadastrarFuncionalidade");
            this.cadastrarFuncionalidade.Name = "cadastrarFuncionalidade";
            this.cadastrarFuncionalidade.UseVisualStyleBackColor = false;
            this.cadastrarFuncionalidade.Click += new System.EventHandler(this.cadastrarFuncionalidade_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            resources.ApplyResources(this.btnRemove, "btnRemove");
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Name = "label1";
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.listView, "listView");
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Tile;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            resources.ApplyResources(this.btnFinalizar, "btnFinalizar");
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // Form_Principal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.cadastrarFuncionalidade);
            this.Controls.Add(this.cadastrarModulo);
            this.Controls.Add(this.btnAdd);
            this.MaximizeBox = false;
            this.Name = "Form_Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button cadastrarModulo;
        private System.Windows.Forms.Button cadastrarFuncionalidade;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button btnFinalizar;
    }
}

