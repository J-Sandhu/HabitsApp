namespace Model
{
    /// <summary>
    /// This class represents tasks that are scheduled, and recurring, they must be done before expiry
    /// or damage is incurred on the player
    /// </summary>
    public class Daily
    {
        public string name;
        public Daily(string name)
        {
            this.name = name;
        }
    }
}