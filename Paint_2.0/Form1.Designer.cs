﻿namespace Paint_2._0
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
            panel1 = new Panel();
            color_picker = new PictureBox();
            btn_line = new Button();
            btn_rect = new Button();
            btn_ellipse = new Button();
            btn_rotate = new Button();
            btn_transform = new Button();
            btn_fill = new Button();
            pic_color = new Button();
            panel3 = new Panel();
            btn_color = new Button();
            panel2 = new Panel();
            pic = new PictureBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            themeToolStripMenuItem = new ToolStripMenuItem();
            customToolStripMenuItem = new ToolStripMenuItem();
            monochromelightToolStripMenuItem = new ToolStripMenuItem();
            monochromedarkToolStripMenuItem = new ToolStripMenuItem();
            spravkaToolStripMenuItem = new ToolStripMenuItem();
            aboutUsToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)color_picker).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.YellowGreen;
            panel1.Controls.Add(color_picker);
            panel1.Controls.Add(btn_line);
            panel1.Controls.Add(btn_rect);
            panel1.Controls.Add(btn_ellipse);
            panel1.Controls.Add(btn_rotate);
            panel1.Controls.Add(btn_transform);
            panel1.Controls.Add(btn_fill);
            panel1.Controls.Add(pic_color);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 25);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 145);
            panel1.TabIndex = 0;
            // 
            // color_picker
            // 
            color_picker.Cursor = Cursors.Hand;
            color_picker.Image = Properties.Resources.color_palette;
            color_picker.Location = new Point(5, 30);
            color_picker.Margin = new Padding(3, 4, 3, 4);
            color_picker.Name = "color_picker";
            color_picker.Size = new Size(220, 110);
            color_picker.SizeMode = PictureBoxSizeMode.StretchImage;
            color_picker.TabIndex = 9;
            color_picker.TabStop = false;
            color_picker.MouseClick += color_picker_MouseClick;
            // 
            // pic_color
            // 
            pic_color.BackColor = Color.White;
            pic_color.Cursor = Cursors.Hand;
            pic_color.Location = new Point(235, 65);
            pic_color.Margin = new Padding(3, 4, 3, 4);
            pic_color.Name = "pic_color";
            pic_color.Size = new Size(40, 40);
            pic_color.TabIndex = 0;
            pic_color.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Green;
            panel3.Controls.Add(btn_color);
            panel3.Location = new Point(290, 40);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(440, 90);
            panel3.TabIndex = 8;
            // 
            // btn_color
            // 
            btn_color.BackColor = Color.YellowGreen;
            btn_color.Cursor = Cursors.Hand;
            btn_color.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_color.FlatAppearance.MouseOverBackColor = Color.Green;
            btn_color.FlatStyle = FlatStyle.Flat;
            btn_color.ForeColor = Color.White;
            btn_color.BackgroundImage = Properties.Resources.color1;
            btn_color.BackgroundImageLayout = ImageLayout.Zoom;
            btn_color.Location = new Point(15, 15);
            btn_color.Margin = new Padding(3, 4, 3, 4);
            btn_color.Name = "btn_color";
            btn_color.Size = new Size(60, 60);
            btn_color.TabIndex = 1;
            btn_color.TextAlign = ContentAlignment.BottomCenter;
            btn_color.UseVisualStyleBackColor = false;
            btn_color.Click += btn_color_Click;
            // 
            // btn_fill
            // 
            btn_fill.BackColor = Color.YellowGreen;
            btn_fill.Cursor = Cursors.Hand;
            btn_fill.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_fill.FlatAppearance.MouseOverBackColor = Color.Green;
            btn_fill.FlatStyle = FlatStyle.Flat;
            btn_fill.ForeColor = Color.White;
            btn_fill.BackgroundImage = Properties.Resources.fill;
            btn_fill.BackgroundImageLayout = ImageLayout.Zoom;
            btn_fill.Location = new Point(375, 55);
            btn_fill.Margin = new Padding(3, 4, 3, 4);
            btn_fill.Name = "btn_fill";
            btn_fill.Size = new Size(60, 60);
            btn_fill.TabIndex = 2;
            btn_fill.TextAlign = ContentAlignment.BottomCenter;
            btn_fill.UseVisualStyleBackColor = false;
            btn_fill.Click += btn_fill_Click;
            // 
            // btn_transform
            // 
            btn_transform.BackColor = Color.YellowGreen;
            btn_transform.Cursor = Cursors.Hand;
            btn_transform.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_transform.FlatAppearance.MouseOverBackColor = Color.Green;
            btn_transform.FlatStyle = FlatStyle.Flat;
            btn_transform.ForeColor = Color.White;
            btn_transform.BackgroundImage = Properties.Resources.transform;
            btn_transform.BackgroundImageLayout = ImageLayout.Zoom;
            btn_transform.Location = new Point(445, 55);
            btn_transform.Margin = new Padding(3, 4, 3, 4);
            btn_transform.Name = "btn_transform";
            btn_transform.Size = new Size(60, 60);
            btn_transform.TabIndex = 3;
            btn_transform.TextAlign = ContentAlignment.BottomCenter;
            btn_transform.UseVisualStyleBackColor = false;
            btn_transform.Click += btn_pencil_Click;
            // 
            // btn_rotate
            // 
            btn_rotate.BackColor = Color.YellowGreen;
            btn_rotate.Cursor = Cursors.Hand;
            btn_rotate.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_rotate.FlatAppearance.MouseOverBackColor = Color.Green;
            btn_rotate.FlatStyle = FlatStyle.Flat;
            btn_rotate.ForeColor = Color.White;
            btn_rotate.BackgroundImage = Properties.Resources.rotation;
            btn_rotate.BackgroundImageLayout = ImageLayout.Zoom;
            btn_rotate.Location = new Point(445, 90);
            btn_rotate.Margin = new Padding(3, 4, 3, 4);
            btn_rotate.Name = "btn_rotate";
            btn_rotate.Size = new Size(30, 30);
            btn_rotate.TabIndex = 4;
            btn_rotate.TextAlign = ContentAlignment.BottomCenter;
            btn_rotate.UseVisualStyleBackColor = false;
            btn_rotate.Click += btn_eraser_Click;
            btn_rotate.Visible = false;
            // 
            // btn_ellipse
            // 
            btn_ellipse.BackColor = Color.YellowGreen;
            btn_ellipse.Cursor = Cursors.Hand;
            btn_ellipse.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_ellipse.FlatAppearance.MouseOverBackColor = Color.Green;
            btn_ellipse.FlatStyle = FlatStyle.Flat;
            btn_ellipse.ForeColor = Color.White;
            btn_ellipse.BackgroundImage = Properties.Resources.circle1;
            btn_ellipse.BackgroundImageLayout = ImageLayout.Zoom;
            btn_ellipse.Location = new Point(515, 55);
            btn_ellipse.Margin = new Padding(3, 4, 3, 4);
            btn_ellipse.Name = "btn_ellipse";
            btn_ellipse.Size = new Size(60, 60);
            btn_ellipse.TabIndex = 5;
            btn_ellipse.TextAlign = ContentAlignment.BottomCenter;
            btn_ellipse.UseVisualStyleBackColor = false;
            btn_ellipse.Click += btn_ellipse_Click;
            // 
            // btn_rect
            // 
            btn_rect.BackColor = Color.YellowGreen;
            btn_rect.Cursor = Cursors.Hand;
            btn_rect.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_rect.FlatAppearance.MouseOverBackColor = Color.Green;
            btn_rect.FlatStyle = FlatStyle.Flat;
            btn_rect.ForeColor = Color.White;
            btn_rect.BackgroundImage = Properties.Resources.rect;
            btn_rect.BackgroundImageLayout = ImageLayout.Zoom;
            btn_rect.Location = new Point(585, 55);
            btn_rect.Margin = new Padding(3, 4, 3, 4);
            btn_rect.Name = "btn_rect";
            btn_rect.Size = new Size(60, 60);
            btn_rect.TabIndex = 6;
            btn_rect.TextAlign = ContentAlignment.BottomCenter;
            btn_rect.UseVisualStyleBackColor = false;
            btn_rect.Click += btn_rect_Click;
            // 
            // btn_line
            // 
            btn_line.BackColor = Color.YellowGreen;
            btn_line.Cursor = Cursors.Hand;
            btn_line.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_line.FlatAppearance.MouseOverBackColor = Color.Green;
            btn_line.FlatStyle = FlatStyle.Flat;
            btn_line.ForeColor = Color.White;
            btn_line.BackgroundImage = Properties.Resources.line1;
            btn_line.BackgroundImageLayout = ImageLayout.Zoom;
            btn_line.Location = new Point(655, 55);
            btn_line.Margin = new Padding(3, 4, 3, 4);
            btn_line.Name = "btn_line";
            btn_line.Size = new Size(60, 60);
            btn_line.TabIndex = 7;
            btn_line.TextAlign = ContentAlignment.BottomCenter;
            btn_line.UseVisualStyleBackColor = false;
            btn_line.Click += btn_line_Click;
            // 
            // pic
            // 
            pic.BackColor = Color.White;
            pic.Location = new Point(10, 150);
            pic.Margin = new Padding(3, 4, 3, 4);
            pic.Name = "pic";
            pic.Size = new Size(914, 475);
            pic.TabIndex = 0;
            pic.TabStop = false;
            pic.Paint += pic_Paint;
            pic.MouseClick += pic_MouseClick;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            pic.MouseDown += UpdateLocation;
            pic.MouseMove += UpdateLocation;
            pic.MouseUp += UpdateLocation;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, themeToolStripMenuItem, spravkaToolStripMenuItem });
            menuStrip1.BackColor = Color.Beige;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(950, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clearToolStripMenuItem, openToolStripMenuItem, saveAsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(180, 22);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(180, 22);
            saveAsToolStripMenuItem.Text = "Save as";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customToolStripMenuItem, monochromelightToolStripMenuItem, monochromedarkToolStripMenuItem });
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(55, 20);
            themeToolStripMenuItem.Text = "Theme";
            // 
            // customToolStripMenuItem
            // 
            customToolStripMenuItem.Name = "customToolStripMenuItem";
            customToolStripMenuItem.Size = new Size(180, 22);
            customToolStripMenuItem.Text = "Custom";
            customToolStripMenuItem.Click += customToolStripMenuItem_Click;
            // 
            // monochromelightToolStripMenuItem
            // 
            monochromelightToolStripMenuItem.Name = "monochromelightToolStripMenuItem";
            monochromelightToolStripMenuItem.Size = new Size(180, 22);
            monochromelightToolStripMenuItem.Text = "Monochrome (light)";
            monochromelightToolStripMenuItem.Click += monochromelightToolStripMenuItem_Click;
            // 
            // monochromedarkToolStripMenuItem
            // 
            monochromedarkToolStripMenuItem.Name = "monochromedarkToolStripMenuItem";
            monochromedarkToolStripMenuItem.Size = new Size(180, 22);
            monochromedarkToolStripMenuItem.Text = "Monochrome (dark)";
            monochromedarkToolStripMenuItem.Click += monochromedarkToolStripMenuItem_Click;
            // 
            // spravkaToolStripMenuItem
            // 
            spravkaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutUsToolStripMenuItem });
            spravkaToolStripMenuItem.Name = "spravkaToolStripMenuItem";
            spravkaToolStripMenuItem.Size = new Size(60, 20);
            spravkaToolStripMenuItem.Text = "Help";
            // 
            // aboutUsToolStripMenuItem
            // 
            aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            aboutUsToolStripMenuItem.Size = new Size(180, 22);
            aboutUsToolStripMenuItem.Text = "About us";
            aboutUsToolStripMenuItem.Click += aboutUsToolStripMenuItem_Click;
            //
            // panel2
            // 
            panel2.BackColor = Color.YellowGreen;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1018);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(950, 25);
            panel2.TabIndex = 1;
            // 
            // Form1
            // 
            //AutoScaleDimensions = new SizeF(8F, 20F);
            //AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 700);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pic);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Paint 2.0";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)color_picker).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pic;
        private Button pic_color;
        private Button btn_color;
        private Button btn_fill;
        private Button btn_ellipse;
        private Button btn_rotate;
        private Button btn_transform;
        private Button btn_line;
        private Button btn_rect;
        private Panel panel3;
        private PictureBox color_picker;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem customToolStripMenuItem;
        private ToolStripMenuItem monochromelightToolStripMenuItem;
        private ToolStripMenuItem monochromedarkToolStripMenuItem;
        private ToolStripMenuItem spravkaToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
    }
}
