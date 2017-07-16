﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plunder.Storage.SqlServer.Models
{
    public interface IEntity
    {
        Guid Id { get; set; }

        DateTime CreateTime { get; set; }

        DateTime? UpdateTime { get; set; }
    }
}
