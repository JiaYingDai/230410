using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230410
{
	public enum OverrideFile //列舉型別
	{
		若檔案存在就覆蓋,
		若檔案存在就丟出例外
	} 

	public enum NewFolder
	{
		若資料夾不存在就新建,
		若資料夾不存在就丟出例外
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			string text = "Hello, world";
			string path = @"d:\temp\aaa.text";

			CreateFile(text, path, OverrideFile.若檔案存在就覆蓋, NewFolder.若資料夾不存在就新建);
		}

		/// <summary>
		/// 將content存成文字檔
		/// </summary>
		/// <param name="content"></param>
		/// <param name="fullName"></param>要存放的檔案位置及檔名
		/// <param name="replaceFile"></param>是否要覆蓋檔案，如果檔案存在
		/// <param name="createFolder"></param>若資料夾不存在，要不要自動建立
		static void CreateFile(string content, string fullName, OverrideFile replaceFile, NewFolder createFolder) 
		{
			if (replaceFile == OverrideFile.若檔案存在就覆蓋)
			{

			}
			else if (replaceFile==OverrideFile.若檔案存在就丟出例外)
			{

			}
		}
	}
}
