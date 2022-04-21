﻿using Bloggers.Models;

namespace DAL
{
    public interface IDataManager
    {
        List<Blogger> GetBloggers();
        bool DeleteBlogger(int id);
        bool UpdateBlogger(int id, string? name, string? post);
        bool InsertBlogger(string? name, string? post);
    }
}
