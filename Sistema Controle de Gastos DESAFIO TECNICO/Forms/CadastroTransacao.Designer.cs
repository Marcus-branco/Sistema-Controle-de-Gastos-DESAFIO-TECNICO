namespace Sistema_Controle_de_Gastos_DESAFIO_TECNICO.Forms
{
    partial class FormTransacao
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
            components = new System.ComponentModel.Container();
            buttonMenu = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtValorTransacao = new TextBox();
            groupBox1 = new GroupBox();
            comboxPessoa = new ComboBox();
            listTipoTransacao = new ListBox();
            buttonSalvarTransacao = new Button();
            txtDescricaoTransacao = new RichTextBox();
            conexoesBindingSource1 = new BindingSource(components);
            listViewTransaçõesXPessoas = new ListView();
            conexoesBindingSource = new BindingSource(components);
            txtConsulta = new TextBox();
            buttonPesquisarTransacao = new Button();
            conexoesBindingSource2 = new BindingSource(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)conexoesBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexoesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexoesBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // buttonMenu
            // 
            buttonMenu.Location = new Point(12, 12);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(75, 23);
            buttonMenu.TabIndex = 0;
            buttonMenu.Text = "Menu";
            buttonMenu.UseVisualStyleBackColor = true;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(6, 21);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 2;
            label1.Text = "Pessoa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(6, 65);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 3;
            label2.Text = "Tipo de transação";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(6, 124);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 4;
            label3.Text = "Valor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(6, 168);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 5;
            label4.Text = "Descrição";
            // 
            // txtValorTransacao
            // 
            txtValorTransacao.Font = new Font("Segoe UI", 9F);
            txtValorTransacao.Location = new Point(6, 142);
            txtValorTransacao.Name = "txtValorTransacao";
            txtValorTransacao.Size = new Size(158, 23);
            txtValorTransacao.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboxPessoa);
            groupBox1.Controls.Add(listTipoTransacao);
            groupBox1.Controls.Add(buttonSalvarTransacao);
            groupBox1.Controls.Add(txtDescricaoTransacao);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtValorTransacao);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(170, 364);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Transação";
            // 
            // comboxPessoa
            // 
            comboxPessoa.FormattingEnabled = true;
            comboxPessoa.Location = new Point(6, 39);
            comboxPessoa.Name = "comboxPessoa";
            comboxPessoa.Size = new Size(158, 25);
            comboxPessoa.TabIndex = 13;
            // 
            // listTipoTransacao
            // 
            listTipoTransacao.FormattingEnabled = true;
            listTipoTransacao.Items.AddRange(new object[] { "Despesa", "Receita" });
            listTipoTransacao.Location = new Point(6, 83);
            listTipoTransacao.Name = "listTipoTransacao";
            listTipoTransacao.Size = new Size(158, 38);
            listTipoTransacao.TabIndex = 13;
            // 
            // buttonSalvarTransacao
            // 
            buttonSalvarTransacao.Location = new Point(6, 328);
            buttonSalvarTransacao.Name = "buttonSalvarTransacao";
            buttonSalvarTransacao.Size = new Size(158, 23);
            buttonSalvarTransacao.TabIndex = 9;
            buttonSalvarTransacao.Text = "Salvar";
            buttonSalvarTransacao.UseVisualStyleBackColor = true;
            buttonSalvarTransacao.Click += buttonSalvarTransacao_Click;
            // 
            // txtDescricaoTransacao
            // 
            txtDescricaoTransacao.Location = new Point(6, 186);
            txtDescricaoTransacao.Name = "txtDescricaoTransacao";
            txtDescricaoTransacao.Size = new Size(158, 136);
            txtDescricaoTransacao.TabIndex = 8;
            txtDescricaoTransacao.Text = "";
            // 
            // conexoesBindingSource1
            // 
            conexoesBindingSource1.DataSource = typeof(Conexoes);
            // 
            // listViewTransaçõesXPessoas
            // 
            listViewTransaçõesXPessoas.Location = new Point(188, 41);
            listViewTransaçõesXPessoas.Name = "listViewTransaçõesXPessoas";
            listViewTransaçõesXPessoas.Size = new Size(654, 364);
            listViewTransaçõesXPessoas.TabIndex = 10;
            listViewTransaçõesXPessoas.UseCompatibleStateImageBehavior = false;
            // 
            // conexoesBindingSource
            // 
            conexoesBindingSource.DataSource = typeof(Conexoes);
            // 
            // txtConsulta
            // 
            txtConsulta.Location = new Point(188, 13);
            txtConsulta.Name = "txtConsulta";
            txtConsulta.Size = new Size(205, 23);
            txtConsulta.TabIndex = 11;
            // 
            // buttonPesquisarTransacao
            // 
            buttonPesquisarTransacao.Location = new Point(399, 13);
            buttonPesquisarTransacao.Name = "buttonPesquisarTransacao";
            buttonPesquisarTransacao.Size = new Size(114, 23);
            buttonPesquisarTransacao.TabIndex = 12;
            buttonPesquisarTransacao.Text = "Pesquisar";
            buttonPesquisarTransacao.UseVisualStyleBackColor = true;
            buttonPesquisarTransacao.Click += buttonPesquisarTransacao_Click;
            // 
            // conexoesBindingSource2
            // 
            conexoesBindingSource2.DataSource = typeof(Conexoes);
            // 
            // FormTransacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 417);
            Controls.Add(buttonPesquisarTransacao);
            Controls.Add(txtConsulta);
            Controls.Add(listViewTransaçõesXPessoas);
            Controls.Add(groupBox1);
            Controls.Add(buttonMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTransacao";
            Text = "CadastroTransacao";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)conexoesBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexoesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexoesBindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMenu;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtValorTransacao;
        private GroupBox groupBox1;
        private ListView listViewTransaçõesXPessoas;
        private BindingSource conexoesBindingSource;
        private RichTextBox txtDescricaoTransacao;
        private Button buttonSalvarTransacao;
        private TextBox txtConsulta;
        private Button buttonPesquisarTransacao;
        private ListBox listTipoTransacao;
        private ComboBox comboxPessoa;
        private BindingSource conexoesBindingSource1;
        private BindingSource conexoesBindingSource2;
    }
}