// See https://aka.ms/new-console-template for more information
using Employee;

Console.WriteLine("Hello, World!");
DB_Connection db=new DB_Connection();
db.InsertEmp();
////db.Update();
//db.Delete();
db.Inserting();