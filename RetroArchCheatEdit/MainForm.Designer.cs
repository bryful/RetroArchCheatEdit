namespace RetroArchCheatEdit
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			tbDes = new TextBox();
			btnAdd = new Button();
			btnUpdate = new Button();
			btnUp = new Button();
			btnDown = new Button();
			btnDelete = new Button();
			tbCode = new TextBox();
			cheatListbox1 = new CheatListbox();
			cbEnable = new CheckBox();
			menuStrip1 = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			openToolStripMenuItem = new ToolStripMenuItem();
			saveToolStripMenuItem = new ToolStripMenuItem();
			saveAsToolStripMenuItem = new ToolStripMenuItem();
			quitToolStripMenuItem = new ToolStripMenuItem();
			splitContainer1 = new SplitContainer();
			pictureBox1 = new PictureBox();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// tbDes
			// 
			tbDes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbDes.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			tbDes.Location = new Point(13, 72);
			tbDes.Name = "tbDes";
			tbDes.Size = new Size(334, 29);
			tbDes.TabIndex = 3;
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(13, 14);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(57, 45);
			btnAdd.TabIndex = 0;
			btnAdd.Text = "Add";
			btnAdd.UseVisualStyleBackColor = true;
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(76, 14);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(53, 45);
			btnUpdate.TabIndex = 1;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = true;
			// 
			// btnUp
			// 
			btnUp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnUp.Location = new Point(179, 14);
			btnUp.Name = "btnUp";
			btnUp.Size = new Size(51, 45);
			btnUp.TabIndex = 1;
			btnUp.Text = "Up";
			btnUp.UseVisualStyleBackColor = true;
			// 
			// btnDown
			// 
			btnDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnDown.Location = new Point(236, 14);
			btnDown.Name = "btnDown";
			btnDown.Size = new Size(51, 45);
			btnDown.TabIndex = 2;
			btnDown.Text = "Down";
			btnDown.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(82, 10);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(53, 49);
			btnDelete.TabIndex = 0;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			// 
			// tbCode
			// 
			tbCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tbCode.Font = new Font("源ノ角ゴシック Code JP R", 12F, FontStyle.Regular, GraphicsUnit.Point);
			tbCode.Location = new Point(13, 108);
			tbCode.Multiline = true;
			tbCode.Name = "tbCode";
			tbCode.ScrollBars = ScrollBars.Vertical;
			tbCode.Size = new Size(351, 346);
			tbCode.TabIndex = 4;
			// 
			// cheatListbox1
			// 
			cheatListbox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			cheatListbox1.CodeTextBox = tbCode;
			cheatListbox1.DesTextBox = tbDes;
			cheatListbox1.EnableCheckBox = cbEnable;
			cheatListbox1.Font = new Font("源ノ角ゴシック Code JP R", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
			cheatListbox1.FormattingEnabled = true;
			cheatListbox1.IntegralHeight = false;
			cheatListbox1.ItemHeight = 17;
			cheatListbox1.Location = new Point(12, 72);
			cheatListbox1.Name = "cheatListbox1";
			cheatListbox1.ScrollAlwaysVisible = true;
			cheatListbox1.Size = new Size(294, 382);
			cheatListbox1.TabIndex = 3;
			// 
			// cbEnable
			// 
			cbEnable.AutoSize = true;
			cbEnable.Location = new Point(135, 40);
			cbEnable.Name = "cbEnable";
			cbEnable.Size = new Size(61, 19);
			cbEnable.TabIndex = 2;
			cbEnable.Text = "Enable";
			cbEnable.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(701, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, quitToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(37, 20);
			fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			openToolStripMenuItem.Name = "openToolStripMenuItem";
			openToolStripMenuItem.Size = new Size(111, 22);
			openToolStripMenuItem.Text = "Open";
			// 
			// saveToolStripMenuItem
			// 
			saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			saveToolStripMenuItem.Size = new Size(111, 22);
			saveToolStripMenuItem.Text = "Save";
			// 
			// saveAsToolStripMenuItem
			// 
			saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			saveAsToolStripMenuItem.Size = new Size(111, 22);
			saveAsToolStripMenuItem.Text = "SaveAs";
			// 
			// quitToolStripMenuItem
			// 
			quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			quitToolStripMenuItem.Size = new Size(111, 22);
			quitToolStripMenuItem.Text = "Quit";
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 24);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(pictureBox1);
			splitContainer1.Panel1.Controls.Add(cheatListbox1);
			splitContainer1.Panel1.Controls.Add(btnUp);
			splitContainer1.Panel1.Controls.Add(btnDown);
			splitContainer1.Panel1.Controls.Add(btnDelete);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(cbEnable);
			splitContainer1.Panel2.Controls.Add(tbCode);
			splitContainer1.Panel2.Controls.Add(tbDes);
			splitContainer1.Panel2.Controls.Add(btnAdd);
			splitContainer1.Panel2.Controls.Add(btnUpdate);
			splitContainer1.Size = new Size(701, 466);
			splitContainer1.SplitterDistance = 321;
			splitContainer1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.Icons064;
			pictureBox1.Location = new Point(12, 10);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(64, 56);
			pictureBox1.TabIndex = 10;
			pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(701, 490);
			Controls.Add(splitContainer1);
			Controls.Add(menuStrip1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuStrip1;
			Name = "MainForm";
			Text = "RetroArchCheatEdit";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private TextBox tbDes;
		private Button btnAdd;
		private Button btnUpdate;
		private Button btnUp;
		private Button btnDown;
		private Button btnDelete;
		private TextBox tbCode;
		private CheatListbox cheatListbox1;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem openToolStripMenuItem;
		private ToolStripMenuItem saveToolStripMenuItem;
		private ToolStripMenuItem saveAsToolStripMenuItem;
		private ToolStripMenuItem quitToolStripMenuItem;
		private SplitContainer splitContainer1;
		private CheckBox cbEnable;
		private PictureBox pictureBox1;
	}
}