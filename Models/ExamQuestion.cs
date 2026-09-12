namespace PrefinalExam.Models;

/// <summary>
/// A single answer choice for a multiple-choice exam question.
/// </summary>
public class ExamOption
{
    public char Letter { get; set; }
    public string Text { get; set; } = string.Empty;
}

/// <summary>
/// One exam item: the question itself, its code snippet (if any),
/// its four options, my chosen/correct answer, and a short explanation
/// of why that answer is correct. No database is used — every
/// ExamQuestion instance lives only in memory (see ExamQuestionRepository).
/// </summary>
public class ExamQuestion
{
    public int Number { get; set; }
    public string Topic { get; set; } = string.Empty;
    public string QuestionText { get; set; } = string.Empty;
    public string? CodeSnippet { get; set; }
    public List<ExamOption> Options { get; set; } = new();
    public char CorrectLetter { get; set; }
    public string Explanation { get; set; } = string.Empty;

    public string CorrectAnswerText =>
        Options.FirstOrDefault(o => o.Letter == CorrectLetter)?.Text ?? "";
}
