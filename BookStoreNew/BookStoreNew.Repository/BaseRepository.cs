using BookStoreNew.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreNew.Repository
{
    public class BaseRepository
    {
        protected readonly bookstoreContext _context = new bookstoreContext();
    }
}
