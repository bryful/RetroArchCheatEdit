using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RetroArchCheatEdit
{
	public class CheatListbox : ListBox
	{
		private CheatFile cf = new CheatFile();
		// *****************************************************************
		private TextBox? m_DesTextBox = null;
		public TextBox? DesTextBox
		{
			get { return m_DesTextBox; }
			set
			{
				m_DesTextBox = value;
				if (m_DesTextBox != null)
				{
				}
			}
		}
		// *****************************************************************
		public string FileName
		{
			get { return cf.FileName; }
		}
		// *****************************************************************
		// *****************************************************************
		private TextBox? m_CodeTextBox = null;
		public TextBox? CodeTextBox
		{
			get { return m_CodeTextBox; }
			set
			{
				m_CodeTextBox = value;
				if (m_CodeTextBox != null)
				{
				}
			}
		}
		// *****************************************************************
		private CheckBox? m_EnableCheckBox = null;
		public CheckBox? EnableCheckBox
		{
			get { return m_EnableCheckBox; }
			set
			{
				m_EnableCheckBox = value;
				if(m_EnableCheckBox!=null)
				{
				}
			}
		}
		// *****************************************************************
		public CheatListbox() 
		{ 
		}
		public bool Load(string p)
		{
			this.Items.Clear();	
			bool ret = cf.Load(p);
			if(ret)
			{
				this.Items.AddRange(cf.GetDesList());
			}
			return ret;
		}
		public bool Save(string p)
		{
			bool ret = cf.Save(p);
			return ret;
		}
		public void Clear()
		{
			this.Items.Clear();
			cf.Clear();
			if (m_DesTextBox != null)
			{
				m_DesTextBox.Text = "";
			}
			if (m_CodeTextBox != null)
			{
				m_CodeTextBox.Text = "";
			}
			if (m_EnableCheckBox != null)
			{
				m_EnableCheckBox.Checked = false;
			}
		}
		// *****************************************************************
		protected override void OnMouseDoubleClick(MouseEventArgs e)
		{
			GetData();
		}
		public void GetData()
		{
			int idx = this.SelectedIndex;
			if ((idx >= 0) && (idx < cf.CheatCount))
			{
				if (m_DesTextBox != null)
				{
					m_DesTextBox.Text = cf.Items[idx].Desc;
				}
				if (m_CodeTextBox != null)
				{
					m_CodeTextBox.Lines = cf.Items[idx].CodeLines;
				}
				if (m_EnableCheckBox != null)
				{
					m_EnableCheckBox.Checked = cf.Items[idx].Enable;
				}
			}
		}
		// *****************************************************************
		public void UpdateData()
		{
			int idx = this.SelectedIndex;
			if ((idx >= 0) && (idx < cf.CheatCount))
			{
				string d = "";
				string [] c = new string[0];
				bool e = false;
				if (m_CodeTextBox != null)
				{
					c = m_CodeTextBox.Lines;
				}
				if (m_DesTextBox != null)
				{
					d = m_DesTextBox.Text.Trim();
				}
				if (m_EnableCheckBox != null)
				{
					e = m_EnableCheckBox.Checked;
				}

				cf.Items[idx].Desc = d;
				cf.Items[idx].CodeLines = c;
				cf.Items[idx].Enable = e;
				this.Items[idx] = d;
			}
		}
		public void AddData()
		{
			string d = "";
			string [] c = new string[0];
			bool e = false;
			if (m_DesTextBox != null)
			{
				d = m_DesTextBox.Text.Trim();
			}
			if (m_CodeTextBox != null)
			{
				c = m_CodeTextBox.Lines;
			}
			if (m_EnableCheckBox != null)
			{
				e = m_EnableCheckBox.Checked;
			}
			CheatItem ci = new CheatItem(d, string.Join("+", c), e);

			int si = this.SelectedIndex;
			if((si <0)||(si>=this.Items.Count-1))
			{
				cf.Items.Add(ci);
				this.Items.Add(ci.Desc);
				this.SelectedIndex = this.Items.Count - 1;
			}
			else
			{
				cf.Items.Insert(si+1,ci);
				this.Items.Insert(si+1, ci.Desc);
				this.SelectedIndex = si+1;
			}

		}
		public void DeleteData()
		{
			int idx = this.SelectedIndex;
			if ((idx >= 0) && (idx < cf.CheatCount))
			{
				DialogResult result = MessageBox.Show("Delete: " + this.Items[idx].ToString(), "", MessageBoxButtons.YesNo);
				if (result != DialogResult.Yes)
				{
					return;
				}

				int si = this.SelectedIndex;
				cf.Items.RemoveAt(idx);
				this.Items.RemoveAt(idx);
				if(this.Items.Count>0)
				{
					if (si >= this.Items.Count) si = this.Items.Count - 1;
					if(si>=0)
					{
						this.SelectedIndex = si;
					}
				}
			}
		}
		public void UpMoveData()
		{
			int idx = this.SelectedIndex;
			if ((idx >= 1) && (idx < cf.CheatCount))
			{
				int si = this.SelectedIndex;
				CheatItem ci = new CheatItem( cf.Items[si]);
				cf.Items[si].Assign(cf.Items[si - 1]);
				cf.Items[si - 1].Assign(ci);
				this.Items[si] = cf.Items[si].Desc;
				this.Items[si-1] = cf.Items[si-1].Desc;
				this.SelectedIndex = si - 1;
			}
		}
		public void DownMoveData()
		{
			int idx = this.SelectedIndex;
			if ((idx >= 0) && (idx < cf.CheatCount-1))
			{
				int si = this.SelectedIndex;
				CheatItem ci = new CheatItem(cf.Items[si]);
				cf.Items[si].Assign(cf.Items[si + 1]);
				cf.Items[si + 1].Assign(ci);
				this.Items[si] = cf.Items[si].Desc;
				this.Items[si + 1] = cf.Items[si + 1].Desc;
				this.SelectedIndex = si + 1;
			}
		}
	}
}
