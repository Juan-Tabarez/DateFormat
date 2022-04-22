using System;
//using System.Linq;

namespace DateFormat
{
    public class FormatDate
    {
        public static String ChangeFormat(String year)
        {
            return year.Substring(6) + "-" + year.Substring(3, 2) + "-" + year.Substring(0, 2);
        }

        public static String ChangeFormat2(string date)
        {
            if (String.IsNullOrEmpty(date) || !date.Contains("/")) 
                return "";
            else
            {
                string res = "";
                string[] dateDivide = date.Split("/");
                if (dateDivide[0].Length == 2 && dateDivide[1].Length == 2 && dateDivide[2].Length == 4)
                {
                    res = dateDivide[0] + "-" + dateDivide[1] + "-" + dateDivide[2];
                }
                return res;
            }
        }

        public static void Main(string[] args)
        {
            string testDate = "10/11/1977";
            //Console.WriteLine("{0} se convierte a: {1} ", testDate, ChangeFormat(testDate));
            Console.WriteLine(testDate + " " + ChangeFormat2(testDate));
        }
    }
}
