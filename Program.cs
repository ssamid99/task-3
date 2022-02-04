using System;

namespace ConsoleApp.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) verilmish 4 reqemli ededin reqemlerinin cemini tap

            int a = 1234;
            int qaliq;
            int cem = 0;

            if (a >= 1000 && a < 10000)
            {
                while (a > 0)
                {
                    qaliq = a % 10;
                    a = (a - qaliq) / 10;
                    cem = cem + qaliq;

                }
                Console.WriteLine(cem);
            }
            else
            {
                Console.WriteLine($"{a} ededi 4 reqemli deyil");
            }
            

            //2) verilmihs 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap: example: 123600 = 1 + 2 + 3
            int a = 123456;
            int cem = 0;
            int b;
            int qaliq;
            if (a >= 1000000&& a < 1000000)
            {
                
                while(a > 1000)
                {
                    qaliq = a % 10;
                    a = (a - qaliq)/10;
                  
                }
                
                while(a > 0)
                {
                    b = a % 10;
                    a = (a - b) / 10;
                    cem = cem + b;                   
                }
                Console.WriteLine(cem);
            }
            
            else
            {
                Console.WriteLine($"{a} ededi 6 reqemli deyil");
            }
            
            
            //3) verilmihs 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi
            int a = 123456789;
            int l = 0;
            int c = 0;
            if(a > 100000000 && a < 1000000000)
            {
                while(a > 1000000)
                {
                    int q = a % 10;
                    a = (a - q) / 10;
                }
                
                while (a > 0)
                {
                    int w = a % 10;
                    a = (a - w) / 10;
                    l = (l * 10) + w;                  
                }
                
                while(l > 1000)
                {
                    int q = l % 10;
                    l = (l - q) / 10;
                }
                
                while (l > 0)
                {
                    int q = l % 10;
                    l = (l - q) / 10;
                    c = c + q;                   
                }
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine($"{a} ededi 9 reqemli deyil");
            }
            
            //4) verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati
            int a = 12345;          
            if(a >= 10000 && a < 100000)
            {
                int b = a % 10;
                a /= 10000;
                int c = a + b;
                c = c * c;
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine($"{a} ededi 5 reqemli deyil");
            }
            
            //5) verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.
            int a = 123456;
            int b = 0;
            int d = 0;
            if (a >= 100000 && a < 1000000)
            {
                while(a > 0)
                {
                    int qaliq = a % 10;
                    a = (a - qaliq) / 10;
                    b = (b * 10) + qaliq;
                }
                //Console.WriteLine(b);
                int c = b % 10;
                b = (b - c) / 10;
                while (b > 0)
                {
                    int qaliq = b % 10;
                    b = (b - qaliq) / 10;
                    d = (d * 10) + qaliq;
                }
                d = (d * 10) + 1;
                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine($"{a} ededi 6 reqemli deyil");
            }
            
            //6) verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et
            int a = 12345678;
            int b = 0;
            int c = 0;
            if (a >= 10000000 && a < 100000000)
            {
                while (a > 0)
                {
                    int qaliq = a % 10;
                    a = (a - qaliq) / 10;
                    b = (b * 10) + qaliq;
                }               
                int e = b % 10;
                b = (b - e) / 10;
                while (b > 0)
                {
                    int qaliq = b % 10;
                    b = (b - qaliq) / 10;
                    c = (c * 10) + qaliq;
                }
                int d = c % 10;
                c = (c - d) / 10;
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine($"{a} ededi 8 reqemli deyil");
            }
            
            //7)verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir
            int a = 1234;
            int b = 0;
            int c = 0;
            if (a >= 1000 && a < 10000)
            {
                while(a > 0)
                {
                    int qaliq = a % 10;
                    a = (a - qaliq) / 10;
                    b = (b * 10) + qaliq;  
                }
                b=(b * 10) + 8;
                while(b > 0)
                {
                    int qaliq = b % 10;
                    b = (b - qaliq) / 10;
                    c = (c * 10) + qaliq;
                }
                c=(c * 10) + 8;
                Console.WriteLine(c);
            }
            else
            {
            Console.WriteLine($"{a} ededi 4 reqemli deyil")
            }
            
            //8) Verilmis ededdin axirdan 3 - cu reqemi ile sonuncu reqeminin cemini tap
            int a = 1234567;
            int qaliq;
            int c = 0;
            int i = 1;
             if(a >= 1000000 && a < 10000000)
            {
                while(a > 10000)
                {
                    qaliq = a % 10;
                    a = a / 10;
                    if(i % 2 != 0)
                    {
                        c = c + qaliq;
                        
                    }
                    i++;
                }
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine($"{a} ededi shertlere uygun deyil");
            }            

            //9) 9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389 = 12439
            int a = 123456789;
            int i = 1;
            int j = 0;
            int k = 0;
            
            if (a >= 100000000 && a < 1000000000)
            {
                while (a > 0)
                {
                    int qaliq = a % 10;
                    a = a / 10;
                    if (i % 2 != 0)
                    {
                        j = j * 10 + qaliq;
                    }

                    i++;
                }
                while(j > 0)
                {
                    int qaliq = j % 10;
                    j = (j - qaliq) / 10;
                    k= k * 10 + qaliq;

                }
                Console.WriteLine(k);
                
            }
            else
            {
                Console.WriteLine($"{a} ededi 9 reqemli deyil");
            }
            
            //10) 9 reqemli ededdi tek yerde dayananlardan bir eded duzlet,
            //sonra cut yerde dayanlarinda bir eded duzlet,
            //sonra onlari topla
            int a = 123456789;
            int m = a;
            int b = 0;
            int i = 1;
            int c = 1;
            int d = 0;
            int e = 0;
            int f = 0;
            int g = 0;
            if (a >= 100000000 && a < 1000000000)
            {
                while(a > 0)
                {
                    int qaliq = a % 10;
                    a = a / 10;
                    if(i % 2 != 0)
                    {
                        b = b * 10 + qaliq;
                    }
                    i++;
                }
                Console.WriteLine(b);
                while(b > 0)
                {
                    int qaliq = b % 10;
                    b = (b - qaliq) / 10;
                    d = d * 10 + qaliq;                   
                }
                Console.WriteLine(d);
                
                while(m > 0)
                {
                    int qaliq = m % 10;
                    m = m / 10;
                    if(c % 2 == 0)
                    {
                        e = e * 10 + qaliq;
                    }
                    c++;
                }
                Console.WriteLine(e);
                while(e > 0)
                {
                    int qaliq = e % 10;
                    e = (e - qaliq)/10;
                    f = f * 10 + qaliq;
                }
                Console.WriteLine(f);

                g = d + f;
                Console.WriteLine(g);
            }
            
           
            
        }
    }
}
