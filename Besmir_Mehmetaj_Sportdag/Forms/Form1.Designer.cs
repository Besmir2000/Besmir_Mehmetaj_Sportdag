namespace Besmir_Mehmetaj_Sportdag
{
    partial class Form1
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
            this.txtRegistratieNaam = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblRegistratieNaam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRegistreren = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRegistratieNaam
            // 
            this.txtRegistratieNaam.Location = new System.Drawing.Point(153, 45);
            this.txtRegistratieNaam.Name = "txtRegistratieNaam";
            this.txtRegistratieNaam.Size = new System.Drawing.Size(100, 20);
            this.txtRegistratieNaam.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // lblRegistratieNaam
            // 
            this.lblRegistratieNaam.AutoSize = true;
            this.lblRegistratieNaam.Location = new System.Drawing.Point(31, 45);
            this.lblRegistratieNaam.Name = "lblRegistratieNaam";
            this.lblRegistratieNaam.Size = new System.Drawing.Size(38, 13);
            this.lblRegistratieNaam.TabIndex = 2;
            this.lblRegistratieNaam.Text = "Naam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "1)\r\n2)\r\n3)";
            // 
            // BtnRegistreren
            // 
            this.BtnRegistreren.Location = new System.Drawing.Point(153, 146);
            this.BtnRegistreren.Name = "BtnRegistreren";
            this.BtnRegistreren.Size = new System.Drawing.Size(75, 23);
            this.BtnRegistreren.TabIndex = 4;
            this.BtnRegistreren.Text = "Registreren";
            this.BtnRegistreren.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Voetbal\r\nDansen\r\nGymnastiek\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRegistreren);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRegistratieNaam);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtRegistratieNaam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegistratieNaam;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblRegistratieNaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnRegistreren;
        private System.Windows.Forms.Label label1;
    }
}

