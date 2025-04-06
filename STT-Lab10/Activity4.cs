using System;
class Student {
    public string Name { get; set; }
    public int ID { get; set; }
    public double Marks { get; set; }

    public Student(string name, int id, double marks) {
        Name = name;
        ID = id;
        Marks = marks;
    }

    public char getGrade() {
        if (Marks >= 90) return 'A';
        else if (Marks >= 80) return 'B';
        else return 'C';
    }
}

class StudentIITGN : Student {
    public string Hostel_Name_IITGN { get; set; }

    public StudentIITGN(string name, int id, double marks, string hostel) 
        : base(name, id, marks) {
        Hostel_Name_IITGN = hostel;
    }

    static void Main() {
        StudentIITGN student = new StudentIITGN("John", 101, 85.5, "Arawali");
        Console.WriteLine($"Name: {student.Name}, Hostel: {student.Hostel_Name_IITGN}, Grade: {student.getGrade()}");
    }
}
