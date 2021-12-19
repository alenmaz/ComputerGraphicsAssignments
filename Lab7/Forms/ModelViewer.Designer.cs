
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
            this.sceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeLightSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteLightSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sphereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pyramidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cylinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelExampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greekTempleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lightComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sceneComboBox = new System.Windows.Forms.ComboBox();
            this.drawAllCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.RGBBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.RGBBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.RGBBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BigRBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sizeZBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sizeYBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sizeXBox = new System.Windows.Forms.TextBox();
            this.ZLabel = new System.Windows.Forms.Label();
            this.zTextBox = new System.Windows.Forms.TextBox();
            this.YLabel = new System.Windows.Forms.Label();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(0, 27);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(555, 573);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            this.glControl1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.glControl1_Zoom);
            // 
            // objComboBox
            // 
            this.objComboBox.FormattingEnabled = true;
            this.objComboBox.Location = new System.Drawing.Point(10, 75);
            this.objComboBox.Name = "objComboBox";
            this.objComboBox.Size = new System.Drawing.Size(121, 21);
            this.objComboBox.TabIndex = 3;
            // 
            // mComboBox
            // 
            this.mComboBox.FormattingEnabled = true;
            this.mComboBox.Location = new System.Drawing.Point(10, 115);
            this.mComboBox.Name = "mComboBox";
            this.mComboBox.Size = new System.Drawing.Size(121, 21);
            this.mComboBox.TabIndex = 4;
            this.mComboBox.SelectedIndexChanged += new System.EventHandler(this.mComboBox_SelectedIndexChanged);
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Location = new System.Drawing.Point(7, 99);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(44, 13);
            this.materialLabel.TabIndex = 5;
            this.materialLabel.Text = "Material";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Model";
            // 
            // textureLabel
            // 
            this.textureLabel.AutoSize = true;
            this.textureLabel.Location = new System.Drawing.Point(7, 139);
            this.textureLabel.Name = "textureLabel";
            this.textureLabel.Size = new System.Drawing.Size(43, 13);
            this.textureLabel.TabIndex = 8;
            this.textureLabel.Text = "Texture";
            // 
            // textureComboBox
            // 
            this.textureComboBox.DisplayMember = "(none)";
            this.textureComboBox.FormattingEnabled = true;
            this.textureComboBox.Location = new System.Drawing.Point(10, 155);
            this.textureComboBox.Name = "textureComboBox";
            this.textureComboBox.Size = new System.Drawing.Size(121, 21);
            this.textureComboBox.TabIndex = 9;
            this.textureComboBox.SelectedIndexChanged += new System.EventHandler(this.textureComboBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modelToolStripMenuItem,
            this.sceneToolStripMenuItem,
            this.lightToolStripMenuItem,
            this.addToolStripMenuItem,
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
            // sceneToolStripMenuItem
            // 
            this.sceneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSceneToolStripMenuItem});
            this.sceneToolStripMenuItem.Name = "sceneToolStripMenuItem";
            this.sceneToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.sceneToolStripMenuItem.Text = "Scene";
            // 
            // newSceneToolStripMenuItem
            // 
            this.newSceneToolStripMenuItem.Name = "newSceneToolStripMenuItem";
            this.newSceneToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.newSceneToolStripMenuItem.Text = "New scene";
            this.newSceneToolStripMenuItem.Click += new System.EventHandler(this.newSceneToolStripMenuItem_Click);
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
            this.makeLightSourceToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.makeLightSourceToolStripMenuItem.Text = "Make light source";
            this.makeLightSourceToolStripMenuItem.Click += new System.EventHandler(this.makeLightSourceToolStripMenuItem_Click);
            // 
            // deleteLightSourceToolStripMenuItem
            // 
            this.deleteLightSourceToolStripMenuItem.Name = "deleteLightSourceToolStripMenuItem";
            this.deleteLightSourceToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.deleteLightSourceToolStripMenuItem.Text = "Delete light source";
            this.deleteLightSourceToolStripMenuItem.Click += new System.EventHandler(this.deleteLightSourceToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cubeToolStripMenuItem,
            this.sphereToolStripMenuItem,
            this.pyramidToolStripMenuItem,
            this.torusToolStripMenuItem,
            this.conusToolStripMenuItem,
            this.cylinderToolStripMenuItem,
            this.modelExampleToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.addToolStripMenuItem.Text = "Add mesh...";
            // 
            // cubeToolStripMenuItem
            // 
            this.cubeToolStripMenuItem.Name = "cubeToolStripMenuItem";
            this.cubeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.cubeToolStripMenuItem.Text = "Cube";
            this.cubeToolStripMenuItem.Click += new System.EventHandler(this.cubeToolStripMenuItem_Click);
            // 
            // sphereToolStripMenuItem
            // 
            this.sphereToolStripMenuItem.Name = "sphereToolStripMenuItem";
            this.sphereToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.sphereToolStripMenuItem.Text = "Sphere";
            this.sphereToolStripMenuItem.Click += new System.EventHandler(this.sphereToolStripMenuItem_Click);
            // 
            // pyramidToolStripMenuItem
            // 
            this.pyramidToolStripMenuItem.Name = "pyramidToolStripMenuItem";
            this.pyramidToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.pyramidToolStripMenuItem.Text = "Pyramid";
            this.pyramidToolStripMenuItem.Click += new System.EventHandler(this.pyramidToolStripMenuItem_Click);
            // 
            // torusToolStripMenuItem
            // 
            this.torusToolStripMenuItem.Name = "torusToolStripMenuItem";
            this.torusToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.torusToolStripMenuItem.Text = "Torus";
            this.torusToolStripMenuItem.Click += new System.EventHandler(this.torusToolStripMenuItem_Click);
            // 
            // conusToolStripMenuItem
            // 
            this.conusToolStripMenuItem.Name = "conusToolStripMenuItem";
            this.conusToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.conusToolStripMenuItem.Text = "Conus";
            this.conusToolStripMenuItem.Click += new System.EventHandler(this.conusToolStripMenuItem_Click);
            // 
            // cylinderToolStripMenuItem
            // 
            this.cylinderToolStripMenuItem.Name = "cylinderToolStripMenuItem";
            this.cylinderToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.cylinderToolStripMenuItem.Text = "Cylinder";
            this.cylinderToolStripMenuItem.Click += new System.EventHandler(this.cylinderToolStripMenuItem_Click);
            // 
            // modelExampleToolStripMenuItem
            // 
            this.modelExampleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greekTempleToolStripMenuItem});
            this.modelExampleToolStripMenuItem.Name = "modelExampleToolStripMenuItem";
            this.modelExampleToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.modelExampleToolStripMenuItem.Text = "Model Example";
            // 
            // greekTempleToolStripMenuItem
            // 
            this.greekTempleToolStripMenuItem.Name = "greekTempleToolStripMenuItem";
            this.greekTempleToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.greekTempleToolStripMenuItem.Text = "Greek Temple";
            this.greekTempleToolStripMenuItem.Click += new System.EventHandler(this.greekTempleToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Light";
            // 
            // lightComboBox
            // 
            this.lightComboBox.FormattingEnabled = true;
            this.lightComboBox.Location = new System.Drawing.Point(10, 195);
            this.lightComboBox.Name = "lightComboBox";
            this.lightComboBox.Size = new System.Drawing.Size(121, 21);
            this.lightComboBox.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sceneComboBox);
            this.groupBox1.Controls.Add(this.drawAllCheckBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lightComboBox);
            this.groupBox1.Controls.Add(this.objComboBox);
            this.groupBox1.Controls.Add(this.textureLabel);
            this.groupBox1.Controls.Add(this.textureComboBox);
            this.groupBox1.Controls.Add(this.materialLabel);
            this.groupBox1.Controls.Add(this.mComboBox);
            this.groupBox1.Location = new System.Drawing.Point(561, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 243);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // sceneComboBox
            // 
            this.sceneComboBox.FormattingEnabled = true;
            this.sceneComboBox.Location = new System.Drawing.Point(94, 26);
            this.sceneComboBox.Name = "sceneComboBox";
            this.sceneComboBox.Size = new System.Drawing.Size(121, 21);
            this.sceneComboBox.TabIndex = 16;
            this.sceneComboBox.SelectedIndexChanged += new System.EventHandler(this.sceneComboBox_SelectedIndexChanged);
            // 
            // drawAllCheckBox
            // 
            this.drawAllCheckBox.AutoSize = true;
            this.drawAllCheckBox.Location = new System.Drawing.Point(10, 28);
            this.drawAllCheckBox.Name = "drawAllCheckBox";
            this.drawAllCheckBox.Size = new System.Drawing.Size(64, 17);
            this.drawAllCheckBox.TabIndex = 13;
            this.drawAllCheckBox.Text = "Draw all";
            this.drawAllCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.RGBBox3);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.RGBBox2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.RGBBox1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.BigRBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.sizeZBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.sizeYBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.sizeXBox);
            this.groupBox2.Controls.Add(this.ZLabel);
            this.groupBox2.Controls.Add(this.zTextBox);
            this.groupBox2.Controls.Add(this.YLabel);
            this.groupBox2.Controls.Add(this.yTextBox);
            this.groupBox2.Controls.Add(this.xLabel);
            this.groupBox2.Controls.Add(this.xTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(561, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 324);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Object spawner settings";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "B";
            // 
            // RGBBox3
            // 
            this.RGBBox3.Location = new System.Drawing.Point(30, 298);
            this.RGBBox3.Name = "RGBBox3";
            this.RGBBox3.Size = new System.Drawing.Size(34, 20);
            this.RGBBox3.TabIndex = 23;
            this.RGBBox3.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "G";
            // 
            // RGBBox2
            // 
            this.RGBBox2.Location = new System.Drawing.Point(30, 272);
            this.RGBBox2.Name = "RGBBox2";
            this.RGBBox2.Size = new System.Drawing.Size(34, 20);
            this.RGBBox2.TabIndex = 21;
            this.RGBBox2.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 249);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "R";
            // 
            // RGBBox1
            // 
            this.RGBBox1.Location = new System.Drawing.Point(30, 246);
            this.RGBBox1.Name = "RGBBox1";
            this.RGBBox1.Size = new System.Drawing.Size(34, 20);
            this.RGBBox1.TabIndex = 19;
            this.RGBBox1.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Color";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Properties";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "R";
            // 
            // BigRBox
            // 
            this.BigRBox.Location = new System.Drawing.Point(193, 173);
            this.BigRBox.Name = "BigRBox";
            this.BigRBox.Size = new System.Drawing.Size(34, 20);
            this.BigRBox.TabIndex = 15;
            this.BigRBox.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "r";
            // 
            // rBox
            // 
            this.rBox.Location = new System.Drawing.Point(193, 147);
            this.rBox.Name = "rBox";
            this.rBox.Size = new System.Drawing.Size(34, 20);
            this.rBox.TabIndex = 13;
            this.rBox.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "sizeZ";
            // 
            // sizeZBox
            // 
            this.sizeZBox.Location = new System.Drawing.Point(48, 203);
            this.sizeZBox.Name = "sizeZBox";
            this.sizeZBox.Size = new System.Drawing.Size(34, 20);
            this.sizeZBox.TabIndex = 11;
            this.sizeZBox.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "sizeY";
            // 
            // sizeYBox
            // 
            this.sizeYBox.Location = new System.Drawing.Point(48, 177);
            this.sizeYBox.Name = "sizeYBox";
            this.sizeYBox.Size = new System.Drawing.Size(34, 20);
            this.sizeYBox.TabIndex = 9;
            this.sizeYBox.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "sizeX";
            // 
            // sizeXBox
            // 
            this.sizeXBox.Location = new System.Drawing.Point(48, 151);
            this.sizeXBox.Name = "sizeXBox";
            this.sizeXBox.Size = new System.Drawing.Size(34, 20);
            this.sizeXBox.TabIndex = 7;
            this.sizeXBox.Text = "1";
            // 
            // ZLabel
            // 
            this.ZLabel.AutoSize = true;
            this.ZLabel.Location = new System.Drawing.Point(10, 97);
            this.ZLabel.Name = "ZLabel";
            this.ZLabel.Size = new System.Drawing.Size(14, 13);
            this.ZLabel.TabIndex = 6;
            this.ZLabel.Text = "Z";
            // 
            // zTextBox
            // 
            this.zTextBox.Location = new System.Drawing.Point(30, 94);
            this.zTextBox.Name = "zTextBox";
            this.zTextBox.Size = new System.Drawing.Size(34, 20);
            this.zTextBox.TabIndex = 5;
            this.zTextBox.Text = "0";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(10, 71);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(14, 13);
            this.YLabel.TabIndex = 4;
            this.YLabel.Text = "Y";
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(30, 68);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(34, 20);
            this.yTextBox.TabIndex = 3;
            this.yTextBox.Text = "0";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(10, 45);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(14, 13);
            this.xLabel.TabIndex = 2;
            this.xLabel.Text = "X";
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(30, 42);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(34, 20);
            this.xTextBox.TabIndex = 1;
            this.xTextBox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pivot point";
            // 
            // ModelViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.glControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ModelViewer";
            this.Text = "3DModelViewer";
            this.Load += new System.EventHandler(this.ModelViewer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeLightSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteLightSourceToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox lightComboBox;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sphereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pyramidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cylinderToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ZLabel;
        private System.Windows.Forms.TextBox zTextBox;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sizeZBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sizeYBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sizeXBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BigRBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rBox;
        private System.Windows.Forms.CheckBox drawAllCheckBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox RGBBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox RGBBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox RGBBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem modelExampleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greekTempleToolStripMenuItem;
        private System.Windows.Forms.ComboBox sceneComboBox;
        private System.Windows.Forms.ToolStripMenuItem sceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSceneToolStripMenuItem;
    }
}

