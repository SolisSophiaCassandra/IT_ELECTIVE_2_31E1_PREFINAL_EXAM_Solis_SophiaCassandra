using Microsoft.AspNetCore.Mvc;
using PrefinalExam.Data;

namespace PrefinalExam.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.TotalQuestions = ExamQuestionRepository.GetAll().Count;
        return View();
    }

    public IActionResult Error()
    {
        return View();
    }
}
