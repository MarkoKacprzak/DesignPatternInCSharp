namespace DesignPattern.Creational.AbstractFactory.Sample2.Interfaces
{

    public interface ITicketHolder
    {
    }

    public interface IUser: ITicketHolder
    {
        void SetIdentity(IUserIdentity identity);
    }
}
