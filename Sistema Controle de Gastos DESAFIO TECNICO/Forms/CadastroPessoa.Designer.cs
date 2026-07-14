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
            buttonMenu = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listConsulta
            // 
            listConsulta.Location = new Point(6, 47);
            listConsulta.Name = "listConsulta";
            listConsulta.Size = new Size(241, 163);
            listConsulta.TabIndex = 12;
            listConsulta.UseCompatibleStateImageBehavior = false;
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
            txtBuscar.Location = new Point(6, 22);
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
            btnConsultarPessoa.Location = new Point(144, 21);
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
            groupBox2.Controls.Add(btnConsultarPessoa);
            groupBox2.Controls.Add(listConsulta);
            groupBox2.Controls.Add(txtBuscar);
            groupBox2.Location = new Point(12, 164);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(253, 216);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Consulta";
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
            // FormPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 392);
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
    }
}
