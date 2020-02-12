namespace RecipeHelper
{
    partial class frmRecipeHelper
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConvFahr = new System.Windows.Forms.Button();
            this.btnConvCups = new System.Windows.Forms.Button();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.txtMilliliters = new System.Windows.Forms.TextBox();
            this.txtCups = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celsius";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fahrenheit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Milliliters";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cups";
            // 
            // btnConvFahr
            // 
            this.btnConvFahr.Location = new System.Drawing.Point(119, 129);
            this.btnConvFahr.Name = "btnConvFahr";
            this.btnConvFahr.Size = new System.Drawing.Size(106, 57);
            this.btnConvFahr.TabIndex = 4;
            this.btnConvFahr.Text = "Convert to Fahrenheit";
            this.btnConvFahr.UseVisualStyleBackColor = true;
            this.btnConvFahr.Click += new System.EventHandler(this.btnConvFahr_Click);
            // 
            // btnConvCups
            // 
            this.btnConvCups.Location = new System.Drawing.Point(528, 129);
            this.btnConvCups.Name = "btnConvCups";
            this.btnConvCups.Size = new System.Drawing.Size(89, 57);
            this.btnConvCups.TabIndex = 5;
            this.btnConvCups.Text = "Convert to Cups";
            this.btnConvCups.UseVisualStyleBackColor = true;
            this.btnConvCups.Click += new System.EventHandler(this.btnConvCups_Click);
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(139, 67);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 20);
            this.txtCelsius.TabIndex = 6;
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(139, 226);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.ReadOnly = true;
            this.txtFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txtFahrenheit.TabIndex = 7;
            // 
            // txtMilliliters
            // 
            this.txtMilliliters.Location = new System.Drawing.Point(557, 67);
            this.txtMilliliters.Name = "txtMilliliters";
            this.txtMilliliters.Size = new System.Drawing.Size(100, 20);
            this.txtMilliliters.TabIndex = 8;
            // 
            // txtCups
            // 
            this.txtCups.Location = new System.Drawing.Point(557, 226);
            this.txtCups.Name = "txtCups";
            this.txtCups.ReadOnly = true;
            this.txtCups.Size = new System.Drawing.Size(100, 20);
            this.txtCups.TabIndex = 9;
            // 
            // frmRecipeHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCups);
            this.Controls.Add(this.txtMilliliters);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.btnConvCups);
            this.Controls.Add(this.btnConvFahr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRecipeHelper";
            this.Text = "Recipe Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConvFahr;
        private System.Windows.Forms.Button btnConvCups;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.TextBox txtMilliliters;
        private System.Windows.Forms.TextBox txtCups;
    }
}

