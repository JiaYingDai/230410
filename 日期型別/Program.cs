using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 日期型別
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime dt1= DateTime.Now;
			DateTime dt2= DateTime.Today;
			DateTime dt3= new DateTime(2023,1,1);
			DateTime dt4 = new DateTime(2023, 1, 1,13,45,3,101);

			// 日期格式化成字串
			string value1=dt4.ToString();

			// MM是會自動補零的意思，M不會自動補零
			// dd, d的意思亦同
			string value2 = dt4.ToString("yyyy-MM-dd");

			// HH是24小時制, hh是12小時制 (盡量寫大寫)
			// mm:分鐘
			// ss是秒，s不會自動補零
			string value3 = dt4.ToString("yyyy-MM-dd HH:mm:ss");

			// dt4加時間
			dt4.AddYears(1);
			dt4.AddHours(1);
			dt4.AddMinutes(1);
			dt4.AddSeconds(1);
			dt4.AddMilliseconds(1);

			// 取dt4當月1日
			DateTime dt5 = new DateTime(dt4.Year, dt4.Month, 1);

			// dt4下個月1日
			dt5 = new DateTime(dt4.Year, dt4.Month, 1).AddMonths(1);

			// 取今天時間當月的最後一天
			dt5 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

			// 去年的今天
			dt5=DateTime.Now.AddYears(-1);

			// 只取得日期
			dt5 = dt5.Date;

			// 得知dt當月共有幾天
			int days=DateTime.DaysInMonth(dt5.Year, dt5.Month);

			// 得知dt當年是否閏年
			bool result=DateTime.IsLeapYear(dt5.Year);

			// dt星期幾
			DayOfWeek dayOfWeek=dt5.DayOfWeek;


			Console.WriteLine(dayOfWeek);
			Console.WriteLine((int)dayOfWeek);


			DateTime dtBegin = new DateTime(2023, 4, 10);
			DateTime dtEnd = new DateTime(2023, 4, 12);

			TimeSpan ts = dtEnd - dtBegin;
			double hours = ts.TotalHours;
			double days1 = ts.TotalDays;
			double mins = ts.TotalMinutes;
			double secs = ts.TotalSeconds;

			Console.WriteLine("TotalHours= "+ hours);
			Console.WriteLine("TotalDays= " + days1);
			Console.WriteLine("TotalMins= " + mins);
			Console.WriteLine("TotalSecs= " + secs);




		}
	}
}
