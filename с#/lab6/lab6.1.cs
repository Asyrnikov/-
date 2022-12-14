using System;
using System.Collections.Generic;

public class Human{
    private string lastName;   // Фамилия
    private int birthYear; // Год рождения
    private string status;  // Статус
    
    // Конструктор с параметрами
    public Human(string lastName, 
                 int birthYear, 
                 string status){
        this.lastName = lastName;
        this.birthYear = birthYear;
        this.status = status;
    }
    // Конструктор без параметров
    public Human(): this("unknown", 0, "unknown"){
        this.lastName = "unknown";
        this.birthYear = 0;
        this.status = "unknown";
    }
    // Свойство для фамилии
    public string LastName{
        get{return lastName;}
        set{lastName = value;}
    }
    // Свойство для года рождения
    public int birthYear{
        get{return birthYear;}
        set{birthYear = value;}
    }
    // Свойство для статуса
    public string Status{
        get{return status;}
        set{status = value;}
    }
    // Виртуальный метод
    public virtual void Info(){
        DateTime d = DateTime.Now;
        Console.WriteLine("Возраст: " + (Convert.ToInt32(d.Year)-BirthYear));
    }
    // Метод вывода информации
    public void About(){
        Console.WriteLine("");
        Console.WriteLine("Фамилия: " + LastName);
        Console.WriteLine("Год рождения: " + BirthYear);
        Info();
        Console.WriteLine("Статус: " + Status);
    }
}

public class Student: Human{
    private int mathBall;  // Оценка по математике
    private int physBall;  // Оценка по физике
    private int histBall;  // Оценка по истории
    
    // Конструктор с параметрами
    public Student(string lastName, 
                   int birthYear, 
                   string status, 
                   int mathBall,
                   int physBall,
                   int histBall): base(lastName, birthYear, status){
        this.mathBall = mathBall;
        this.physBall = physBall;
        this.histBall = histBall;
    }
    // Свойство для оценки по математике
    public int MathBall{
        get{return mathBall;}
        set{mathBall = value;}
    }
    //С войство для оценки по физике
    public int PhysBall{
        get{return physBall;}
        set{physBall = value;}
    }
    // Свойство для оценки по истории
    public int HistBall{
        get{return histBall;}
        set{histBall = value;}
    }
    // Метод для подсчета среднего бала
    public float AverageBall(){
        float sum = MathBall+PhysBall+HistBall;
        float average = sum/3;
        return average;
    }
    // Переопределение метода для возврата максимальной оценки
    public override void Info(){
        int[] balls = new int[] {MathBall, PhysBall, HistBall};
        int maxBall = 0;
        for (int i=0; i<3; i++){
            if(balls[i]>maxBall) maxBall = balls[i];
        }
        Console.WriteLine("Максимальная оценка: " + maxBall);
    }
}

class AgeSort: IComparer<Human>{
    public int Compare(Human first, Human second){
        if (first.BirthYear > second.BirthYear) {
            return 1;
        }
        else if (first.BirthYear < second.BirthYear) {
            return -1;
        }
        else {
            return 0;
        }
    }
}

class LnameSort: IComparer<Human>{
    public int Compare(Human first, Human second){
        if (Convert.ToInt32(first.LastName[0]) > Convert.ToInt32(second.LastName[0])) {
            return 1;
        }
        else if (Convert.ToInt32(first.LastName[0]) < Convert.ToInt32(second.LastName[0])) {
            return -1;
        }
        else {
            return 0;
        }
    }
}

public class Program{
	public static void Main(){
	    Human p1 = new Human("Гореликов", 2002, "Студент");
	    Human p2 = new Human("Максимов", 2003, "Студент");
	    Human p3 = new Human("Гордон", 2004, "Студент");
	    Human p4 = new Human("Филков", 1990, "Преподаватель");
	    Human p5 = new Human("Ленцев", 2001, "Студент");
		Human[] people = new Human[] {p1, p2, p3, p4, p5};
	    Array.Sort(people, new AgeSort());
	    // Сортировка по возрасту
	    foreach(Human p in people){
	        Console.WriteLine("{0} - {1}", p.LastName, p.BirthYear);
	    }
	    Console.WriteLine("");
	    // Сортировка по фамилии
	    Array.Sort(people, new LnameSort());
	    foreach(Human p in people){
	        Console.WriteLine("{0} - {1}", p.LastName, p.BirthYear);
	    }
	    foreach(Human p in people){
	        p.About();
	    }
	}
}