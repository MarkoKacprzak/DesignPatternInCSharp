using System;
using Substitution.Interfaces;

namespace Substitution.Models
{
    public class Machine: IUser<MacAddress>
    {
        public Producer Producer { get; set; }
        public string Model { get; set; }
        public MacAddress Identity { get; private set; }

        public void SetIdentity(MacAddress identity)
        {
            this.Identity = identity as MacAddress;
            // do something with address.
        }

        public Machine(Producer producer, string model)
        {
            if (string.IsNullOrEmpty(model))
                throw new ArgumentException();

            this.Producer = producer ?? throw new ArgumentNullException();
            this.Model = model;

        }
    }
}
