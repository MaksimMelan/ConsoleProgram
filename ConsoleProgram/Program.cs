// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;
using System.Xml.Linq;

const string CommandSetName = "1";
const string CommandChangeConsoleColore = "2";
const string InitialConsoleSettings = "3";
const string CommandSetPassword = "4";
const string CommandWriteName = "5";
const string CommandEsc = "6";

bool isExit = false;
string exitMessage = "Выход из программы! Нажмите любую клавишу!";
string userInput;
string nameUser = string.Empty;
string invalidInput = string.Empty;
string missingNameMessage = "Имя не установлено. Введите имя!";
string nameReceived = "Имя получено! ";
string passwordUser = string.Empty;
string passwordReceived = "Пароль получен. ";
string missingPasswordUserMessage = "Пароль не установлен. Устновите пароль.";
string invalidPasswordMessage = "Пароль не верный.";
string noOption = "Такого варианта нет. ";
string programMenu = $"Выберете действие:\n" +
        $"{CommandSetName} - установите имя. \n" +
        $"{CommandChangeConsoleColore} - именение цвета консоли - зелёный.\n" +
        $"{InitialConsoleSettings} - начальные настройки консоли.\n" +
        $"{CommandSetPassword} - установите пароль.\n" +
        $"{CommandWriteName} - вывести имя после ввода пароля.\n" +
        $"{CommandEsc} - выход из программы. ";
    
Console.WriteLine(programMenu);

while (isExit == false)
{
    userInput = Console.ReadLine();

    switch (userInput)
    {
        case CommandSetName:
            nameUser = Console.ReadLine();

            if (userInput != invalidInput)
            {
                Console.WriteLine(nameReceived);
            }
            else
            {
                Console.WriteLine(missingNameMessage);
            }
            break;
        
        case CommandChangeConsoleColore:
            Console.BackgroundColor = ConsoleColor.Green;
            break;
        
        case InitialConsoleSettings:
            Console.ResetColor();
            break;
        
        case CommandSetPassword:
            passwordUser = Console.ReadLine();
            Console.WriteLine(passwordReceived);
            break;
        
        case CommandWriteName:
            if (nameUser != invalidInput)//проверка наличия имени
            {              
                if (passwordUser != invalidInput)//проверка на наличие пароля
                {
                    userInput = Console.ReadLine();// ввод пароля

                    if (userInput == passwordUser)//пароль верен
                    {
                        Console.WriteLine(nameUser);// вывод пароля.
                    }
                    else
                    {
                        Console.WriteLine(invalidPasswordMessage);// неправильный пароль
                    }
                }
                else
                {
                    Console.WriteLine(missingPasswordUserMessage);
                }

            }
            else
            {
                Console.WriteLine(missingNameMessage);
            }
            break;
        
        case CommandEsc:
            Console.WriteLine(exitMessage);
            Console.ReadKey();
            isExit = true;
            break;
        
        default:
            Console.WriteLine(noOption);
            break;   
    }
}
