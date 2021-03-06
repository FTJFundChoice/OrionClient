﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Interfaces.Common {

    public interface ISearchModule<T> {

        Task<IResult<IEnumerable<T>>> SearchAsync(string search);
    }
}