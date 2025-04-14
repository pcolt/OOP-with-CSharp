var db = Database.Instance;

var employees = db.GetEmployees();
foreach (var employee in employees) {
    Console.WriteLine(employee.Name);
}

var task1 = Task.Run(async () => {
    await Task.Delay(1000);
    Console.WriteLine("Inside async task1:");
    db.UpsertEmployee(new EmployeeEntity {
        Id = 3,
        Name = "Giorgio Neri",
    });
    Console.WriteLine("After modifiying an employee in tssk1:");
    employees = db.GetEmployees();
    foreach (var employee in employees) {
        Console.WriteLine(employee.Name);
    }

    db.RemoveEmployee(new IdModel {
        Id = 1,
    });
    Console.WriteLine("After removing an employee in task1:");
    employees = db.GetEmployees();
    foreach (var employee in employees) {
        Console.WriteLine(employee.Name);
    } 
});

var task2 =  Task.Run(() => {
    Console.WriteLine("Inside async task2:");
    db.UpsertEmployee(new EmployeeEntity {
        Id = 4,
        Name = "Sara Bianchi",
    });
    Console.WriteLine("After modifiying an employee in task2:");
    employees = db.GetEmployees();
    foreach (var employee in employees) {
        Console.WriteLine(employee.Name);
    }
});

await Task.WhenAll(task1, task2);

Console.WriteLine("After async tasks have finished:");
employees = db.GetEmployees();
foreach (var employee in employees) {
    Console.WriteLine(employee.Name);
}

public class Database {
    /*
        SINGLETON is made of 3 steps:
        - private instance constructor
        - public static instance
        - static initialization of the instance.
    */

    // The private constructor prevents any other class from instantiating the Database class directly. 
    // This ensures that the only way to get an instance of the Database class is through the Instance property.
    private Database() {
        _employees = new List<EmployeeEntity> {
            new EmployeeEntity {
                Id = 1,
                Name = "Mario Rossi",
            },
            new EmployeeEntity {
                Id = 2,
                Name = "Luigi Verdi",
            },
            new EmployeeEntity {
                Id = 3,
                Name = "Anna Gialli",
            },
        };
    }

    // The static constructor is called automatically before any static fields are accessed or any static methods are called. 
    // It ensures that the Instance is initialized before it is used.
    static Database() {
        Instance = new Database();
    }

    public static Database Instance { get; }

    private List<EmployeeEntity> _employees;
    public List<EmployeeEntity> GetEmployees() {
        return _employees;
    }

    public void UpsertEmployee(EmployeeEntity employee) {
        var existingEmployee = _employees.FirstOrDefault(e => e.Id == employee.Id);
        if (existingEmployee != null) {
            existingEmployee.Name = employee.Name;
        } else {
            _employees.Add(employee);
        }
    }

    public void RemoveEmployee(IdModel Id) {
        _employees.RemoveAll(e => e.Id == Id.Id);
    }

}

public class IdModel {
    public int Id { get; set; }
}

public class EmployeeEntity : IdModel {
    public string Name { get; set; }
}