using DotNetGram.Data;
using DotNetGram.Model.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetGram.Model.Services
{
    public class PostManagerService:IPost
    {
        private readonly PostDbContext _context;
        public PostManagerService(PostDbContext context)
        {
            _context = context;
        }
        public async Task DeleteAsync(int id)
        {
            Post post = await _context.Posts.FindAsync(id);
            if (post != null)

            {

                _context.Posts.Remove(post);

                await _context.SaveChangesAsync();

            }
        }

        public async Task<Post> FindPostAsync(int id)
        {
            Post post = await _context.Posts.FirstOrDefaultAsync(p => p.ID == id);
            return post;
        }

        public async Task<List<Post>> GetPosts()
        {
            return await _context.Posts.ToListAsync();
        }

        public async Task SaveAsync(Post Post)
        {
            if (await _context.Posts.FirstOrDefaultAsync(p => p.ID == Post.ID) == null)

            {
                _context.Posts.Add(Post);

            }
            else

            {  //update if its there
                _context.Posts.Update(Post);

            }

            await _context.SaveChangesAsync();
        }
    }
}
    

