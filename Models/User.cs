﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.Dal.Models
{
    class User
    {
        public string ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Event> Events { get; set; }


    }
}
