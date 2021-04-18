using DR.Packages.Mongo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Frameworks.Users.Models
{
    public class User : IIdentifiable
    {
        public User() { }

        public User(
            Guid id,
            string email,
            string identitySub = null,
            string identityIss = null,
            int? salutation = null,
            string title = null,
            string lastName = null,
            string firstName = null)
        {
            Id = id;
            IdentitySub = identitySub;
            IdentityIss = identityIss;
            Email = email;
            Salutation = salutation ?? -9;
            Title = title;
            LastName = lastName;
            FirstName = firstName;
        }

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
