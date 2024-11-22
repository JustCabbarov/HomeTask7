namespace HOMETASK11_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter FullName");
            string fullname = Console.ReadLine();
            Console.WriteLine("Enter Email");
            string email = (Console.ReadLine());
            Console.WriteLine("Enter Password");
            string password = (Console.ReadLine());
            User user1 = new User(fullname, email, password);
            Console.WriteLine("ADD Point");
            Student student1 = new Student()
            {
            
                Fullname = fullname,
                Point=Convert.ToInt32(Console.ReadLine()),

            };
         
            
            
     

            Console.WriteLine("1. Show Info");
            Console.WriteLine("2. Create New group");
            int imput = Convert.ToInt32(Console.ReadLine());
            Group group = null;
            switch (imput)
            {
                case 1:
                    user1.ShowInfo();

                    break;
                case 2:
                    Console.WriteLine("Enter GroupNo");
                    string GroupNo = Console.ReadLine();

                    Console.WriteLine("Enter GroupLimit");
                    int StudentLimit = Convert.ToInt32(Console.ReadLine());
                    group = new Group(GroupNo, StudentLimit); 
                    break;
                    
            }
                    group.AddStudent(student1);
             
            int number;

            do
            {
               
                Console.WriteLine("1. Show All Student");
                Console.WriteLine("2. Get Student By Id");
                Console.WriteLine("3. Add Student");
                Console.WriteLine("0. Quit");
                 number = Convert.ToInt32(Console.ReadLine());

                switch (number)
                {
                    case 1:

                        var students = group.GetAllStudents();
                        
                            foreach (var student in students)
                        {
                                student.StudentInfo();
                        }


                        break;
                        
                    case 2:
                        Console.WriteLine("Enter Id");
                        int wantedid = Convert.ToInt32(Console.ReadLine());
                        var SelectedStudent = group.GetStudent(wantedid);
                        SelectedStudent.StudentInfo();


                        break;
                    case 3:
                        Console.WriteLine("Enter FullName");
                        string fullname1 = Console.ReadLine();
                        Console.WriteLine("Enter Piont");
                        int point1 = Convert.ToInt32(Console.ReadLine());
                        Student student2 = new Student(fullname1, point1);
                        group.AddStudent(student2);
                        break;
                    case 0:
                        Console.WriteLine("The program has been suspended");
                        break;
                    default:
                        Console.WriteLine("Enter the correct transaction");
                        break;

                }





                
            }while (number != 0) ;



        }
    }
}
