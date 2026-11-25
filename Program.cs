namespace SrudentManagementSystem_
{
    internal class Program
    {

       

        static void Main(string[] args)
        {
            List<Student> student = new List<Student>();
            int ch=0;
            

            while(ch!=6)
            {
                Console.WriteLine("\nselect the operation");
                Console.WriteLine("1.Add student");
                Console.WriteLine("2.update student");
                Console.WriteLine("3.delete student");
                Console.WriteLine("4.display student");
                Console.WriteLine("5.Display All Student");
                Console.WriteLine("6.Exit");
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine();
                ch=Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Student s = new Student();
                        Console.WriteLine("Enter Student Details");
                        Console.WriteLine("Enter Student Id");

                        int studentId= Convert.ToInt32(Console.ReadLine());
                        if(student.Any(s => s.id == studentId))
                        {
                            Console.WriteLine("Student Already Exist");
                        }
                        else
                        {
                            s.id = studentId;
                            Console.WriteLine("Enter Student name");
                            s.studentName = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Enter Student Age");
                            s.age = Convert.ToInt32(Console.ReadLine());
                            student.Add(s);
                            Console.WriteLine("student added successfully");

                        }
                        

                        break;
                    case 2: 
                        Console.WriteLine("Enter Student Id");
                        int studentId1=Convert.ToInt32(Console.ReadLine());
                        Student s1 = student.Find(s => s.id == studentId1);
                        if (s1 == null)
                        {
                            Console.WriteLine("Student not found");
                        }
                        else
                        {
                            Console.WriteLine("id=" + s1.id);
                            Console.WriteLine("name=" + s1.studentName);
                            Console.WriteLine("age=" + s1.age);
                            Console.WriteLine("---------------------");

                            Console.WriteLine("Enter Student name");
                            s1.studentName = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Enter Student Age");
                            s1.age = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("student Update successfully");

                        }


                            break;
                    case 3:
                        Console.WriteLine("Enter student id");
                        int studentId2=Convert.ToInt32( Console.ReadLine());
                        Student s2=student.Find(x=>x.id== studentId2);
                        if (s2 == null)
                        {
                            Console.WriteLine("student Not Exist by this id");
                        }
                        else
                        {
                            student.Remove(s2);
                            Console.WriteLine("Deleted Successfully");
                        }
                        break;
                    case 4: 
                        Console.WriteLine("Enter Student Id");
                        int studentid = Convert.ToInt32(Console.ReadLine());
                        Student s3=student.Find(x=>x.id== studentid);
                        if (s3 == null)
                        {
                            Console.WriteLine("Student Not Exist");
                        }
                        else
                        {
                            Console.WriteLine("id=" + s3.id);
                            Console.WriteLine("name=" + s3.studentName);
                            Console.WriteLine("age=" + s3.age);

                        }
                        break;
                    case 5:
                        if (student.Count == 0)
                        {
                            Console.WriteLine("Student Not Exists");
                        }
                        else
                        {
                            foreach (Student i in student)
                            {
                                Console.WriteLine("id=" + i.id);
                                Console.WriteLine("name=" + i.studentName);
                                Console.WriteLine("age=" + i.age);
                                Console.WriteLine("---------------------");

                            }

                        }
                        
                        break;
                    default: Console.WriteLine("Enter Valid Choice");
                            break;
                }

            } ;
            




        }
    }
}
