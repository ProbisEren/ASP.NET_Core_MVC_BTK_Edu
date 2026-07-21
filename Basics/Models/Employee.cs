namespace Basics.Models
{
    public class Employee()
    {
        public int ID { get; set; }  
        public String FirstName { get; set; } = String.Empty;
        public String Surname { get; set; }  =String.Empty;

        public String FullName =>$"{FirstName} {Surname.ToUpper()}";
        public int Age { get; set; }  
    }
}