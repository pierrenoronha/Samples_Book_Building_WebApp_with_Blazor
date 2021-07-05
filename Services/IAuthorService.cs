using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Samples_Book_Building_WebApp_with_Blazor.Data;

namespace Samples_Book_Building_WebApp_with_Blazor.Services
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAuthors(); 
    }
}
