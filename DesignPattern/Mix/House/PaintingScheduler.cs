using System;
using System.Collections.Generic;

namespace DesignPattern.Mix.Houses
{
    public abstract class PaintingScheduler
    {
        public abstract  IEnumerable<Tuple<PainterComponent, double>> Organize(IEnumerable<PainterComponent> painters,
                                                      double houses);
    }
}
