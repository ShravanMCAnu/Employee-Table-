// See https://aka.ms/new-console-template for more information
using Employee;

Console.WriteLine("Hello, World!");
DB_Connection db=new DB_Connection();
int choice = 0;
db.InsertEmp();
Console.WriteLine(" Firstly,\n\t   Employee List inserted into DB sucessfully....");

do
{
    Console.WriteLine("\nWElcome to Employee Table For database operations choose below \n\t1.Update\n\t2.Delete\n\t4.Inserting\n\t5.Close DB");
    choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        //case 1:
        //    objDB_Connection.Display();
        //break;
        case 1:
            db.Update();
            break;
        case 2:
            db.Delete();
            break;
        case 3:
            db.Inserting();
            break;

    }
}
while (choice < 4);
db.DBClear();
Console.WriteLine("Database CLosed Press Enter to exit the Console");