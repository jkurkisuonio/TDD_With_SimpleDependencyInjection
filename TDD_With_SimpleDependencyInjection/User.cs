using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_TDD_WO_SimpleDI;

namespace TDD_With_SimpleDependencyInjection
{
    public class User
    {
        private string firstName;
        private IDatabaseConnection _db;

        public User(IDatabaseConnection db)
        {
            // Suoritetaan dependency injectio. Tästä luokasta olion haluavan
            // Tahon tulee alustaa tämä luokka IDatabaseConnection interfacea(sopimusta)
            // Noudattavalla oliolla. Se sijoitetaan tämän luokan *sisäiseen* vastaavaan.
            // Riippuvuus on näin purettu. Tämä luokka ei ole riippuvainen mistään muusta luokasta.
            this._db = db;
        }

        public string FirstName
        {
            get
            {
                // Tämä luokka on riippuvainen myös database connectiosta.
                // Tämä riippuvuus pitäisi purkaa.
                //var databaseConnection = new DatabaseConnection();
                //return databaseConnection.GetData();
                var result =  _db.GetData();
                return result.Trim();
            }
            set
            {
                firstName = value;
            }
        }


    }
}
