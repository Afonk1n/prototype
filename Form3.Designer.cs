namespace Prototype
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.exit2form = new System.Windows.Forms.PictureBox();
            this.min2form = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.exit2form)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min2form)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit2form
            // 
            this.exit2form.BackColor = System.Drawing.Color.Transparent;
            this.exit2form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit2form.Image = ((System.Drawing.Image)(resources.GetObject("exit2form.Image")));
            this.exit2form.Location = new System.Drawing.Point(1195, 3);
            this.exit2form.Name = "exit2form";
            this.exit2form.Size = new System.Drawing.Size(27, 26);
            this.exit2form.TabIndex = 13;
            this.exit2form.TabStop = false;
            this.exit2form.Click += new System.EventHandler(this.Exit2form_Click);
            // 
            // min2form
            // 
            this.min2form.BackColor = System.Drawing.Color.Transparent;
            this.min2form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.min2form.Image = ((System.Drawing.Image)(resources.GetObject("min2form.Image")));
            this.min2form.Location = new System.Drawing.Point(1163, 3);
            this.min2form.Name = "min2form";
            this.min2form.Size = new System.Drawing.Size(26, 28);
            this.min2form.TabIndex = 14;
            this.min2form.TabStop = false;
            this.min2form.Click += new System.EventHandler(this.Min2form_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(366, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(58, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(209, 71);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 17;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1234, 650);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.min2form);
            this.Controls.Add(this.exit2form);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exit2form)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min2form)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox exit2form;
        private System.Windows.Forms.PictureBox min2form;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}