namespace WindowCommandTool
{
    public class CommandReader
    {
        public void CommandTaker(string command, string? option, string fileName)
        {

            command = command.ToLower();
            if (string.IsNullOrEmpty(command) || command != "ccwc")
            {
                Console.WriteLine("Command not known");
            }

            switch (option)
            {
                case "-c":
                    CalculateByteSum(fileName);
                    break;

                case "-l":
                    OutputNumberOfLines(fileName);
                    break;
                case "-m":
                    OutputNumbersOfCharacters(fileName);
                    break;
                case "-w":
                    OutputNumbersOfWords(fileName);
                    break;
                default :
                    DefaultOutput(fileName);
                    break;
            }



        }
        private void CalculateByteSum(string file)
        {

            var directoryPath = FileLocation();
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            var path = Path.Combine(directoryPath, file);


            var output = File.ReadAllBytes(path);
            var byteSum = output.Sum(x => x);
            Console.WriteLine(byteSum);



        }


        private void OutputNumberOfLines(string file)
        {
            var directoryPath = FileLocation();
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            var path = Path.Combine(directoryPath, file);

            var texts = File.ReadAllText(path).Split("\n").Count();
            Console.WriteLine(texts);

        }

        private void OutputNumbersOfCharacters(string file)
        {
            var directoryPath = FileLocation();
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            var path = Path.Combine(directoryPath, file);
            var result = File.ReadAllText(path).Replace(" ", "").Replace("\r\n", "").Length;
            Console.WriteLine(result);
        }

        private void OutputNumbersOfWords(string file)
        {
            var directoryPath = FileLocation();
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            var path = Path.Combine(directoryPath, file);
            var result = File.ReadAllText(path).Replace("\r\n", " ").Split(" ").Count();
            Console.WriteLine(result);
        }

        private void DefaultOutput(string file)
        {
            var directoryPath = FileLocation();

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            var path = Path.Combine(directoryPath, file);
            OutputNumbersOfWords(file);
            CalculateByteSum(file);
            OutputNumbersOfCharacters(file);

        }

        public string FileLocation()
        {
            return ("C:\\Users\\THINKBOOK\\source\\repos\\WindowCommandTool\\WindowCommandTool\\File\\");
        }
    }
}

