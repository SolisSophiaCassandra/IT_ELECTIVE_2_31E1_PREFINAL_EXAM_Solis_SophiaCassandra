using PrefinalExam.Models;

namespace PrefinalExam.Data;

/// <summary>
/// In-memory data source for the exam review app.
/// No database is used, per the exam instructions — this static list
/// is the single source of truth for every question and answer shown
/// by the MVC application. Questions were added one at a time,
/// commit by commit, while answering the exam.
/// </summary>
public static class ExamQuestionRepository
{
    private static readonly List<ExamQuestion> Questions = new()
    {
        new ExamQuestion
        {
            Number = 1,
            Topic = "Data Persistence",
            QuestionText = "What is the main problem solved by using a database instead of an in-memory collection?",
            Options = new List<ExamOption>
            {
                new ExamOption { Letter = 'A', Text = "It makes C# code shorter" },
                new ExamOption { Letter = 'B', Text = "It prevents the application from restarting" },
                new ExamOption { Letter = 'C', Text = "It allows data to persist after the application stops" },
                new ExamOption { Letter = 'D', Text = "It removes the need for MVC" }
            },
            CorrectLetter = 'C',
            Explanation = "An in-memory collection only exists while the app is running and is wiped out on restart. A database stores data on disk so it survives application restarts and shutdowns."
        },
        new ExamQuestion
        {
            Number = 2,
            Topic = "EF Core Approaches",
            QuestionText = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
            Options = new List<ExamOption>
            {
                new ExamOption { Letter = 'A', Text = "Code-First" },
                new ExamOption { Letter = 'B', Text = "Database-First" },
                new ExamOption { Letter = 'C', Text = "Model-First" },
                new ExamOption { Letter = 'D', Text = "Controller-First" }
            },
            CorrectLetter = 'B',
            Explanation = "Database-First means the database already exists and EF Core reverse-engineers (scaffolds) entity classes and a DbContext from it, as opposed to Code-First where classes come first."
        },
        // Questions are appended here, one per commit, as each item is answered.
    };

    public static List<ExamQuestion> GetAll() =>
        Questions.OrderBy(q => q.Number).ToList();

    public static ExamQuestion? GetByNumber(int number) =>
        Questions.FirstOrDefault(q => q.Number == number);
}
