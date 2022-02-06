using System;
using System.Collections.Generic;
using System.Text;

namespace home.db
{
    public interface ISqlite
    {
        string GetDatabasePath(string filename);
    }
}
