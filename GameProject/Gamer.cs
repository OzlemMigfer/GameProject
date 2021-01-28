using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Gamer//özellikleri tanımladık
    {
        public int Id { get; set; }
        public int NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long BirthYear { get; set; }
    }
}
