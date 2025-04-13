# WindowCommandTool

## Overview
The **WindowCommandTool** is a command-line utility designed to perform various operations on text files. 
It supports commands to calculate the byte sum, count lines, count characters, and count words in a specified file. The tool is implemented in C# and targets .NET 8.

## Features
- **Byte Sum Calculation**: Computes the sum of all bytes in the file.
- **Line Count**: Outputs the number of lines in the file.
- **Character Count**: Outputs the number of characters in the file (excluding spaces and newlines).
- **Word Count**: Outputs the number of words in the file.
- **Default Output**: Executes all the above operations if no specific option is provided.

## Usage
The program accepts commands in the following format:

### Commands and Options
- `ccwc -c [fileName]`: Calculate the byte sum of the file.
- `ccwc -l [fileName]`: Count the number of lines in the file.
- `ccwc -m [fileName]`: Count the number of characters in the file.
- `ccwc -w [fileName]`: Count the number of words in the file.
- `ccwc [fileName]`: Perform all operations (default behavior).

### Example
To count the number of lines in a file named `test.txt`: ccwc -l test.txt

## File Location
The program expects files to be located in the following directory:C:\Users\THINKBOOK\source\repos\WindowCommandTool\WindowCommandTool\File\

Ensure the file exists in this directory before running the command.

## Installation
1. Clone the repository.
2. Open the solution in Visual Studio 2022.
3. Build the project targeting .NET 8.

## Running the Program
1. Open a terminal or command prompt.
2. Navigate to the directory containing the compiled executable.
3. Run the program using the command format described above.

## Notes
- The program will create the required directory if it does not exist.
- If the command is invalid or the file is not found, appropriate error messages will be displayed.

## License
This project is licensed under the MIT License.


