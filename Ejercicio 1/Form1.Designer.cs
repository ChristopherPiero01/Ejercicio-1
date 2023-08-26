namespace Ejercicio_1
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
            txtFa = new TextBox();
            txtCe = new TextBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 77);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Grados Fahrenheit";
            // 
            // txtFa
            // 
            txtFa.Location = new Point(264, 74);
            txtFa.Name = "txtFa";
            txtFa.Size = new Size(100, 23);
            txtFa.TabIndex = 1;
            // 
            // txtCe
            // 
            txtCe.Location = new Point(264, 162);
            txtCe.Name = "txtCe";
            txtCe.ReadOnly = true;
            txtCe.Size = new Size(100, 23);
            txtCe.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 165);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 3;
            label2.Text = "Grados Celsius";
            // 
            // button1
            // 
            button1.Location = new Point(274, 241);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "convertir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtCe);
            Controls.Add(txtFa);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFa;
        private TextBox txtCe;
        private Label label2;
        private Button button1;
    }
}