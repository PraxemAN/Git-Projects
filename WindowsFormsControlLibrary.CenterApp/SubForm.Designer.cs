namespace WindowsFormsControlLibrary.CenterApp
{
    partial class SubForm
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
            this.buttonLeftArrow = new System.Windows.Forms.Button();
            this.textBoxLeftArrow = new System.Windows.Forms.TextBox();
            this.labelInstruct = new System.Windows.Forms.Label();
            this.buttonRightArrow = new System.Windows.Forms.Button();
            this.textBoxRightArrow = new System.Windows.Forms.TextBox();
            this.buttonUpArrow = new System.Windows.Forms.Button();
            this.textBoxUpArrow = new System.Windows.Forms.TextBox();
            this.buttonDownArrow = new System.Windows.Forms.Button();
            this.textBoxDownArrow = new System.Windows.Forms.TextBox();
            this.buttonAcceptChange = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLeftArrow
            // 
            this.buttonLeftArrow.Location = new System.Drawing.Point(13, 77);
            this.buttonLeftArrow.Name = "buttonLeftArrow";
            this.buttonLeftArrow.Size = new System.Drawing.Size(75, 23);
            this.buttonLeftArrow.TabIndex = 0;
            this.buttonLeftArrow.Text = "left";
            this.buttonLeftArrow.UseVisualStyleBackColor = true;
            this.buttonLeftArrow.Click += new System.EventHandler(this.ButtonLeftArrow_Click);
            // 
            // textBoxLeftArrow
            // 
            this.textBoxLeftArrow.Location = new System.Drawing.Point(13, 51);
            this.textBoxLeftArrow.Name = "textBoxLeftArrow";
            this.textBoxLeftArrow.Size = new System.Drawing.Size(75, 20);
            this.textBoxLeftArrow.TabIndex = 1;
            this.textBoxLeftArrow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelInstruct
            // 
            this.labelInstruct.AutoSize = true;
            this.labelInstruct.Location = new System.Drawing.Point(69, 0);
            this.labelInstruct.Name = "labelInstruct";
            this.labelInstruct.Size = new System.Drawing.Size(222, 13);
            this.labelInstruct.TabIndex = 2;
            this.labelInstruct.Text = "Adjust the Top-Left point for the main program";
            this.labelInstruct.Click += new System.EventHandler(this.LabelInstruct_Click);
            // 
            // buttonRightArrow
            // 
            this.buttonRightArrow.Location = new System.Drawing.Point(94, 77);
            this.buttonRightArrow.Name = "buttonRightArrow";
            this.buttonRightArrow.Size = new System.Drawing.Size(75, 23);
            this.buttonRightArrow.TabIndex = 3;
            this.buttonRightArrow.Text = "right";
            this.buttonRightArrow.UseVisualStyleBackColor = true;
            // 
            // textBoxRightArrow
            // 
            this.textBoxRightArrow.Location = new System.Drawing.Point(94, 51);
            this.textBoxRightArrow.Name = "textBoxRightArrow";
            this.textBoxRightArrow.Size = new System.Drawing.Size(75, 20);
            this.textBoxRightArrow.TabIndex = 4;
            this.textBoxRightArrow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonUpArrow
            // 
            this.buttonUpArrow.Location = new System.Drawing.Point(200, 77);
            this.buttonUpArrow.Name = "buttonUpArrow";
            this.buttonUpArrow.Size = new System.Drawing.Size(75, 23);
            this.buttonUpArrow.TabIndex = 5;
            this.buttonUpArrow.Text = "up";
            this.buttonUpArrow.UseVisualStyleBackColor = true;
            // 
            // textBoxUpArrow
            // 
            this.textBoxUpArrow.Location = new System.Drawing.Point(200, 51);
            this.textBoxUpArrow.Name = "textBoxUpArrow";
            this.textBoxUpArrow.Size = new System.Drawing.Size(75, 20);
            this.textBoxUpArrow.TabIndex = 6;
            this.textBoxUpArrow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonDownArrow
            // 
            this.buttonDownArrow.Location = new System.Drawing.Point(281, 77);
            this.buttonDownArrow.Name = "buttonDownArrow";
            this.buttonDownArrow.Size = new System.Drawing.Size(75, 23);
            this.buttonDownArrow.TabIndex = 7;
            this.buttonDownArrow.Text = "down";
            this.buttonDownArrow.UseVisualStyleBackColor = true;
            // 
            // textBoxDownArrow
            // 
            this.textBoxDownArrow.Location = new System.Drawing.Point(281, 51);
            this.textBoxDownArrow.Name = "textBoxDownArrow";
            this.textBoxDownArrow.Size = new System.Drawing.Size(75, 20);
            this.textBoxDownArrow.TabIndex = 8;
            this.textBoxDownArrow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAcceptChange
            // 
            this.buttonAcceptChange.Location = new System.Drawing.Point(149, 22);
            this.buttonAcceptChange.Name = "buttonAcceptChange";
            this.buttonAcceptChange.Size = new System.Drawing.Size(75, 23);
            this.buttonAcceptChange.TabIndex = 9;
            this.buttonAcceptChange.Text = "Accept";
            this.buttonAcceptChange.UseVisualStyleBackColor = true;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(281, 22);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(75, 23);
            this.buttonDone.TabIndex = 10;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.ButtonDone_Click);
            // 
            // SubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 112);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonAcceptChange);
            this.Controls.Add(this.textBoxDownArrow);
            this.Controls.Add(this.buttonDownArrow);
            this.Controls.Add(this.textBoxUpArrow);
            this.Controls.Add(this.buttonUpArrow);
            this.Controls.Add(this.textBoxRightArrow);
            this.Controls.Add(this.buttonRightArrow);
            this.Controls.Add(this.labelInstruct);
            this.Controls.Add(this.textBoxLeftArrow);
            this.Controls.Add(this.buttonLeftArrow);
            this.Name = "SubForm";
            this.Text = "SubForm";
            this.Load += new System.EventHandler(this.SubForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLeftArrow;
        private System.Windows.Forms.TextBox textBoxLeftArrow;
        private System.Windows.Forms.Label labelInstruct;
        private System.Windows.Forms.Button buttonRightArrow;
        private System.Windows.Forms.TextBox textBoxRightArrow;
        private System.Windows.Forms.Button buttonUpArrow;
        private System.Windows.Forms.TextBox textBoxUpArrow;
        private System.Windows.Forms.Button buttonDownArrow;
        private System.Windows.Forms.TextBox textBoxDownArrow;
        private System.Windows.Forms.Button buttonAcceptChange;
        private System.Windows.Forms.Button buttonDone;
    }
}