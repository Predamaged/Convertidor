namespace Mp4
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelurl = new System.Windows.Forms.Label();
            this.labelresolucion = new System.Windows.Forms.Label();
            this.labeldestino = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(636, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Descargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelurl
            // 
            this.labelurl.AutoSize = true;
            this.labelurl.Location = new System.Drawing.Point(104, 65);
            this.labelurl.Name = "labelurl";
            this.labelurl.Size = new System.Drawing.Size(44, 17);
            this.labelurl.TabIndex = 1;
            this.labelurl.Text = "URL :";
            // 
            // labelresolucion
            // 
            this.labelresolucion.AutoSize = true;
            this.labelresolucion.Location = new System.Drawing.Point(62, 130);
            this.labelresolucion.Name = "labelresolucion";
            this.labelresolucion.Size = new System.Drawing.Size(86, 17);
            this.labelresolucion.TabIndex = 2;
            this.labelresolucion.Text = "Resolucion :";
            // 
            // labeldestino
            // 
            this.labeldestino.AutoSize = true;
            this.labeldestino.Location = new System.Drawing.Point(84, 235);
            this.labeldestino.Name = "labeldestino";
            this.labeldestino.Size = new System.Drawing.Size(64, 17);
            this.labeldestino.TabIndex = 3;
            this.labeldestino.Text = "Destino :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(712, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "0%";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(525, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 232);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(322, 22);
            this.textBox2.TabIndex = 6;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(118, 176);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(572, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "360",
            "480",
            "720"});
            this.comboBox1.Location = new System.Drawing.Point(155, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(754, 361);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labeldestino);
            this.Controls.Add(this.labelresolucion);
            this.Controls.Add(this.labelurl);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelurl;
        private System.Windows.Forms.Label labelresolucion;
        private System.Windows.Forms.Label labeldestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

