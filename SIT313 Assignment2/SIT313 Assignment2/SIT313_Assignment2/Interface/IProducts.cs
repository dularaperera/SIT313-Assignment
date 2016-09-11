using System;
using SQLite.Net;

namespace SIT313_Assignment2
{
    public interface IProducts
    {
        SQLiteConnection GetConnection();
    }
}
