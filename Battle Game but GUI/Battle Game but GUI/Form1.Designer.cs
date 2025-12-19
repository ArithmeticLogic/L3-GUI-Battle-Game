namespace Battle_Game_but_GUI
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
            startGameBtn = new Button();
            baseBtn = new Button();
            openWorldBtn = new Button();
            SuspendLayout();
            // 
            // startGameBtn
            // 
            startGameBtn.Location = new Point(191, 154);
            startGameBtn.Name = "startGameBtn";
            startGameBtn.Size = new Size(251, 96);
            startGameBtn.TabIndex = 1;
            startGameBtn.Text = "Start Game";
            startGameBtn.UseVisualStyleBackColor = true;
            startGameBtn.Visible = false;
            startGameBtn.Click += startGameBtn_Click;
            // 
            // baseBtn
            // 
            baseBtn.Location = new Point(12, 12);
            baseBtn.Name = "baseBtn";
            baseBtn.Size = new Size(300, 380);
            baseBtn.TabIndex = 4;
            baseBtn.Text = "Base";
            baseBtn.UseVisualStyleBackColor = true;
            baseBtn.Visible = false;
            baseBtn.Click += baseBtn_Click;
            // 
            // openWorldBtn
            // 
            openWorldBtn.Location = new Point(322, 12);
            openWorldBtn.Name = "openWorldBtn";
            openWorldBtn.Size = new Size(300, 380);
            openWorldBtn.TabIndex = 3;
            openWorldBtn.Text = "Open World";
            openWorldBtn.UseVisualStyleBackColor = true;
            openWorldBtn.Visible = false;
            openWorldBtn.Click += openWorldBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 404);
            Controls.Add(startGameBtn);
            Controls.Add(baseBtn);
            Controls.Add(openWorldBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button startGameBtn;
        private Button baseBtn;
        private Button openWorldBtn;
    }
}
