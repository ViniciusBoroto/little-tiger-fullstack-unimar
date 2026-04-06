namespace LittleTiger.Entities
{
    public class Achievement : EntityBase
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public List<User> Users { get; set; }
    }
}
