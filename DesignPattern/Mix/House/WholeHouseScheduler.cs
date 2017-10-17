using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Mix.Houses
{
    public class WholeHouseScheduler: PaintingScheduler
    {
        public override IEnumerable<Tuple<PainterComponent, double>> Organize(
                                    IEnumerable<PainterComponent> painters, double houses)
        {
            IEnumerable<Tuple<PainterComponent, double>> schedule =
                this.CreateEmptySchedule(painters);

            while (houses > 0.0)
            {
                double part = Math.Min(1.0, houses);
                schedule = this.Add(schedule, part);
                houses -= part;
            }
            return schedule;
        }

        private IEnumerable<Tuple<PainterComponent, double>> Add(
                    IEnumerable<Tuple<PainterComponent, double>> schedule, double part)
        {

            Tuple<PainterComponent, double> optimalPainter =
                schedule
                .Select(pair => Tuple.Create(pair.Item1, pair.Item2 + part))
                .OrderBy(pair => pair.Item1.EstimateDays(pair.Item2))
                .First();

            IEnumerable<Tuple<PainterComponent, double>> newSchedule =
                schedule
                .Where(pair =>
                    !object.ReferenceEquals(pair.Item1, optimalPainter.Item1))
                .Union(new Tuple<PainterComponent, double>[] { optimalPainter })
                .ToList();

            return newSchedule;

        }

        private IEnumerable<Tuple<PainterComponent, double>> CreateEmptySchedule(
                                                IEnumerable<PainterComponent> painters)
        {
            return
                painters
                .Select(painter => Tuple.Create(painter, 0.0))
                .ToList();
        }
    }
}
