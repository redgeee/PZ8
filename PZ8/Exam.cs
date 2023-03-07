namespace PZ8
{
    internal class Exam : IControl
    {
        string IControl.Rate(int mark)
        {
            return mark.ToString() + "Exam";
        }
    }
}
