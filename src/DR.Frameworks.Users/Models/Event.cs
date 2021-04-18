using DR.Packages.Mongo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Frameworks.Users.Models
{
    public class Event : IIdentifiable
    {
        public Guid Id { get; set; }
        public DateTime ConsumedAtUtc { get; set; }
        public string MessageType { get; set; }
        public string Message { get; set; }
    }
}
