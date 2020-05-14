using DAL.Models;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.InterFace
{
   public interface IUnitOfWork
    {
        public UserRepository UserRepo  { get; }
        Task Save();
    }
}
