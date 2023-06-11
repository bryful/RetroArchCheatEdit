﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroArchCheatEdit
{
	public class CheatItem
	{
		public bool Enable { set; get; } = false;
		public string Desc { set; get; } = "";
		private List<string> m_CodeList = new List<string>();
		public string Code
		{
			get 
			{
				return string.Join("+", m_CodeList);
			}
			set 
			{
				string[] sa = value.Split("+");
				if (sa.Length > 0)
				{
					m_CodeList.Clear();
					for (int i = 0; i < sa.Length; i++)
					{
						m_CodeList.Add(sa[i].Trim());
					}
				}
			}
		}
		public string CodeText
		{
			get { return string.Join("\r\n", m_CodeList.ToArray()); }
			set
			{
				m_CodeList.Clear();
				string[] sa = value.Split("\r\n");
				if (sa.Length > 0)
				{
					for (int i = 0; i < sa.Length; i++)
					{
						m_CodeList.Add(sa[i].Trim());
					}
				}
			}
		}
		public CheatItem(string des, string code,bool ena=false)
		{
			this.Desc = des;
			this.Code = code;
			Enable = ena;
		}
		public CheatItem(CheatItem ci)
		{
			Assign(ci);
		}
		public void Assign(CheatItem ci)
		{
			Desc = ci.Desc;
			Enable = ci.Enable;
			m_CodeList.Clear();

			if (ci.m_CodeList.Count > 0)
			{
				foreach (string s in ci.m_CodeList)
				{
					m_CodeList.Add(s);
				}
			}
		}
	}

}