namespace WindowCommandTool
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string? input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("command cannot be empty");
            }
            var command =  input!.Split(" ");

            CommandReader reader = new();
            if (command.Count() == 2)
            {
                var option = string.Empty;
                reader.CommandTaker(command[0], option, command[1]);
            }
            else
            {
                reader.CommandTaker(command[0], command[1], command[2]);
            }
            Console.WriteLine("Task Done");
          
        }

    }
}