// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;
using System.Xml.Linq;

const string CommandSetName = "1 - установите имя. ";
const string CommandChangeConsoleColore = "2 - именение цвета консоли - зелёный. ";
const string InitialConsoleSettings = "3 - начальные настройки консоли.";
const string CommandSetPassword = "4 - установите пароль. ";
const string CommandWriteName = "5 - вывести имя после ввода пароля. ";
const string CommandEsc = "6 - выход из программы. ";

bool isExite = false;
string exit_message = "Выход из программы! Нажмите любую клавишу!";
string userInput;
string nameUser = "";
string invalidInput = "";
string missingName = "Имя не установлено. Введите имя!";
string nameReceived = "Имя получено! ";
string passwordUser = "";
string passwordReceived = "Пароль получен. ";
string missingPasswordUser = "Пароль не установлен. Устновите пароль.";
string noOption = "Такого варианта нет. ";
string programMenu = $"Выберете действие:\n" +
        $"{CommandSetName}\n" +
        $"{CommandChangeConsoleColore}\n" +
        $"{InitialConsoleSettings}\n" +
        $"{CommandSetPassword}\n" +
        $"{CommandWriteName}\n" +
        $"{CommandEsc}";
    
Console.WriteLine(programMenu);

while (isExite == false)
{
    userInput = Console.ReadLine();

    switch (userInput)
    {
        case "1":
            nameUser = Console.ReadLine();

            if (userInput != invalidInput)
            {
                Console.WriteLine(nameReceived);
            }
            else
            {
                Console.WriteLine(missingName);
            }
            break;
        
        case "2":
            Console.BackgroundColor = ConsoleColor.Green;
            break;
        
        case "3":
            Console.ResetColor();
            break;
        
        case "4":
            passwordUser = Console.ReadLine();
            Console.WriteLine(passwordReceived);
            break;
        
        case "5":
            if (nameUser != invalidInput)
            {
                userInput = Console.ReadLine();

                if (userInput == passwordUser)
                {
                    Console.WriteLine(nameUser);
                }
                else if (userInput != invalidInput)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(missingPasswordUser);
                }
            }
            else
            {
                Console.WriteLine(missingName);
            }
            break;
        
        case "6":
            Console.WriteLine(exit_message);
            Console.ReadKey();
            isExite = true;
            break;
        
        default:
            Console.WriteLine(noOption);
            break;   
    }
}
