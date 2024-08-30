namespace SysPecNSDesk
{
    partial class FrmCliente
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
            groupBox1 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            chkAtivo = new CheckBox();
            btnEditar = new Button();
            btnInserir = new Button();
            dtpDataNasc = new DateTimePicker();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtCpf = new TextBox();
            txtNome = new TextBox();
            txtId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            printDialog1 = new PrintDialog();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(843, 599);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(6, 22);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(831, 571);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(chkAtivo);
            tabPage1.Controls.Add(btnEditar);
            tabPage1.Controls.Add(btnInserir);
            tabPage1.Controls.Add(dtpDataNasc);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(txtTelefone);
            tabPage1.Controls.Add(txtCpf);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Controls.Add(txtId);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(823, 543);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(567, 358);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 30;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(349, 357);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 29;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(121, 354);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 28;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Format = DateTimePickerFormat.Short;
            dtpDataNasc.Location = new Point(535, 269);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(200, 23);
            dtpDataNasc.TabIndex = 27;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(88, 269);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(201, 23);
            txtEmail.TabIndex = 26;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(558, 180);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(166, 23);
            txtTelefone.TabIndex = 25;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(331, 269);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(164, 23);
            txtCpf.TabIndex = 24;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(240, 180);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(231, 23);
            txtNome.TabIndex = 23;
            // 
            // txtId
            // 
            txtId.Location = new Point(88, 180);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(588, 251);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 21;
            label6.Text = "Data Nascimento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 251);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 20;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(635, 162);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 19;
            label4.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 251);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 18;
            label3.Text = "Cpf";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(331, 162);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 17;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 162);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 16;
            label1.Text = "ID";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(823, 543);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 605);
            Controls.Add(groupBox1);
            Name = "FrmCliente";
            Text = "FrmCliente";
            Load += FrmCliente_Load;
            groupBox1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private CheckBox chkAtivo;
        private Button btnEditar;
        private Button btnInserir;
        private DateTimePicker dtpDataNasc;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtCpf;
        private TextBox txtNome;
        private TextBox txtId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private PrintDialog printDialog1;
    }
}