using System;

namespace _3
{
    class Date
    {
        public int day;
        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        public int month;
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public void Coincide(int month, int day)
        {
            if (month == day)
            {
                Console.WriteLine("Збiгаються номер мiсяця i число дня");
            }
        }
        public int IncreaseMonth(int month)
        {
            return month++;
        }
    }
    class Medicine : Date
    {
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string firm;
        public string Firm
        {
            get { return firm; }
            set { firm = value; }
        }
        public Medicine(int day, int month, int year, string name, string firm) : base(day, month, year)
        {
            this.name = name;
            this.firm = firm;
        }
        public void Foo(int d, int m, int y)
        {
            string date = Convert.ToString(d) + "/" + Convert.ToString(m) + "/" + Convert.ToString(y);
            DateTime dt = DateTime.Parse(date);
            DateTime now = DateTime.Now;
            var days = (now - dt).Days;
            Console.WriteLine("Пройшло " + days + " днiв вiд виготовлення лiкiв");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var m = new Medicine(0, 0, 0, "", "");
            Console.Write("Введiть назву лiкiв: ");
            m.name = Console.ReadLine();
            Console.Write("Введiть назву фiрми: ");
            m.firm = Console.ReadLine();
            Console.Write("Введiть день випуску: ");
            m.day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введiть мiсяць випуску: ");
            m.month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введiть рiк випуску: ");
            m.year = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Фiрма: " + m.firm + " | Лiки: " + m.name + " | Дата: " + Convert.ToString(m.day) + "/" + Convert.ToString(m.month) + "/" + Convert.ToString(m.year));
            m.Foo(m.day, m.month, m.year);
            m.Coincide(m.day, m.month);
        }

    }
}