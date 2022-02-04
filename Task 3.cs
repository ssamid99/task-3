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
            else
            {
                Console.WriteLine($"{a} ededi 9 reqemli deyil");
            }

            
            //11) 8 reqemli ededin reqemlerini iki -iki qruplashdir.
            //Qruplarin cemini tap.Alinan cavabin axirina 99 artir.
            //Sonra cavabin ozunden onun 18 % ni cix;
            int a = 12345678;
            int b = 0;
            if (a >= 10000000 && a < 100000000)
            {
                while (a > 0)
                {
                    int qaliq = a % 100;
                    a = (a - qaliq) / 100;
                    b = b + qaliq;
                }
                b = b * 100 + 99;
                double q = (b * 18) / 100.0;
                double w = b - q;
                Console.WriteLine(w);

            }
            else
            {
                Console.WriteLine($"{a} ededi 8 reqemli deyil");
            }
            
            //12) 2 dene 5 reqemli eded daxil et.
            //I ededin reqemleri ceminin usutne
            //II ededin reqemleri hasilini gel.
            //Neticenin axirina I ededin en axiinci reqemini artir.
            int a = 12345;
            int b = 67891;
            int c = 0;
            int d = 1;
            int g = a;
            bool qq = a >= 10000 && b >= 10000;
            bool ww = a < 100000 && b < 100000;
            if (qq == ww)
            {
                
                while(a > 0)
                {
                  int qaliq = a % 10;
                  a = (a - qaliq) / 10;
                  c = c + qaliq;
                }
                
                while(b > 0)
                {
                    int qaliq = b % 10;
                    b = (b - qaliq) / 10;
                    d = d * qaliq;
                }
                
                int e = c + d;
                int f = g % 10;
                int h = (e * 10) + f;
                Console.WriteLine(h);
                return;
            }
            
            //13) 3 dene 5 reqemli eded var.
            //Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet. Alinan neticeleri topla
            //Yekunda alian cavabin 50 % -ni hemin ededin uzerine gel.
            int a = 12345;
            int b = 67891;
            int c = 98765;
            int i = 1;
            int o = 0;
            int p = 0;
            int t = 0;
            bool qq = a >= 10000 && b >= 10000 && c >= 10000;
            bool ww = a < 100000 && b < 100000 && c < 100000;
            if(qq == ww)
            {
                int q = a % 10;
                while(a > 0)
                {
                    int qaliq = a % 10;
                    a = (a - qaliq) / 10;                   
                    o = o * 10 + qaliq;
                    
                }
                o = o % 10;
                o = o * 10 + q;
                

                int w = b % 10;
                while (b > 0)
                {
                    int qaliq = b % 10;
                    b = (b - qaliq) / 10;
                    p = p * 10 + qaliq;                   
                }              
                p = p % 10;
                p = (p * 10) + w;
                

                int r = c % 10;
                while (c > 0)
                {
                    int qaliq = c % 10;
                    c = (c - qaliq) / 10;
                    t = t * 10 + qaliq;
                }
                t = t % 10;
                t = (t * 10) + r;
                
                int y = o + p + t;
                double u = (y * 50) / 100.0;
                double v = y + u;
                Console.WriteLine(v);

                return;
            }
            
            //14) 4 dene eded daxil et. Bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.
            // 6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
            // Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel
            // Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.
            // Neticenin 60 % tap.Cavabin axirina 60 artir.
            // Neticeden 18 % cix
            int a = 121212;
            int b = 343434;
            int c = 565656;
            int d = 7878213;
            int i = d;
            int f = 0;
            int g = 0;
            int h = 1;
            int e;
            bool qq = a >= 100000 && b >= 100000 && c >= 100000;
            bool ww = a < 1000000 && b < 1000000 && c < 1000000;
            bool ee = d >= 1000000 && d < 10000000;
            if (qq == ww == ee)
            {
                while(a > 1000)
                {
                    int qaliq = a % 10;
                    a = (a - qaliq) / 10;                                       
                }
                //Console.WriteLine(a);

                while (b > 1000)
                {
                    int qaliq = b % 10;
                    b = (b - qaliq) / 10;
                }
                //Console.WriteLine(b);

                while (c > 1000)
                {
                    int qaliq = c % 10;
                    c = (c - qaliq) / 10;
                }
                //Console.WriteLine(c);
                e = a + b + c;
                //Console.WriteLine(e);
                
                while(d > 1000)
                {
                    int qaliq = d % 10;
                    d = (d - qaliq) / 10;
                    f = (f * 10) + qaliq;
                }
                while(f > 0)
                {
                    int qaliq = f % 10;
                    f = (f - qaliq) / 10;
                    g = g * 10 + qaliq;
                }
                //Console.WriteLine(g);
                int m = e + g;
                //Console.WriteLine(m);
                while (i > 1000)
                {
                    int qaliq = i % 10;
                    i = (i - qaliq) / 10;
                    
                }
                while(i > 0)
                {
                    int qaliq = i % 10;
                    i = (i - qaliq) / 10;
                    h = h * qaliq;
                }
                //Console.WriteLine(h);
                int s = m - h;
                double l = s * 0.60;
                l = (l * 100) + 60;
                //Console.WriteLine(l);
                double j = l * 0.18;
                double k = l - j;
                Console.WriteLine(k);
            }
            else
            {
                Console.WriteLine("verilen ededler shertlere uygun deyil");
            }
            
            //15)*5 dene eded daxil et. Bunlarda 2 denesi 3 reqemli. 2 denesi 6 reqemli. 1 denesi 7 reqemli olsun.
            //3 reqemli ededlerin cemini tap ve cavabin axirdan 2 denesini kvadratini tap.
            //Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel.
            //Cavabdan 7 reqemli ededin son 5 reqemini cix.
            //Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.
            //Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel.
            //Cavabin axirina 11 artir.
            //Sonra 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededi cix.
            //Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et.
            int a = 123;
            int b = 456;
            int c = 122411;
            int d = 614331;
            int e = 1234567;
            int e1 = e;
            int e2 = e;
            int i = 1;
            int h = 0;
            int m = 0;
            int l = 0;
            int k = 0;
            int r = 0;
            int t = 0;
            int s = 0;
            int y = 0;
            bool qq = a >= 100 && b >= 100;
            bool ww = a < 1000 && b < 1000;
            bool xw = c >= 100000 && d >= 100000;
            bool yw = d < 1000000 && e >= 1000000;
            bool zw = e >= 1000000 && e < 100000000;
            if (qq == ww && xw == yw == zw)
            {
                int f = a + b;
                f = f % 100;
                f = f * f;
                //Console.WriteLine(f);
                int g = (a * 1000) + b;
                g = g + f;
                //Console.WriteLine(g);
                while (e > 100)
                {
                    int qaliq = e % 10;
                    e = (e - qaliq) / 10;
                    h = h * 10 + qaliq;
                }
                //Console.WriteLine(h);
                while (h > 0)
                {
                    int qaliq = h % 10;
                    h = (h - qaliq) / 10;
                    m = m * 10 + qaliq;
                }
                //Console.WriteLine(m);
                g = g - m;
                //Console.WriteLine(g);
                int n = c + d;
                while (n > 1000)
                {
                    int qaliq = n % 10;
                    n = (n - qaliq) / 10;
                    l = l * 10 + qaliq;
                }
                //Console.WriteLine(l);
                while (l > 0)
                {
                    int qaliq = l % 10;
                    l = (l - qaliq) / 10;
                    k = k * 10 + qaliq;
                }
                //Console.WriteLine(k);
                g = g + k;
                while (e1 > 0)
                {
                    int qaliq = e1 % 10;
                    e1 = (e1 - qaliq) / 10;
                    r = r + qaliq;
                }
                //Console.WriteLine(r);
                while (r > 0)
                {
                    int qaliq = r % 10;
                    r = (r - qaliq) / 10;
                    t = t * 10 + qaliq;
                }
                //Console.WriteLine(t);
                g = g + t;
                g = (g * 100) + 11;
                //Console.WriteLine(g);
                while (e2 > 0)
                {
                    int qaliq = e2 % 10;
                    e2 = e2 / 10;
                    if (i % 2 != 0)
                    {
                        y = y * 10 + qaliq;
                    }
                    i++;
                }
                //Console.WriteLine(y);
                while (y > 0)
                {
                    int qaliq = y % 10;
                    y = (y - qaliq) / 10;
                    s = s * 10 + qaliq;
                }
                //Console.WriteLine(s);
                g = g - s;
                //Console.WriteLine(g);
                int u = g % 10;
                g = (g - u) / 10;

                g = g * 100 + 88;

                g = g * 10 + u;
                Console.WriteLine(g);
            }
            else
            {
                Console.WriteLine("verilen ededler shertlere uygun deyil");
            }

        }
    }
}
