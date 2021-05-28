using MindforkTask.Repository;
using System.Collections.Generic;
using MindforkTask.Models;

namespace MindforkTask.Service
{
    public class CommentService : ICommentService
    {
        private ICommentRepo<Comment> repo;
        public CommentService(ICommentRepo<Comment> repo)
        {
            this.repo = repo;
        }
        public List<Comment> comments()
        {
           return  repo.comments();
        }
    }
}