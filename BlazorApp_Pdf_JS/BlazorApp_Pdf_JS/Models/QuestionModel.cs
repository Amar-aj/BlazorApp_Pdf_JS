namespace BlazorApp_Pdf_JS.Models;

public class QuestionMSAModel
{
    public string Question { get; set; }
    public string Option1 { get; set; }
    public string Option2 { get; set; }
    public string Option3 { get; set; }
    public string Option4 { get; set; }
    public string CorrectOption { get; set; }  
    public int DurationInMinitus { get; set; }
    public int Marks { get; set; }
}
public class QuestionTOFModel
{
    public string Question { get; set; }
    public string Option1 { get; set; }
    public string Option2 { get; set; }
    public string CorrectOption { get; set; }  
    public int DurationInMinitus { get; set; }
    public int Marks { get; set; }
}
