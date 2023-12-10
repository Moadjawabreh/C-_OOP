using System;
using System.IO;

//public class Car
//{
//    private string make;
//    private int year;
//    private string type;
//    private decimal price;
//    private string model;
//    private string palletNo;
//    private string color;

//    public Car(string make, int year, string type, decimal price, string model, string palletNo, string color)
//    {
//        this.make = make;
//        this.year = year;
//        this.type = type;
//        this.price = price;
//        this.model = model;
//        this.palletNo = palletNo;
//        this.color = color;
//    }

//    public string Make
//    {
//        get { return make; }
//    }

//    public int Year
//    {
//        get { return year; }
//    }

//    public string Type
//    {
//        get { return type; }
//    }

//    public decimal Price
//    {
//        get { return price; }
//    }

//    public string Model
//    {
//        get { return model; }
//    }

//    public string PalletNo
//    {
//        get { return palletNo; }
//    }

//    public string Color
//    {
//        get { return color; }
//    }

//    public void DisplayCarInfo()
//    {
//        Console.WriteLine($"Make: {Make}");
//        Console.WriteLine($"Year: {Year}");
//        Console.WriteLine($"Type: {Type}");
//        Console.WriteLine($"Price: {Price:C}");
//        Console.WriteLine($"Model: {Model}");
//        Console.WriteLine($"Pallet No: {PalletNo}");
//        Console.WriteLine($"Color: {Color}");
//    }


//    public virtual void StartEngine()
//    {
//        Console.WriteLine("Engine started. Vroom vroom!");
//    }

//    public virtual void StopEngine()
//    {
//        Console.WriteLine("Engine stopped. Silence.");
//    }

//    public virtual string GetCarInfo()
//    {
//        return $"Make: {Make}\n" +
//               $"Year: {Year}\n" +
//               $"Type: {Type}\n" +
//               $"Price: {Price:C}\n" +
//               $"Model: {Model}\n" +
//               $"Pallet No: {PalletNo}\n" +
//               $"Color: {Color}";
//    }
//}

//class CarTest
//{
//    static void Main()
//    {
//        Car myCar = new Car("Toyota", 2022, "Sedan", 25000.50m, "Camry", "ABC123", "Blue");
//        myCar.StartEngine();

//        string carInfo = myCar.GetCarInfo();
//        Console.WriteLine("\nCar Information:\n" + carInfo);

//        myCar.StopEngine();
//    }
//}
//public class Vehicle : Car
//{
//    private string type;
//    private string model;

//    public Vehicle(string make, int year, string type, decimal price, string model, string palletNo, string color)
//        : base(make, year, price, palletNo, color)
//    {
//        this.type = type;
//        this.model = model;
//    }

//    public override string GetCarInfo()
//    {
//        return GetCarInfo() + $"\nType: {type}\nModel: {model}";
//    }

//    public override void StartEngine()
//    {
//        Console.WriteLine("Car engine started. Vroom vroom!");
//    }

//    public override void StopEngine()
//    {
//        Console.WriteLine("Car engine stopped. Silence.");
//    }
//}


class Program
{
    static void Main()
    {
        // 1
        //Car myCar = new Car("Toyota", 2022, "Sedan", 25000.50m, "Camry", "ABC123", "Blue");
        //myCar.DisplayCarInfo();

        // myCar.StartEngine();

        //string carInfo = myCar.GetCarInfo();
        //Console.WriteLine(carInfo);

        // myCar.StopEngine();



        //2

        string inputFile = "C:\\Users\\Coding School\\Desktop\\C#7\\Read.txt";
        string outputFile = "C:\\Users\\Coding School\\Desktop\\C#7\\Write.txt";


        try
        {
            // Using statement ensures that StreamReader and StreamWriter are properly disposed
            using(StreamReader sr = new StreamReader(inputFile))
            using (StreamWriter sw = new StreamWriter(outputFile))
            {
                int countC = 0;
                int countW = 0;

                while (!sr.EndOfStream)
                {
                    string lineC = sr.ReadLine();
                    foreach (var item in lineC)
                    {
                        countC++;
                    }
                
                    string []  strings = lineC.Split(' ');
                    countW=countW+strings.Length; 
                    sw.WriteLine(lineC); 
                }

                Console.WriteLine("File content copied successfully.");
                
                sw.WriteLine(countC);
                sw.WriteLine(countW);


            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }



    }
}
