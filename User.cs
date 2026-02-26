namespace UserManagementSystem
{
    public class User
    {


        private static int _counter = 0;

        private int _id { get; set; }
        private string _name { get; set; }
        private string _email { get; set; }
        private string _phoneNum { get; set; }

        public override string ToString()
        {
            return "\n=======================" +
                  $"\nID:{_id}" +
                  $"\nName:{_name}" +
                  $"\nEmail:{_email}" +
                  $"\nPhone Number:{_phoneNum}";

        }

        public void Add(List<User> list)
        {
            Console.WriteLine("============Add User============");
            Console.Write("Enter name:");
            _name = Console.ReadLine();
            Console.Write("Enter Email:");
            _email = Console.ReadLine();
            Console.Write("Enter Phone Number:");
            _phoneNum = Console.ReadLine();
            _id = ++_counter;
            list.Add(this);

        }

        public static void Update(List<User> list) 
        {
            Console.Write("Enter id for user u want to update: ");
            int id = Convert.ToInt32(Console.ReadLine());
      

            var result = list.FirstOrDefault((item) => id == item._id);
            if (result != null)
            {
                Console.Write("To edit Name prees 1\nTo edit Email prees 2\nTo edit phone number prees 3\n---> ");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.Write("enter edited name : ");
                        result._name = Console.ReadLine(); break;
                    case 2:
                        Console.Write("enter edited email : ");
                        result._email = Console.ReadLine(); break;
                    case 3:
                        Console.Write("enter edited phone number : ");
                        result._phoneNum = Console.ReadLine(); break;
                    default:
                        Console.WriteLine("INVALID CHOICE"); break;
                }
                Console.WriteLine($"This user {result._name} is updated!!"); return;
            }
             Console.WriteLine("This user is not existed!!");



        }

        public static void Delete(List<User> list)
        {
            Console.WriteLine("============Delete User============");
            Console.Write("Enter id of elment u want to delete:");
            int id = Convert.ToInt32(Console.ReadLine());

           var result= list.FirstOrDefault((item) => item._id == id);
            if (result != null) { 
                list.Remove(result);
            Console.WriteLine($"{result._name} Deleted"); 
            }
            else Console.WriteLine("This user is not existed!!");

        }

        public static void PrintAllUsere(List<User> list)
        {
            if(list.Count == 0) { Console.WriteLine("no users to print!!"); return; }
            Console.WriteLine("============All Users============");

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (User u in list) Console.WriteLine(u);
            Console.ResetColor();


        }

    }
}
