namespace Battle_Game_but_GUI
{
    partial class OpenWorld
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenWorld));
            btnRun = new Button();
            btnAttack = new Button();
            pbPlayerMonster = new PictureBox();
            pbEnemyMonster = new PictureBox();
            iLEnemyMonster = new ImageList(components);
            iLPlayerMonster = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pbPlayerMonster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEnemyMonster).BeginInit();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Location = new Point(12, 268);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(120, 50);
            btnRun.TabIndex = 3;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // btnAttack
            // 
            btnAttack.Location = new Point(142, 268);
            btnAttack.Name = "btnAttack";
            btnAttack.Size = new Size(120, 50);
            btnAttack.TabIndex = 4;
            btnAttack.Text = "Attack";
            btnAttack.UseVisualStyleBackColor = true;
            btnAttack.Click += btnAttack_Click;
            // 
            // pbPlayerMonster
            // 
            pbPlayerMonster.Location = new Point(12, 12);
            pbPlayerMonster.Name = "pbPlayerMonster";
            pbPlayerMonster.Size = new Size(250, 250);
            pbPlayerMonster.TabIndex = 6;
            pbPlayerMonster.TabStop = false;
            // 
            // pbEnemyMonster
            // 
            pbEnemyMonster.Location = new Point(321, 12);
            pbEnemyMonster.Name = "pbEnemyMonster";
            pbEnemyMonster.Size = new Size(250, 250);
            pbEnemyMonster.TabIndex = 7;
            pbEnemyMonster.TabStop = false;
            // 
            // iLEnemyMonster
            // 
            iLEnemyMonster.ColorDepth = ColorDepth.Depth32Bit;
            iLEnemyMonster.ImageStream = (ImageListStreamer)resources.GetObject("iLEnemyMonster.ImageStream");
            iLEnemyMonster.TransparentColor = Color.Transparent;
            iLEnemyMonster.Images.SetKeyName(0, "Goblin");
            iLEnemyMonster.Images.SetKeyName(1, "ElderBlackDragonGod");
            iLEnemyMonster.Images.SetKeyName(2, "Slime");
            // 
            // iLPlayerMonster
            // 
            iLPlayerMonster.ColorDepth = ColorDepth.Depth32Bit;
            iLPlayerMonster.ImageStream = (ImageListStreamer)resources.GetObject("iLPlayerMonster.ImageStream");
            iLPlayerMonster.TransparentColor = Color.Transparent;
            iLPlayerMonster.Images.SetKeyName(0, "Igris");
            iLPlayerMonster.Images.SetKeyName(1, "Aqua");
            // 
            // OpenWorld
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 331);
            Controls.Add(pbEnemyMonster);
            Controls.Add(pbPlayerMonster);
            Controls.Add(btnAttack);
            Controls.Add(btnRun);
            Name = "OpenWorld";
            Text = "OpenWorld";
            Load += OpenWorld_Load;
            ((System.ComponentModel.ISupportInitialize)pbPlayerMonster).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEnemyMonster).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMonsterSlime;
        private Button btnMonsterGoblin;
        private Button btnRun;
        private Button btnAttack;
        private PictureBox pbPlayerMonster;
        private PictureBox pbEnemyMonster;
        private ImageList iLEnemyMonster;
        private ImageList iLPlayerMonster;
    }
}