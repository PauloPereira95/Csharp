namespace c_08_opp_heranca
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
            label1 = new Label();
            txtAltura = new TextBox();
            button1 = new Button();
            txtAreaBase = new TextBox();
            label2 = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 90);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Altura";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(216, 90);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(204, 320);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtAreaBase
            // 
            txtAreaBase.Location = new Point(216, 128);
            txtAreaBase.Name = "txtAreaBase";
            txtAreaBase.Size = new Size(100, 23);
            txtAreaBase.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 131);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 3;
            label2.Text = "Area da Base";
            // 
            // lblResultado
            // 
            lblResultado.BackColor = SystemColors.AppWorkspace;
            lblResultado.BorderStyle = BorderStyle.Fixed3D;
            lblResultado.ForeColor = Color.Gold;
            lblResultado.Location = new Point(119, 183);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(281, 87);
            lblResultado.TabIndex = 5;
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(txtAreaBase);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txtAltura);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAltura;
        private Button button1;
        private TextBox txtAreaBase;
        private Label label2;
        private Label lblResultado;
    }
}