namespace Sistema_Controle_de_Gastos_DESAFIO_TECNICO.Forms
{
    partial class FormMenu
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
            buttonCadastroPessoa = new Button();
            buttonCadastroTransacao = new Button();
            buttonConsultas = new Button();
            SuspendLayout();
            // 
            // buttonCadastroPessoa
            // 
            buttonCadastroPessoa.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCadastroPessoa.Location = new Point(12, 168);
            buttonCadastroPessoa.Name = "buttonCadastroPessoa";
            buttonCadastroPessoa.Size = new Size(244, 57);
            buttonCadastroPessoa.TabIndex = 0;
            buttonCadastroPessoa.Text = "Cadastro de pessoa";
            buttonCadastroPessoa.UseVisualStyleBackColor = true;
            buttonCadastroPessoa.Click += buttonCadastroPessoa_Click_1;
            // 
            // buttonCadastroTransacao
            // 
            buttonCadastroTransacao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCadastroTransacao.Location = new Point(12, 319);
            buttonCadastroTransacao.Name = "buttonCadastroTransacao";
            buttonCadastroTransacao.Size = new Size(244, 57);
            buttonCadastroTransacao.TabIndex = 1;
            buttonCadastroTransacao.Text = "Cadastro de transações";
            buttonCadastroTransacao.UseVisualStyleBackColor = true;
            buttonCadastroTransacao.Click += buttonCadastroTransacao_Click;
            // 
            // buttonConsultas
            // 
            buttonConsultas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonConsultas.Location = new Point(12, 12);
            buttonConsultas.Name = "buttonConsultas";
            buttonConsultas.Size = new Size(244, 57);
            buttonConsultas.TabIndex = 2;
            buttonConsultas.Text = "Consultas\r\n";
            buttonConsultas.UseVisualStyleBackColor = true;
            buttonConsultas.Click += buttonConsultas_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 491);
            Controls.Add(buttonConsultas);
            Controls.Add(buttonCadastroTransacao);
            Controls.Add(buttonCadastroPessoa);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCadastroPessoa;
        private Button buttonCadastroTransacao;
        private Button buttonConsultas;
    }
}