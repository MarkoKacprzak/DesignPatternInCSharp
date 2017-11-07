using System;
using DesignPattern.Creational.AbstractFactory.Sample2.Interfaces;

namespace DesignPattern.Creational.AbstractFactory.Sample2.Models
{
    public class Machine: IUser
    {
        public Producer Producer { get; }
        public string Model { get; }

        public Machine(Producer producer, string model)
        {
            if (string.IsNullOrEmpty(model))
                throw new ArgumentException("Model name must be non-empty.");

            Producer = producer ?? throw new ArgumentNullException(nameof(producer));
            Model = model;
        }

        public void SetIdentity(IUserIdentity identity)
        {
            throw new System.NotImplementedException();
        }
    }
}
