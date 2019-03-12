using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SaverMate.Data
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
