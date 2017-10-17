using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Mix.Reservations
{
    public class VacationSpecification
    {
        private IVacationPart part => parts.ToArray()[0];
        private IList<IVacationPart> parts;

        public VacationSpecification(IList<IVacationPart> parts)
        {
            // TODO: Complete member initialization
            this.parts = parts;
        }
    }
}
