using System;

namespace BTH2
{
    //Bai1
    class Stack
    {
        private int top;
        private int[] a;
        public bool empty()
        {
            return (top == -1);
        }
        public bool full()
        {
            return (top >= a.Length);
        }
        public Stack()
        {
            a = new int[20];
            top = -1;
        }
        public void push(int x)
        {
            if (!full())
            {
                top = top + 1;
                a[top] = x;
            }
            else
                Console.Write("stack tran");
        }
        public int pop()
        {
            if (empty())
            {
                Console.Write("stack can");
                return 0;
            }
            else
                return a[top--];
        }
    }
    class hecoso
    {
        static void Main1()
        {
            int n;
            Console.Write("Nhap vao so can doi:");
            n = int.Parse(Console.ReadLine());
            Stack T = new Stack();
            string st = "0123456789ABCDEF";
            while (n != 0)
            {
                T.push((int)st[n % 16]);
                n = n / 16;
            }
            Console.Write("Ket qua doi sang he 16 :");
            while (!T.empty())
            {
                Console.Write("{0}", (char)T.pop());
            }
            Console.ReadLine();
        }
    }

    //Bai2
    class PS
    {
        private int ts, ms;
        public PS()
        {
            ts = 0;
            ms = 1;
        }

        public PS(int ts, int ms)
        {
            this.ts = ts;
            this.ms = ms;
        }

        public PS(PS t)
        {
            this.ts = t.ts;
            this.ms = t.ms;
        }
        public PS Tong(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ms + this.ms * t2.ts;
            t.ms = this.ms * t2.ms;
            return t;
        }

        public PS Hieu(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ms - this.ms * t2.ts;
            t.ms = this.ms * t2.ms;
            return t;
        }

        public PS Tich(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ts;
            t.ms = this.ms * t2.ms;
            return t;
        }

        public PS Thuong(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ms;
            t.ms = this.ms * t2.ts;
            return t;
        }

        public int Ucln(int x, int y)
        {
            x = Math.Abs(x);
            y = Math.Abs(y);
            while (x != y)
            {
                if (x > y)
                    x = x - y;
                if (y > x)
                    y = y - x;
            }
            return x;
        }

        public PS Rutgon()
        {
            int uc = Ucln(this.ts, this.ms);
            this.ts = this.ts / uc;
            this.ms = this.ms / uc;
            return this;
        }

        public static bool operator ==(PS t1, PS t2)
        {
            if (t1.ts * t2.ms == t2.ts * t1.ms)
                return true;
            else
                return false;
        }

        public static bool operator !=(PS t1, PS t2)
        {
            if (t1.ts * t2.ms == t2.ts * t1.ms)
                return false;
            else
                return true;
        }

        public static bool operator >(PS t1, PS t2)
        {
            return t1.ts * t2.ms > t2.ts * t1.ms;
        }

        public static bool operator <(PS t1, PS t2)
        {
            return t1.ts * t2.ms < t2.ts * t1.ms;
        }

        public void Hien()
        {
            if (ms == 1) Console.WriteLine("{0}", ts);
            else
                Console.WriteLine("{0} / {1}", ts, ms);
        }

        class App
        {
            static void Main2()
            {
                PS t1 = new PS();
                PS t2 = new PS();
                Console.WriteLine("Tong 2 phan so");
                PS t3 = t1.Tong(t2);
                t3.Hien();

                Console.WriteLine("Hieu 2 phan so");
                PS t4 = t1.Hieu(t2);
                t4.Hien();

                Console.WriteLine("Tich 2 phan so");
                PS t5 = t1.Tich(t2);
                t5.Hien();

                Console.WriteLine("Thuong 2 phan so");
                PS t6 = t1.Thuong(t2);
                t6.Hien();

                if (t1 > t2) Console.WriteLine("t1 > t2");
                else
                    Console.WriteLine("t1 <= t2");
                Console.ReadKey();

            }
        }


        //Bai3
        class Queue
        {
            private int front;
            private int rear;
            private int[] q;
            public Queue()
            {
                front = rear = 0;
            }
            public Queue(int n)
            {
                q = new int[n];
            }
            public bool isEmpty()
            {
                return (front == 0 || front > 0 ? true : false);
            }
            public bool isFull()
            {
                return (rear > q.Length - 1 ? true : false);
            }
            public void Push(int x)
            {
                if (isFull())
                {
                    Console.WriteLine("Queue day");
                    return;
                }
                rear++;
                q[rear] = x;

            }
            public void Pop()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Queue rong");
                    return;
                }
                q[front] = 0;
                front++;

            }

            class App
            {
                static void Main3()
                {
                    int n;
                    Queue q = new Queue();
                    Console.WriteLine("Nhap vao so nguyen n: ");
                    n = int.Parse(Console.ReadLine());

                }
            }


            //Bai4
            class DaThuc
            {
                private int n;
                private int[] a;
                public DaThuc()
                {
                    n = 0;
                    a = null;
                }

                public DaThuc(int n)
                {
                    this.n = n;
                    a = new int[n];
                }

                public void Nhap()
                {
                    Console.WriteLine("Nhap thong tin cua da thuc");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("a[{0}] = ", i);
                        a[i] = int.Parse(Console.ReadLine());
                    }
                }

                public void Hien()
                {
                    Console.WriteLine("Thong tin cac he so cua da thuc");
                    for (int i = 0; i < n; i++)
                        Console.Write("{0}, ", i);
                }

                public DaThuc Tong(DaThuc t2)
                {
                    if (this.n == t2.n)
                    {
                        DaThuc d = new DaThuc(this.n);
                        for (int i = 0; i < n; i++)
                            d.a[i] = this.a[i] + t2.a[i];
                        return d;
                    }
                    else return null;
                }

                public DaThuc Hieu(DaThuc t2)
                {
                    if (this.n == t2.n)
                    {
                        DaThuc d = new DaThuc(this.n);
                        for (int i = 0; i < n; i++)
                            d.a[i] = this.a[i] - t2.a[i];
                        return d;
                    }
                    else return null;
                }

                class App
                {
                    static void Main4()
                    {
                        DaThuc d1 = new DaThuc();
                        DaThuc d2 = new DaThuc();
                        Console.WriteLine("Da thuc thu nhat"); d1.Hien();
                        Console.WriteLine("Da thuc thu hai"); d2.Hien();
                        DaThuc d3 = d1.Tong(d2);
                        DaThuc d4 = d1.Hieu(d2);
                        Console.WriteLine("Da thuc tong"); d3.Hien();
                        Console.WriteLine("Da thuc hieu"); d4.Hien();
                        Console.ReadLine();

                    }
                }


                //Bai5
                public class Date
                {
                    public void DisplayCurrentTime()
                    {
                        Console.WriteLine("Time\t: {0}/{1}/{2}   {3}:{4}:{5}", date, month, year, hour, minute, second);

                    }
                    public Date(System.DateTime dt)
                    {
                        year = dt.Year;
                        month = dt.Month;
                        date = dt.Day;
                        hour = dt.Hour;
                        minute = dt.Minute;
                        second = dt.Second;
                    }
                    public int Hour
                    {
                        get
                        {
                            return Hour;
                        }
                        set
                        {
                            hour = value;
                        }
                    }

                    //Biến thành viên private
                    private int year;
                    private int month;
                    private int date;
                    private int hour;
                    private int minute;
                    private int second;


                    static void Main5(string[] args)
                    {
                        DateTime currentTime = System.DateTime.Now;
                        Date d = new Date(currentTime);
                        d.DisplayCurrentTime();
                        //Lấy dữ liệu từ thuộc tính Hour
                        int theHour = d.Hour;
                        Console.WriteLine("Retrieved the hour: {0} ", theHour);
                        theHour++;
                        d.Hour = theHour;
                        Console.WriteLine("Updated the hour: {0} ", theHour);
                    }
                }
            }
        }
    }
}