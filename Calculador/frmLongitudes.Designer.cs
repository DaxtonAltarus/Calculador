
namespace Calculador
{
    partial class frmLongitudes
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
            this.cmbdestino = new System.Windows.Forms.ComboBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmborigen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbdestino
            // 
            this.cmbdestino.FormattingEnabled = true;
            this.cmbdestino.Items.AddRange(new object[] {
            "Metros",
            "Centímetros",
            "Milímetros"});
            this.cmbdestino.Location = new System.Drawing.Point(281, 63);
            this.cmbdestino.Name = "cmbdestino";
            this.cmbdestino.Size = new System.Drawing.Size(121, 23);
            this.cmbdestino.TabIndex = 18;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(317, 189);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ReadOnly = true;
            this.txtresultado.Size = new System.Drawing.Size(117, 23);
            this.txtresultado.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "RESULTADO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "PROCESAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "A";
            // 
            // cmborigen
            // 
            this.cmborigen.FormattingEnabled = true;
            this.cmborigen.Items.AddRange(new object[] {
            "Metros",
            "Centímetros",
            "Milímetros"});
            this.cmborigen.Location = new System.Drawing.Point(66, 62);
            this.cmborigen.Name = "cmborigen";
            this.cmborigen.Size = new System.Drawing.Size(121, 23);
            this.cmborigen.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "DE";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(101, 29);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(165, 23);
            this.txtvalor.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "CONVERTIR";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 24);
            this.button2.TabIndex = 19;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmLongitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 275);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbdestino);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmborigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.label1);
            this.Name = "frmLongitudes";
            this.Text = "CALCULANDO LONGITUDES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbdestino;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmborigen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}