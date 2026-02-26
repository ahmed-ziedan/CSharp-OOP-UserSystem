namespace UserManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool LoopStatus = true;
            List<User> list = new List<User>();
            while (LoopStatus)
            {
                Console.WriteLine("1-Add User\n2-Update User\n3-Delete User\n4-Print All users\n0-EXIT");
                int choice = Convert.ToInt32(Console.ReadLine());
                

                switch (choice) 
                {
                    case 1: User user = new User(); user.Add(list);            break;
                    case 2: User.Update(list);         break;
                    case 3: User.Delete(list);         break;
                    case 4: User.PrintAllUsere(list);  break;
                    case 0: return;

                    default:
                        Console.WriteLine("NOT IN CHOICE, TRY AGAIN!");
                        break;

                }
                AnyThingElse();


            }



             void AnyThingElse()
            {
                Console.WriteLine("Do you want anything else?\nY/N");
                char input = Convert.ToChar(Console.ReadLine().ToUpper());
                //if(input != "Y" &&  input != "N") {
                if (input == 'N') LoopStatus = false;
                else if (input == 'Y') Console.WriteLine("=================");
            }
        }

    
    }
}
