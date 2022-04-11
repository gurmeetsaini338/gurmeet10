using System;
using System.Collections.Generic;

#nullable disable

namespace gurmeet10.DB_Context
{
    public partial class Login
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int? Password { get; set; }
    }
}
