namespace Implement
{
    using Contract;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class FigureLogic : IFigureLogic
    {
        private readonly ValueTuple<string, int>[] _data =
        {
            ("roundness", 1),
            ("rectangle", 4),
            ("triangle", 3),
            ("foursquare", 4),
        };

        public IEnumerable<string> GetCommonGraphic(int numberOfSideLength)
        {
            return _data.Where(item => item.Item2 == numberOfSideLength).Select(item => item.Item1);
        }
    }
}