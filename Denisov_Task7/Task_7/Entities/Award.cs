namespace Entities
{
    public class Award
    {

        public Award(int id, string title)
        {
            this.id = id;
            this.title = title;
        }

        internal int id { get; }

        internal string title { get; }
    }
}
