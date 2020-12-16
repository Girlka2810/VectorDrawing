
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VectorDrawingForm));
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
            this.regularPolygonButton = new System.Windows.Forms.Button();
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
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelTools = new System.Windows.Forms.Panel();
            this.ToolsButton = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thickness)).BeginInit();
            this.anglesForPolygonGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cornerNumericUpDown)).BeginInit();
            this.panelSideMenu.SuspendLayout();
            this.panelTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // brushButton
            // 
            this.brushButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.brushButton.FlatAppearance.BorderSize = 0;
            this.brushButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.brushButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brushButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brushButton.Image = ((System.Drawing.Image)(resources.GetObject("brushButton.Image")));
            this.brushButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.brushButton.Location = new System.Drawing.Point(0, 0);
            this.brushButton.Name = "brushButton";
            this.brushButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.brushButton.Size = new System.Drawing.Size(228, 33);
            this.brushButton.TabIndex = 0;
            this.brushButton.TabStop = false;
            this.brushButton.Text = "Кисть";
            this.brushButton.UseVisualStyleBackColor = true;
            this.brushButton.Click += new System.EventHandler(this.OnBrushButtonClick);
            // 
            // lineButton
            // 
            this.lineButton.FlatAppearance.BorderSize = 0;
            this.lineButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.lineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lineButton.Image = ((System.Drawing.Image)(resources.GetObject("lineButton.Image")));
            this.lineButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lineButton.Location = new System.Drawing.Point(0, 33);
            this.lineButton.Name = "lineButton";
            this.lineButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lineButton.Size = new System.Drawing.Size(228, 33);
            this.lineButton.TabIndex = 1;
            this.lineButton.TabStop = false;
            this.lineButton.Text = "Линия";
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.OnLineButtonClick);
            // 
            // nlineButton
            // 
            this.nlineButton.BackColor = System.Drawing.Color.Lavender;
            this.nlineButton.FlatAppearance.BorderSize = 0;
            this.nlineButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.nlineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nlineButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nlineButton.Image = ((System.Drawing.Image)(resources.GetObject("nlineButton.Image")));
            this.nlineButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nlineButton.Location = new System.Drawing.Point(0, 66);
            this.nlineButton.Name = "nlineButton";
            this.nlineButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nlineButton.Size = new System.Drawing.Size(228, 33);
            this.nlineButton.TabIndex = 2;
            this.nlineButton.TabStop = false;
            this.nlineButton.Text = "Кривая линия";
            this.nlineButton.UseVisualStyleBackColor = false;
            this.nlineButton.Click += new System.EventHandler(this.OnNlineButtonClick);
            // 
            // rectangleButton
            // 
            this.rectangleButton.FlatAppearance.BorderSize = 0;
            this.rectangleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.rectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangleButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("rectangleButton.Image")));
            this.rectangleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rectangleButton.Location = new System.Drawing.Point(0, 99);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rectangleButton.Size = new System.Drawing.Size(228, 33);
            this.rectangleButton.TabIndex = 3;
            this.rectangleButton.TabStop = false;
            this.rectangleButton.Text = "Прямоугольник";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.OnRectangleButtonClick);
            // 
            // squareButton
            // 
            this.squareButton.FlatAppearance.BorderSize = 0;
            this.squareButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.squareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.squareButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.squareButton.Image = ((System.Drawing.Image)(resources.GetObject("squareButton.Image")));
            this.squareButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.squareButton.Location = new System.Drawing.Point(0, 132);
            this.squareButton.Name = "squareButton";
            this.squareButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.squareButton.Size = new System.Drawing.Size(228, 33);
            this.squareButton.TabIndex = 4;
            this.squareButton.TabStop = false;
            this.squareButton.Text = "Квадрат";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.OnSquareButtonClick);
            // 
            // circleButton
            // 
            this.circleButton.FlatAppearance.BorderSize = 0;
            this.circleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.circleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.circleButton.Image = ((System.Drawing.Image)(resources.GetObject("circleButton.Image")));
            this.circleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.circleButton.Location = new System.Drawing.Point(0, 165);
            this.circleButton.Name = "circleButton";
            this.circleButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.circleButton.Size = new System.Drawing.Size(228, 33);
            this.circleButton.TabIndex = 5;
            this.circleButton.TabStop = false;
            this.circleButton.Text = "Круг";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.OnCircleButtonClick);
            // 
            // ellipseButton
            // 
            this.ellipseButton.FlatAppearance.BorderSize = 0;
            this.ellipseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.ellipseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellipseButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ellipseButton.Image = ((System.Drawing.Image)(resources.GetObject("ellipseButton.Image")));
            this.ellipseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ellipseButton.Location = new System.Drawing.Point(0, 198);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ellipseButton.Size = new System.Drawing.Size(228, 33);
            this.ellipseButton.TabIndex = 6;
            this.ellipseButton.TabStop = false;
            this.ellipseButton.Text = "Эллипс";
            this.ellipseButton.UseVisualStyleBackColor = true;
            this.ellipseButton.Click += new System.EventHandler(this.OnEllipseButtonClick);
            // 
            // rectangularTriangleButton
            // 
            this.rectangularTriangleButton.FlatAppearance.BorderSize = 0;
            this.rectangularTriangleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.rectangularTriangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangularTriangleButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rectangularTriangleButton.Image = ((System.Drawing.Image)(resources.GetObject("rectangularTriangleButton.Image")));
            this.rectangularTriangleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rectangularTriangleButton.Location = new System.Drawing.Point(0, 231);
            this.rectangularTriangleButton.Name = "rectangularTriangleButton";
            this.rectangularTriangleButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rectangularTriangleButton.Size = new System.Drawing.Size(228, 47);
            this.rectangularTriangleButton.TabIndex = 7;
            this.rectangularTriangleButton.TabStop = false;
            this.rectangularTriangleButton.Text = "Прямоугольный \r\nтреугольник";
            this.rectangularTriangleButton.UseVisualStyleBackColor = true;
            this.rectangularTriangleButton.Click += new System.EventHandler(this.OnRectangularTriangleButtonClick);
            // 
            // triangleButton
            // 
            this.triangleButton.FlatAppearance.BorderSize = 0;
            this.triangleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.triangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.triangleButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.triangleButton.Image = ((System.Drawing.Image)(resources.GetObject("triangleButton.Image")));
            this.triangleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.triangleButton.Location = new System.Drawing.Point(0, 278);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.triangleButton.Size = new System.Drawing.Size(228, 33);
            this.triangleButton.TabIndex = 8;
            this.triangleButton.TabStop = false;
            this.triangleButton.Text = "Треугольник";
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.Click += new System.EventHandler(this.OnTriangleButtonClick);
            // 
            // isoscelesTriangleButton
            // 
            this.isoscelesTriangleButton.FlatAppearance.BorderSize = 0;
            this.isoscelesTriangleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.isoscelesTriangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isoscelesTriangleButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isoscelesTriangleButton.Image = ((System.Drawing.Image)(resources.GetObject("isoscelesTriangleButton.Image")));
            this.isoscelesTriangleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.isoscelesTriangleButton.Location = new System.Drawing.Point(0, 311);
            this.isoscelesTriangleButton.Name = "isoscelesTriangleButton";
            this.isoscelesTriangleButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.isoscelesTriangleButton.Size = new System.Drawing.Size(228, 46);
            this.isoscelesTriangleButton.TabIndex = 9;
            this.isoscelesTriangleButton.TabStop = false;
            this.isoscelesTriangleButton.Text = "Равнобедренный \r\nтрегольник";
            this.isoscelesTriangleButton.UseVisualStyleBackColor = true;
            this.isoscelesTriangleButton.Click += new System.EventHandler(this.OnIsoscelesTriangleButtonClick);
            // 
            // polygonButton
            // 
            this.polygonButton.FlatAppearance.BorderSize = 0;
            this.polygonButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.polygonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.polygonButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.polygonButton.Image = ((System.Drawing.Image)(resources.GetObject("polygonButton.Image")));
            this.polygonButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.polygonButton.Location = new System.Drawing.Point(0, 357);
            this.polygonButton.Name = "polygonButton";
            this.polygonButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.polygonButton.Size = new System.Drawing.Size(228, 33);
            this.polygonButton.TabIndex = 10;
            this.polygonButton.TabStop = false;
            this.polygonButton.Text = "Многоугольник";
            this.polygonButton.UseVisualStyleBackColor = true;
            this.polygonButton.Click += new System.EventHandler(this.OnPolygonButtonClick);
            // 
            // regularPolygonButton
            // 
            this.regularPolygonButton.FlatAppearance.BorderSize = 0;
            this.regularPolygonButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.regularPolygonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regularPolygonButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regularPolygonButton.Image = ((System.Drawing.Image)(resources.GetObject("regularPolygonButton.Image")));
            this.regularPolygonButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.regularPolygonButton.Location = new System.Drawing.Point(0, 390);
            this.regularPolygonButton.Name = "regularPolygonButton";
            this.regularPolygonButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.regularPolygonButton.Size = new System.Drawing.Size(228, 50);
            this.regularPolygonButton.TabIndex = 11;
            this.regularPolygonButton.TabStop = false;
            this.regularPolygonButton.Text = "Правильный \r\nмногоугольник";
            this.regularPolygonButton.UseVisualStyleBackColor = true;
            this.regularPolygonButton.Click += new System.EventHandler(this.OnRegularPolygonButtonClick);
            // 
            // ToolsLabel
            // 
            this.ToolsLabel.AutoSize = true;
            this.ToolsLabel.Font = new System.Drawing.Font("Vladimir Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolsLabel.Location = new System.Drawing.Point(246, 38);
            this.ToolsLabel.Name = "ToolsLabel";
            this.ToolsLabel.Size = new System.Drawing.Size(158, 26);
            this.ToolsLabel.TabIndex = 12;
            this.ToolsLabel.Text = "Инструменты";
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(246, 67);
            this.pictureBox.MinimumSize = new System.Drawing.Size(746, 459);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(870, 500);
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            this.pictureBox.SizeChanged += new System.EventHandler(this.OnPictureBoxSizeChanged);
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
            this.thickness.Size = new System.Drawing.Size(70, 20);
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
            this.label1.Size = new System.Drawing.Size(137, 13);
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
            this.cornerNumericUpDown.Size = new System.Drawing.Size(47, 20);
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
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Количество углов";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Image = ((System.Drawing.Image)(resources.GetObject("clearButton.Image")));
            this.clearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearButton.Location = new System.Drawing.Point(822, 17);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(147, 33);
            this.clearButton.TabIndex = 17;
            this.clearButton.TabStop = false;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.OnClearClick);
            // 
            // moveModeButton
            // 
            this.moveModeButton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moveModeButton.Location = new System.Drawing.Point(426, 38);
            this.moveModeButton.Name = "moveModeButton";
            this.moveModeButton.Size = new System.Drawing.Size(146, 33);
            this.moveModeButton.TabIndex = 18;
            this.moveModeButton.TabStop = false;
            this.moveModeButton.Text = "Переместить";
            this.moveModeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.moveModeButton.UseVisualStyleBackColor = true;
            this.moveModeButton.Click += new System.EventHandler(this.OnMoveModeButtonClick);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(990, 17);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 23);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.OnSaveButtonClick);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.Controls.Add(this.panelTools);
            this.panelSideMenu.Controls.Add(this.ToolsButton);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(228, 592);
            this.panelSideMenu.TabIndex = 20;
            // 
            // panelTools
            // 
            this.panelTools.Controls.Add(this.brushButton);
            this.panelTools.Controls.Add(this.lineButton);
            this.panelTools.Controls.Add(this.nlineButton);
            this.panelTools.Controls.Add(this.rectangleButton);
            this.panelTools.Controls.Add(this.squareButton);
            this.panelTools.Controls.Add(this.circleButton);
            this.panelTools.Controls.Add(this.ellipseButton);
            this.panelTools.Controls.Add(this.rectangularTriangleButton);
            this.panelTools.Controls.Add(this.triangleButton);
            this.panelTools.Controls.Add(this.isoscelesTriangleButton);
            this.panelTools.Controls.Add(this.regularPolygonButton);
            this.panelTools.Controls.Add(this.polygonButton);
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTools.Location = new System.Drawing.Point(0, 118);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(228, 447);
            this.panelTools.TabIndex = 13;
            // 
            // ToolsButton
            // 
            this.ToolsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolsButton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolsButton.Location = new System.Drawing.Point(0, 85);
            this.ToolsButton.Name = "ToolsButton";
            this.ToolsButton.Size = new System.Drawing.Size(228, 33);
            this.ToolsButton.TabIndex = 0;
            this.ToolsButton.Text = "Инструменты";
            this.ToolsButton.UseVisualStyleBackColor = true;
            this.ToolsButton.Click += new System.EventHandler(this.ToolsButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(228, 85);
            this.panelLogo.TabIndex = 12;
            // 
            // VectorDrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1128, 592);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.moveModeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.anglesForPolygonGroupBox);
            this.Controls.Add(this.colorFrontButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thickness);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.ToolsLabel);
            this.MinimumSize = new System.Drawing.Size(962, 590);
            this.Name = "VectorDrawingForm";
            this.Text = "VectorDrawing2D";
            this.Load += new System.EventHandler(this.OnVectorDrawingFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thickness)).EndInit();
            this.anglesForPolygonGroupBox.ResumeLayout(false);
            this.anglesForPolygonGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cornerNumericUpDown)).EndInit();
            this.panelSideMenu.ResumeLayout(false);
            this.panelTools.ResumeLayout(false);
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
        private System.Windows.Forms.Button regularPolygonButton;
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
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Button ToolsButton;
        private System.Windows.Forms.Panel panelLogo;
    }
}

