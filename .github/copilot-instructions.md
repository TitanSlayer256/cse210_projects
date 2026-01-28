# Copilot Instructions for cse210-student-template

## Project Overview
This is a C# learning project repository organized as a progression of assignments for CSE 210 (Programming with Classes). It's structured as a single Visual Studio solution (`cse210-student-template.sln`) containing multiple independent .NET projects organized by learning stage.

## Directory Structure & Purpose
- **`csharp-prep/`** - Basic C# syntax fundamentals (Prep1-Prep5). Console I/O, variables, loops, conditionals.
- **`prepare/`** - Object-oriented fundamentals through simple class modeling (Learning02-Learning05). E.g., Learning02 demonstrates class design with `Job` and `Resume` classes.
- **`prove/`** - More complex OOP patterns and larger projects (Develop02-Develop05).
- **`final/`** - Capstone projects including `FinalProject` and `Foundation1-4` for specialized topics.
- **`sandbox/`** - Playground project for experimentation with no grading constraints.

## Build System & Commands
Each project is a standalone .NET/C# project with its own `.csproj` file. Build using:
```bash
dotnet build <path-to-project>/<ProjectName>.csproj
```

Common tasks configured in VS Code:
- **Build tasks**: Run `build-prepare-Learning02`, `build-prove-Develop02`, etc. via task runner
- **No dedicated test framework** - Projects typically use console output for validation
- **bin/Debug/** contains compiled outputs; **obj/** contains build artifacts

Projects should compile without external NuGet dependencies beyond standard .NET libraries.

## Code Patterns & Conventions

### Class Structure
- **Public member variables** are standard (e.g., `_jobTitle`, `_company` in `Job.cs`) - underscore prefix convention for private-like intent
- **Display() methods** are the common pattern for output (not ToString()). Classes typically implement `public void Display()` to print formatted output
- **Keep It Simple** - Classes are intentionally minimal; focus on core responsibilities (data + display)

Example pattern from Learning02:
```csharp
public class Job {
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;
    
    public void Display() {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
```

### Composition Pattern
Parent classes maintain `List<T>` collections of child classes:
```csharp
public class Resume {
    public string _name;
    public List<Job> _jobs = new List<Job>();
    
    public void Display() {
        Console.WriteLine($"Name: {_name}");
        foreach (var job in _jobs) {
            job.Display();  // Delegate display responsibility
        }
    }
}
```

### Console I/O
- Use `Console.WriteLine()` and `Console.ReadLine()` for user interaction
- Format strings with `$"text {variable}"` interpolation
- Output formatting follows "Label: Value" or "Title\nDetail" patterns for readability

## Critical Developer Workflows

### Running Individual Projects
1. Open integrated terminal
2. Navigate to workspace root
3. Use dotnet task runner OR: `dotnet run --project sandbox/Sandbox/Sandbox.csproj`
4. No separate compilation step needed for testing (dotnet run builds implicitly)

### Typical Assignment Workflow
1. Projects start with placeholder `Console.WriteLine("Hello [ProjectName] World!")`
2. Implement required classes (usually 2-3 classes per project)
3. Create instances in Main() and call Display() methods
4. Test by running project and verifying console output format

### Known Build Characteristics
- Solution file: `cse210-student-template.sln` references all projects
- Each project is independent; one project's failure doesn't block others
- Debug folder is `.NET Framework` standard (netX.X framework)

## Important Notes for AI Agents
- **No Unit Tests** - Validation is manual console output inspection. Assist with output formatting correctness.
- **Minimal Dependencies** - Stick to `System`, `System.Collections.Generic`, and core .NET libraries
- **Scaffolding Pattern** - Most projects provide skeleton code with inline comments describing requirements
- **Learning Progression** - Earlier projects (Prep) are simpler; later projects (Develop/Final) add complexity. Match code sophistication to project stage.
- **Member Variable Convention** - Public members with underscore prefix are intentional; this is the learning style for this course, not a production pattern.

## Key Files to Reference
- [prepare/Learning02/Resume.cs](prepare/Learning02/Resume.cs) - Exemplifies composition and Display() pattern
- [prepare/Learning02/Job.cs](prepare/Learning02/Job.cs) - Simple class design example
- [README.md](README.md) - Official project structure documentation
