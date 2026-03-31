namespace LittleTiger.Entities
{
    public class Achievement : EntityBase
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public Achievement(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }
    }
}
