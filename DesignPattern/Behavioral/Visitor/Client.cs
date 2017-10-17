namespace DesignPattern.Behavioral.Visitor
{
    public class Client
    {
        Visitor visitor;
        ObjectStructure objectStructure;

        public Visitor Visitor { get => visitor; set => visitor = value; }
        public ObjectStructure ObjectStructure { get => objectStructure; set => objectStructure = value; }
    }
}
