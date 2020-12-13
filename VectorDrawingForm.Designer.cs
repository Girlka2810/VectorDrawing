
namespace VectorDrawing
{
    partial class VectorDrawingForm
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
            this.brushButton = new System.Windows.Forms.Button();
            this.lineButton = new System.Windows.Forms.Button();
            this.nlineButton = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.squareButton = new System.Windows.Forms.Button();
            this.circleButton = new System.Windows.Forms.Button();
            this.ellipseButton = new System.Windows.Forms.Button();
            this.rectangularTriangleButton = new System.Windows.Forms.Button();
            this.triangleButton = new System.Windows.Forms.Button();
            this.isoscelesTriangleButton = new System.Windows.Forms.Button();
            this.polygonButton = new System.Windows.Forms.Button();
            this.RegularPolygonButton = new System.Windows.Forms.Button();
            this.ToolsLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.thickness = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.colorFrontButton = new System.Windows.Forms.Button();
            this.anglesForPolygonGroupBox = new System.Windows.Forms.GroupBox();
            this.cornerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.moveModeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thickness)).BeginInit();
            this.anglesForPolygonGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cornerNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // brushButton
            // 
            this.brushButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.brushButton.Location = new System.Drawing.Point(11, 67);
            this.brushButton.Name = "brushButton";
            this.brushButton.Size = new System.Drawing.Size(171, 26);
            this.brushButton.TabIndex = 0;
            this.brushButton.TabStop = false;
            this.brushButton.Text = "Кисть";
            this.brushButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brushButton.UseVisualStyleBackColor = true;
            this.brushButton.Click += new System.EventHandler(this.OnBrushButtonClick);
            // 
            // lineButton
            // 
            this.lineButton.Location = new System.Drawing.Point(11, 102);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(171, 28);
            this.lineButton.TabIndex = 1;
            this.lineButton.TabStop = false;
            this.lineButton.Text = "Линия";
            this.lineButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.OnLineButtonClick);
            // 
            // nlineButton
            // 
            this.nlineButton.Location = new System.Drawing.Point(11, 136);
            this.nlineButton.Name = "nlineButton";
            this.nlineButton.Size = new System.Drawing.Size(171, 26);
            this.nlineButton.TabIndex = 2;
            this.nlineButton.TabStop = false;
            this.nlineButton.Text = "Кривая линия";
            this.nlineButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nlineButton.UseVisualStyleBackColor = true;
            this.nlineButton.Click += new System.EventHandler(this.OnNlineButtonClick);
            // 
            // rectangleButton
            // 
            this.rectangleButton.Location = new System.Drawing.Point(12, 168);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(170, 26);
            this.rectangleButton.TabIndex = 3;
            this.rectangleButton.TabStop = false;
            this.rectangleButton.Text = "Прямоугольник";
            this.rectangleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.OnRectangleButtonClick);
            // 
            // squareButton
            // 
            this.squareButton.Location = new System.Drawing.Point(11, 200);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(171, 26);
            this.squareButton.TabIndex = 4;
            this.squareButton.TabStop = false;
            this.squareButton.Text = "Квадрат";
            this.squareButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.OnSquareButtonClick);
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(12, 232);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(170, 26);
            this.circleButton.TabIndex = 5;
            this.circleButton.TabStop = false;
            this.circleButton.Text = "Круг";
            this.circleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.OnCircleButtonClick);
            // 
            // ellipseButton
            // 
            this.ellipseButton.Location = new System.Drawing.Point(12, 264);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Size = new System.Drawing.Size(170, 26);
            this.ellipseButton.TabIndex = 6;
            this.ellipseButton.TabStop = false;
            this.ellipseButton.Text = "Эллипс";
            this.ellipseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ellipseButton.UseVisualStyleBackColor = true;
            this.ellipseButton.Click += new System.EventHandler(this.OnEllipseButtonClick);
            // 
            // rectangularTriangleButton
            // 
            this.rectangularTriangleButton.Location = new System.Drawing.Point(12, 296);
            this.rectangularTriangleButton.Name = "rectangularTriangleButton";
            this.rectangularTriangleButton.Size = new System.Drawing.Size(170, 26);
            this.rectangularTriangleButton.TabIndex = 7;
            this.rectangularTriangleButton.TabStop = false;
            this.rectangularTriangleButton.Text = "Прямоугольный треугольник";
            this.rectangularTriangleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rectangularTriangleButton.UseVisualStyleBackColor = true;
            this.rectangularTriangleButton.Click += new System.EventHandler(this.OnRectangularTriangleButtonClick);
            // 
            // triangleButton
            // 
            this.triangleButton.Location = new System.Drawing.Point(12, 328);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(170, 26);
            this.triangleButton.TabIndex = 8;
            this.triangleButton.TabStop = false;
            this.triangleButton.Text = "Треугольник";
            this.triangleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.Click += new System.EventHandler(this.OnTriangleButtonClick);
            // 
            // isoscelesTriangleButton
            // 
            this.isoscelesTriangleButton.Location = new System.Drawing.Point(12, 360);
            this.isoscelesTriangleButton.Name = "isoscelesTriangleButton";
            this.isoscelesTriangleButton.Size = new System.Drawing.Size(170, 26);
            this.isoscelesTriangleButton.TabIndex = 9;
            this.isoscelesTriangleButton.TabStop = false;
            this.isoscelesTriangleButton.Text = "Равнобедренный трегольник";
            this.isoscelesTriangleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.isoscelesTriangleButton.UseVisualStyleBackColor = true;
            this.isoscelesTriangleButton.Click += new System.EventHandler(this.OnIsoscelesTriangleButtonClick);
            // 
            // polygonButton
            // 
            this.polygonButton.Location = new System.Drawing.Point(12, 392);
            this.polygonButton.Name = "polygonButton";
            this.polygonButton.Size = new System.Drawing.Size(170, 26);
            this.polygonButton.TabIndex = 10;
            this.polygonButton.TabStop = false;
            this.polygonButton.Text = "Многоугольник";
            this.polygonButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.polygonButton.UseVisualStyleBackColor = true;
            this.polygonButton.Click += new System.EventHandler(this.OnPolygonButtonClick);
            // 
            // RegularPolygonButton
            // 
            this.RegularPolygonButton.Location = new System.Drawing.Point(12, 424);
            this.RegularPolygonButton.Name = "RegularPolygonButton";
            this.RegularPolygonButton.Size = new System.Drawing.Size(170, 26);
            this.RegularPolygonButton.TabIndex = 11;
            this.RegularPolygonButton.TabStop = false;
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
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(188, 67);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(755, 480);
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnPictureBoxMouseDoubleClick);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnPictureBoxMouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnPictureBoxMouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnPictureBoxMouseUp);
            // 
            // thickness
            // 
            this.thickness.DecimalPlaces = 2;
            this.thickness.Location = new System.Drawing.Point(543, 14);
            this.thickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.thickness.Name = "thickness";
            this.thickness.Size = new System.Drawing.Size(70, 22);
            this.thickness.TabIndex = 13;
            this.thickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.thickness.ValueChanged += new System.EventHandler(this.OnThicknessValueChanged);
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
            // colorFrontButton
            // 
            this.colorFrontButton.Location = new System.Drawing.Point(251, 12);
            this.colorFrontButton.Name = "colorFrontButton";
            this.colorFrontButton.Size = new System.Drawing.Size(112, 23);
            this.colorFrontButton.TabIndex = 12;
            this.colorFrontButton.Text = "Цвет линий";
            this.colorFrontButton.UseVisualStyleBackColor = true;
            this.colorFrontButton.Click += new System.EventHandler(this.OnColorFrontButtonClick);
            // 
            // anglesForPolygonGroupBox
            // 
            this.anglesForPolygonGroupBox.Controls.Add(this.cornerNumericUpDown);
            this.anglesForPolygonGroupBox.Controls.Add(this.label2);
            this.anglesForPolygonGroupBox.Location = new System.Drawing.Point(631, 9);
            this.anglesForPolygonGroupBox.Name = "anglesForPolygonGroupBox";
            this.anglesForPolygonGroupBox.Size = new System.Drawing.Size(171, 40);
            this.anglesForPolygonGroupBox.TabIndex = 16;
            this.anglesForPolygonGroupBox.TabStop = false;
            this.anglesForPolygonGroupBox.Text = "Многоугольник";
            this.anglesForPolygonGroupBox.Visible = false;
            // 
            // cornerNumericUpDown
            // 
            this.cornerNumericUpDown.Location = new System.Drawing.Point(114, 14);
            this.cornerNumericUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.cornerNumericUpDown.Name = "cornerNumericUpDown";
            this.cornerNumericUpDown.Size = new System.Drawing.Size(47, 22);
            this.cornerNumericUpDown.TabIndex = 1;
            this.cornerNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.cornerNumericUpDown.ValueChanged += new System.EventHandler(this.OnCornersNumericUpDownValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Количество углов";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(22, 464);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(147, 23);
            this.clearButton.TabIndex = 17;
            this.clearButton.TabStop = false;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.OnClearClick);
            // 
            // moveModeButton
            // 
            this.moveModeButton.Location = new System.Drawing.Point(22, 507);
            this.moveModeButton.Name = "moveModeButton";
            this.moveModeButton.Size = new System.Drawing.Size(146, 22);
            this.moveModeButton.TabIndex = 18;
            this.moveModeButton.TabStop = false;
            this.moveModeButton.Text = "Переместить";
            this.moveModeButton.UseVisualStyleBackColor = true;
            this.moveModeButton.Click += new System.EventHandler(this.OnMoveModeButtonClick);
            // 
            // VectorDrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 572);
            this.Controls.Add(this.moveModeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.anglesForPolygonGroupBox);
            this.Controls.Add(this.colorFrontButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thickness);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.ToolsLabel);
            this.Controls.Add(this.RegularPolygonButton);
            this.Controls.Add(this.polygonButton);
            this.Controls.Add(this.isoscelesTriangleButton);
            this.Controls.Add(this.triangleButton);
            this.Controls.Add(this.rectangularTriangleButton);
            this.Controls.Add(this.ellipseButton);
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.rectangleButton);
            this.Controls.Add(this.nlineButton);
            this.Controls.Add(this.lineButton);
            this.Controls.Add(this.brushButton);
            this.Name = "VectorDrawingForm";
            this.Text = "VectorDrawing2D";
            this.Load += new System.EventHandler(this.OnVectorDrawingFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thickness)).EndInit();
            this.anglesForPolygonGroupBox.ResumeLayout(false);
            this.anglesForPolygonGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cornerNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brushButton;
        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.Button nlineButton;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button ellipseButton;
        private System.Windows.Forms.Button rectangularTriangleButton;
        private System.Windows.Forms.Button triangleButton;
        private System.Windows.Forms.Button isoscelesTriangleButton;
        private System.Windows.Forms.Button polygonButton;
        private System.Windows.Forms.Button RegularPolygonButton;
        private System.Windows.Forms.Label ToolsLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.NumericUpDown thickness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button colorFrontButton;
        private System.Windows.Forms.NumericUpDown cornerNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox anglesForPolygonGroupBox;
        private System.Windows.Forms.Button moveModeButton;
    }
}

