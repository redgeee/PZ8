namespace PZ8
{
    internal class Exam : IControl
    {
        string IControl.Rate(int points)
        {
            if (points >= 90)
                return "5";
            else if (points >= 80)
                return "4";
            else if (points >= 60)
                return "3";
            else
                return "2";
        }
    }
}
