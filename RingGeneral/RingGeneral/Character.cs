using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingGeneral
{
    class Character : GameObject
    {
        string LongAlias { get; set; }
        string ShortAlias { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        
        public enum Genders { Male, Female };
        public enum Nationalities { UnitedStates, Canada, Mexico };

        public Genders Gender { get; set; }
        DateTime BirthDate { get; set; }

        public Nationalities Nationality { get; set; }
        public string Hometown { get; set; }

        public int Height { get; set; }
        public int Weight { get; set; }

        public string Description { get; set; }
    }
}
