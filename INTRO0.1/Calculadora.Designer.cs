namespace INTRO0._1
{
    partial class Calculadora
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
            this.Resultado = new System.Windows.Forms.Button();
            this.lb_1 = new System.Windows.Forms.TextBox();
            this.lb_2 = new System.Windows.Forms.TextBox();
            this.lb_text = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(281, 97);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(71, 71);
            this.Resultado.TabIndex = 0;
            this.Resultado.Text = "Suma";
            this.Resultado.UseVisualStyleBackColor = true;
            this.Resultado.Click += new System.EventHandler(this.calcSuma);
            // 
            // lb_1
            // 
            this.lb_1.Location = new System.Drawing.Point(96, 142);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(179, 26);
            this.lb_1.TabIndex = 1;
            // 
            // lb_2
            // 
            this.lb_2.Location = new System.Drawing.Point(96, 97);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(179, 26);
            this.lb_2.TabIndex = 2;
            // 
            // lb_text
            // 
            this.lb_text.AutoSize = true;
            this.lb_text.Location = new System.Drawing.Point(166, 181);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(51, 20);
            this.lb_text.TabIndex = 3;
            this.lb_text.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 71);
            this.button1.TabIndex = 4;
            this.button1.Text = "Resta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.calcResta);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(435, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 71);
            this.button2.TabIndex = 5;
            this.button2.Text = "MIltiplicación";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.calcMulti);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(549, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 71);
            this.button3.TabIndex = 6;
            this.button3.Text = "División";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.calcDivision);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 349);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_text);
            this.Controls.Add(this.lb_2);
            this.Controls.Add(this.lb_1);
            this.Controls.Add(this.Resultado);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Resultado;
        private System.Windows.Forms.TextBox lb_1;
        private System.Windows.Forms.TextBox lb_2;
        private System.Windows.Forms.Label lb_text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}