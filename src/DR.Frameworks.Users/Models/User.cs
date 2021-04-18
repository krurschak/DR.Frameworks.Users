using DR.Packages.Mongo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Frameworks.Users.Models
{
    public class User : IIdentifiable
    {
        public Guid Id { get; set; }
        public string IdentitySub { get; set; }
        public string IdentityIss { get; set; }
        public string Email { get; set; }
        public int Salutation { get; set; }
        public string Title { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}
