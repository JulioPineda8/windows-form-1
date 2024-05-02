namespace ConsumoCombustible
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
            txtDistancia = new TextBox();
            txtConsumo = new TextBox();
            txtGalones = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 60);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 0;
            label1.Text = "Distancia Recorrida";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 110);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 1;
            label2.Text = "Consumo Km/Galón";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 299);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 2;
            label3.Text = "Galones Consumidos";
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(511, 53);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(125, 27);
            txtDistancia.TabIndex = 3;
            // 
            // txtConsumo
            // 
            txtConsumo.Location = new Point(511, 103);
            txtConsumo.Name = "txtConsumo";
            txtConsumo.Size = new Size(125, 27);
            txtConsumo.TabIndex = 4;
            // 
            // txtGalones
            // 
            txtGalones.Location = new Point(511, 292);
            txtGalones.Name = "txtGalones";
            txtGalones.Size = new Size(125, 27);
            txtGalones.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(75, 204);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(txtGalones);
            Controls.Add(txtConsumo);
            Controls.Add(txtDistancia);
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
        private TextBox txtDistancia;
        private TextBox txtConsumo;
        private TextBox txtGalones;
        private Button btnCalcular;
    }
}
