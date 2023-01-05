namespace EvTapshiriqlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Proqrama xosh geldiz!");
                //ExerciseOne();
                //ExerciseTwo();
                //ExerciseThree();
                //ExerciseFour();
                //ExerciseFive();
                //ExerciseSix();
                //ExerciseSeven();
                //ExerciseEight();
                //ExerciseNine();
                //ExerciseTen();
                //ExerciseEleven();
                //ExerciseTwelve();


            }



            static void ExerciseOne()
            {
            //4 reqemli eded verilib. Bu ededin eveline 7 reqemini , axirinada 8 reqemini artir. Example1: 3333= 733338
            Label1:
                Console.Write("a:");

                string inputValue = Console.ReadLine();
                int a;
                if (int.TryParse(inputValue, out a) != true)
                {
                    Console.WriteLine("eded dogru deyil");
                    goto Label1;
                }
                if (a >= 1000 && a < 10000)
                {
                    a = 70000 + a;
                    a = a * 10 + 8;
                    Console.WriteLine($"Netice: {a}");
                }
                else
                {
                    Console.WriteLine("eded bu parcada olmalidir [1000,9999]!");
                    goto Label1;
                }
            }
            static void ExerciseTwo()
            {
            // reqemli eded verilib. Bu ededin axirina hemin ededdin ozunu yapishdir.example:333 = 333333;
            Label1:
                Console.Write("a:");

                string inputValue = Console.ReadLine();
                int a;
                if (int.TryParse(inputValue, out a) != true)
                {
                    Console.WriteLine("eded dogru deyil");
                    goto Label1;
                }
                if (a >= 100 && a < 1000)
                {
                    a = 1000 * a + a;
                    Console.WriteLine($"Netice: {a}");
                }
                else
                {
                    Console.WriteLine("eded bu araliqda olmalidir [100,999]!");
                    goto Label1;


                }
            }
            static void ExerciseThree()
            {
            // 5 reqemli eded verilib. Bu ededin evvel  18 % sonra ise 3 % tap
            Label1:
                Console.Write("a:");

                string inputValue = Console.ReadLine();
                int a;
                if (int.TryParse(inputValue, out a) != true)
                {
                    Console.WriteLine("eded dogru deyil");
                    goto Label1;
                }
                if (a >= 10000 && a < 100000)
                {
                    a = a * 18 / 100;
                    a = a * 3 / 100;
                    Console.WriteLine($"Netice: {a}");
                }
                else
                {
                    Console.WriteLine("eded bu araliqda olmalidir [10000,99999]!");
                    goto Label1;


                }
            }
            static void ExerciseFour()
            {
            // 3 reqemli eded verilib. Bu ededin axirina 7 artir. Sonra cavabin 7% tap;
            Label1:
                Console.Write("a:");

                string inputValue = Console.ReadLine();
                int a;
                if (int.TryParse(inputValue, out a) != true)
                {
                    Console.WriteLine("eded dogru deyil");
                    goto Label1;
                }
                if (a >= 100 && a < 1000)
                {
                    a = a * 10 + 7;
                    a = a * 7 / 100;
                    Console.WriteLine($"Netice: {a}");
                }
                else
                {
                    Console.WriteLine("eded bu araliqda olmalidir [100,999]!");
                    goto Label1;


                }
            }
            static void ExerciseFive()

            {
            // 4 reqemli eded verilib. Bu ededin evvelin 4 reqemi , axirina ise 44 ededini artir. Alinan cavabin 44 % tap.
            Label1:
                Console.Write("a:");

                string inputValue = Console.ReadLine();
                int a;
                if (int.TryParse(inputValue, out a) != true)
                {
                    Console.WriteLine("eded dogru deyil");
                    goto Label1;
                }
                if (a >= 1000 && a < 10000)
                {
                    a = a + 40000;
                    a = a * 100;
                    a = a + 44;
                    Console.WriteLine($"Ilk Netice: {a}");
                    a = a * 44 / 100;
                    Console.WriteLine($"Netice: {a}");
                }
                else
                {
                    Console.WriteLine("eded bu araliqda olmalidir [1000,9999]!");
                    goto Label1;


                }

            }
            static void ExerciseSix()

            {
            // 4 reqemli eded verilib. Bu ededin evvel 20%-ni ,  sonra ise cavabin 10% tap.  Alinan  cavabin kvadratini tap.
            Label1:
                Console.Write("a:");

                string inputValue = Console.ReadLine();
                int a;
                if (int.TryParse(inputValue, out a) != true)
                {
                    Console.WriteLine("eded dogru deyil");
                    goto Label1;
                }
                if (a >= 1000 && a < 10000)
                {
                    a = a * 20 / 100;
                    a = a * 10 / 100;
                    a = a * a;
                    Console.WriteLine($"Netice: {a}");
                }
                else
                {
                    Console.WriteLine("eded bu araliqda olmalidir [1000,9999]!");
                    goto Label1;


                }

            }
            static void ExerciseSeven()

            {
            // 2 dene 5 reqemli eded verilib. Bu ededleri toplayib. Alinan cavabin evveline ve axirina 5 artir. Neticenin 5 % tap
            Label1:
                Console.Write("a:");

                string inputValue = Console.ReadLine();
                int a;
                if (int.TryParse(inputValue, out a) != true)
                {
                    Console.WriteLine("eded dogru deyil");
                    goto Label1;
                }

                if (a >= 10000 && a < 100000)
                {
                Label2:
                    Console.Write("b:");

                    string inputValueB = Console.ReadLine();
                    int b;
                    if (int.TryParse(inputValueB, out b) != true)
                    {
                        Console.WriteLine("eded dogru deyil");
                        goto Label2;
                    }
                    if (b >= 10000 && b < 100000)
                    {
                        a = a + b;
                        if (a >= 10000 && a < 100000)
                        {
                            a = 500000 + a;
                        }
                        else
                        {
                            a = 5000000 + a;
                        }

                        a = a * 10 + 5;
                        Console.WriteLine($"Netice eded: {a}");
                        a = a + (a * 5 / 100);
                        Console.WriteLine($"Netice eded +5%: {a}");

                    }
                    else
                    {
                        Console.WriteLine("b ededi bu araliqda olmalidir [10000,99999]!");
                        goto Label2;


                    }

                }
                else
                {
                    Console.WriteLine("a ededi bu araliqda olmalidir [10000,99999]!");
                    goto Label1;


                }

            }
            static void ExerciseEight()

            {
            // 2 dene eded verilib. I eded 4 reqemli II eded 7 reqemlidir.
            //I ededin 4 % -ni tap.
            //Sonra II ededin 9 % ni tap.
            //Sonra Cavalari toplayib 10 % ni tap.
            Label1:
                Console.Write("a:");

                string inputValue = Console.ReadLine();
                int a;
                if (int.TryParse(inputValue, out a) != true)
                {
                    Console.WriteLine("eded dogru deyil");
                    goto Label1;
                }
                if (a >= 1000 && a < 10000)
                {
                Label2:
                    Console.Write("b:");

                    string inputValueB = Console.ReadLine();
                    int b;
                    if (int.TryParse(inputValueB, out b) != true)
                    {
                        Console.WriteLine("eded dogru deyil");
                        goto Label2;
                    }
                    if (b >= 100000 && b < 1000000)
                    {
                        a = a * 4 / 100;
                        b = b * 9 / 100;
                        a = a + b;
                        a = a * 10 / 100;
                        Console.WriteLine($"Netice : {a}");
                    }

                    else
                    {
                        Console.WriteLine("b ededi bu araliqda olmalidir [100000,999999]!");
                        goto Label2;


                    }

                }
                else
                {
                    Console.WriteLine("a ededi bu araliqda olmalidir [1000,9999]!");
                    goto Label1;


                }

            }
            static void ExerciseNine()

            {
            // 3 dene 6 reqemli eded verilib. Her birinin 10 faizini tapib neticeleri topla. Alinan cavabin 10% tap.
            Label1:
                Console.Write("a:");

                string inputValue = Console.ReadLine();
                int a;
                if (int.TryParse(inputValue, out a) != true)
                {
                    Console.WriteLine("eded dogru deyil");
                    goto Label1;
                }

                if (a >= 100000 && a < 1000000)
                {
                Label2:
                    Console.Write("b:");

                    string inputValueB = Console.ReadLine();
                    int b;
                    if (int.TryParse(inputValueB, out b) != true)
                    {
                        Console.WriteLine("eded dogru deyil");
                        goto Label2;
                    }
                    if (b >= 100000 && b < 1000000)
                    {
                    Label3:
                        Console.Write("c:");

                        string inputValueC = Console.ReadLine();
                        int c;
                        if (int.TryParse(inputValueC, out c) != true)
                        {
                            Console.WriteLine("eded dogru deyil");
                            goto Label3;
                        }
                        if (c >= 100000 && c < 1000000)
                        {
                            a = (a + b + c) * 10 / 100;
                            a = a * 10 / 100;
                            Console.WriteLine($"Netice : {a}");
                        }

                        else
                        {
                            Console.WriteLine("c ededi bu araliqda olmalidir [100000,999999]!");
                            goto Label3;
                        }
                    }

                    else
                    {
                        Console.WriteLine("b ededi bu araliqda olmalidir [100000,999999]!");
                        goto Label2;
                    }

                }
                else
                {
                    Console.WriteLine("a ededi bu araliqda olmalidir [100000,999999]!");
                    goto Label1;
                }

            }
            static void ExerciseTen()

            {
            // 3 dene 4 reqemli eded verilib.  I ededin 1%-ni, II ededin 2% , III ededin 3 % tap. 
            //Neticeleri bir birinden cix. Alinan cavabin ustune III ededin 7 % faizini gel
            Label1:
                Console.Write("a:");

                string inputValue = Console.ReadLine();
                int a;
                if (int.TryParse(inputValue, out a) != true)
                {
                    Console.WriteLine("eded dogru deyil");
                    goto Label1;
                }

                if (a >= 1000 && a < 10000)
                {
                Label2:
                    Console.Write("b:");

                    string inputValueB = Console.ReadLine();
                    int b;
                    if (int.TryParse(inputValueB, out b) != true)
                    {
                        Console.WriteLine("eded dogru deyil");
                        goto Label2;
                    }
                    if (b >= 1000 && b < 10000)
                    {
                    Label3:
                        Console.Write("c:");

                        string inputValueC = Console.ReadLine();
                        int c;
                        if (int.TryParse(inputValueC, out c) != true)
                        {
                            Console.WriteLine("eded dogru deyil");
                            goto Label3;
                        }
                        if (c >= 1000 && c < 10000)
                        {
                            a = a * 1 / 100;
                            b = b * 2 / 100;
                            int d = c * 7 / 100;
                            c = c * 3 / 100;
                            a = a - b - c;
                            a = a + d;

                            Console.WriteLine($"Netice : {a}");
                        }

                        else
                        {
                            Console.WriteLine("c ededi bu araliqda olmalidir [1000,9999]!");
                            goto Label3;
                        }
                    }

                    else
                    {
                        Console.WriteLine("b ededi bu araliqda olmalidir [1000,9999]!");
                        goto Label2;
                    }

                }
                else
                {
                    Console.WriteLine("a ededi bu araliqda olmalidir [1000,9999]!");
                    goto Label1;
                }

            }
            static void ExerciseEleven()

            {
            // 4 dene 5 reqemli eded verilib. Her I ededin ustune III ededi gel . II ededin usutune IV eeddi gel. 
            //Sonra cavablari vur birbirine. Alinan neticeden III ededin 3 % -ni cix.
            Label1:
                Console.Write("a:");

                string inputValue = Console.ReadLine();
                int a;
                if (int.TryParse(inputValue, out a) != true)
                {
                    Console.WriteLine("eded dogru deyil");
                    goto Label1;
                }

                if (a >= 10000 && a < 100000)
                {
                Label2:
                    Console.Write("b:");

                    string inputValueB = Console.ReadLine();
                    int b;
                    if (int.TryParse(inputValueB, out b) != true)
                    {
                        Console.WriteLine("eded dogru deyil");
                        goto Label2;
                    }
                    if (b >= 10000 && b < 100000)
                    {
                    Label3:
                        Console.Write("c:");

                        string inputValueC = Console.ReadLine();
                        int c;
                        if (int.TryParse(inputValueC, out c) != true)
                        {
                            Console.WriteLine("eded dogru deyil");
                            goto Label3;
                        }
                        if (c >= 10000 && c < 100000)
                        {
                        Label4:
                            Console.Write("d:");

                            string inputValueD = Console.ReadLine();
                            int d;
                            if (int.TryParse(inputValueD, out d) != true)
                            {
                                Console.WriteLine("eded dogru deyil");
                                goto Label4;
                            }
                            if (d >= 10000 && d < 100000)
                            {
                                int e;
                                e = c * 3 / 100;
                                a = a + c;
                                b = b + d;
                                a = a * b;
                                a = a - e;

                                Console.WriteLine($"Netice : {a}");
                            }

                            else
                            {
                                Console.WriteLine("d ededi bu araliqda olmalidir [10000,99999]!");
                                goto Label4;
                            }

                        }

                        else
                        {
                            Console.WriteLine("c ededi bu araliqda olmalidir [10000,99999]!");
                            goto Label3;
                        }
                    }

                    else
                    {
                        Console.WriteLine("b ededi bu araliqda olmalidir [10000,99999]!");
                        goto Label2;
                    }

                }
                else
                {
                    Console.WriteLine("a ededi bu araliqda olmalidir [10000,99999]!");
                    goto Label1;
                }

            }
            static void ExerciseTwelve()

            {
            // 4 dene 6 reqemli eded verilib. Ededlerin hamisinin 10 faizini tap ve topla. Sonra hamisinin 15 faizini tap ve topla. 
            //Sonra yekunda alinanlar iki cavabi vur biri birine. Alinan neticenin evvel 10 % tap sonra ise hemin cavabin 11 % tap.
            Label1:
                Console.Write("a:");

                string inputValue = Console.ReadLine();
                int a;
                if (int.TryParse(inputValue, out a) != true)
                {
                    Console.WriteLine("eded dogru deyil");
                    goto Label1;
                }

                if (a >= 100000 && a < 1000000)
                {
                Label2:
                    Console.Write("b:");

                    string inputValueB = Console.ReadLine();
                    int b;
                    if (int.TryParse(inputValueB, out b) != true)
                    {
                        Console.WriteLine("eded dogru deyil");
                        goto Label2;
                    }
                    if (b >= 100000 && b < 1000000)
                    {
                    Label3:
                        Console.Write("c:");

                        string inputValueC = Console.ReadLine();
                        int c;
                        if (int.TryParse(inputValueC, out c) != true)
                        {
                            Console.WriteLine("eded dogru deyil");
                            goto Label3;
                        }
                        if (c >= 100000 && c < 1000000)
                        {
                        Label4:
                            Console.Write("d:");

                            string inputValueD = Console.ReadLine();
                            int d;
                            if (int.TryParse(inputValueD, out d) != true)
                            {
                                Console.WriteLine("eded dogru deyil");
                                goto Label4;
                            }
                            if (d >= 100000 && d < 1000000)
                            {
                                int e;
                                int x;
                                e = (a + b + c + d) * 10 / 100;
                                x = (a + b + c + d) * 15 / 100;
                                a = e * x;
                                a = a * 10 / 100;
                                a = a * 11 / 100;


                                Console.WriteLine($"Netice : {a}");
                            }

                            else
                            {
                                Console.WriteLine("d ededi bu araliqda olmalidir [100000,999999]!");
                                goto Label4;
                            }

                        }

                        else
                        {
                            Console.WriteLine("c ededi bu araliqda olmalidir [100000,999999]!");
                            goto Label3;
                        }
                    }

                    else
                    {
                        Console.WriteLine("b ededi bu araliqda olmalidir [100000,999999]!");
                        goto Label2;
                    }

                }
                else
                {
                    Console.WriteLine("a ededi bu araliqda olmalidir [100000,999999]!");
                    goto Label1;
                }






            }
        }
    }
}
    
