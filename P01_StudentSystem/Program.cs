using Microsoft.VisualBasic;
using P01_StudentSystem.Data;
using P01_StudentSystem.Models;

namespace P01_StudentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext context = new AppDbContext();
            char c = ' ';
            do
            {
                Console.WriteLine("A- Add New Student");
                Console.WriteLine("B- Add New Course");
                Console.WriteLine("Q-Quite");
                Console.WriteLine("=========================");
                Console.WriteLine("Enter Your Choice");
                c =char.Parse(Console.ReadLine());
                switch (c)
                {
                    case 'a':
                    case 'A': Student student = new Student();
                        Console.WriteLine("Name:");
                        student.Name = Console.ReadLine();
                        Console.WriteLine("PhoneNumber must be Less Than 10");
                        do
                        {
                            Console.WriteLine("PhoneNumber:");
                            student.PhoneNumber = Console.ReadLine();
                        }while (student.PhoneNumber.Length>10);
                        Console.WriteLine("RegisteredOn become Already Now ");
                        student.RegisteredOn=DateTime.Now;
                        Console.WriteLine("Birthday:");

                        int year;
                        int month;
                        int day;
                        do
                        {
                            Console.WriteLine("please Enter Valid year :");

                            year = int.Parse(Console.ReadLine());

                        } while (year > 2024 || year <= 1800);
                        do
                        {
                            Console.WriteLine("please Enter Valid month :");

                            month = int.Parse(Console.ReadLine());

                        } while (month > 12 || month <= 0);

                        if (month == 2)
                        {
                            do
                            {

                                Console.WriteLine("please Enter Valid day :");

                                day = int.Parse(Console.ReadLine());

                            } while (day > 29 || day <= 0);
                        }
                        else if (month == 4 || month == 6 || month == 11 || month == 9)
                        {
                            do
                            {

                                Console.WriteLine("please Enter Valid day :");

                                day = int.Parse(Console.ReadLine());

                            } while (day > 30 || day <= 0);



                        }
                        else
                        {
                            do
                            {

                                Console.WriteLine("please Enter Valid day :");

                                day = int.Parse(Console.ReadLine());

                            } while (day > 31 || day <= 0);


                        }
                        var date = new DateTime(year, month, day);
                        Console.WriteLine(date);
                        student.Birthday = date;

                        try { 
                        
                        context.Students.Add(student);
                        context.SaveChanges();
                            Console.WriteLine("Student Added Sucessfully ");
                        } catch {
                            Console.WriteLine("Error");
                        }

                        break;

                    case 'b':
                    case 'B':
                        Course course = new Course();
                        Console.WriteLine("Course Name: ");
                        course.Name = Console.ReadLine();
                        Console.WriteLine("Description :");
                        course.Description = Console.ReadLine();
                        Console.WriteLine("StartDate Already From Now");
                        course.StartDate= DateTime.Now;
                        Console.WriteLine("EndDate:");
                        int d;
                        int m;
                        int y;
                        DateTime dat;
                        do
                        {
                            Console.WriteLine($"Please Enter Valid Date Biger Than {course.StartDate}");
                            Console.WriteLine("Enter day :");
                            d = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Month :");
                            m = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Year :");
                            y = int.Parse(Console.ReadLine());
                            dat = new DateTime(y, m, d);

                        } while (dat<=course.StartDate);
                        course.EndDate = dat;
                        Console.WriteLine("Price :");
                        course.Price = double.Parse(Console.ReadLine());


                        try{ 
                        
                            context.Courses.Add(course);
                            context.SaveChanges();
                            Console.WriteLine("Course Added Sucessfully ");
                        }
                        catch { Console.WriteLine("Error"); }

                        break;
                    case 'q':
                    case 'Q':
                        Console.WriteLine("GoodBy...");
                        break;
                        default: Console.WriteLine("Invalid");
                        break;

                }
            } while (c!='q'&&c!='Q');


            
            
        }
    }
}
