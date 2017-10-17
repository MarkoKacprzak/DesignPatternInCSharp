using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Mix.Houses
{
    public class ProportionalScheduler: PaintingScheduler
    {
        public override IEnumerable<Tuple<PainterComponent, double>> Organize(
                                    IEnumerable<PainterComponent> painters, double houses)
        {

            double totalVelocity = GetOverallVelocity(painters);

            IEnumerable<Tuple<PainterComponent, double>> result =
                painters
                .Select(painter =>
                    new
                    {
                        Painter = painter,
                        Velocity = 1 / (double)painter.EstimateDays(1)
                    })
                .Select(record =>
                    Tuple.Create(
                        record.Painter,
                        houses * record.Velocity / totalVelocity))
                .ToList();

            return result;

        }

        private double GetOverallVelocity(IEnumerable<PainterComponent> painters)
        {
            return
                painters
                .Select(painter => painter.EstimateDays(1))
                .Select(daysPerHouse => 1 / (double)daysPerHouse)
                .Sum();
        }
    }
}
