Console.WriteLine("Hello, World!");

Equal s1 = new Equal("Ajay", "Rathod");
Equal s2 = new Equal("Ajay", "Rathod");
if (s1.Equals(s2))
{
    Console.WriteLine("Equal");
}
else { Console.WriteLine("Not Equal"); }

var ajay = string () => null; // lamda expression var me hold kar sakte hai freamwork me nahi hota tha
                              // freamwork Func/delegate likhna padta tha
                              // null value bhi hold kar sakte hai  nulleble hai


Console.ReadLine();

public record class Equal(string FirstName, string LastName);
//record : class (keyword) value equality chack karta hai na ki refarence equality

public interface IStudent //interface me incomplate as well as complate dono method likh sakte hai
{
    public void Print();
    public void PrintA()
    {
        Console.WriteLine("Interface Method Called");
    }
}
public struct Student
{//struct class me paremeter less(default constuctor) likha ja sakta hai
    public Student()
    { }
}

