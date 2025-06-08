namespace PdqkLesson7.Models
{ 
    public class PdqkEmployee
    {
    public int PdqkId { get; set; }

    public string PdqkName { get; set; }

    public DateTime PdqkBirthDay { get; set; }

    public string PdqkEmail { get; set; }  // ✅ Email là string

    public string PdqkPhone { get; set; }

    public float PdqkSalary { get; set; }

    public int PdqkStatus { get; set; }
    }
}