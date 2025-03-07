///// S.O.L.I.D.

//// S - Single Responsibility
//// One class should do one job = A class should have only one reason to change.
//// Non-Compliant: Data manager handling both saving and logging.
//public class DataManager
//{
//    public void SaveAndLogData(string data)
//    {
//        // Save data logic
//        // Log data logic
//    }
//}

//// Compliant: Separate conderns of saving and logging.
//public class DataManager
//{
//    public void SaveData(string data)
//    {
//        // Save data logic
//        // Log data logic
//    }
//}

//public class Logger
//{
//    public void Log(string data)
//    {
//        // Log message logic
//    }
//}

//// O - Open Closed Principle
//// Software entities (classes, modules, functions, etc.) should be open for extension but closed for modification.
//// Non-Compliant: Modifying existing class.
//public class Circle
//{
//    public double Radius { get; set; }

//    public double Area()
//    {
//        return Math.PI * Radius * Radius;
//    }
//}

//// Compliant: Extensible through inheritance
//public abstract class Shape
//{
//    public abstract double Area(); 
//}

//public class Circle
//{
//    public double Radius { get; set; }

//    public double Area()
//    {
//        return Math.PI * Radius * Radius;
//    }
//}

//// L - Liskov substitution Principle
//// Subtypes must be substitutable for their base types without altering the correctness of the program.
//// Non-Compliant: Violating LSP, Square cannot substitute Rectangle
//public class Rectangle
//{
//    public int Width { get; set; }
//    public int Height { get; set; }

//    public int Area()
//    {
//        return Width * Height
//    }
//}

//public class Rectangle
//{
//    public int Width 
//    {
//        set { base.Width = base.Height = value; }
//    }

//    public int Height
//    {
//        set { base.Width = base.Height = value; }
//    }
//}

//// Compliant: Square is a valid substitute for Rectangle
//public class Rectangle
//{
//    public virtual int Width { get; set; }
//    public virtual int Height { get; set; }

//    public int Area()
//    {
//        return Width * Height
//    }
//}

//public class Square: Rectangle
//{
//    public override int Width 
//    {
//        set { base.Width = base.Height = value; }
//    }

//    public override int Height
//    {
//        set { base.Width = base.Height = value; }
//    }
//}

//// I - Interface Segregration Principle
///*
// * A client should not be forced to implement interfaces it does not use.
// */
//// Non-Compliant: Single interface forcing unnecessary methods.
//public interface IWorker
//{
//    void Work();
//    void Eat();
//}

//public class Worker : IWorker
//{
//    public void Work()
//    {
//        // Work logic
//    } 
//}

//    public void Eat()
//    {
//        // This class doesn't need to implement Eat
//    } 
//}

//// Compliant: Segregated interfaces
//public interface IWorker
//{
//    void Work();
//}

//public interface IEater
//{
//    void Eat();
//}

//public class Worker : IWorker, IEater
//{
//    public void Work()
//    {
//        // Work logic
//    } 
//}

//public class SuperWorker : IWorker, IEater
//{
//    public void Work()
//    {
//        // Work logic
//    } 
//}

//    public void Eat()
//    {
//        // Eat logic
//    } 
//}

//// D - Dependancy Inversion Principle
///*
// * High-level modules should not depend on low-level modules. Both should depend on abstractions.
// * Abstractions should not depend on details; details should depend on abstractions.
// */
//// Non-Compliant: High-level module (DataProcessor) depends on low-level module (Console).
//public class ConsoleLogger
//{
//    public void Log(string message)
//    {
//        // Console.WriteLine(message);
//    } 
//}

//public class DataProcessor
//{
//    private readonly ConsoleLogger _logger;

//    public DataProcessor(ConsoleLogger logger)
//    {
//        _logger = logger;
//    }

//    public void ProcessData(string data)
//    {
//        // Data processing logic
//        _logger.Log("Data processed successfully.");
//    } 
//}

//// Compliant: Abstraction (ILogger) depends on abstraction, not details
//public interface ILogger
//{
//    void Log(string message);
//}

//public class ConsoleLogger : ILogger
//{
//    public void Log(string message)
//    {
//        Debug.Log.WriteLine(message);
//    } 
//}

//public class DataProcessor
//{
//    private readonly ILogger _logger;

//    public DataProcessor(ILogger logger)
//    {
//        _logger = logger;
//    }

//    public void ProcessData(string data)
//    {
//        // Data processing logic
//        _logger.Log("Data processed successfully.");
//    } 
//}