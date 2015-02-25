namespace ImageViewer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Show_butt = new System.Windows.Forms.Button();
            this.Clear_butt = new System.Windows.Forms.Button();
            this.Background_butt = new System.Windows.Forms.Button();
            this.Close_butt = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(534, 312);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(83, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 274);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.Location = new System.Drawing.Point(3, 283);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 26);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Strech";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.Show_butt);
            this.flowLayoutPanel1.Controls.Add(this.Clear_butt);
            this.flowLayoutPanel1.Controls.Add(this.Background_butt);
            this.flowLayoutPanel1.Controls.Add(this.Close_butt);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(83, 283);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(448, 26);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // Show_butt
            // 
            this.Show_butt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Show_butt.Location = new System.Drawing.Point(357, 3);
            this.Show_butt.Name = "Show_butt";
            this.Show_butt.Size = new System.Drawing.Size(88, 23);
            this.Show_butt.TabIndex = 0;
            this.Show_butt.Text = "Show Picture";
            this.Show_butt.UseVisualStyleBackColor = true;
            this.Show_butt.Click += new System.EventHandler(this.Show_butt_Click);
            // 
            // Clear_butt
            // 
            this.Clear_butt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Clear_butt.Location = new System.Drawing.Point(248, 3);
            this.Clear_butt.Name = "Clear_butt";
            this.Clear_butt.Size = new System.Drawing.Size(103, 23);
            this.Clear_butt.TabIndex = 1;
            this.Clear_butt.Text = "Clear the picture";
            this.Clear_butt.UseVisualStyleBackColor = true;
            this.Clear_butt.Click += new System.EventHandler(this.Clear_butt_Click);
            // 
            // Background_butt
            // 
            this.Background_butt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Background_butt.Location = new System.Drawing.Point(146, 3);
            this.Background_butt.Name = "Background_butt";
            this.Background_butt.Size = new System.Drawing.Size(96, 23);
            this.Background_butt.TabIndex = 2;
            this.Background_butt.Text = "Set backgroud";
            this.Background_butt.UseVisualStyleBackColor = true;
            this.Background_butt.Click += new System.EventHandler(this.Background_butt_Click);
            // 
            // Close_butt
            // 
            this.Close_butt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Close_butt.Location = new System.Drawing.Point(65, 3);
            this.Close_butt.Name = "Close_butt";
            this.Close_butt.Size = new System.Drawing.Size(75, 23);
            this.Close_butt.TabIndex = 3;
            this.Close_butt.Text = "Close";
            this.Close_butt.UseVisualStyleBackColor = true;
            this.Close_butt.Click += new System.EventHandler(this.Close_butt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Select a picture";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 312);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Show_butt;
        private System.Windows.Forms.Button Clear_butt;
        private System.Windows.Forms.Button Background_butt;
        private System.Windows.Forms.Button Close_butt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

