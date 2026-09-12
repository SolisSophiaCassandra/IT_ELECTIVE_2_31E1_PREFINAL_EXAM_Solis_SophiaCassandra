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
        new ExamQuestion
        {
            Number = 3,
            Topic = "EF Core Core Concepts",
            QuestionText = "What is the primary purpose of Entity Framework Core?",
            Options = new List<ExamOption>
            {
                new ExamOption { Letter = 'A', Text = "To create HTML pages automatically" },
                new ExamOption { Letter = 'B', Text = "To replace the MVC Controller" },
                new ExamOption { Letter = 'C', Text = "To map objects in code to relational database data" },
                new ExamOption { Letter = 'D', Text = "To replace the C# compiler" }
            },
            CorrectLetter = 'C',
            Explanation = "EF Core is an Object-Relational Mapper (ORM) — its core job is mapping C# classes and objects to rows and tables in a relational database."
        },
        new ExamQuestion
        {
            Number = 4,
            Topic = "EF Core Core Concepts",
            QuestionText = "Which EF Core component is primarily responsible for communicating with the database?",
            Options = new List<ExamOption>
            {
                new ExamOption { Letter = 'A', Text = "DbContext" },
                new ExamOption { Letter = 'B', Text = "DbSetView" },
                new ExamOption { Letter = 'C', Text = "ControllerContext" },
                new ExamOption { Letter = 'D', Text = "RazorContext" }
            },
            CorrectLetter = 'A',
            Explanation = "DbContext is the session object that manages the connection to the database, tracks entities, and translates LINQ queries into SQL."
        },
        new ExamQuestion
        {
            Number = 5,
            Topic = "Tooling",
            QuestionText = "What does the following command primarily do?",
            CodeSnippet = "dotnet ef dbcontext scaffold \"ConnectionString\" Microsoft.EntityFrameworkCore.SqlServer -o Models",
            Options = new List<ExamOption>
            {
                new ExamOption { Letter = 'A', Text = "Deletes the database" },
                new ExamOption { Letter = 'B', Text = "Creates a new MVC project" },
                new ExamOption { Letter = 'C', Text = "Generates EF Core models and a DbContext from an existing database" },
                new ExamOption { Letter = 'D', Text = "Starts the MVC application" }
            },
            CorrectLetter = 'C',
            Explanation = "The `dotnet ef dbcontext scaffold` command reverse-engineers an existing database into EF Core entity classes and a DbContext, placing the generated files in the Models folder."
        },
        new ExamQuestion
        {
            Number = 6,
            Topic = "Configuration",
            QuestionText = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
            Options = new List<ExamOption>
            {
                new ExamOption { Letter = 'A', Text = "Program.cs only" },
                new ExamOption { Letter = 'B', Text = "appsettings.json" },
                new ExamOption { Letter = 'C', Text = "Index.cshtml" },
                new ExamOption { Letter = 'D', Text = "Student.cs" }
            },
            CorrectLetter = 'B',
            Explanation = "Connection strings are configuration data, so they belong in appsettings.json, where they can be read via the configuration system and swapped per environment."
        },
        new ExamQuestion
        {
            Number = 7,
            Topic = "Relationships",
            QuestionText = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
            Options = new List<ExamOption>
            {
                new ExamOption { Letter = 'A', Text = "One-to-One" },
                new ExamOption { Letter = 'B', Text = "One-to-Many" },
                new ExamOption { Letter = 'C', Text = "Many-to-Many" },
                new ExamOption { Letter = 'D', Text = "Many-to-One only" }
            },
            CorrectLetter = 'B',
            Explanation = "One Section can have many Students, but each Student has only one Section — that asymmetry is the definition of a one-to-many relationship (from Section to Student)."
        },
        new ExamQuestion
        {
            Number = 8,
            Topic = "Relationships",
            QuestionText = "In the following example, what is SectionId?",
            CodeSnippet = "public int SectionId { get; set; }\npublic Section Section { get; set; }",
            Options = new List<ExamOption>
            {
                new ExamOption { Letter = 'A', Text = "Primary key of Student" },
                new ExamOption { Letter = 'B', Text = "Foreign key referencing Section" },
                new ExamOption { Letter = 'C', Text = "Navigation property" },
                new ExamOption { Letter = 'D', Text = "Database connection string" }
            },
            CorrectLetter = 'B',
            Explanation = "SectionId is a scalar property that stores the id of the related Section row — that's exactly what a foreign key is, while `Section` itself is the navigation property."
        },
        new ExamQuestion
        {
            Number = 9,
            Topic = "Relationships",
            QuestionText = "What is the purpose of a navigation property such as public Section Section { get; set; }?",
            Options = new List<ExamOption>
            {
                new ExamOption { Letter = 'A', Text = "It stores the database password" },
                new ExamOption { Letter = 'B', Text = "It represents a relationship to another entity" },
                new ExamOption { Letter = 'C', Text = "It creates a new database" },
                new ExamOption { Letter = 'D', Text = "It validates the student's name" }
            },
            CorrectLetter = 'B',
            Explanation = "A navigation property lets you move from one entity to its related entity in code (e.g. student.Section), representing the relationship rather than storing raw data itself."
        },
        new ExamQuestion
        {
            Number = 10,
            Topic = "EF Core Core Concepts",
            QuestionText = "What does .Include() generally allow EF Core to do?",
            Options = new List<ExamOption>
            {
                new ExamOption { Letter = 'A', Text = "Delete the Section table" },
                new ExamOption { Letter = 'B', Text = "Load related Section data together with Students" },
                new ExamOption { Letter = 'C', Text = "Create a new Student" },
                new ExamOption { Letter = 'D', Text = "Validate Student input" }
            },
            CorrectLetter = 'B',
            Explanation = ".Include() tells EF Core to eagerly load a related entity in the same query, so Section data comes back together with the Students instead of requiring a separate query."
        },
        new ExamQuestion
        {
            Number = 11,
            Topic = "MVC Design",
            QuestionText = "Why might a ViewModel be used when displaying Student and Section information?",
            Options = new List<ExamOption>
            {
                new ExamOption { Letter = 'A', Text = "To replace the database" },
                new ExamOption { Letter = 'B', Text = "To combine or shape the data specifically needed by the view" },
                new ExamOption { Letter = 'C', Text = "To automatically create database tables" },
                new ExamOption { Letter = 'D', Text = "To prevent controllers from using LINQ" }
            },
            CorrectLetter = 'B',
            Explanation = "A ViewModel is a plain object tailored to a specific view — it lets you combine fields from Student and Section into exactly the shape the Razor view needs, without exposing the raw entities."
        },
        new ExamQuestion
        {
            Number = 12,
            Topic = "EF Core Core Concepts",
            QuestionText = "Consider this query. What is the main benefit of Include(s => s.Section)?",
            CodeSnippet = "var students = _context.Students.Include(s => s.Section).ToList();",
            Options = new List<ExamOption>
            {
                new ExamOption { Letter = 'A', Text = "It loads the related Section navigation property" },
                new ExamOption { Letter = 'B', Text = "It creates a Section object manually" },
                new ExamOption { Letter = 'C', Text = "It removes the foreign key" },
                new ExamOption { Letter = 'D', Text = "It prevents the query from accessing the database" }
            },
            CorrectLetter = 'A',
            Explanation = "Include(s => s.Section) eagerly loads each student's related Section object in the same database round trip, avoiding extra queries or a null navigation property."
        },
        new ExamQuestion
        {
            Number = 13,
            Topic = "Validation",
            QuestionText = "Which type of validation occurs in the browser before a request is sent to the server?",
            Options = new List<ExamOption>
            {
                new ExamOption { Letter = 'A', Text = "Database-level validation" },
                new ExamOption { Letter = 'B', Text = "Client-side validation" },
                new ExamOption { Letter = 'C', Text = "Server-side validation" },
                new ExamOption { Letter = 'D', Text = "EF Core migration validation" }
            },
            CorrectLetter = 'B',
            Explanation = "Client-side validation runs in the browser (typically via JavaScript/jQuery unobtrusive validation) before the form is ever submitted to the server."
        },
        // Questions are appended here, one per commit, as each item is answered.
    };

    public static List<ExamQuestion> GetAll() =>
        Questions.OrderBy(q => q.Number).ToList();

    public static ExamQuestion? GetByNumber(int number) =>
        Questions.FirstOrDefault(q => q.Number == number);
}
