using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInterviewDoro
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"..\..\Questions.txt";
            try     // will run only if Questions.txt exists. If it doesn't it will move on to one of the catch blocks
            {
                StreamReader reader = new StreamReader(fileName);
                StreamWriter realWriter = new StreamWriter("..\\..\\Answers.txt");
                StreamWriter writer = new StreamWriter("..\\..\\FakeAnswers.txt");
                StringBuilder sb = new StringBuilder();
                //Console.WriteLine("File {0} successfully opened.", fileName);
                //int answerNum = 0;

                using(reader)
                {
                    string line = reader.ReadLine();    // reads first line of the Questions file

                    while (line != null)    // while loop will execute will there are lines in the Questions text file
                    {
                        Console.WriteLine(line);    // writes the current line it is on in the console
                        //answerNum++;
                        sb.Append(Console.ReadLine());  // adds the user input to the stringbuilder sb
                        sb.AppendLine("\n");    // adds a new line to stringbuilder to move down a line in text
                        sb.AppendLine("\n");    // add a new line to stringbuilder to move down a line in text
                        line = reader.ReadLine();   // reads the next line of the text file
                    }
                    
                }
                using (writer)
                    {
                        writer.WriteLine(sb);   // writes whatever is in stringbuilder into the text file called Answers
                    }
            }
            catch (FileNotFoundException)   // if file Questions.txt doesn't exist, this block will execute and display the 
                                            // following error
            {
                Console.WriteLine ("Can not find file {0}.", fileName);
            }
            catch (DirectoryNotFoundException)  // if the directory doesn't exist, this block will execute and display the 
            // following error
            {
                Console.Error.WriteLine("Invalid directory in the file path.");
            }
            catch (IOException) // if file Questions.txt is corrupted or something, this block will execute and display the 
            // following error
            {
                Console.Error.WriteLine("Cannot open the file {0}", fileName);
            }
            Console.ReadLine();
            }

        }
    }

