namespace Substitution.Builders.Person.Interfaces
{
    public interface IFirstNameHolder
    {
        ILastNameHolder WithFirstName(string name);
    }
}
