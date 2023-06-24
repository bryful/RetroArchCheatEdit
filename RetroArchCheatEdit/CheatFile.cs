using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroArchCheatEdit
{
	public class CheatFile
	{
		private string m_FileName = string.Empty;
		public string FileName 
		{ 
			get { return m_FileName; } 
			set 
			{
				Load(value); 
			}
		}
		// **********************************************************
		public void Clear()
		{
			m_FileName = "";
			Items.Clear();
		}
		// **********************************************************
		public List<CheatItem> Items = new List<CheatItem>();
		public int CheatCount { get { return Items.Count; } }
		// **********************************************************
		public CheatFile()
		{

		}
		// **********************************************************
		public string[] GetDesList()
		{
			List<string> list = new List<string>();
			if(Items.Count > 0 )
			{
				foreach( CheatItem item in Items )
				{
					list.Add(item.Desc);
				}
			}
			return list.ToArray();
		}
		// **********************************************************
		private string[] SplitLine(string line)
		{
			string[] ret = new string[] { "", "" };
			ret = line.Trim().Split('=');
			if(ret.Length !=2 ) return ret;
			ret[0] = ret[0].Trim();
			ret[1] = ret[1].Trim();
			if((ret[0]=="")||(ret[1]=="")) return ret;
			if ( (ret[1][0] =='"')&& (ret[1][ret[1].Length-1] == '"'))
			{
				ret[1] = ret[1].Substring(1, ret[1].Length-2);
			}
			return ret;
		}
		// **********************************************************
		private int GetCount(string[] lines)
		{
			int ret = -1;
			if(lines.Length > 0)
			{
				for(int i=0; i<lines.Length; i++)
				{
					string[] sa = SplitLine(lines[i]);
					if (sa[0]== "cheats")
					{
						int v = 0;
						if (int.TryParse(DelWQ(sa[1]), out v))
						{
							ret = v;
						}
						break;
					}
				}
			}
			return ret;
		}
		private string GetHeader(string line)
		{
			string ret = "";
			if(line.Length <=0) return ret;
			int idx = line.IndexOf('_');
			if(idx>0)
			{
				ret= line.Substring(0, idx);
			}
			return ret;
		}
		// **********************************************************
		private string GetLineValue(List<string[]> lines,string tag)
		{
			string ret = "";
			if(lines.Count>0)
			{
				for(int i=0;i<lines.Count;i++)
				{
					if (lines[i][0]== tag)
					{
						ret = DelWQ(lines[i][1]);
					}
				}
			}
			return ret;
		}
		// **********************************************************
		public string DelWQ(string s)
		{
			s = s.Trim();
			if (s.Length > 0)
			{
				if (s[0] == '\"') s = s.Substring(1, s.Length - 1).Trim();
			}
			if (s.Length > 0)
			{
				if (s[s.Length - 1] == '\"') s = s.Substring(0, s.Length - 1).Trim();
			}
			return s;
		}
		private bool Analysis(string[] lines)
		{
			bool ret = false;
			Items.Clear();
			if (lines.Length <= 0) return ret;

			int ic = GetCount(lines);
			if(ic<=0) return ret;

			List<string[]> list = new List<string[]>();
			for (int i = 0; i < lines.Length; i++)
			{
				string[] sa = SplitLine(lines[i]);
				if ((sa[0] != "") && (sa[0] != "cheats"))
				{
					list.Add(sa);
				}
			}
			if (ic * 2 > list.Count) return ret;

			List<CheatItem> items = new List<CheatItem>();
			for(int i=0; i<ic;i++)
			{
				string des = GetLineValue(list, $"cheat{i}_desc");
				string code = GetLineValue(list, $"cheat{i}_code");
				string ena = GetLineValue(list, $"cheat{i}_enable");
				if (ena == "") ena = "false";
				if (des != "")
				{
					bool e = (ena == "true");
					CheatItem ci = new CheatItem(des, code,e);
					items.Add(ci);
				}
			}
			Items = items;
			ret= true;
			return ret;
		}
		// **********************************************************
		public bool Load(string p)
		{
			bool ret = false;

			if(File.Exists(p)==false) return ret;

			try
			{
				string[] lines = System.IO.File.ReadAllLines(p, Encoding.GetEncoding("utf-8"));
				if (lines.Length <= 0) return ret;

				ret = Analysis(lines);
				if (ret)
				{
					m_FileName = p;
				}
				else
				{
					m_FileName = p;
				}

			}
			catch
			{
				ret = false;
			}
			return ret;
		}
		// *****************************************************************
		private string ToCht()
		{
			string ret = "";
			for(int i=0; i<Items.Count; i++)
			{
				ret += "\n";
				ret += $"cheat{i}_desc = \"{Items[i].Desc}\"\n";
				ret += $"cheat{i}_code = \"{Items[i].Code}\"\n";
				string ena = "false";
				if(Items[i].Enable==true) ena = "true";
				ret += $"cheat{i}_enable = \"{ena}\"\n";
			}
			ret += $"cheats = \"{Items.Count}\"\n";
			return ret ;
		}
		// *****************************************************************
		public bool Save(string p)
		{
			bool ret = false;
			try
			{
				if(File.Exists(p)) File.Delete(p);
				System.IO.File.WriteAllText(p, ToCht());
				ret = (File.Exists(p));
			}
			catch
			{
				ret = false;
			}
			return ret;
		}
		// **********************************************************
	}
}
