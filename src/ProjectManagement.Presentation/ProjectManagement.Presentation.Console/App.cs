using ProjectManagement.Application.Commands;
using ProjectManagement.Application.Handlers;

namespace ProjectManagement.Presentation.Console;

public class App
{
    private readonly CreateEmployeeHandler _crEmpHandler;

    public App(CreateEmployeeHandler crEmHandler)
    {
        _crEmpHandler = crEmHandler;
    }

    public async Task RunAsync()
    {
        while(true)
        {
            System.Console.WriteLine("1.Добавить работника");
            System.Console.WriteLine("0.Выход");

            var choice = System.Console.ReadLine();

            switch(choice)
            {
                case "1":
                    await AddEmployee();
                    break;
                case "0":
                    return;
            }

        }
    }

    public async Task AddEmployee()
    {
        System.Console.WriteLine("Имя: ");
        var name = System.Console.ReadLine();
        System.Console.WriteLine("Email: ");
        var email = System.Console.ReadLine();
        System.Console.WriteLine("Номер рабочего пропуска: ");
        var workPass = System.Console.ReadLine();
        System.Console.WriteLine("Должность: ");
        var role = System.Console.ReadLine();

        var command = new CreateEmployeeCommand
        {
            EmployeeName = name,
            EmployeeEmail = email,
            EmployeeRole = role,
            EmployeeWorkPass = workPass
        };
        var result = await _crEmpHandler.Handle(command);

        if (result.IsSuccess)
        {
            System.Console.WriteLine($"Работник создан с Id: {result.EmployeeId}");
        }
        else
        {
            System.Console.WriteLine($"Ошибка: {result.ErrorMessage}");
        }
    }
}