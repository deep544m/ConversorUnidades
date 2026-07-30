namespace ConversorUnidades
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
            lblValor = new Label();
            txtValor = new TextBox();
            lblConversion = new Label();
            cmbConversion = new ComboBox();
            btnConvertir = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(374, 9);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(43, 20);
            lblValor.TabIndex = 0;
            lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(346, 45);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(125, 27);
            txtValor.TabIndex = 1;
            // 
            // lblConversion
            // 
            lblConversion.AutoSize = true;
            lblConversion.Location = new Point(363, 102);
            lblConversion.Name = "lblConversion";
            lblConversion.Size = new Size(82, 20);
            lblConversion.TabIndex = 2;
            lblConversion.Text = "Conversión";
            // 
            // cmbConversion
            // 
            cmbConversion.FormattingEnabled = true;
            cmbConversion.Location = new Point(330, 147);
            cmbConversion.Name = "cmbConversion";
            cmbConversion.Size = new Size(151, 28);
            cmbConversion.TabIndex = 3;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(357, 201);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(94, 29);
            btnConvertir.TabIndex = 4;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(374, 264);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(78, 20);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resultado:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnConvertir);
            Controls.Add(cmbConversion);
            Controls.Add(lblConversion);
            Controls.Add(txtValor);
            Controls.Add(lblValor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblValor;
        private TextBox txtValor;
        private Label lblConversion;
        private ComboBox cmbConversion;
        private Button btnConvertir;
        private Label lblResultado;
    }
}
