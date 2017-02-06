﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Interfaces.Common {

    public interface IQueryModule<T> {

        Task<IResult<List<T>>> GetAll(int top = 1000, int skip = 0, bool? isActive = true);

        Task<IResult<T>> Get(long id);
    }
}