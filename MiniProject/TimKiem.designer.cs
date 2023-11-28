namespace MiniProject
{
    partial class TimKiem
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
            this.BA_button = new System.Windows.Forms.RadioButton();
            this.HR_button = new System.Windows.Forms.RadioButton();
            this.IT_button = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Savefile_button = new System.Windows.Forms.Button();
            this.Show_button = new System.Windows.Forms.Button();
            this.Search_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BA_button
            // 
            this.BA_button.AutoSize = true;
            this.BA_button.Location = new System.Drawing.Point(13, 177);
            this.BA_button.Name = "BA_button";
            this.BA_button.Size = new System.Drawing.Size(46, 20);
            this.BA_button.TabIndex = 15;
            this.BA_button.TabStop = true;
            this.BA_button.Text = "BA";
            this.BA_button.UseVisualStyleBackColor = true;
            this.BA_button.CheckedChanged += new System.EventHandler(this.BA_button_CheckedChanged);
            // 
            // HR_button
            // 
            this.HR_button.AutoSize = true;
            this.HR_button.Location = new System.Drawing.Point(13, 119);
            this.HR_button.Name = "HR_button";
            this.HR_button.Size = new System.Drawing.Size(48, 20);
            this.HR_button.TabIndex = 14;
            this.HR_button.TabStop = true;
            this.HR_button.Text = "HR";
            this.HR_button.UseVisualStyleBackColor = true;
            this.HR_button.CheckedChanged += new System.EventHandler(this.HR_button_CheckedChanged);
            // 
            // IT_button
            // 
            this.IT_button.AutoSize = true;
            this.IT_button.Location = new System.Drawing.Point(12, 64);
            this.IT_button.Name = "IT_button";
            this.IT_button.Size = new System.Drawing.Size(40, 20);
            this.IT_button.TabIndex = 13;
            this.IT_button.TabStop = true;
            this.IT_button.Text = "IT";
            this.IT_button.UseVisualStyleBackColor = true;
            this.IT_button.CheckedChanged += new System.EventHandler(this.IT_button_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(593, 289);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 22);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Savefile_button
            // 
            this.Savefile_button.Location = new System.Drawing.Point(439, 389);
            this.Savefile_button.Name = "Savefile_button";
            this.Savefile_button.Size = new System.Drawing.Size(75, 23);
            this.Savefile_button.TabIndex = 11;
            this.Savefile_button.Text = "Save file";
            this.Savefile_button.UseVisualStyleBackColor = true;
            this.Savefile_button.Click += new System.EventHandler(this.Savefile_button_Click);
            // 
            // Show_button
            // 
            this.Show_button.Location = new System.Drawing.Point(275, 389);
            this.Show_button.Name = "Show_button";
            this.Show_button.Size = new System.Drawing.Size(75, 23);
            this.Show_button.TabIndex = 10;
            this.Show_button.Text = "Show";
            this.Show_button.UseVisualStyleBackColor = true;
            this.Show_button.Click += new System.EventHandler(this.Show_button_Click);
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(496, 289);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(75, 23);
            this.Search_button.TabIndex = 9;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(158, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(630, 219);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BA_button);
            this.Controls.Add(this.HR_button);
            this.Controls.Add(this.IT_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Savefile_button);
            this.Controls.Add(this.Show_button);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton BA_button;
        private System.Windows.Forms.RadioButton HR_button;
        private System.Windows.Forms.RadioButton IT_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Savefile_button;
        private System.Windows.Forms.Button Show_button;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}