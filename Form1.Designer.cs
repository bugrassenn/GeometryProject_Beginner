namespace GeometryProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel3 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtEdge = new System.Windows.Forms.TextBox();
            this.BtnSquare = new System.Windows.Forms.Button();
            this.LblSquareArea = new System.Windows.Forms.Label();
            this.LblSquarePerimeter = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LblCirclePerimeter = new System.Windows.Forms.Label();
            this.LblCircleArea = new System.Windows.Forms.Label();
            this.BtnCircle = new System.Windows.Forms.Button();
            this.TxtRadius = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(-1, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(865, 146);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geometry App";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(626, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.LblSquarePerimeter);
            this.groupBox1.Controls.Add(this.LblSquareArea);
            this.groupBox1.Controls.Add(this.BtnSquare);
            this.groupBox1.Controls.Add(this.TxtEdge);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(104, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 269);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Square";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Edge";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "Area";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 26);
            this.label7.TabIndex = 4;
            this.label7.Text = "Perimeter";
            // 
            // TxtEdge
            // 
            this.TxtEdge.Location = new System.Drawing.Point(106, 57);
            this.TxtEdge.Name = "TxtEdge";
            this.TxtEdge.Size = new System.Drawing.Size(100, 33);
            this.TxtEdge.TabIndex = 5;
            // 
            // BtnSquare
            // 
            this.BtnSquare.Location = new System.Drawing.Point(82, 115);
            this.BtnSquare.Name = "BtnSquare";
            this.BtnSquare.Size = new System.Drawing.Size(124, 38);
            this.BtnSquare.TabIndex = 6;
            this.BtnSquare.Text = "Calculate";
            this.BtnSquare.UseVisualStyleBackColor = true;
            this.BtnSquare.Click += new System.EventHandler(this.BtnSquare_Click);
            // 
            // LblSquareArea
            // 
            this.LblSquareArea.AutoSize = true;
            this.LblSquareArea.Location = new System.Drawing.Point(123, 181);
            this.LblSquareArea.Name = "LblSquareArea";
            this.LblSquareArea.Size = new System.Drawing.Size(69, 26);
            this.LblSquareArea.TabIndex = 7;
            this.LblSquareArea.Text = "label2";
            // 
            // LblSquarePerimeter
            // 
            this.LblSquarePerimeter.AutoSize = true;
            this.LblSquarePerimeter.Location = new System.Drawing.Point(123, 225);
            this.LblSquarePerimeter.Name = "LblSquarePerimeter";
            this.LblSquarePerimeter.Size = new System.Drawing.Size(69, 26);
            this.LblSquarePerimeter.TabIndex = 8;
            this.LblSquarePerimeter.Text = "label8";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this.LblCirclePerimeter);
            this.groupBox4.Controls.Add(this.LblCircleArea);
            this.groupBox4.Controls.Add(this.BtnCircle);
            this.groupBox4.Controls.Add(this.TxtRadius);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(515, 149);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(242, 269);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Circle";
            // 
            // LblCirclePerimeter
            // 
            this.LblCirclePerimeter.AutoSize = true;
            this.LblCirclePerimeter.Location = new System.Drawing.Point(123, 225);
            this.LblCirclePerimeter.Name = "LblCirclePerimeter";
            this.LblCirclePerimeter.Size = new System.Drawing.Size(69, 26);
            this.LblCirclePerimeter.TabIndex = 8;
            this.LblCirclePerimeter.Text = "label8";
            // 
            // LblCircleArea
            // 
            this.LblCircleArea.AutoSize = true;
            this.LblCircleArea.Location = new System.Drawing.Point(123, 181);
            this.LblCircleArea.Name = "LblCircleArea";
            this.LblCircleArea.Size = new System.Drawing.Size(69, 26);
            this.LblCircleArea.TabIndex = 7;
            this.LblCircleArea.Text = "label2";
            // 
            // BtnCircle
            // 
            this.BtnCircle.Location = new System.Drawing.Point(82, 115);
            this.BtnCircle.Name = "BtnCircle";
            this.BtnCircle.Size = new System.Drawing.Size(124, 38);
            this.BtnCircle.TabIndex = 6;
            this.BtnCircle.Text = "Calculate";
            this.BtnCircle.UseVisualStyleBackColor = true;
            this.BtnCircle.Click += new System.EventHandler(this.BtnCircle_Click);
            // 
            // TxtRadius
            // 
            this.TxtRadius.Location = new System.Drawing.Point(106, 57);
            this.TxtRadius.Name = "TxtRadius";
            this.TxtRadius.Size = new System.Drawing.Size(100, 33);
            this.TxtRadius.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 26);
            this.label9.TabIndex = 4;
            this.label9.Text = "Perimeter";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 26);
            this.label10.TabIndex = 3;
            this.label10.Text = "Area";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 26);
            this.label11.TabIndex = 1;
            this.label11.Text = "Radius";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(863, 481);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblSquarePerimeter;
        private System.Windows.Forms.Label LblSquareArea;
        private System.Windows.Forms.Button BtnSquare;
        private System.Windows.Forms.TextBox TxtEdge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label LblCirclePerimeter;
        private System.Windows.Forms.Label LblCircleArea;
        private System.Windows.Forms.Button BtnCircle;
        private System.Windows.Forms.TextBox TxtRadius;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

