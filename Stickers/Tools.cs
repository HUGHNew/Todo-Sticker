using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Text;

namespace Stickers
{
    namespace Tool
    {
        public class CSV
        {
            public DataTable Read(string csvfile)
            {
                DataTable table = new DataTable();
                FileStream stream = new FileStream(csvfile,FileMode.Open,FileAccess.Read);
                StreamReader reader = new StreamReader(stream,Encoding.UTF8);
                // read contents
                bool FirstFlag = true;
                string line;
                string[] lineSplit=null;
                while ((line = reader.ReadLine()) != null)
                {
                    lineSplit=line.Split(',');
                    if (FirstFlag)
                    {
                        FirstFlag = false;
                        for(int idx = 0; idx < lineSplit.Length; ++idx)
                        {
                            table.Columns.Add(new DataColumn(lineSplit[idx]));
                        }
                    }
                    else
                    {
                        DataRow dr=table.NewRow();
                        dr.ItemArray = lineSplit;
                        table.Rows.Add(dr);
                    }
                }
                if(null != lineSplit && lineSplit.Length > 0)
                {
                // set default sort
                }
                return table;
            }
        }
        public class DateTimeFormatter : IFormattable,IFormatProvider
        {
            private DateTime time;
            public DateTimeFormatter()
            {
                time = DateTime.Now;
            }
            public DateTimeFormatter(int month,int day,int hour=0,int min=0)
            {
                time = new DateTime(DateTime.Now.Year,month,day,hour,min,0);
            }
            public DateTimeFormatter(DateTime dt)
            {
                SetTime(dt);
            }
            public void SetTime(DateTime dt)
            {
                time = dt + new TimeSpan();
            }
            #region Time Parts
            public int Year => time.Year;
            public int Month => time.Month;
            public int Day => time.Day;
            public int Hour => time.Hour;
            public int Minute => time.Minute;
            #endregion
            public override string ToString() => this.ToString("MM/dd HH:mm",null);
            public string ToString(string format) => this.ToString(format,null);
            public string ToString(string format, IFormatProvider formatProvider)
            {
                formatProvider ??= DateTimeFormatInfo.CurrentInfo;
                return time.ToString(format, formatProvider);
            }

            public object GetFormat(Type formatType)
            {
                return this;
            }
            //public DateTime Format(string format) {
            //    return DateTime.TryParse(format,this,)
            //}
        }
    }
}
