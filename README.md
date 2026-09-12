# Sophia Cassandra Solis — Section 31E1 — IT Elective 2 (Web Systems and Technologies)

## Prefinal Examination — MVC Exam Review App

This repository contains my prefinal exam submission for **IT Elective 2 – Web
Systems and Technologies**. Instead of a plain answer sheet, the exam is
presented as a small **ASP.NET Core MVC** web application that displays each
of the 20 multiple-choice questions along with my chosen answer and a short
explanation of why that answer is correct.

No database is used — all exam data (questions, options, correct answers,
explanations) is stored in memory in `Data/ExamQuestionRepository.cs`.

## How it's organized (MVC)

| Layer | Location | Purpose |
|---|---|---|
| **Model** | `Models/ExamQuestion.cs` | Represents one exam item: question text, options, correct letter, explanation |
| **Data** | `Data/ExamQuestionRepository.cs` | In-memory list of all 20 questions (no database) |
| **Controller** | `Controllers/ExamController.cs`, `Controllers/HomeController.cs` | Handles requests, fetches data, picks the view |
| **View** | `Views/Home/Index.cshtml`, `Views/Exam/Index.cshtml`, `Views/Exam/Details.cshtml` | Renders the landing page, the question list, and the per-question detail page |

## Features

- **Home page** — overview of the exam and student info.
- **Questions page** (`/Exam`) — every question as a card, filterable by topic, with the correct answer badge shown at a glance.
- **Details page** (`/Exam/Details/{id}`) — full question view with all four options, the correct option highlighted, and an explanation; includes previous/next navigation (and left/right arrow key support).
- **Bright pink theme** built with plain CSS (no external UI framework).

## Running the app

```bash
dotnet restore
dotnet run
```

Then open the URL shown in the console (e.g. `https://localhost:5001`).

## Commit history

Each of the 20 exam items was added and committed individually, so the
commit history doubles as an answer-by-answer log of the exam
(`git log --oneline` shows one commit per question, plus setup/README/styling
commits), satisfying the exam's minimum-20-commits requirement.

## Table of Specification (TOS)

| Content (Topics) | No. of Items | Item Placement |
|---|---|---|
| Relational Data Modeling (Tables, Keys, Constraints); Model Binding and Controller Actions | 5 | 1–5 |
| Conceptual Data Architecture: Designing ERDs; Razor Syntax and Dynamic Rendering | 5 | 6–10 |
| Data Normalization & Structural Integrity (1NF, 2NF, 3NF); Data Validation and ModelState | 5 | 11–15 |
| Introduction to SQL; In-Memory Data Storage and CRUD Operations | 5 | 16–20 |

## Exam metadata

- **Subject:** IT Elective 2 – Web Systems and Technologies
- **Exam:** Prefinal Examination
- **Format:** Multiple Choice (20 items)
- **Student:** Sophia Cassandra Solis
- **Section:** 31E1
