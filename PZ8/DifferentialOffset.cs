namespace PZ8
{
    internal class DifferentialOffset : IControl
    {
        string IControl.Rate(int mark)
        {
            return mark.ToString() + "DifOffset";
        }
    }
}
