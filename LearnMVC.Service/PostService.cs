using LearnMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnMVC.Data.Repositories;
using LearnMVC.Data.Infrastructure;

namespace LearnMVC.Service
{
    public interface IPostService
    {
        void Add(Post post);
        void Update(Post post);
        void Detele(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow);
        Post GetById(int id);
        IEnumerable<Post> GetAllByTagPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();
    }
    public class PostService : IPostService
    {
        IPostRepository _postReponsitory;
        IUnitOfWork _unitOfWork;

        public PostService(IPostRepository postReponsitory, IUnitOfWork unitOfWork)
        {
            this._postReponsitory = postReponsitory;
            this._unitOfWork = unitOfWork;
        }
        public void Add(Post post)
        {
            _postReponsitory.Add(post);
        }

        public void Detele(int id)
        {
            _postReponsitory.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _postReponsitory.GetAll(new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllByTagPaging(int page, int pageSize, out int totalRow)
        {
            return _postReponsitory.GetMultiPaging(x=>x.Status, out totalRow, page, pageSize );
        }

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _postReponsitory.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }


        public Post GetById(int id)
        {
            return _postReponsitory.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Post post)
        {
            _postReponsitory.Update(post);
        }
    }
}
