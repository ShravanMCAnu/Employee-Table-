using System.Data.SqlClient;


namespace Employee
{
    internal class DB_Connection:Employee_LIst
    {
        readonly SqlConnection sqlCon = new("Server=LAPTOP-BJF2P1AA;Database=DatabaseOne;Trusted_Connection=true;");


        public void InsertEmp()
        {
            string query = "insert into Employees values(@Name,@Age,@Gender,@DeptId)";
            Employee_LIst obj = new();
            var listing = obj.EmployeeMethod();
            foreach (var item in listing)
            {
                SqlCommand cmd = new(query, sqlCon);
                cmd.Parameters.Add("@Name", System.Data.SqlDbType.NVarChar, 100).Value = item.Employee_Name;
                cmd.Parameters.Add("@Age", System.Data.SqlDbType.NVarChar, 100).Value = item.Age;
                cmd.Parameters.Add("@Gender", System.Data.SqlDbType.NVarChar, 100).Value = item.Gender;
                cmd.Parameters.Add("@DeptId", System.Data.SqlDbType.NVarChar, 100).Value = item.Department_id;
                sqlCon.Open();
                cmd.ExecuteNonQuery();
                sqlCon.Close();
            }
            Console.WriteLine("Employee List inserted into DB sucessfully....");
        }
        

        public void Update()
        {

            Console.WriteLine("The Employee Table Values are:");
            SqlCommand cmd1 = new("select * from Employees", sqlCon);
            sqlCon.Open();
            SqlDataReader reader=cmd1.ExecuteReader();
            while (reader.Read())
            {
                for(int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine(" "+reader.GetValue(i));
                   
                }
                Console.WriteLine("------------------------------------------");
            }

            sqlCon.Close();
            Console.WriteLine("Enter values into EmployeeID and EmployeeName You want to Update...");
            sqlCon.Open();
            int EmployeeID = int.Parse(Console.ReadLine());
            string? Employee_Name = Console.ReadLine();


            SqlCommand cmd2 = new("Update Employees set Employee_Name='" + Employee_Name + "' Where Employee_Id=" + EmployeeID + "", sqlCon);

            cmd2.ExecuteNonQuery();
            Console.WriteLine("Updated Sucessfully");
            sqlCon.Close();

            SqlCommand cmd3 = new("select * from Employees Where Employee_Id=" + EmployeeID + "", sqlCon);
            sqlCon.Open();
            SqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                for (int i = 0; i < reader3.VisibleFieldCount; i++)
                {
                    Console.WriteLine("  "+reader3.GetValue(i));

                }
                Console.WriteLine("------------------------------------------");
            }
            sqlCon.Close();

        }
        public void Delete()
        {

            Console.WriteLine("The Employee Table Values are:");
            SqlCommand cmd1 = new("select * from Employees", sqlCon);
            sqlCon.Open();
            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine(" "+reader.GetValue(i));

                }
                Console.WriteLine("------------------------------------------");
            }

            sqlCon.Close();
            Console.WriteLine("Enter values into EmployeeID You want to delete");
            sqlCon.Open();
            int EmployeeID = int.Parse(Console.ReadLine());
            


            SqlCommand cmd2 = new("delete from Employees  Where Employee_Id=" + EmployeeID + "", sqlCon);

            cmd2.ExecuteNonQuery();
            Console.WriteLine("deleted Sucessfully");
            sqlCon.Close();
        }


        public void Inserting()
        {
            Console.WriteLine("The Employee Table Values are:");
            SqlCommand cmd4 = new("select * from Employees", sqlCon);
            sqlCon.Open();
            SqlDataReader reader = cmd4.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine(" " + reader.GetValue(i));

                }
                Console.WriteLine("------------------------------------------");
            }

            sqlCon.Close();

            Console.WriteLine("Enter Employee Name ");
            string? EmpName = Console.ReadLine();
            Console.WriteLine("Enter Employee Age");
            int EmpAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Gender");
            string? EmpGender = Console.ReadLine();
            Console.WriteLine("Enter Department ID Based on Employee");
            int EmpDeptID = int.Parse(Console.ReadLine());

            sqlCon.Open();
            SqlCommand cmd5 = new("insert into  Employee values('" + EmpName + "', " + EmpAge + ", '"+EmpGender+"', "+EmpDeptID+")", sqlCon);
            cmd5.ExecuteNonQuery();
            sqlCon.Close();

        }

        public void DBClear()
        {
            SqlCommand cmdclear = new("truncate table employee", sqlCon);
            sqlCon.Open();
            cmdclear.ExecuteNonQuery();
            sqlCon.Close();
        }
    }
}
