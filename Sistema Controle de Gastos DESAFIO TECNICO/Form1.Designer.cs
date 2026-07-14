namespace Sistema_Controle_de_Gastos_DESAFIO_TECNICO
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
            labelNome = new Label();
            labelIdade = new Label();
            labelDescricao = new Label();
            labelValor = new Label();
            labelTipo = new Label();
            labelConsulta = new Label();
            txtNomePessoa = new TextBox();
            txtIdadePessoa = new TextBox();
            txtDescricaoDespesa = new TextBox();
            txtValorDespesa = new TextBox();
            txtBuscar = new TextBox();
            listConsulta = new ListView();
            btnSalvarDespesa = new Button();
            btnConsultarDespesa = new Button();
            listboxTipoDespesa = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(12, 9);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            // 
            // labelIdade
            // 
            labelIdade.AutoSize = true;
            labelIdade.Location = new Point(12, 65);
            labelIdade.Name = "labelIdade";
            labelIdade.Size = new Size(36, 15);
            labelIdade.TabIndex = 1;
            labelIdade.Text = "Idade";
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.Location = new Point(12, 189);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(58, 15);
            labelDescricao.TabIndex = 2;
            labelDescricao.Text = "Descrição";
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Location = new Point(12, 245);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(33, 15);
            labelValor.TabIndex = 3;
            labelValor.Text = "Valor";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(14, 301);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(31, 15);
            labelTipo.TabIndex = 4;
            labelTipo.Text = "TIpo";
            // 
            // labelConsulta
            // 
            labelConsulta.AutoSize = true;
            labelConsulta.Location = new Point(176, 9);
            labelConsulta.Name = "labelConsulta";
            labelConsulta.Size = new Size(54, 15);
            labelConsulta.TabIndex = 5;
            labelConsulta.Text = "Consulta";
            // 
            // txtNomePessoa
            // 
            txtNomePessoa.Location = new Point(12, 27);
            txtNomePessoa.Name = "txtNomePessoa";
            txtNomePessoa.Size = new Size(100, 23);
            txtNomePessoa.TabIndex = 6;
            // 
            // txtIdadePessoa
            // 
            txtIdadePessoa.Location = new Point(12, 83);
            txtIdadePessoa.Name = "txtIdadePessoa";
            txtIdadePessoa.Size = new Size(100, 23);
            txtIdadePessoa.TabIndex = 7;
            // 
            // txtDescricaoDespesa
            // 
            txtDescricaoDespesa.Location = new Point(12, 207);
            txtDescricaoDespesa.Name = "txtDescricaoDespesa";
            txtDescricaoDespesa.Size = new Size(100, 23);
            txtDescricaoDespesa.TabIndex = 8;
            // 
            // txtValorDespesa
            // 
            txtValorDespesa.Location = new Point(12, 263);
            txtValorDespesa.Name = "txtValorDespesa";
            txtValorDespesa.Size = new Size(100, 23);
            txtValorDespesa.TabIndex = 9;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(176, 27);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(365, 23);
            txtBuscar.TabIndex = 11;
            // 
            // listConsulta
            // 
            listConsulta.Location = new Point(176, 55);
            listConsulta.Name = "listConsulta";
            listConsulta.Size = new Size(465, 383);
            listConsulta.TabIndex = 12;
            listConsulta.UseCompatibleStateImageBehavior = false;
            // 
            // btnSalvarDespesa
            // 
            btnSalvarDespesa.Location = new Point(14, 348);
            btnSalvarDespesa.Name = "btnSalvarDespesa";
            btnSalvarDespesa.Size = new Size(98, 23);
            btnSalvarDespesa.TabIndex = 13;
            btnSalvarDespesa.Text = "Salvar";
            btnSalvarDespesa.UseVisualStyleBackColor = true;
            btnSalvarDespesa.Click += btnSalvarDespesa_Click;
            // 
            // btnConsultarDespesa
            // 
            btnConsultarDespesa.Location = new Point(547, 26);
            btnConsultarDespesa.Name = "btnConsultarDespesa";
            btnConsultarDespesa.Size = new Size(94, 23);
            btnConsultarDespesa.TabIndex = 14;
            btnConsultarDespesa.Text = "Pesquisar";
            btnConsultarDespesa.UseVisualStyleBackColor = true;
            btnConsultarDespesa.Click += btnConsultarDespesa_Click;
            // 
            // listboxTipoDespesa
            // 
            listboxTipoDespesa.FormattingEnabled = true;
            listboxTipoDespesa.Location = new Point(14, 323);
            listboxTipoDespesa.Name = "listboxTipoDespesa";
            listboxTipoDespesa.Size = new Size(98, 19);
            listboxTipoDespesa.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 143);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 17;
            label1.Text = "Despesas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 450);
            Controls.Add(label1);
            Controls.Add(listboxTipoDespesa);
            Controls.Add(btnConsultarDespesa);
            Controls.Add(btnSalvarDespesa);
            Controls.Add(listConsulta);
            Controls.Add(txtBuscar);
            Controls.Add(txtValorDespesa);
            Controls.Add(txtDescricaoDespesa);
            Controls.Add(txtIdadePessoa);
            Controls.Add(txtNomePessoa);
            Controls.Add(labelConsulta);
            Controls.Add(labelTipo);
            Controls.Add(labelValor);
            Controls.Add(labelDescricao);
            Controls.Add(labelIdade);
            Controls.Add(labelNome);
            Name = "Form1";
            Text = "Controle de gastos em C# com MySQL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private Label labelIdade;
        private Label labelDescricao;
        private Label labelValor;
        private Label labelTipo;
        private Label labelConsulta;
        private TextBox txtNomePessoa;
        private TextBox txtIdadePessoa;
        private TextBox txtDescricaoDespesa;
        private TextBox txtValorDespesa;
        private TextBox txtBuscar;
        private ListView listConsulta;
        private Button btnSalvarDespesa;
        private Button btnConsultarDespesa;
        private ListBox listboxTipoDespesa;
        private Label label1;
    }
}
