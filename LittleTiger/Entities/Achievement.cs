namespace LittleTiger.Entities
{
    public class Achievement : EntityBase
    {
        private Guid guid;

        public Achievement(Guid guid, string name, string description)
        {
            this.guid = guid;
            Name = name;
            Description = description;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public List<User> Users { get; set; }
    }
}
