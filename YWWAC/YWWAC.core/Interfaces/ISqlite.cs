﻿using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YWWAC.core.Interfaces
{
    public interface ISqlite
    {
        SQLiteConnection GetConnection();
    }
}
