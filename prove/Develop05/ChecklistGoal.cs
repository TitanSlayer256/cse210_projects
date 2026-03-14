public class ChecklistGoal : Goal
{
    //This tracks how many times the goal has been completed so far vs their target
    private int _amountCompleted;
    private int _target;
    //Extra points for when the target is reached
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0; //all new checklist goals must start at zero :)
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete() => _amountCompleted >= _target; //The goal only becomes finished when the amount completed reaches the target.

    public override string GetDetailsString()
    {
        //this puts the fraction on the end of the string to show the user's progress
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    //this is to format for saving and loading. It includes the amount completed, target, and bonus in addition to the normal goal info.
    public override string GetStringRepresentation() => $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";

    // A simple setter used by the Load process to restore the user's progress
    public void SetAmount(int amount)
    {
        _amountCompleted = amount;
    }
}