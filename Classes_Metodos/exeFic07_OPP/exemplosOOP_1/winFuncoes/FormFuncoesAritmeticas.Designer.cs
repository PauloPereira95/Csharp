namespace winFuncoes
{
    partial class FormFuncoesAritmeticas
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
            btnSomar = new Button();
            textResultado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textValor1 = new TextBox();
            textValor2 = new TextBox();
            btnSubtrair = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            SuspendLayout();
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(54, 139);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(86, 26);
            btnSomar.TabIndex = 0;
            btnSomar.Text = "Somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // textResultado
            // 
            textResultado.Location = new Point(134, 198);
            textResultado.Name = "textResultado";
            textResultado.ReadOnly = true;
            textResultado.Size = new Size(114, 25);
            textResultado.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 34);
            label1.Name = "label1";
            label1.Size = new Size(50, 17);
            label1.TabIndex = 2;
            label1.Text = "Valor 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 81);
            label2.Name = "label2";
            label2.Size = new Size(50, 17);
            label2.TabIndex = 3;
            label2.Text = "Valor 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 207);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 4;
            label3.Text = "Resultado";
            // 
            // textValor1
            // 
            textValor1.Location = new Point(121, 31);
            textValor1.Name = "textValor1";
            textValor1.Size = new Size(114, 25);
            textValor1.TabIndex = 5;
            // 
            // textValor2
            // 
            textValor2.Location = new Point(121, 77);
            textValor2.Name = "textValor2";
            textValor2.Size = new Size(114, 25);
            textValor2.TabIndex = 6;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(146, 139);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(86, 26);
            btnSubtrair.TabIndex = 7;
            btnSubtrair.Text = "Subtrair";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(239, 139);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(86, 26);
            btnMultiplicar.TabIndex = 8;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(331, 139);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(86, 26);
            btnDividir.TabIndex = 9;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // FormFuncoesAritmeticas
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 310);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnSubtrair);
            Controls.Add(textValor2);
            Controls.Add(textValor1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textResultado);
            Controls.Add(btnSomar);
            Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormFuncoesAritmeticas";
            Text = "Form1";
            Load += FormFuncoesAritmeticas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSomar;
        private TextBox textResultado;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textValor1;
        private TextBox textValor2;
        private Button btnSubtrair;
        private Button btnMultiplicar;
        private Button btnDividir;
    }
}