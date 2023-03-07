namespace PZ8
{
    internal interface IControl
    {
        string Rate(int points) 
        {
            return points.ToString();
        }
    }
}
