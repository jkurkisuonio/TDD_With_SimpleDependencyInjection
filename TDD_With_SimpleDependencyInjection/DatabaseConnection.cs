using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_TDD_WO_SimpleDI
{
    public class DatabaseConnection : IDatabaseConnection
    {
        public String GetData()
        {
            // Haetaan tämä tietokannasta.
            Random rnd = new Random();
            int month = rnd.Next(1, 13);
            if (month < 5) return null; else return "We have connection to database.";
        }
    }

    public interface IDatabaseConnection
    {
        String GetData();

    }
}
