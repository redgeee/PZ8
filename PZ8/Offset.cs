namespace PZ8
{
    public class Offset : IControl
    {
        string IControl.Rate(int points)
        {
            if (points < 40)
                return "Не зачет";
            return "Зачет";
        }
    }
}
