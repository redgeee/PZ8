namespace PZ8
{
    internal class DifferentialOffset : IControl
    {
        string IControl.Rate(int points)
        {
            if (points >= 90)
                return "5 Зачет";
            else if (points >= 80)
                return "4 Зачет";
            else if (points >= 60)
                return "3 Зачет";
            else
                return "Не зачет";
        }
    }
}
