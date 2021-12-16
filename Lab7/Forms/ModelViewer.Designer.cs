
namespace Lab7
{
    partial class ModelViewer
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
            this.glControl1 = new OpenTK.GLControl();
            this.objComboBox = new System.Windows.Forms.ComboBox();
            this.mComboBox = new System.Windows.Forms.ComboBox();
            this.materialLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textureLabel = new System.Windows.Forms.Label();
            this.textureComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importobjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importmtlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleObjectModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sceneModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeLightSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteLightSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramsGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lightComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.paramsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(0, 67);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(800, 533);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            this.glControl1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.glControl1_Zoom);
            // 
            // objComboBox
            // 
            this.objComboBox.FormattingEnabled = true;
            this.objComboBox.Location = new System.Drawing.Point(62, 13);
            this.objComboBox.Name = "objComboBox";
            this.objComboBox.Size = new System.Drawing.Size(121, 21);
            this.objComboBox.TabIndex = 3;
            // 
            // mComboBox
            // 
            this.mComboBox.FormattingEnabled = true;
            this.mComboBox.Location = new System.Drawing.Point(239, 13);
            this.mComboBox.Name = "mComboBox";
            this.mComboBox.Size = new System.Drawing.Size(121, 21);
            this.mComboBox.TabIndex = 4;
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Location = new System.Drawing.Point(189, 16);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(44, 13);
            this.materialLabel.TabIndex = 5;
            this.materialLabel.Text = "Material";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Model ID";
            // 
            // textureLabel
            // 
            this.textureLabel.AutoSize = true;
            this.textureLabel.Location = new System.Drawing.Point(366, 16);
            this.textureLabel.Name = "textureLabel";
            this.textureLabel.Size = new System.Drawing.Size(43, 13);
            this.textureLabel.TabIndex = 8;
            this.textureLabel.Text = "Texture";
            // 
            // textureComboBox
            // 
            this.textureComboBox.DisplayMember = "(none)";
            this.textureComboBox.FormattingEnabled = true;
            this.textureComboBox.Location = new System.Drawing.Point(415, 13);
            this.textureComboBox.Name = "textureComboBox";
            this.textureComboBox.Size = new System.Drawing.Size(121, 21);
            this.textureComboBox.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modelToolStripMenuItem,
            this.modeToolStripMenuItem,
            this.lightToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modelToolStripMenuItem
            // 
            this.modelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importobjToolStripMenuItem,
            this.importmtlToolStripMenuItem,
            this.importImageToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.modelToolStripMenuItem.Name = "modelToolStripMenuItem";
            this.modelToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.modelToolStripMenuItem.Text = "File";
            this.modelToolStripMenuItem.Click += new System.EventHandler(this.modelToolStripMenuItem_Click);
            // 
            // importobjToolStripMenuItem
            // 
            this.importobjToolStripMenuItem.Name = "importobjToolStripMenuItem";
            this.importobjToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.importobjToolStripMenuItem.Text = "Import .obj";
            this.importobjToolStripMenuItem.Click += new System.EventHandler(this.importobjToolStripMenuItem_Click);
            // 
            // importmtlToolStripMenuItem
            // 
            this.importmtlToolStripMenuItem.Name = "importmtlToolStripMenuItem";
            this.importmtlToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.importmtlToolStripMenuItem.Text = "Import .mtl";
            this.importmtlToolStripMenuItem.Click += new System.EventHandler(this.importmtlToolStripMenuItem_Click);
            // 
            // importImageToolStripMenuItem
            // 
            this.importImageToolStripMenuItem.Name = "importImageToolStripMenuItem";
            this.importImageToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.importImageToolStripMenuItem.Text = "Import image";
            this.importImageToolStripMenuItem.Click += new System.EventHandler(this.importImageToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleObjectModeToolStripMenuItem,
            this.sceneModeToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // singleObjectModeToolStripMenuItem
            // 
            this.singleObjectModeToolStripMenuItem.CheckOnClick = true;
            this.singleObjectModeToolStripMenuItem.Name = "singleObjectModeToolStripMenuItem";
            this.singleObjectModeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.singleObjectModeToolStripMenuItem.Text = "Single Object Mode";
            this.singleObjectModeToolStripMenuItem.Click += new System.EventHandler(this.singleObjectModeToolStripMenuItem_Click);
            // 
            // sceneModeToolStripMenuItem
            // 
            this.sceneModeToolStripMenuItem.CheckOnClick = true;
            this.sceneModeToolStripMenuItem.Name = "sceneModeToolStripMenuItem";
            this.sceneModeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.sceneModeToolStripMenuItem.Text = "Scene Mode";
            this.sceneModeToolStripMenuItem.Click += new System.EventHandler(this.sceneModeToolStripMenuItem_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeLightSourceToolStripMenuItem,
            this.deleteLightSourceToolStripMenuItem});
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.lightToolStripMenuItem.Text = "Light";
            // 
            // makeLightSourceToolStripMenuItem
            // 
            this.makeLightSourceToolStripMenuItem.Name = "makeLightSourceToolStripMenuItem";
            this.makeLightSourceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.makeLightSourceToolStripMenuItem.Text = "Make light source";
            this.makeLightSourceToolStripMenuItem.Click += new System.EventHandler(this.makeLightSourceToolStripMenuItem_Click);
            // 
            // deleteLightSourceToolStripMenuItem
            // 
            this.deleteLightSourceToolStripMenuItem.Name = "deleteLightSourceToolStripMenuItem";
            this.deleteLightSourceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteLightSourceToolStripMenuItem.Text = "Delete light source";
            this.deleteLightSourceToolStripMenuItem.Click += new System.EventHandler(this.deleteLightSourceToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // paramsGroupBox
            // 
            this.paramsGroupBox.Controls.Add(this.label2);
            this.paramsGroupBox.Controls.Add(this.lightComboBox);
            this.paramsGroupBox.Controls.Add(this.label1);
            this.paramsGroupBox.Controls.Add(this.textureComboBox);
            this.paramsGroupBox.Controls.Add(this.objComboBox);
            this.paramsGroupBox.Controls.Add(this.textureLabel);
            this.paramsGroupBox.Controls.Add(this.materialLabel);
            this.paramsGroupBox.Controls.Add(this.mComboBox);
            this.paramsGroupBox.Location = new System.Drawing.Point(0, 23);
            this.paramsGroupBox.Name = "paramsGroupBox";
            this.paramsGroupBox.Size = new System.Drawing.Size(800, 38);
            this.paramsGroupBox.TabIndex = 11;
            this.paramsGroupBox.TabStop = false;
            this.paramsGroupBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Light";
            // 
            // lightComboBox
            // 
            this.lightComboBox.FormattingEnabled = true;
            this.lightComboBox.Location = new System.Drawing.Point(581, 13);
            this.lightComboBox.Name = "lightComboBox";
            this.lightComboBox.Size = new System.Drawing.Size(121, 21);
            this.lightComboBox.TabIndex = 11;
            // 
            // ModelViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.paramsGroupBox);
            this.Controls.Add(this.glControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ModelViewer";
            this.Text = "3DModelViewer";
            this.Load += new System.EventHandler(this.ModelViewer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.paramsGroupBox.ResumeLayout(false);
            this.paramsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.ComboBox objComboBox;
        private System.Windows.Forms.ComboBox mComboBox;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textureLabel;
        private System.Windows.Forms.ComboBox textureComboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importobjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importmtlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.GroupBox paramsGroupBox;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeLightSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteLightSourceToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox lightComboBox;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleObjectModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sceneModeToolStripMenuItem;
    }
}

