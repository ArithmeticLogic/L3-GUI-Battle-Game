namespace Battle_Game_but_GUI
{
    partial class Base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base));
            btnChooseMonster1 = new Button();
            btnChooseMonster2 = new Button();
            btnCancelMonsterSelect = new Button();
            iLPlayerMonster = new ImageList(components);
            SuspendLayout();
            // 
            // btnChooseMonster1
            // 
            btnChooseMonster1.Location = new Point(12, 12);
            btnChooseMonster1.Name = "btnChooseMonster1";
            btnChooseMonster1.Size = new Size(250, 250);
            btnChooseMonster1.TabIndex = 0;
            btnChooseMonster1.Text = "Igris";
            btnChooseMonster1.UseVisualStyleBackColor = true;
            btnChooseMonster1.Click += btnChooseMonster1_Click;
            // 
            // btnChooseMonster2
            // 
            btnChooseMonster2.Location = new Point(268, 12);
            btnChooseMonster2.Name = "btnChooseMonster2";
            btnChooseMonster2.Size = new Size(250, 250);
            btnChooseMonster2.TabIndex = 1;
            btnChooseMonster2.Text = "Aqua";
            btnChooseMonster2.UseVisualStyleBackColor = true;
            btnChooseMonster2.Click += btnChooseMonster2_Click;
            // 
            // btnCancelMonsterSelect
            // 
            btnCancelMonsterSelect.Location = new Point(12, 268);
            btnCancelMonsterSelect.Name = "btnCancelMonsterSelect";
            btnCancelMonsterSelect.Size = new Size(506, 50);
            btnCancelMonsterSelect.TabIndex = 2;
            btnCancelMonsterSelect.Text = "Cancel";
            btnCancelMonsterSelect.UseVisualStyleBackColor = true;
            btnCancelMonsterSelect.Click += btnCancelMonsterSelect_Click;
            // 
            // iLPlayerMonster
            // 
            iLPlayerMonster.ColorDepth = ColorDepth.Depth32Bit;
            iLPlayerMonster.ImageStream = (ImageListStreamer)resources.GetObject("iLPlayerMonster.ImageStream");
            iLPlayerMonster.TransparentColor = Color.Transparent;
            iLPlayerMonster.Images.SetKeyName(0, "Aqua");
            iLPlayerMonster.Images.SetKeyName(1, "Igris");
            // 
            // Base
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 327);
            Controls.Add(btnCancelMonsterSelect);
            Controls.Add(btnChooseMonster2);
            Controls.Add(btnChooseMonster1);
            Name = "Base";
            Text = "Base";
            Load += Base_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnChooseMonster1;
        private Button btnChooseMonster2;
        private Button btnCancelMonsterSelect;
        private ImageList iLPlayerMonster;
    }
}