
namespace Componentes
{
    partial class F_ComboBox
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
            this.tb_transporte = new System.Windows.Forms.TextBox();
            this.btn_adicionarNovoTransprote = new System.Windows.Forms.Button();
            this.btn_resetarElementos = new System.Windows.Forms.Button();
            this.btn_limparElementos = new System.Windows.Forms.Button();
            this.btn_mostrarSelecionados = new System.Windows.Forms.Button();
            this.cb_transportes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tb_transporte
            // 
            this.tb_transporte.Location = new System.Drawing.Point(241, 118);
            this.tb_transporte.Name = "tb_transporte";
            this.tb_transporte.Size = new System.Drawing.Size(211, 20);
            this.tb_transporte.TabIndex = 11;
            // 
            // btn_adicionarNovoTransprote
            // 
            this.btn_adicionarNovoTransprote.Location = new System.Drawing.Point(241, 144);
            this.btn_adicionarNovoTransprote.Name = "btn_adicionarNovoTransprote";
            this.btn_adicionarNovoTransprote.Size = new System.Drawing.Size(211, 23);
            this.btn_adicionarNovoTransprote.TabIndex = 10;
            this.btn_adicionarNovoTransprote.Text = "Adicionar Novo transporte";
            this.btn_adicionarNovoTransprote.UseVisualStyleBackColor = true;
            this.btn_adicionarNovoTransprote.Click += new System.EventHandler(this.btn_adicionarNovoTransprote_Click);
            // 
            // btn_resetarElementos
            // 
            this.btn_resetarElementos.Location = new System.Drawing.Point(241, 72);
            this.btn_resetarElementos.Name = "btn_resetarElementos";
            this.btn_resetarElementos.Size = new System.Drawing.Size(211, 23);
            this.btn_resetarElementos.TabIndex = 9;
            this.btn_resetarElementos.Text = "Resetar Elementos";
            this.btn_resetarElementos.UseVisualStyleBackColor = true;
            this.btn_resetarElementos.Click += new System.EventHandler(this.btn_resetarElementos_Click);
            // 
            // btn_limparElementos
            // 
            this.btn_limparElementos.Location = new System.Drawing.Point(241, 42);
            this.btn_limparElementos.Name = "btn_limparElementos";
            this.btn_limparElementos.Size = new System.Drawing.Size(211, 23);
            this.btn_limparElementos.TabIndex = 8;
            this.btn_limparElementos.Text = "Limpar Elementos";
            this.btn_limparElementos.UseVisualStyleBackColor = true;
            this.btn_limparElementos.Click += new System.EventHandler(this.btn_limparElementos_Click);
            // 
            // btn_mostrarSelecionados
            // 
            this.btn_mostrarSelecionados.Location = new System.Drawing.Point(241, 12);
            this.btn_mostrarSelecionados.Name = "btn_mostrarSelecionados";
            this.btn_mostrarSelecionados.Size = new System.Drawing.Size(211, 23);
            this.btn_mostrarSelecionados.TabIndex = 7;
            this.btn_mostrarSelecionados.Text = "Mostrar Selecionados";
            this.btn_mostrarSelecionados.UseVisualStyleBackColor = true;
            this.btn_mostrarSelecionados.Click += new System.EventHandler(this.btn_mostrarSelecionados_Click);
            // 
            // cb_transportes
            // 
            this.cb_transportes.FormattingEnabled = true;
            this.cb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ónibus",
            "Trem"});
            this.cb_transportes.Location = new System.Drawing.Point(12, 12);
            this.cb_transportes.Name = "cb_transportes";
            this.cb_transportes.Size = new System.Drawing.Size(211, 21);
            this.cb_transportes.TabIndex = 6;
            this.cb_transportes.SelectedIndexChanged += new System.EventHandler(this.cb_transportes_SelectedIndexChanged);
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 269);
            this.Controls.Add(this.tb_transporte);
            this.Controls.Add(this.btn_adicionarNovoTransprote);
            this.Controls.Add(this.btn_resetarElementos);
            this.Controls.Add(this.btn_limparElementos);
            this.Controls.Add(this.btn_mostrarSelecionados);
            this.Controls.Add(this.cb_transportes);
            this.Name = "F_ComboBox";
            this.Text = "F_ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_transporte;
        private System.Windows.Forms.Button btn_adicionarNovoTransprote;
        private System.Windows.Forms.Button btn_resetarElementos;
        private System.Windows.Forms.Button btn_limparElementos;
        private System.Windows.Forms.Button btn_mostrarSelecionados;
        private System.Windows.Forms.ComboBox cb_transportes;
    }
}