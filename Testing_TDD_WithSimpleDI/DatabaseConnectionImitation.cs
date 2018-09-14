using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_TDD_WO_SimpleDI;

namespace Testing_TDD_WithSimpleDI
{
    class DatabaseConnectionImitation : IDatabaseConnection
    {
        public string GetData()
        {
            return "   Trimmed text.     ";
        }
    }
}
