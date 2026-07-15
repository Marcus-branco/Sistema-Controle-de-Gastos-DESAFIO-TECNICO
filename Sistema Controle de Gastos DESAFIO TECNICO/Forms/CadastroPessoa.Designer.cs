namespace Sistema_Controle_de_Gastos_DESAFIO_TECNICO
{
    partial class FormPessoa
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
            listConsulta = new ListView();
            labelNome = new Label();
            labelIdade = new Label();
            txtNomePessoa = new TextBox();
            txtIdadePessoa = new TextBox();
            txtBuscar = new TextBox();
            btnSalvarPessoa = new Button();
            btnConsultarPessoa = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            listPessoasDelete = new ListView();
            buttonDeletePessoa = new Button();
            buttonMenu = new Button();
            label1 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listConsulta
            // 
            listConsulta.Location = new Point(6, 66);
            listConsulta.Name = "listConsulta";
            listConsulta.Size = new Size(241, 137);
            listConsulta.TabIndex = 12;
            listConsulta.UseCompatibleStateImageBehavior = false;
            listConsulta.ItemChecked += listViewChecked;
            listConsulta.ItemSelectionChanged += listViewChecked;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(6, 22);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            // 
            // labelIdade
            // 
            labelIdade.AutoSize = true;
            labelIdade.Location = new Point(6, 66);
            labelIdade.Name = "labelIdade";
            labelIdade.Size = new Size(36, 15);
            labelIdade.TabIndex = 1;
            labelIdade.Text = "Idade";
            // 
            // txtNomePessoa
            // 
            txtNomePessoa.Location = new Point(6, 40);
            txtNomePessoa.Name = "txtNomePessoa";
            txtNomePessoa.Size = new Size(236, 23);
            txtNomePessoa.TabIndex = 6;
            // 
            // txtIdadePessoa
            // 
            txtIdadePessoa.Location = new Point(6, 83);
            txtIdadePessoa.Name = "txtIdadePessoa";
            txtIdadePessoa.Size = new Size(127, 23);
            txtIdadePessoa.TabIndex = 7;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(6, 40);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(132, 23);
            txtBuscar.TabIndex = 11;
            // 
            // btnSalvarPessoa
            // 
            btnSalvarPessoa.Location = new Point(139, 83);
            btnSalvarPessoa.Name = "btnSalvarPessoa";
            btnSalvarPessoa.Size = new Size(103, 23);
            btnSalvarPessoa.TabIndex = 13;
            btnSalvarPessoa.Text = "Salvar";
            btnSalvarPessoa.UseVisualStyleBackColor = true;
            btnSalvarPessoa.Click += BtnSalvarPessoa_Click;
            // 
            // btnConsultarPessoa
            // 
            btnConsultarPessoa.Location = new Point(144, 40);
            btnConsultarPessoa.Name = "btnConsultarPessoa";
            btnConsultarPessoa.Size = new Size(103, 23);
            btnConsultarPessoa.TabIndex = 14;
            btnConsultarPessoa.Text = "Pesquisar";
            btnConsultarPessoa.UseVisualStyleBackColor = true;
            btnConsultarPessoa.Click += btnConsultarPessoa_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSalvarPessoa);
            groupBox1.Controls.Add(txtIdadePessoa);
            groupBox1.Controls.Add(txtNomePessoa);
            groupBox1.Controls.Add(labelIdade);
            groupBox1.Controls.Add(labelNome);
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(253, 117);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(listPessoasDelete);
            groupBox2.Controls.Add(buttonDeletePessoa);
            groupBox2.Controls.Add(btnConsultarPessoa);
            groupBox2.Controls.Add(listConsulta);
            groupBox2.Controls.Add(txtBuscar);
            groupBox2.Location = new Point(336, 41);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(503, 364);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Exclusão";
            // 
            // listPessoasDelete
            // 
            listPessoasDelete.Location = new Point(256, 66);
            listPessoasDelete.Name = "listPessoasDelete";
            listPessoasDelete.Size = new Size(241, 137);
            listPessoasDelete.TabIndex = 22;
            listPessoasDelete.UseCompatibleStateImageBehavior = false;
            // 
            // buttonDeletePessoa
            // 
            buttonDeletePessoa.Location = new Point(356, 209);
            buttonDeletePessoa.Name = "buttonDeletePessoa";
            buttonDeletePessoa.Size = new Size(141, 23);
            buttonDeletePessoa.TabIndex = 21;
            buttonDeletePessoa.Text = "Excluir selecionados";
            buttonDeletePessoa.UseVisualStyleBackColor = true;
            buttonDeletePessoa.Click += buttonDeletePessoa_Click;
            // 
            // buttonMenu
            // 
            buttonMenu.Location = new Point(12, 12);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(75, 23);
            buttonMenu.TabIndex = 19;
            buttonMenu.Text = "Menu";
            buttonMenu.UseVisualStyleBackColor = true;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 22);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 23;
            label1.Text = "Pessoas a Excluir";
            // 
            // button1
            // 
            button1.Location = new Point(356, 18);
            button1.Name = "button1";
            button1.Size = new Size(141, 23);
            button1.TabIndex = 24;
            button1.Text = "Limpar selecionados";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 417);
            Controls.Add(buttonMenu);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPessoa";
            Text = "Cadastro de pessoa";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListView listConsulta;
        private Label labelNome;
        private Label labelIdade;
        private TextBox txtNomePessoa;
        private TextBox txtIdadePessoa;
        private TextBox txtBuscar;
        private Button btnSalvarPessoa;
        private Button btnConsultarPessoa;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button buttonMenu;
        private ListView listPessoasDelete;
        private Button buttonDeletePessoa;
        private Button button1;
        private Label label1;
    }
}
