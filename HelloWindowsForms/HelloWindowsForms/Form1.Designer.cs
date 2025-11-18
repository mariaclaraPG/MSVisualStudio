namespace HelloWindowsForms
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            interpretacao = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(287, 9);
            label2.Name = "label2";
            label2.Size = new Size(262, 54);
            label2.TabIndex = 1;
            label2.Text = "SISTEMA IMC";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(108, 115);
            label1.Name = "label1";
            label1.Size = new Size(125, 54);
            label1.TabIndex = 2;
            label1.Text = "PESO:";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(108, 202);
            label3.Name = "label3";
            label3.Size = new Size(172, 54);
            label3.TabIndex = 3;
            label3.Text = "ALTURA:";
            label3.Click += label3_Click;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(315, 132);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(214, 23);
            txtPeso.TabIndex = 4;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(315, 218);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(214, 23);
            txtAltura.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(315, 278);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(203, 57);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(78, 338);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(242, 54);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "RESULTADO:";
            // 
            // interpretacao
            // 
            interpretacao.AutoSize = true;
            interpretacao.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            interpretacao.Location = new Point(78, 392);
            interpretacao.Name = "interpretacao";
            interpretacao.Size = new Size(410, 54);
            interpretacao.TabIndex = 8;
            interpretacao.Text = "Interpretação do IMC:";
            interpretacao.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 463);
            Controls.Add(interpretacao);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Button btnCalcular;
        private Label lblResultado;
        private Label interpretacao;
    }
}