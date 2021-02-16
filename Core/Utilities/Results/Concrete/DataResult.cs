﻿using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete
{
   public class DataResult<T>:Result,IDataResult<T>
    {
        public DataResult(T data, bool success, string message) : base(success, message)
        {
            this.Data = data;
        }
        public DataResult(T data, bool success) : base(success)
        {
            this.Data = data;
        }
        public T Data { get; }
    }
}
