using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.RefactoringConditionalStatements
{
    class Table
    {
        public void GoToCell()
        {
            double x, y, minX, maxX, minY, maxY;
            x = y = minX = maxX = minY = maxY = 0;
            bool visitedCell = true;
            bool inX = (x >= minX && x <= maxX);
            bool inY = (maxY >= y && minY <= y);
            if (inX && inY && !visitedCell)
            {
               VisitCell();
            }
        }

        private void VisitCell()
        {
            throw new NotImplementedException();
        }
    }
}
