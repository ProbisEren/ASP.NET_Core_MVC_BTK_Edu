namespace  BtkAkademiProje.Models
{
    public class Candidate
    {
       public String? Email  { get; set; } =String.Empty; // veri tipinin yanındaki "?" demek bu değer nullable yani null olabilir
                                                          // demek, normalde bi string null olamaz ama bu işaret sayesinde null olursa sorun yok
       public String? FirstName  { get; set; } =String.Empty;
       public String? LastName  { get; set; } =String.Empty;

       public String FullName => $"{FirstName} {LastName?.ToUpper()}";
       public int? Age  { get; set; }  
       public String? SelectedCourse  { get; set; } =String.Empty; 
       public DateTime AppliedAt  { get; set; }     

       public Candidate()
       {
            AppliedAt= DateTime.Now;
       }
    
    }
    
}