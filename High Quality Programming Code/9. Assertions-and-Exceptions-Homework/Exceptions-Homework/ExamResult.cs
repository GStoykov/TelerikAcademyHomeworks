using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("The grade must be positive.");
        }
        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("The grade must be positive");
        }
        if (maxGrade <= minGrade)
        {
            throw new ArgumentOutOfRangeException("Maximum grade shouldn`t be smaller than minimum grade");
        }
        if (comments == null || comments == "")
        {
            throw new ArgumentNullException("The comments shouldn`t be empty");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
