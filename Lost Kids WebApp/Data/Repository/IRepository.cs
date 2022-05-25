using Lost_Kids_WebApp.Models.Comments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lost_Kids_WebApp.Data.Repository
{
    public interface IRepository
    {
        void AddSubComment(SubComment comment);
    }
}
