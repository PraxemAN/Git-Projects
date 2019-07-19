namespace WindowsFormsControlLibrary.CenterApp
{
    partial class FormWindow
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWindow));
            this.textAppSelect = new System.Windows.Forms.TextBox();
            this.buttonCenter = new System.Windows.Forms.Button();
            this.labelExplanation = new System.Windows.Forms.Label();
            this.buttonArrowRight = new System.Windows.Forms.Button();
            this.textBoxArrowRight = new System.Windows.Forms.TextBox();
            this.buttonArrowUp = new System.Windows.Forms.Button();
            this.textBoxArrowUp = new System.Windows.Forms.TextBox();
            this.buttonArrowLeft = new System.Windows.Forms.Button();
            this.textBoxArrowLeft = new System.Windows.Forms.TextBox();
            this.buttonArrowDown = new System.Windows.Forms.Button();
            this.textBoxArrowDown = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.cornerAdjustToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDelAppTB = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textAppSelect
            // 
            this.textAppSelect.Location = new System.Drawing.Point(28, 57);
            this.textAppSelect.Name = "textAppSelect";
            this.textAppSelect.Size = new System.Drawing.Size(295, 20);
            this.textAppSelect.TabIndex = 0;
            this.textAppSelect.Text = "Enter program name here:";
            this.textAppSelect.TextChanged += new System.EventHandler(this.textAppSelect_TextChanged);
            // 
            // buttonCenter
            // 
            this.buttonCenter.Location = new System.Drawing.Point(162, 83);
            this.buttonCenter.Name = "buttonCenter";
            this.buttonCenter.Size = new System.Drawing.Size(75, 23);
            this.buttonCenter.TabIndex = 1;
            this.buttonCenter.Text = "Confirm";
            this.buttonCenter.UseVisualStyleBackColor = true;
            this.buttonCenter.Click += new System.EventHandler(this.ButtonCenter_Click);
            // 
            // labelExplanation
            // 
            this.labelExplanation.AutoSize = true;
            this.labelExplanation.Location = new System.Drawing.Point(124, 25);
            this.labelExplanation.Name = "labelExplanation";
            this.labelExplanation.Size = new System.Drawing.Size(149, 13);
            this.labelExplanation.TabIndex = 2;
            this.labelExplanation.Text = "Window Centering Application";
            this.labelExplanation.Click += new System.EventHandler(this.LabelExplanation_Click);
            // 
            // buttonArrowRight
            // 
            this.buttonArrowRight.Location = new System.Drawing.Point(93, 138);
            this.buttonArrowRight.Name = "buttonArrowRight";
            this.buttonArrowRight.Size = new System.Drawing.Size(75, 23);
            this.buttonArrowRight.TabIndex = 3;
            this.buttonArrowRight.Text = "right";
            this.buttonArrowRight.UseVisualStyleBackColor = true;
            this.buttonArrowRight.Click += new System.EventHandler(this.ButtonArrowRight_Click);
            // 
            // textBoxArrowRight
            // 
            this.textBoxArrowRight.Location = new System.Drawing.Point(93, 112);
            this.textBoxArrowRight.Name = "textBoxArrowRight";
            this.textBoxArrowRight.Size = new System.Drawing.Size(75, 20);
            this.textBoxArrowRight.TabIndex = 4;
            this.textBoxArrowRight.Text = "0";
            this.textBoxArrowRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxArrowRight.TextChanged += new System.EventHandler(this.TextBoxArrowRight_TextChanged);
            // 
            // buttonArrowUp
            // 
            this.buttonArrowUp.Location = new System.Drawing.Point(227, 138);
            this.buttonArrowUp.Name = "buttonArrowUp";
            this.buttonArrowUp.Size = new System.Drawing.Size(75, 23);
            this.buttonArrowUp.TabIndex = 5;
            this.buttonArrowUp.Text = "up";
            this.buttonArrowUp.UseVisualStyleBackColor = true;
            this.buttonArrowUp.Click += new System.EventHandler(this.ButtonArrowUp_Click);
            // 
            // textBoxArrowUp
            // 
            this.textBoxArrowUp.Location = new System.Drawing.Point(227, 112);
            this.textBoxArrowUp.Name = "textBoxArrowUp";
            this.textBoxArrowUp.Size = new System.Drawing.Size(75, 20);
            this.textBoxArrowUp.TabIndex = 6;
            this.textBoxArrowUp.Text = "0";
            this.textBoxArrowUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonArrowLeft
            // 
            this.buttonArrowLeft.Location = new System.Drawing.Point(11, 138);
            this.buttonArrowLeft.Name = "buttonArrowLeft";
            this.buttonArrowLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonArrowLeft.TabIndex = 7;
            this.buttonArrowLeft.Text = "left";
            this.buttonArrowLeft.UseVisualStyleBackColor = true;
            this.buttonArrowLeft.Click += new System.EventHandler(this.ButtonArrowLeft_Click);
            // 
            // textBoxArrowLeft
            // 
            this.textBoxArrowLeft.Location = new System.Drawing.Point(11, 112);
            this.textBoxArrowLeft.Name = "textBoxArrowLeft";
            this.textBoxArrowLeft.Size = new System.Drawing.Size(75, 20);
            this.textBoxArrowLeft.TabIndex = 8;
            this.textBoxArrowLeft.Text = "0";
            this.textBoxArrowLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxArrowLeft.TextChanged += new System.EventHandler(this.TextBoxArrowLeft_TextChanged);
            // 
            // buttonArrowDown
            // 
            this.buttonArrowDown.Location = new System.Drawing.Point(308, 138);
            this.buttonArrowDown.Name = "buttonArrowDown";
            this.buttonArrowDown.Size = new System.Drawing.Size(75, 23);
            this.buttonArrowDown.TabIndex = 9;
            this.buttonArrowDown.Text = "down";
            this.buttonArrowDown.UseVisualStyleBackColor = true;
            this.buttonArrowDown.Click += new System.EventHandler(this.ButtonArrowDown_Click);
            // 
            // textBoxArrowDown
            // 
            this.textBoxArrowDown.Location = new System.Drawing.Point(308, 112);
            this.textBoxArrowDown.Name = "textBoxArrowDown";
            this.textBoxArrowDown.Size = new System.Drawing.Size(74, 20);
            this.textBoxArrowDown.TabIndex = 10;
            this.textBoxArrowDown.Text = "0";
            this.textBoxArrowDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(392, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cornerAdjustToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // cornerAdjustToolStripMenuItem
            // 
            this.cornerAdjustToolStripMenuItem.Name = "cornerAdjustToolStripMenuItem";
            this.cornerAdjustToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cornerAdjustToolStripMenuItem.Text = "Starting Point Adjust";
            this.cornerAdjustToolStripMenuItem.Click += new System.EventHandler(this.CornerAdjustToolStripMenuItem_Click);
            // 
            // buttonDelAppTB
            // 
            this.buttonDelAppTB.Location = new System.Drawing.Point(329, 57);
            this.buttonDelAppTB.Name = "buttonDelAppTB";
            this.buttonDelAppTB.Size = new System.Drawing.Size(31, 20);
            this.buttonDelAppTB.TabIndex = 12;
            this.buttonDelAppTB.Text = "del";
            this.buttonDelAppTB.UseVisualStyleBackColor = true;
            this.buttonDelAppTB.Click += new System.EventHandler(this.ButtonDelAppTB_Click);
            // 
            // FormWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelAppTB);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBoxArrowDown);
            this.Controls.Add(this.buttonArrowDown);
            this.Controls.Add(this.textBoxArrowLeft);
            this.Controls.Add(this.buttonArrowLeft);
            this.Controls.Add(this.textBoxArrowUp);
            this.Controls.Add(this.buttonArrowUp);
            this.Controls.Add(this.textBoxArrowRight);
            this.Controls.Add(this.buttonArrowRight);
            this.Controls.Add(this.labelExplanation);
            this.Controls.Add(this.buttonCenter);
            this.Controls.Add(this.textAppSelect);
            this.Name = "FormWindow";
            this.Size = new System.Drawing.Size(392, 181);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textAppSelect;
        private System.Windows.Forms.Button buttonCenter;
        private System.Windows.Forms.Label labelExplanation;
        private System.Windows.Forms.Button buttonArrowRight;
        private System.Windows.Forms.TextBox textBoxArrowRight;
        private System.Windows.Forms.Button buttonArrowUp;
        private System.Windows.Forms.TextBox textBoxArrowUp;
        private System.Windows.Forms.Button buttonArrowLeft;
        private System.Windows.Forms.TextBox textBoxArrowLeft;
        private System.Windows.Forms.Button buttonArrowDown;
        private System.Windows.Forms.TextBox textBoxArrowDown;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem cornerAdjustToolStripMenuItem;
        private System.Windows.Forms.Button buttonDelAppTB;
    }
}
