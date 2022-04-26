using Bloggers.Models;

namespace DAL
{
    public class EFDataManager : IDataManager
    {
        public bool DeleteBlogger(int id)
        {
            using (BloggersContext db = new BloggersContext())
            {
                var blogger = db.Blogger.Find(id);
                if (blogger is null)
                    return false;

                db.Blogger.Remove(blogger);
                return db.SaveChanges() > 0;
            }
        }

        public Blogger? Get(int id)
        {
            using (BloggersContext db = new BloggersContext())
            {
                return db.Blogger.Find(id);
            }
        }

        public List<Blogger> GetBloggers()
        {
            using (BloggersContext db = new BloggersContext())
            {
                return db.Blogger.ToList();
            }
        }

        public bool InsertBlogger(string? name, string? post)
        {
            using (BloggersContext db = new BloggersContext())
            {
                var blogger = new Blogger
                {
                    Name = Convert.ToString(name),
                    Post = Convert.ToString(post),
                };

                db.Blogger.Add(blogger);
                return db.SaveChanges() > 0;
            }

        }

        public bool UpdateBlogger(int id, string? name, string? post)
        {
            using (BloggersContext db = new BloggersContext())
            {
                var blogger = db.Blogger.Find(id);
                if (blogger is null)
                    return false;

                blogger.Name = Convert.ToString(name);
                blogger.Post = Convert.ToString(post);
                db.Blogger.Update(blogger);
                return db.SaveChanges() > 0;
            }
        }
    }
}

