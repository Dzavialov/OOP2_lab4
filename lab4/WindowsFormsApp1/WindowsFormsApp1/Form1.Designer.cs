
namespace WindowsFormsApp1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.circleRadius_TextBox = new System.Windows.Forms.TextBox();
            this.SquareSideLength_TextBox = new System.Windows.Forms.TextBox();
            this.RhombHorizontalLength_TextBox = new System.Windows.Forms.TextBox();
            this.RhombVerticalLength_TextBox = new System.Windows.Forms.TextBox();
            this.CircleRadius_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(830, 389);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Виберіть фігуру";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(39, 448);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // circleRadius_TextBox
            // 
            this.circleRadius_TextBox.Location = new System.Drawing.Point(317, 450);
            this.circleRadius_TextBox.Name = "circleRadius_TextBox";
            this.circleRadius_TextBox.Size = new System.Drawing.Size(100, 22);
            this.circleRadius_TextBox.TabIndex = 3;
            this.circleRadius_TextBox.Visible = false;
            // 
            // SquareSideLength_TextBox
            // 
            this.SquareSideLength_TextBox.Location = new System.Drawing.Point(317, 450);
            this.SquareSideLength_TextBox.Name = "SquareSideLength_TextBox";
            this.SquareSideLength_TextBox.Size = new System.Drawing.Size(100, 22);
            this.SquareSideLength_TextBox.TabIndex = 4;
            this.SquareSideLength_TextBox.Visible = false;
            // 
            // RhombHorizontalLength_TextBox
            // 
            this.RhombHorizontalLength_TextBox.Location = new System.Drawing.Point(317, 450);
            this.RhombHorizontalLength_TextBox.Name = "RhombHorizontalLength_TextBox";
            this.RhombHorizontalLength_TextBox.Size = new System.Drawing.Size(100, 22);
            this.RhombHorizontalLength_TextBox.TabIndex = 5;
            this.RhombHorizontalLength_TextBox.Visible = false;
            // 
            // RhombVerticalLength_TextBox
            // 
            this.RhombVerticalLength_TextBox.Location = new System.Drawing.Point(617, 450);
            this.RhombVerticalLength_TextBox.Name = "RhombVerticalLength_TextBox";
            this.RhombVerticalLength_TextBox.Size = new System.Drawing.Size(100, 22);
            this.RhombVerticalLength_TextBox.TabIndex = 6;
            this.RhombVerticalLength_TextBox.Visible = false;
            // 
            // CircleRadius_Label
            // 
            this.CircleRadius_Label.AutoSize = true;
            this.CircleRadius_Label.Location = new System.Drawing.Point(302, 432);
            this.CircleRadius_Label.Name = "CircleRadius_Label";
            this.CircleRadius_Label.Size = new System.Drawing.Size(137, 17);
            this.CircleRadius_Label.TabIndex = 7;
            this.CircleRadius_Label.Text = "Введіть радіус кола";
            this.CircleRadius_Label.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введіть довжину сторони квадрата";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Введіть довжину горизонтальної сторони ромба";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Введіть довжину вертикальної сторони ромба";
            this.label4.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Створити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(830, 484);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CircleRadius_Label);
            this.Controls.Add(this.RhombVerticalLength_TextBox);
            this.Controls.Add(this.RhombHorizontalLength_TextBox);
            this.Controls.Add(this.SquareSideLength_TextBox);
            this.Controls.Add(this.circleRadius_TextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox circleRadius_TextBox;
        private System.Windows.Forms.TextBox SquareSideLength_TextBox;
        private System.Windows.Forms.TextBox RhombHorizontalLength_TextBox;
        private System.Windows.Forms.TextBox RhombVerticalLength_TextBox;
        private System.Windows.Forms.Label CircleRadius_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

