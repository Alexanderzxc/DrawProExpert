namespace drawpro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonTriangle = new Button();
            textBoxWidth = new TextBox();
            panel1 = new Panel();
            panel3color = new Panel();
            labelOnPanel = new Label();
            buttonSquare = new Button();
            buttonLine = new Button();
            colorDialog1 = new ColorDialog();
            panel2Color = new Panel();
            labelWidth = new Label();
            labelColor = new Label();
            buttonColor = new Button();
            buttonCircle = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonTriangle
            // 
            buttonTriangle.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTriangle.Location = new Point(475, 125);
            buttonTriangle.Name = "buttonTriangle";
            buttonTriangle.Size = new Size(138, 142);
            buttonTriangle.TabIndex = 0;
            buttonTriangle.Text = "Triangle";
            buttonTriangle.UseVisualStyleBackColor = true;
            buttonTriangle.Click += buttonTriangle_Click;
            // 
            // textBoxWidth
            // 
            textBoxWidth.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxWidth.Location = new Point(209, 40);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(146, 43);
            textBoxWidth.TabIndex = 1;
            textBoxWidth.Text = "2 ";
            textBoxWidth.TextAlign = HorizontalAlignment.Right;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3color);
            panel1.Controls.Add(labelOnPanel);
            panel1.Location = new Point(51, 172);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 243);
            panel1.TabIndex = 2;
            // 
            // panel3color
            // 
            panel3color.BackColor = SystemColors.Control;
            panel3color.Location = new Point(90, 89);
            panel3color.Name = "panel3color";
            panel3color.Size = new Size(39, 37);
            panel3color.TabIndex = 8;
            // 
            // labelOnPanel
            // 
            labelOnPanel.AutoSize = true;
            labelOnPanel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelOnPanel.Location = new Point(3, 12);
            labelOnPanel.Name = "labelOnPanel";
            labelOnPanel.Size = new Size(301, 74);
            labelOnPanel.TabIndex = 0;
            labelOnPanel.Text = "Выберите:\r\nширину, фигуру и цвет";
            // 
            // buttonSquare
            // 
            buttonSquare.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSquare.Location = new Point(619, 125);
            buttonSquare.Name = "buttonSquare";
            buttonSquare.Size = new Size(138, 142);
            buttonSquare.TabIndex = 5;
            buttonSquare.Text = "Square";
            buttonSquare.UseVisualStyleBackColor = true;
            buttonSquare.Click += buttonSquare_Click;
            // 
            // buttonLine
            // 
            buttonLine.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLine.Location = new Point(619, 273);
            buttonLine.Name = "buttonLine";
            buttonLine.Size = new Size(138, 142);
            buttonLine.TabIndex = 6;
            buttonLine.Text = "Line";
            buttonLine.UseVisualStyleBackColor = true;
            buttonLine.Click += buttonLine_Click;
            // 
            // panel2Color
            // 
            panel2Color.BackColor = SystemColors.ActiveCaptionText;
            panel2Color.Location = new Point(316, 89);
            panel2Color.Name = "panel2Color";
            panel2Color.Size = new Size(39, 37);
            panel2Color.TabIndex = 7;
            panel2Color.Paint += panel2Color_Paint;
            // 
            // labelWidth
            // 
            labelWidth.AutoSize = true;
            labelWidth.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelWidth.Location = new Point(114, 40);
            labelWidth.Name = "labelWidth";
            labelWidth.Size = new Size(89, 37);
            labelWidth.TabIndex = 8;
            labelWidth.Text = "Width";
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelColor.Location = new Point(114, 89);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(82, 37);
            labelColor.TabIndex = 9;
            labelColor.Text = "Color";
            // 
            // buttonColor
            // 
            buttonColor.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonColor.Location = new Point(209, 89);
            buttonColor.Name = "buttonColor";
            buttonColor.Size = new Size(101, 37);
            buttonColor.TabIndex = 10;
            buttonColor.Text = "Change color";
            buttonColor.UseVisualStyleBackColor = true;
            buttonColor.Click += buttonColor_Click;
            // 
            // buttonCircle
            // 
            buttonCircle.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCircle.Location = new Point(475, 273);
            buttonCircle.Name = "buttonCircle";
            buttonCircle.Size = new Size(138, 142);
            buttonCircle.TabIndex = 4;
            buttonCircle.Text = "Circle";
            buttonCircle.UseVisualStyleBackColor = true;
            buttonCircle.Click += buttonCircle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonColor);
            Controls.Add(labelColor);
            Controls.Add(labelWidth);
            Controls.Add(panel2Color);
            Controls.Add(buttonLine);
            Controls.Add(buttonSquare);
            Controls.Add(buttonCircle);
            Controls.Add(panel1);
            Controls.Add(textBoxWidth);
            Controls.Add(buttonTriangle);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonTriangle;
        private TextBox textBoxWidth;
        private Panel panel1;
        private Label labelOnPanel;
        private Button buttonSquare;
        private Button buttonLine;
        private ColorDialog colorDialog1;
        private Panel panel2Color;
        private Label labelWidth;
        private Label labelColor;
        private Button buttonColor;
        private Button buttonCircle;
        private Panel panel3color;
    }
}