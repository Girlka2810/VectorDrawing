
namespace VectorDrawing
{
    partial class VectorDrawing
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
            this.BrushButton = new System.Windows.Forms.Button();
            this.LineButton = new System.Windows.Forms.Button();
            this.NlineButton = new System.Windows.Forms.Button();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.SquareButton = new System.Windows.Forms.Button();
            this.CircleButton = new System.Windows.Forms.Button();
            this.EllipseButton = new System.Windows.Forms.Button();
            this.RectangularTriangleButton = new System.Windows.Forms.Button();
            this.TriangleButton = new System.Windows.Forms.Button();
            this.AlpelesTriangleButton = new System.Windows.Forms.Button();
            this.PolygonButton = new System.Windows.Forms.Button();
            this.RegularPolygonButton = new System.Windows.Forms.Button();
            this.ToolsLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // BrushButton
            // 
            this.BrushButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BrushButton.Location = new System.Drawing.Point(11, 67);
            this.BrushButton.Name = "BrushButton";
            this.BrushButton.Size = new System.Drawing.Size(171, 26);
            this.BrushButton.TabIndex = 0;
            this.BrushButton.Text = "Кисть";
            this.BrushButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BrushButton.UseVisualStyleBackColor = true;
            // 
            // LineButton
            // 
            this.LineButton.Location = new System.Drawing.Point(11, 102);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(171, 28);
            this.LineButton.TabIndex = 1;
            this.LineButton.Text = "Линия";
            this.LineButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LineButton.UseVisualStyleBackColor = true;
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // NlineButton
            // 
            this.NlineButton.Location = new System.Drawing.Point(11, 136);
            this.NlineButton.Name = "NlineButton";
            this.NlineButton.Size = new System.Drawing.Size(171, 26);
            this.NlineButton.TabIndex = 2;
            this.NlineButton.Text = "Кривая линия";
            this.NlineButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NlineButton.UseVisualStyleBackColor = true;
            // 
            // RectangleButton
            // 
            this.RectangleButton.Location = new System.Drawing.Point(12, 168);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(170, 26);
            this.RectangleButton.TabIndex = 3;
            this.RectangleButton.Text = "Прямоугольник";
            this.RectangleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RectangleButton.UseVisualStyleBackColor = true;
            // 
            // SquareButton
            // 
            this.SquareButton.Location = new System.Drawing.Point(11, 200);
            this.SquareButton.Name = "SquareButton";
            this.SquareButton.Size = new System.Drawing.Size(171, 26);
            this.SquareButton.TabIndex = 4;
            this.SquareButton.Text = "Квадрат";
            this.SquareButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SquareButton.UseVisualStyleBackColor = true;
            this.SquareButton.Click += new System.EventHandler(this.SquareButton_Click);
            // 
            // CircleButton
            // 
            this.CircleButton.Location = new System.Drawing.Point(12, 232);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(170, 26);
            this.CircleButton.TabIndex = 5;
            this.CircleButton.Text = "Круг";
            this.CircleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CircleButton.UseVisualStyleBackColor = true;
            // 
            // EllipseButton
            // 
            this.EllipseButton.Location = new System.Drawing.Point(12, 264);
            this.EllipseButton.Name = "EllipseButton";
            this.EllipseButton.Size = new System.Drawing.Size(170, 26);
            this.EllipseButton.TabIndex = 6;
            this.EllipseButton.Text = "Эллипс";
            this.EllipseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EllipseButton.UseVisualStyleBackColor = true;
            // 
            // RectangularTriangleButton
            // 
            this.RectangularTriangleButton.Location = new System.Drawing.Point(12, 296);
            this.RectangularTriangleButton.Name = "RectangularTriangleButton";
            this.RectangularTriangleButton.Size = new System.Drawing.Size(170, 26);
            this.RectangularTriangleButton.TabIndex = 7;
            this.RectangularTriangleButton.Text = "Прямоугольный треугольник";
            this.RectangularTriangleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RectangularTriangleButton.UseVisualStyleBackColor = true;
            // 
            // TriangleButton
            // 
            this.TriangleButton.Location = new System.Drawing.Point(12, 328);
            this.TriangleButton.Name = "TriangleButton";
            this.TriangleButton.Size = new System.Drawing.Size(170, 26);
            this.TriangleButton.TabIndex = 8;
            this.TriangleButton.Text = "Треугольник";
            this.TriangleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TriangleButton.UseVisualStyleBackColor = true;
            // 
            // AlpelesTriangleButton
            // 
            this.AlpelesTriangleButton.Location = new System.Drawing.Point(12, 360);
            this.AlpelesTriangleButton.Name = "AlpelesTriangleButton";
            this.AlpelesTriangleButton.Size = new System.Drawing.Size(170, 26);
            this.AlpelesTriangleButton.TabIndex = 9;
            this.AlpelesTriangleButton.Text = "Равнобедренный трегольник";
            this.AlpelesTriangleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AlpelesTriangleButton.UseVisualStyleBackColor = true;
            // 
            // PolygonButton
            // 
            this.PolygonButton.Location = new System.Drawing.Point(12, 392);
            this.PolygonButton.Name = "PolygonButton";
            this.PolygonButton.Size = new System.Drawing.Size(170, 26);
            this.PolygonButton.TabIndex = 10;
            this.PolygonButton.Text = "Многоугольник";
            this.PolygonButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PolygonButton.UseVisualStyleBackColor = true;
            // 
            // RegularPolygonButton
            // 
            this.RegularPolygonButton.Location = new System.Drawing.Point(12, 424);
            this.RegularPolygonButton.Name = "RegularPolygonButton";
            this.RegularPolygonButton.Size = new System.Drawing.Size(170, 26);
            this.RegularPolygonButton.TabIndex = 11;
            this.RegularPolygonButton.Text = "Правильный многоугольник";
            this.RegularPolygonButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegularPolygonButton.UseVisualStyleBackColor = true;
            // 
            // ToolsLabel
            // 
            this.ToolsLabel.AutoSize = true;
            this.ToolsLabel.Font = new System.Drawing.Font("Vladimir Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolsLabel.Location = new System.Drawing.Point(12, 38);
            this.ToolsLabel.Name = "ToolsLabel";
            this.ToolsLabel.Size = new System.Drawing.Size(158, 26);
            this.ToolsLabel.TabIndex = 12;
            this.ToolsLabel.Text = "Инструменты";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(188, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(755, 480);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(534, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(70, 22);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Толщина линии (пиксели)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Цвет линий";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VectorDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 572);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ToolsLabel);
            this.Controls.Add(this.RegularPolygonButton);
            this.Controls.Add(this.PolygonButton);
            this.Controls.Add(this.AlpelesTriangleButton);
            this.Controls.Add(this.TriangleButton);
            this.Controls.Add(this.RectangularTriangleButton);
            this.Controls.Add(this.EllipseButton);
            this.Controls.Add(this.CircleButton);
            this.Controls.Add(this.SquareButton);
            this.Controls.Add(this.RectangleButton);
            this.Controls.Add(this.NlineButton);
            this.Controls.Add(this.LineButton);
            this.Controls.Add(this.BrushButton);
            this.Name = "VectorDrawing";
            this.Text = "VectorDrawing2D";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrushButton;
        private System.Windows.Forms.Button LineButton;
        private System.Windows.Forms.Button NlineButton;
        private System.Windows.Forms.Button RectangleButton;
        private System.Windows.Forms.Button SquareButton;
        private System.Windows.Forms.Button CircleButton;
        private System.Windows.Forms.Button EllipseButton;
        private System.Windows.Forms.Button RectangularTriangleButton;
        private System.Windows.Forms.Button TriangleButton;
        private System.Windows.Forms.Button AlpelesTriangleButton;
        private System.Windows.Forms.Button PolygonButton;
        private System.Windows.Forms.Button RegularPolygonButton;
        private System.Windows.Forms.Label ToolsLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
    }
}

