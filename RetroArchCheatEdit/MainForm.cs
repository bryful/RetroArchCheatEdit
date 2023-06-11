namespace RetroArchCheatEdit
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			this.AllowDrop = true;
			InitializeComponent();
			cheatListbox1.Items.Clear();

			quitToolStripMenuItem.Click += (sender, e) => { Application.Exit(); };
			openToolStripMenuItem.Click += (sender, e) => { OpenFile(); };
			saveToolStripMenuItem.Click += (sender, e) => { SaveFile(); };
			saveAsToolStripMenuItem.Click += (sender, e) => { SaveAsFile(); };

			btnAdd.Click += (sender, e) => { cheatListbox1.AddData(); };
			btnUpdate.Click += (sender, e) => { cheatListbox1.UpdateData(); };
			btnDelete.Click += (sender, e) => { cheatListbox1.DeleteData(); };
			btnUp.Click += (sender, e) => { cheatListbox1.UpMoveData(); };
			btnDown.Click += (sender, e) => { cheatListbox1.DownMoveData(); };
			btnGet.Click += (sender, e) => { cheatListbox1.GetData(); };
		}
		// ******************************************************************
		public bool OpenFile()
		{
			bool ret = false;
			using (OpenFileDialog dlg = new OpenFileDialog())
			{
				dlg.Filter = "*.cht|*.cht|*.*|*.*";
				string f = cheatListbox1.FileName;
				if (f != "")
				{
					dlg.InitialDirectory = Path.GetDirectoryName(f);
					dlg.FileName = Path.GetFileName(f);
				}
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					ret = cheatListbox1.Load(dlg.FileName);
				}
			}
			return ret;
		}
		// ******************************************************************
		public bool SaveFile()
		{
			bool ret = false;
			string f = cheatListbox1.FileName;
			if (f != "")
			{
				ret = cheatListbox1.Save(f);
			}
			else
			{
				ret = SaveAsFile();
			}
			return ret;
		}

		public bool SaveAsFile()
		{
			bool ret = false;
			using (SaveFileDialog dlg = new SaveFileDialog())
			{
				dlg.Filter = "*.cht|*.cht|*.*|*.*";
				string f = cheatListbox1.FileName;
				if (f != "")
				{
					dlg.InitialDirectory = Path.GetDirectoryName(f);
					dlg.FileName = Path.GetFileName(f);
				}
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					ret = cheatListbox1.Save(dlg.FileName);
				}
			}
			return ret;
		}
		// ******************************************************************
		protected override void OnDragEnter(DragEventArgs drgevent)
		{
			if ((drgevent != null) && (drgevent.Data != null))
			{
				//コントロール内にドラッグされたとき実行される
				if (drgevent.Data.GetDataPresent(DataFormats.FileDrop))
					//ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
					drgevent.Effect = DragDropEffects.Copy;
				else
					//ファイル以外は受け付けない
					drgevent.Effect = DragDropEffects.None;
			}
		}
		// ******************************************************************
		protected override void OnDragDrop(DragEventArgs drgevent)
		{
			if ((drgevent != null) && (drgevent.Data != null))
			{
				string[] fileNames = (string[])drgevent.Data.GetData(DataFormats.FileDrop, false);
				foreach (string fileName in fileNames)
				{
					if (cheatListbox1.Load(fileName) == true)
					{
						break;
					}
				}
			}
		}
	}

}