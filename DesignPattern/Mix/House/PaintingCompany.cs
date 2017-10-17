using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Mix.Houses
{
    public class PaintingComposite: PainterComponent
    {

        private PainterComponent painter=>painters.ToArray()[0];
        private IEnumerable<PainterComponent> painters;
        private PaintingScheduler scheduler;

        public PaintingComposite(IEnumerable<PainterComponent> painters,
                               PaintingScheduler scheduler)
        {
            this.painters = new List<PainterComponent>(painters);
            this.scheduler = scheduler;
        }

        public override double Paint(double houses)
        {

            double totalDays =
                this.scheduler
                .Organize(this.painters, houses)
                .Select(record => record.Item1.Paint(record.Item2))
                .Max();

            return totalDays;

        }

        public override double EstimateDays(double houses)
        {
            return
                this.scheduler
                .Organize(this.painters, houses)
                .Select(pair => pair.Item1.EstimateDays(pair.Item2))
                .Max();
        }
    }
}
