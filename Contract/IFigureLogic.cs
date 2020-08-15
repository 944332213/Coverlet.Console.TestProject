namespace Contract
{
    using System.Collections.Generic;

    public interface IFigureLogic
    {
        IEnumerable<string> GetCommonGraphic(int numberOfSideLength);
    }
}