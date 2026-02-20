public class MathAssignment : Assignment
{
    private string _textbookSelection = "";
    private string _problems = "";

    public MathAssignment(string studenName, string topic, string textbookSelection, string problems) : base(studenName, topic)
    {
        _textbookSelection = textbookSelection;
        _problems = problems;

        
    } 

    public void GetHomeworkList()
    {
        Console.WriteLine($"{_problems}");
    }


}