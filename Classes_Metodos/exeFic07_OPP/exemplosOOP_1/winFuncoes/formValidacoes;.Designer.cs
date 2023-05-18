namespace winFuncoes
{
    partial class FormValidacoes
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
            txtNome = new TextBox();
            btnValidar = new Button();
            label1 = new Label();
            Email = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtTelefone = new TextBox();
            txtTelemovel = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(98, 12);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(382, 23);
            txtNome.TabIndex = 0;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(220, 155);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(75, 23);
            btnValidar.TabIndex = 1;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 20);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(42, 62);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 4;
            Email.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(98, 54);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(382, 23);
            txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 98);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(98, 95);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(135, 23);
            txtTelefone.TabIndex = 6;
            // 
            // txtTelemovel
            // 
            txtTelemovel.Location = new Point(345, 98);
            txtTelemovel.Name = "txtTelemovel";
            txtTelemovel.Size = new Size(135, 23);
            txtTelemovel.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 101);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "Telemovel";
            // 
            // FormValidacoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 252);
            Controls.Add(txtTelemovel);
            Controls.Add(label3);
            Controls.Add(txtTelefone);
            Controls.Add(label2);
            Controls.Add(Email);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(btnValidar);
            Controls.Add(txtNome);
            Name = "FormValidacoes";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Button btnValidar;
        private Label label1;
        private Label Email;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtTelefone;
        private TextBox txtTelemovel;
        private Label label3;
    }
}