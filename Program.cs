using System;


class Customer
{
    string _Firstname;
    string _Lastname;


    public Customer() : this("no one firstname","no one lastname") { }
    public Customer(string Firstname, string lastname)
    { 
     this._Firstname = Firstname;
        this._Lastname = lastname;
    }

    public void PrintFullName()
    {
        Console.WriteLine("Customer full name = {0}", this._Firstname + " " + this._Lastname);
    }

    ~Customer()
    {
        //Clean code
    }
}

 class Program
    {
        static void Main()
        {

     //   Customer C1 = new Customer("Saifullah", "Mahar");
     Customer C1 = new Customer();
        C1.PrintFullName();

        Customer C2 = new Customer("saifullah","Mahar");
        C2.PrintFullName();
        }
    }
