using Microsoft.AspNetCore.Mvc;
using PrefinalExam.Data;

namespace PrefinalExam.Controllers;

public class ExamController : Controller
{
    // GET: /Exam
    public IActionResult Index(string? topic)
    {
        var questions = ExamQuestionRepository.GetAll();

        ViewBag.Topics = questions.Select(q => q.Topic).Distinct().OrderBy(t => t).ToList();
        ViewBag.SelectedTopic = topic;

        if (!string.IsNullOrWhiteSpace(topic))
        {
            questions = questions.Where(q => q.Topic == topic).ToList();
        }

        return View(questions);
    }

    // GET: /Exam/Details/5
    public IActionResult Details(int id)
    {
        var question = ExamQuestionRepository.GetByNumber(id);

        if (question == null)
        {
            return NotFound();
        }

        return View(question);
    }
}
