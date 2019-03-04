using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetGram.Model.Interface
{
    public interface IPost
    {
        Task<Post> FindPostAsync(int id);
        Task<List<Post>> GetPosts();
        Task DeleteAsync(int id);
        Task SaveAsync(Post Post);
    }
}
