using System;

class Program
{
//     static void Main(string[] args)
//     {
        
//         Student student = new Student ("id1", "John", "Computer Science");
//         Faculty faculty = new Faculty ("id2", "Professor Jane", "Bioagriculture");

//         student.Display();
//         faculty.Display();

//         List<Person> people = new List<Person>();
//         people.Add(student);
//         people.Add(faculty);

//         foreach (Person person in people) {
            
//         }
//     }
}

// class Person {
//     protected string id;
//     protected string name;

//     public Person(string id, string name) {
//         this.id = id;
//         this.name = name;
//     }
// }

// class Student: Person {
//     private string major;

//     public Student (string id, string name, string major): base (id, name){
//         this.major = major;
//     }

//     public void Display() {
//         System.Console.WriteLine("ID: {0}, Name: {1}. Department: {2}", id, name, department);
//     }
// }

// class Faculty


class Vehicle {
    protected string make;
    protected string model;
    protected int miles;

    public Vehicle (string make, string model, int miles) {
        this.make = make;
        this.model = model;
        this.miles = miles;
    }
}

class Car: Vehicle {
    private bool hybrid;

    public Car (string make, string model, int miles, bool hybrid): base (make, model, miles){
        this.hybrid = hybrid;
    }
}

class Truck: Vehicle {
    private int towing;

    public Truck (string make, string model, int miles, int towing) : base(make, model, miles) {
        this.towing = towing;
    }
}
