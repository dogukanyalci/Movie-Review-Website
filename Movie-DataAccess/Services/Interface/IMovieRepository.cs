﻿using Movie_Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DataAccess.Services.Interface
{
    public interface IMovieRepository : IBaseRepository<Movie>
    {
    }
}
