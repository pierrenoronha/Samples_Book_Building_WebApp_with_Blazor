using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Samples_Book_Building_WebApp_with_Blazor.Data
{
    public partial class Author
    {
        public Guid Id => Guid.NewGuid();
        public DateTime? BirthDate { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName  => $"{FirstName} {LastName}";

    }
}
