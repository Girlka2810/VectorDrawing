﻿
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
            this.thickness = new System.Windows.Forms.NumericUpDown();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.colorFrontButton = new System.Windows.Forms.Button();
            this.anglesForPolygonGroupBox = new System.Windows.Forms.GroupBox();
            this.cornerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelVectorChanges = new System.Windows.Forms.Panel();
            this.AddTopModeButton = new System.Windows.Forms.Button();
            this.TopMoveModeButton = new System.Windows.Forms.Button();
            this.SideMoveModeButon = new System.Windows.Forms.Button();
            this.ChangeScaleModeButton = new System.Windows.Forms.Button();
            this.ChangeRadiusModeButton = new System.Windows.Forms.Button();
            this.RotateModeButton = new System.Windows.Forms.Button();
            this.moveModeButton = new System.Windows.Forms.Button();
            this.ChangeFigureButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.panelTools = new System.Windows.Forms.Panel();
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
            this.regularPolygonButton = new System.Windows.Forms.Button();
            this.polygonButton = new System.Windows.Forms.Button();
            this.ToolsButton = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Coordinates = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ThicknessValue = new System.Windows.Forms.Label();
            this.thicknessBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.thickness)).BeginInit();
            this.anglesForPolygonGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cornerNumericUpDown)).BeginInit();
            this.panelSideMenu.SuspendLayout();
            this.panelVectorChanges.SuspendLayout();
            this.panelTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessBar)).BeginInit();
            this.SuspendLayout();
            // 
            // thickness
            // 
            this.thickness.Location = new System.Drawing.Point(0, 0);
            this.thickness.Name = "thickness";
            this.thickness.Size = new System.Drawing.Size(120, 20);
            this.thickness.TabIndex = 26;
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
            this.anglesForPolygonGroupBox.Location = new System.Drawing.Point(800, 14);
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
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.Controls.Add(this.panelVectorChanges);
            this.panelSideMenu.Controls.Add(this.ChangeFigureButton);
            this.panelSideMenu.Controls.Add(this.clearButton);
            this.panelSideMenu.Controls.Add(this.panelTools);
            this.panelSideMenu.Controls.Add(this.ToolsButton);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(228, 562);
            this.panelSideMenu.TabIndex = 20;
            // 
            // panelVectorChanges
            // 
            this.panelVectorChanges.Controls.Add(this.AddTopModeButton);
            this.panelVectorChanges.Controls.Add(this.TopMoveModeButton);
            this.panelVectorChanges.Controls.Add(this.SideMoveModeButon);
            this.panelVectorChanges.Controls.Add(this.ChangeScaleModeButton);
            this.panelVectorChanges.Controls.Add(this.ChangeRadiusModeButton);
            this.panelVectorChanges.Controls.Add(this.RotateModeButton);
            this.panelVectorChanges.Controls.Add(this.moveModeButton);
            this.panelVectorChanges.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVectorChanges.Location = new System.Drawing.Point(0, 576);
            this.panelVectorChanges.Name = "panelVectorChanges";
            this.panelVectorChanges.Size = new System.Drawing.Size(211, 256);
            this.panelVectorChanges.TabIndex = 15;
            // 
            // AddTopModeButton
            // 
            this.AddTopModeButton.FlatAppearance.BorderSize = 0;
            this.AddTopModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTopModeButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTopModeButton.ForeColor = System.Drawing.Color.Red;
            this.AddTopModeButton.Image = global::VectorDrawing.Properties.Resources.AddTop;
            this.AddTopModeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddTopModeButton.Location = new System.Drawing.Point(0, 198);
            this.AddTopModeButton.Name = "AddTopModeButton";
            this.AddTopModeButton.Size = new System.Drawing.Size(216, 33);
            this.AddTopModeButton.TabIndex = 24;
            this.AddTopModeButton.TabStop = false;
            this.AddTopModeButton.Text = "Добавь вершину";
            this.AddTopModeButton.UseVisualStyleBackColor = true;
            // 
            // TopMoveModeButton
            // 
            this.TopMoveModeButton.FlatAppearance.BorderSize = 0;
            this.TopMoveModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopMoveModeButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopMoveModeButton.ForeColor = System.Drawing.Color.Red;
            this.TopMoveModeButton.Image = global::VectorDrawing.Properties.Resources.ChangeTop;
            this.TopMoveModeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TopMoveModeButton.Location = new System.Drawing.Point(0, 165);
            this.TopMoveModeButton.Name = "TopMoveModeButton";
            this.TopMoveModeButton.Size = new System.Drawing.Size(211, 33);
            this.TopMoveModeButton.TabIndex = 23;
            this.TopMoveModeButton.TabStop = false;
            this.TopMoveModeButton.Text = "Перемести вершину";
            this.TopMoveModeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TopMoveModeButton.UseVisualStyleBackColor = true;
            // 
            // SideMoveModeButon
            // 
            this.SideMoveModeButon.FlatAppearance.BorderSize = 0;
            this.SideMoveModeButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SideMoveModeButon.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SideMoveModeButon.ForeColor = System.Drawing.Color.Red;
            this.SideMoveModeButon.Image = global::VectorDrawing.Properties.Resources.ChangeSide;
            this.SideMoveModeButon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SideMoveModeButon.Location = new System.Drawing.Point(0, 132);
            this.SideMoveModeButon.Name = "SideMoveModeButon";
            this.SideMoveModeButon.Size = new System.Drawing.Size(211, 33);
            this.SideMoveModeButon.TabIndex = 22;
            this.SideMoveModeButon.TabStop = false;
            this.SideMoveModeButon.Text = "Перемести грань";
            this.SideMoveModeButon.UseVisualStyleBackColor = true;
            // 
            // ChangeScaleModeButton
            // 
            this.ChangeScaleModeButton.FlatAppearance.BorderSize = 0;
            this.ChangeScaleModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeScaleModeButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeScaleModeButton.ForeColor = System.Drawing.Color.Red;
            this.ChangeScaleModeButton.Image = global::VectorDrawing.Properties.Resources.ChangeSize;
            this.ChangeScaleModeButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ChangeScaleModeButton.Location = new System.Drawing.Point(-1, 94);
            this.ChangeScaleModeButton.Name = "ChangeScaleModeButton";
            this.ChangeScaleModeButton.Size = new System.Drawing.Size(211, 33);
            this.ChangeScaleModeButton.TabIndex = 21;
            this.ChangeScaleModeButton.TabStop = false;
            this.ChangeScaleModeButton.Text = "Измени масштаб";
            this.ChangeScaleModeButton.UseVisualStyleBackColor = true;
            // 
            // ChangeRadiusModeButton
            // 
            this.ChangeRadiusModeButton.FlatAppearance.BorderSize = 0;
            this.ChangeRadiusModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeRadiusModeButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeRadiusModeButton.ForeColor = System.Drawing.Color.Red;
            this.ChangeRadiusModeButton.Image = global::VectorDrawing.Properties.Resources.ChangeRadius1;
            this.ChangeRadiusModeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeRadiusModeButton.Location = new System.Drawing.Point(0, 66);
            this.ChangeRadiusModeButton.Name = "ChangeRadiusModeButton";
            this.ChangeRadiusModeButton.Size = new System.Drawing.Size(211, 36);
            this.ChangeRadiusModeButton.TabIndex = 20;
            this.ChangeRadiusModeButton.TabStop = false;
            this.ChangeRadiusModeButton.Text = "Измени радиус";
            this.ChangeRadiusModeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ChangeRadiusModeButton.UseVisualStyleBackColor = true;
            // 
            // RotateModeButton
            // 
            this.RotateModeButton.FlatAppearance.BorderSize = 0;
            this.RotateModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RotateModeButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RotateModeButton.ForeColor = System.Drawing.Color.Red;
            this.RotateModeButton.Image = global::VectorDrawing.Properties.Resources.Rotate;
            this.RotateModeButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RotateModeButton.Location = new System.Drawing.Point(0, 33);
            this.RotateModeButton.Name = "RotateModeButton";
            this.RotateModeButton.Size = new System.Drawing.Size(211, 33);
            this.RotateModeButton.TabIndex = 19;
            this.RotateModeButton.TabStop = false;
            this.RotateModeButton.Text = "Поверни";
            this.RotateModeButton.UseVisualStyleBackColor = true;
            // 
            // moveModeButton
            // 
            this.moveModeButton.FlatAppearance.BorderSize = 0;
            this.moveModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveModeButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moveModeButton.ForeColor = System.Drawing.Color.Red;
            this.moveModeButton.Image = global::VectorDrawing.Properties.Resources.Move;
            this.moveModeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moveModeButton.Location = new System.Drawing.Point(-1, 3);
            this.moveModeButton.Name = "moveModeButton";
            this.moveModeButton.Size = new System.Drawing.Size(211, 33);
            this.moveModeButton.TabIndex = 18;
            this.moveModeButton.TabStop = false;
            this.moveModeButton.Text = "Перемести";
            this.moveModeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.moveModeButton.UseVisualStyleBackColor = true;
            this.moveModeButton.Click += new System.EventHandler(this.OnMoveModeButtonClick);
            // 
            // ChangeFigureButton
            // 
            this.ChangeFigureButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChangeFigureButton.FlatAppearance.BorderSize = 0;
            this.ChangeFigureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeFigureButton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeFigureButton.ForeColor = System.Drawing.Color.Red;
            this.ChangeFigureButton.Location = new System.Drawing.Point(0, 543);
            this.ChangeFigureButton.Name = "ChangeFigureButton";
            this.ChangeFigureButton.Size = new System.Drawing.Size(211, 33);
            this.ChangeFigureButton.TabIndex = 14;
            this.ChangeFigureButton.Text = "Изменение фигур";
            this.ChangeFigureButton.UseVisualStyleBackColor = true;
            this.ChangeFigureButton.Click += new System.EventHandler(this.ChangeFigureButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Image = global::VectorDrawing.Properties.Resources.Clear;
            this.clearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearButton.Location = new System.Drawing.Point(0, 832);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(211, 33);
            this.clearButton.TabIndex = 17;
            this.clearButton.TabStop = false;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.OnClearClick);
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
            this.panelTools.Location = new System.Drawing.Point(0, 96);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(211, 447);
            this.panelTools.TabIndex = 13;
            // 
            // brushButton
            // 
            this.brushButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.brushButton.FlatAppearance.BorderSize = 0;
            this.brushButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.brushButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brushButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brushButton.ForeColor = System.Drawing.Color.Red;
            this.brushButton.Image = global::VectorDrawing.Properties.Resources.Brush;
            this.brushButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.brushButton.Location = new System.Drawing.Point(0, 0);
            this.brushButton.Name = "brushButton";
            this.brushButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.brushButton.Size = new System.Drawing.Size(211, 33);
            this.brushButton.TabIndex = 0;
            this.brushButton.TabStop = false;
            this.brushButton.Text = "Кисть";
            this.brushButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.brushButton.UseVisualStyleBackColor = true;
            this.brushButton.Click += new System.EventHandler(this.OnBrushButtonClick);
            // 
            // lineButton
            // 
            this.lineButton.FlatAppearance.BorderSize = 0;
            this.lineButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.lineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lineButton.ForeColor = System.Drawing.Color.Red;
            this.lineButton.Image = global::VectorDrawing.Properties.Resources.Line;
            this.lineButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lineButton.Location = new System.Drawing.Point(-1, 33);
            this.lineButton.Name = "lineButton";
            this.lineButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lineButton.Size = new System.Drawing.Size(212, 33);
            this.lineButton.TabIndex = 1;
            this.lineButton.TabStop = false;
            this.lineButton.Text = "Линия";
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.OnLineButtonClick);
            // 
            // nlineButton
            // 
            this.nlineButton.BackColor = System.Drawing.Color.LightCyan;
            this.nlineButton.FlatAppearance.BorderSize = 0;
            this.nlineButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.nlineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nlineButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nlineButton.ForeColor = System.Drawing.Color.Red;
            this.nlineButton.Image = global::VectorDrawing.Properties.Resources.Nline;
            this.nlineButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nlineButton.Location = new System.Drawing.Point(0, 66);
            this.nlineButton.Name = "nlineButton";
            this.nlineButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nlineButton.Size = new System.Drawing.Size(211, 33);
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
            this.rectangleButton.ForeColor = System.Drawing.Color.Red;
            this.rectangleButton.Image = global::VectorDrawing.Properties.Resources.Rectangle;
            this.rectangleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rectangleButton.Location = new System.Drawing.Point(0, 99);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rectangleButton.Size = new System.Drawing.Size(211, 33);
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
            this.squareButton.ForeColor = System.Drawing.Color.Red;
            this.squareButton.Image = global::VectorDrawing.Properties.Resources.Square;
            this.squareButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.squareButton.Location = new System.Drawing.Point(0, 132);
            this.squareButton.Name = "squareButton";
            this.squareButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.squareButton.Size = new System.Drawing.Size(211, 33);
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
            this.circleButton.ForeColor = System.Drawing.Color.Red;
            this.circleButton.Image = global::VectorDrawing.Properties.Resources.Circle;
            this.circleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.circleButton.Location = new System.Drawing.Point(0, 165);
            this.circleButton.Name = "circleButton";
            this.circleButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.circleButton.Size = new System.Drawing.Size(211, 33);
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
            this.ellipseButton.ForeColor = System.Drawing.Color.Red;
            this.ellipseButton.Image = global::VectorDrawing.Properties.Resources.Ellipse;
            this.ellipseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ellipseButton.Location = new System.Drawing.Point(0, 198);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ellipseButton.Size = new System.Drawing.Size(211, 33);
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
            this.rectangularTriangleButton.ForeColor = System.Drawing.Color.Red;
            this.rectangularTriangleButton.Image = global::VectorDrawing.Properties.Resources.RectangleTriangle;
            this.rectangularTriangleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rectangularTriangleButton.Location = new System.Drawing.Point(0, 231);
            this.rectangularTriangleButton.Name = "rectangularTriangleButton";
            this.rectangularTriangleButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rectangularTriangleButton.Size = new System.Drawing.Size(211, 47);
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
            this.triangleButton.ForeColor = System.Drawing.Color.Red;
            this.triangleButton.Image = global::VectorDrawing.Properties.Resources.Triangle;
            this.triangleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.triangleButton.Location = new System.Drawing.Point(0, 278);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.triangleButton.Size = new System.Drawing.Size(211, 33);
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
            this.isoscelesTriangleButton.ForeColor = System.Drawing.Color.Red;
            this.isoscelesTriangleButton.Image = global::VectorDrawing.Properties.Resources.IsoscaleTriangle;
            this.isoscelesTriangleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.isoscelesTriangleButton.Location = new System.Drawing.Point(0, 311);
            this.isoscelesTriangleButton.Name = "isoscelesTriangleButton";
            this.isoscelesTriangleButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.isoscelesTriangleButton.Size = new System.Drawing.Size(211, 46);
            this.isoscelesTriangleButton.TabIndex = 9;
            this.isoscelesTriangleButton.TabStop = false;
            this.isoscelesTriangleButton.Text = "Равнобедренный \r\nтрегольник";
            this.isoscelesTriangleButton.UseVisualStyleBackColor = true;
            this.isoscelesTriangleButton.Click += new System.EventHandler(this.OnIsoscelesTriangleButtonClick);
            // 
            // regularPolygonButton
            // 
            this.regularPolygonButton.FlatAppearance.BorderSize = 0;
            this.regularPolygonButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.regularPolygonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regularPolygonButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regularPolygonButton.ForeColor = System.Drawing.Color.Red;
            this.regularPolygonButton.Image = global::VectorDrawing.Properties.Resources.RectanglePolygone;
            this.regularPolygonButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.regularPolygonButton.Location = new System.Drawing.Point(0, 390);
            this.regularPolygonButton.Name = "regularPolygonButton";
            this.regularPolygonButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.regularPolygonButton.Size = new System.Drawing.Size(211, 50);
            this.regularPolygonButton.TabIndex = 11;
            this.regularPolygonButton.TabStop = false;
            this.regularPolygonButton.Text = "Правильный \r\nмногоугольник";
            this.regularPolygonButton.UseVisualStyleBackColor = true;
            this.regularPolygonButton.Click += new System.EventHandler(this.OnRegularPolygonButtonClick);
            // 
            // polygonButton
            // 
            this.polygonButton.FlatAppearance.BorderSize = 0;
            this.polygonButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.polygonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.polygonButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.polygonButton.ForeColor = System.Drawing.Color.Red;
            this.polygonButton.Image = global::VectorDrawing.Properties.Resources.Polygone;
            this.polygonButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.polygonButton.Location = new System.Drawing.Point(0, 357);
            this.polygonButton.Name = "polygonButton";
            this.polygonButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.polygonButton.Size = new System.Drawing.Size(211, 33);
            this.polygonButton.TabIndex = 10;
            this.polygonButton.TabStop = false;
            this.polygonButton.Text = "Многоугольник";
            this.polygonButton.UseVisualStyleBackColor = true;
            this.polygonButton.Click += new System.EventHandler(this.OnPolygonButtonClick);
            // 
            // ToolsButton
            // 
            this.ToolsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolsButton.FlatAppearance.BorderSize = 0;
            this.ToolsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolsButton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolsButton.ForeColor = System.Drawing.Color.Red;
            this.ToolsButton.Location = new System.Drawing.Point(0, 63);
            this.ToolsButton.Name = "ToolsButton";
            this.ToolsButton.Size = new System.Drawing.Size(211, 33);
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
            this.panelLogo.Size = new System.Drawing.Size(211, 63);
            this.panelLogo.TabIndex = 12;
            // 
            // Coordinates
            // 
            this.Coordinates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Coordinates.Location = new System.Drawing.Point(922, 532);
            this.Coordinates.Name = "Coordinates";
            this.Coordinates.Size = new System.Drawing.Size(108, 20);
            this.Coordinates.TabIndex = 21;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Image = global::VectorDrawing.Properties.Resources.Save2;
            this.saveButton.Location = new System.Drawing.Point(977, 17);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(39, 32);
            this.saveButton.TabIndex = 19;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.OnSaveButtonClick);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox.Location = new System.Drawing.Point(246, 67);
            this.pictureBox.MinimumSize = new System.Drawing.Size(746, 459);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(784, 459);
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            this.pictureBox.SizeChanged += new System.EventHandler(this.OnPictureBoxSizeChanged);
            this.pictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnPictureBoxMouseDoubleClick);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnPictureBoxMouseDown);
            this.pictureBox.MouseLeave += new System.EventHandler(this.OnPictureBox_MouseLeave);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnPictureBoxMouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnPictureBoxMouseUp);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(547, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Толщина линии";
            // 
            // ThicknessValue
            // 
            this.ThicknessValue.AutoSize = true;
            this.ThicknessValue.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThicknessValue.Location = new System.Drawing.Point(662, 41);
            this.ThicknessValue.Name = "ThicknessValue";
            this.ThicknessValue.Size = new System.Drawing.Size(15, 18);
            this.ThicknessValue.TabIndex = 24;
            this.ThicknessValue.Text = "1";
            // 
            // thicknessBar
            // 
            this.thicknessBar.LargeChange = 1;
            this.thicknessBar.Location = new System.Drawing.Point(550, 4);
            this.thicknessBar.Maximum = 25;
            this.thicknessBar.Minimum = 1;
            this.thicknessBar.Name = "thicknessBar";
            this.thicknessBar.Size = new System.Drawing.Size(165, 45);
            this.thicknessBar.TabIndex = 22;
            this.thicknessBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.thicknessBar.Value = 1;
            this.thicknessBar.Scroll += new System.EventHandler(this.OnThicknessBar_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(683, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "px";
            // 
            // VectorDrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1042, 562);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ThicknessValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.thicknessBar);
            this.Controls.Add(this.Coordinates);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.anglesForPolygonGroupBox);
            this.Controls.Add(this.colorFrontButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thickness);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(962, 590);
            this.Name = "VectorDrawingForm";
            this.Text = "VectorDrawing2D";
            this.Load += new System.EventHandler(this.OnVectorDrawingFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.thickness)).EndInit();
            this.anglesForPolygonGroupBox.ResumeLayout(false);
            this.anglesForPolygonGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cornerNumericUpDown)).EndInit();
            this.panelSideMenu.ResumeLayout(false);
            this.panelVectorChanges.ResumeLayout(false);
            this.panelTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessBar)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.NumericUpDown thickness;
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
        private System.Windows.Forms.Button ChangeFigureButton;
        private System.Windows.Forms.Panel panelVectorChanges;
        private System.Windows.Forms.Button AddTopModeButton;
        private System.Windows.Forms.Button TopMoveModeButton;
        private System.Windows.Forms.Button SideMoveModeButon;
        private System.Windows.Forms.Button ChangeScaleModeButton;
        private System.Windows.Forms.Button ChangeRadiusModeButton;
        private System.Windows.Forms.Button RotateModeButton;
        private System.Windows.Forms.TextBox Coordinates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ThicknessValue;
        private System.Windows.Forms.TrackBar thicknessBar;
        private System.Windows.Forms.Label label4;
    }
}

