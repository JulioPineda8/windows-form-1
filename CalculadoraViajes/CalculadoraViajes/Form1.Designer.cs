namespace CalculadoraViajes
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
            label2 = new Label();
            label3 = new Label();
            btnCalcular = new Button();
            label4 = new Label();
            txtOrigen = new TextBox();
            txtResultado = new TextBox();
            txtVelocidad = new TextBox();
            txtDestino = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 73);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 0;
            label1.Text = "Punto Origen en KM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 122);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 1;
            label2.Text = "Punto Destino en KM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 188);
            label3.Name = "label3";
            label3.Size = new Size(205, 20);
            label3.TabIndex = 2;
            label3.Text = "Velocidad Constante en Km/h";
            label3.Click += label3_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(137, 238);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(76, 51);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 322);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 4;
            label4.Text = "Resultado";
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(572, 66);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(125, 27);
            txtOrigen.TabIndex = 5;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(572, 315);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(125, 27);
            txtResultado.TabIndex = 6;
            // 
            // txtVelocidad
            // 
            txtVelocidad.Location = new Point(572, 181);
            txtVelocidad.Name = "txtVelocidad";
            txtVelocidad.Size = new Size(125, 27);
            txtVelocidad.TabIndex = 7;
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(572, 122);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(125, 27);
            txtDestino.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDestino);
            Controls.Add(txtVelocidad);
            Controls.Add(txtResultado);
            Controls.Add(txtOrigen);
            Controls.Add(label4);
            Controls.Add(btnCalcular);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCalcular;
        private Label label4;
        private TextBox txtOrigen;
        private TextBox txtResultado;
        private TextBox txtVelocidad;
        private TextBox txtDestino;
    }
}
