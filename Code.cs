using System;
namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project:  The Matrix");
            Console.WriteLine("_".PadRight(46, '_'));
            while (true)
            {
                Console.WriteLine("Do you want to procces for a 3 * 3 matrix or for a 3 * 4 matrix? 3*3/3*4");
                string group = Console.ReadLine();
                switch (group)
                {
                    case "3*3":
                        {
                            double a1, a2, a3, b1, b2, b3, c1, c2, c3;
                            Console.WriteLine("_".PadRight(46, '_'));
                            Console.WriteLine("Format of the matrix to be entered:");
                            Console.WriteLine("| a1 b1 c1 |");
                            Console.WriteLine("| a2 b2 c2 |");
                            Console.WriteLine("| a3 b3 c3 |");
                            Console.WriteLine("_".PadRight(46, '_'));
                            Console.WriteLine("Enter the matrix elements");
                            Console.Write("a1= ");
                            a1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("a2= ");
                            a2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("a3= ");
                            a3 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("b1= ");
                            b1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("b2= ");
                            b2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("b3= ");
                            b3 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("c1= ");
                            c1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("c2= ");
                            c2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("c3= ");
                            c3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("_".PadRight(46, '_'));
                            Console.WriteLine("Entered matrix: ");
                            Console.WriteLine($"| {a1} {b1} {c1} |");
                            Console.WriteLine($"| {a2} {b2} {c2} |");
                            Console.WriteLine($"| {a3} {b3} {c3} |");
                            double det;
                            det = ((a1 * b2 * c3) + (a2 * b3 * c1) + (a3 * b1 * c2)) - ((c1 * b2 * a3) + (c2 * b3 * a1) + (c3 * b1 * a2));
                            while (true)
                            {
                                char question;
                                string sum;
                                Console.WriteLine("_".PadRight(46, '_'));
                                Console.WriteLine("Enter \"S\" for Sums");
                                Console.WriteLine("Enter \"T\" for Transpose of the Matrix");
                                Console.WriteLine("Enter \"D\" for Determinant of the Matrix");
                                question = Convert.ToChar(Console.ReadLine().ToUpper());
                                switch (question)
                                {
                                    case 'S':
                                        while (true)
                                        {
                                            Console.WriteLine("_".PadRight(46, '_'));
                                            Console.WriteLine("Enter \"Rows\" for Sum of Rows");
                                            Console.WriteLine("Enter \"Columns\" for Sum of Columns ");
                                            Console.WriteLine("Enter \"Diagonal\" for Sum of Primary Diagonal");
                                            sum = Convert.ToString(Console.ReadLine().ToUpper());
                                            if (sum == "Rows")
                                            {
                                                Console.WriteLine("_".PadRight(46, '_'));
                                                Console.WriteLine($"Sum of Row 1 is {a1 + b1 + c1}");
                                                Console.WriteLine($"Sum of Row 2 is {a2 + b2 + c2}");
                                                Console.WriteLine($"Sum of Row 3 is {a3 + b3 + c3}");
                                                break;
                                            }
                                            else if (sum == "Columns")
                                            {
                                                Console.WriteLine("_".PadRight(46, '_'));
                                                Console.WriteLine($"Sum of Column 1 is {a1 + a2 + a3}");
                                                Console.WriteLine($"Sum of Column 2 is {b1 + b2 + b3}");
                                                Console.WriteLine($"Sum of Column 3 is {c1 + c2 + c3}");
                                                break;
                                            }
                                            else if (sum == "Diagonal")
                                            {
                                                Console.WriteLine("_".PadRight(46, '_'));
                                                Console.WriteLine($"Sum of Primary Diagonal is {a1 + b2 + c3}");
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("_".PadRight(46, '_'));
                                                Console.WriteLine("Please enter a valid term ");
                                                continue;
                                            }
                                        }
                                        break;
                                    case 'T':
                                        Console.WriteLine("_".PadRight(46, '_'));
                                        Console.WriteLine("Transpose of the Matrix is: ");
                                        Console.WriteLine($"| {a1} {a2} {a3} |");
                                        Console.WriteLine($"| {b1} {b2} {b3} |");
                                        Console.WriteLine($"| {c1} {c2} {c3} |");
                                        break;
                                    case 'D':
                                        Console.WriteLine("_".PadRight(46, '_'));
                                        Console.WriteLine("Determinant of the Matrix is: ");
                                        double det1, det2;
                                        det1 = ((a1 * b2 * c3) + (a2 * b3 * c1) + (a3 * b1 * c2));
                                        det2 = ((c1 * b2 * a3) + (c2 * b3 * a1) + (c3 * b1 * a2));
                                        Console.WriteLine($"(({a1}*{b2}*{c3})+({a2}*{b3}*{c1})+({a3}*{b1}*{c2}))-(({c1}*{b2}*{a3})+({c2}*{b3}*{a1})+({c3}*{b1}*{a2}))");
                                        Console.WriteLine($"= ({det1})-({det2})");
                                        Console.WriteLine("= {0}", det);
                                        break;
                                    default:
                                        Console.WriteLine("_".PadRight(46, '_'));
                                        Console.WriteLine("Please enter a valid term ");
                                        continue;
                                }
                                char answer;
                                Console.WriteLine("_".PadRight(46, '_'));
                                Console.WriteLine("Do you want to process again? Y/N");
                                answer = Convert.ToChar(Console.ReadLine().ToUpper());
                                if (answer == 'Y')
                                {
                                    continue;
                                }
                                else if (answer == 'N')
                                {
                                    break;
                                }
                            }
                            Console.WriteLine("*".PadRight(46, '*'));
                            Console.WriteLine("The Step of Determining the Matrix Type      :");
                            Console.WriteLine("*".PadRight(46, '*'));
                            Boolean Ide = false, Sca = false, Dia = false, ZO = false, Sym = false, Per = false;
                            if (b1 == 0 && c1 == 0 && c2 == 0 && a2 == 0 && a3 == 0 && b3 == 0)
                            {
                                Dia = true;
                                if (a1 == 1 && b2 == 1 && c3 == 1)
                                {
                                    Ide = true;
                                }
                                if (a1 == b2 && b2 == c3)
                                {
                                    Sca = true;
                                }
                            }
                            if ((a1 == 1.0 || a1 == 0.0) && (a2 == 1.0 || a2 == 0.0) && (a3 == 1.0 || a3 == 0.0) && (b1 == 1.0 || b1 == 0.0) && (b2 == 1.0 || b2 == 0.0) && (b3 == 1.0 || b3 == 0.0) && (c1 == 1.0 || c1 == 0.0) && (c2 == 1.0 || c2 == 0.0) && (c3 == 1.0 || c3 == 0.0))
                            {
                                ZO = true;
                                if ((det == 1 || det == -1) && (a1 + a2 + a3 + b1 + b2 + b3 + c1 + c2 + c3 == 3))
                                {
                                    Per = true;
                                }
                            }
                            if (a2 == b1 && a3 == c1 && b3 == c2)
                            {
                                Sym = true;
                            }
                            Console.WriteLine("Identity Matrix    : {0}", Ide);
                            Console.WriteLine("Scalar Matrix      : {0}", Sca);
                            Console.WriteLine("Diagonal Matrix    : {0}", Dia);
                            Console.WriteLine("Zero-one Matrix    : {0}", ZO);
                            Console.WriteLine("Symmetric Matrix   : {0}", Sym);
                            Console.WriteLine("Permutation Matrix : {0}", Per);
                            Console.WriteLine("*".PadRight(46, '*'));
                            Console.WriteLine("The Step of Comparison of the Elements      :");
                            Console.WriteLine("*".PadRight(46, '*'));
                            double min1 = ((a1 <= b1) ? a1 : b1) <= c1 ? ((a1 <= b1) ? a1 : b1) : c1;
                            double min2 = ((a2 <= b2) ? a2 : b2) <= c2 ? ((a2 <= b2) ? a2 : b2) : c2;
                            double min3 = ((a3 <= b3) ? a3 : b3) <= c3 ? ((a3 <= b3) ? a3 : b3) : c3;
                            Console.WriteLine($"Minimum values of each row: {min1} {min2} {min3} ");
                            double max1 = ((a1 >= a2) ? a1 : a2) >= a3 ? ((a1 >= a2) ? a1 : a2) : a3;
                            double max2 = ((b1 >= b2) ? b1 : b2) >= b3 ? ((b1 >= b2) ? b1 : b2) : b3;
                            double max3 = ((c1 >= c2) ? c1 : c2) >= c3 ? ((c1 >= c2) ? c1 : c2) : c3;
                            Console.WriteLine($"Maximum values of each column: {max1} {max2} {max3} ");
                            double maxmin = ((min1 >= min2) ? min1 : min2) >= min3 ? ((min1 >= min2) ? min1 : min2) : min3;
                            double minmax = ((max1 <= max2) ? max1 : max2) <= max3 ? ((max1 <= max2) ? max1 : max2) : max3;
                            Console.WriteLine($"Maximum of minimum values of each row(maxmin) : {maxmin}");
                            Console.WriteLine($"Minimum of maximum values of each column(minmax): : {minmax}");
                            if (maxmin < minmax)
                            {
                                Console.WriteLine("Compare maxmin to minmax: maxmin<minmax");
                            }
                            else if (maxmin < minmax)
                            {
                                Console.WriteLine("Compare maxmin to minmax: maxmin>minmax");
                            }
                            else
                            {
                                Console.WriteLine("Compare maxmin to minmax: maxmin=minmax");
                            }
                            continue;
                        }
                    case "3*4":
                        {
                            double a1, a2, a3, b1, b2, b3, c1, c2, c3, d1, d2, d3;
                            Console.WriteLine("_".PadRight(46, '_'));
                            Console.WriteLine("Format of the matrix to be entered:");
                            Console.WriteLine("| a1 b1 c1 d1 |");
                            Console.WriteLine("| a2 b2 c2 d2 |");
                            Console.WriteLine("| a3 b3 c3 d3 |");
                            Console.WriteLine("_".PadRight(46, '_'));
                            Console.WriteLine("Enter the matrix elements");
                            Console.Write("a1= ");
                            a1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("a2= ");
                            a2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("a3= ");
                            a3 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("b1= ");
                            b1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("b2= ");
                            b2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("b3= ");
                            b3 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("c1= ");
                            c1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("c2= ");
                            c2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("c3= ");
                            c3 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("d1= ");
                            d1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("d2= ");
                            d2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("d3= ");
                            d3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("_".PadRight(46, '_'));
                            Console.WriteLine("Entered matrix: ");
                            Console.WriteLine($"| {a1} {b1} {c1} {d1} |");
                            Console.WriteLine($"| {a2} {b2} {c2} {d2} |");
                            Console.WriteLine($"| {a3} {b3} {c3} {d3} |");
                            Console.WriteLine("_".PadRight(46, '_'));
                            Console.WriteLine("Conversion of the Matrix: ");
                            Console.WriteLine("_".PadRight(46, '_'));
                            Console.WriteLine("Step 1. ");
                            b1 = b1 / a1;
                            c1 = c1 / a1;
                            d1 = d1 / a1;
                            a1 = 1;
                            Console.WriteLine($"| {a1:0.#}  {b1:0.#}  {c1:0.#}  {d1:0.#} |");
                            Console.WriteLine($"| {a2:0.#}  {b2:0.#}  {c2:0.#}  {d2:0.#} |");
                            Console.WriteLine($"| {a3:0.#}  {b3:0.#}  {c3:0.#}  {d3:0.#} |");
                            Console.WriteLine("_".PadRight(46, '_'));
                            Console.WriteLine("Step 2. ");
                            b2 -= b1 * a2;
                            c2 -= c1 * a2;
                            d2 -= d1 * a2;
                            a2 = 0;
                            Console.WriteLine($"| {a1:0.#}  {b1:0.#}  {c1:0.#}  {d1:0.#} |");
                            Console.WriteLine($"| {a2:0.#}  {b2:0.#}  {c2:0.#}  {d2:0.#} |");
                            Console.WriteLine($"| {a3:0.#}  {b3:0.#}  {c3:0.#}  {d3:0.#} |");
                            Console.WriteLine("_".PadRight(46, '_'));
                            Console.WriteLine("Step 3. ");
                            b3 -= b1 * a3;
                            c3 -= c1 * a3;
                            d3 -= d1 * a3;
                            a3 = 0;
                            Console.WriteLine($"| {a1:0.#}  {b1:0.#}  {c1:0.#}  {d1:0.#} |");
                            Console.WriteLine($"| {a2:0.#}  {b2:0.#}  {c2:0.#}  {d2:0.#} |");
                            Console.WriteLine($"| {a3:0.#}  {b3:0.#}  {c3:0.#}  {d3:0.#} |");
                            Console.WriteLine("_".PadRight(46, '_'));
                            Console.WriteLine("Step 4. ");
                            c2 /= b2;
                            d2 /= b2;
                            b2 = 1;
                            Console.WriteLine($"| {a1:0.#}  {b1:0.#}  {c1:0.#}  {d1:0.#} |");
                            Console.WriteLine($"| {a2:0.#}  {b2:0.#}  {c2:0.#}  {d2:0.#} |");
                            Console.WriteLine($"| {a3:0.#}  {b3:0.#}  {c3:0.#}  {d3:0.#} |");
                            Console.WriteLine("_".PadRight(46, '_'));
                            Console.WriteLine("Step 5. ");
                            c1 -= c2 * b1;
                            d1 -= d2 * b1;
                            b1 = 0;
                            Console.WriteLine($"| {a1:0.#}  {b1:0.#}  {c1:0.#}  {d1:0.#} |");
                            Console.WriteLine($"| {a2:0.#}  {b2:0.#}  {c2:0.#}  {d2:0.#} |");
                            Console.WriteLine($"| {a3:0.#}  {b3:0.#}  {c3:0.#}  {d3:0.#} |");
                            Console.WriteLine("_".PadRight(46, '_'));
                            Console.WriteLine("Step 6. ");
                            c3 -= c2 * b3;
                            d3 -= d2 * b3;
                            b3 = 0;
                            Console.WriteLine($"| {a1:0.#}  {b1:0.#}  {c1:0.#}  {d1:0.#} |");
                            Console.WriteLine($"| {a2:0.#}  {b2:0.#}  {c2:0.#}  {d2:0.#} |");
                            Console.WriteLine($"| {a3:0.#}  {b3:0.#}  {c3:0.#}  {d3:0.#} |");
                            Console.WriteLine("_".PadRight(46, '_'));
                            Console.WriteLine("Step 7. ");
                            d3 /= c3;
                            c3 /= c3;
                            Console.WriteLine($"| {a1:0.#}  {b1:0.#}  {c1:0.#}  {d1:0.#} |");
                            Console.WriteLine($"| {a2:0.#}  {b2:0.#}  {c2:0.#}  {d2:0.#} |");
                            Console.WriteLine($"| {a3:0.#}  {b3:0.#}  {c3:0.#}  {d3:0.#} |");
                            Console.WriteLine("_".PadRight(46, '_'));
                            Console.WriteLine("Step 8. ");
                            d1 -= c1 * d3;
                            c1 = 0;
                            Console.WriteLine($"| {a1:0.#}  {b1:0.#}  {c1:0.#}  {d1:0.#} |");
                            Console.WriteLine($"| {a2:0.#}  {b2:0.#}  {c2:0.#}  {d2:0.#} |");
                            Console.WriteLine($"| {a3:0.#}  {b3:0.#}  {c3:0.#}  {d3:0.#} |");
                            Console.WriteLine("_".PadRight(46, '_'));
                            Console.WriteLine("Step 9. ");
                            d2 -= c2 * d3;
                            c2 = 0;
                            Console.WriteLine($"| {a1:0.#}  {b1:0.#}  {c1:0.#}  {d1:0.#} |");
                            Console.WriteLine($"| {a2:0.#}  {b2:0.#}  {c2:0.#}  {d2:0.#} |");
                            Console.WriteLine($"| {a3:0.#}  {b3:0.#}  {c3:0.#}  {d3:0.#} |");
                            Console.WriteLine("_".PadRight(46, '_'));
                            Console.WriteLine("The Value of Unknowns: (x,y,z) ");
                            Console.WriteLine($"x= {d1:0.#}");
                            Console.WriteLine($"y= {d2:0.#}");
                            Console.WriteLine($"z= {d3:0.#}");
                            continue;
                        }
                    default:
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine("_".PadRight(46, '_'));
                        continue;
                }
            }
        }

    }
}