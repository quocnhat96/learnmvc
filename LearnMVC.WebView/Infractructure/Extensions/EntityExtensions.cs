using LearnMVC.Model.Models;
using LearnMVC.WebView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearnMVC.WebView.Infractructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory(this PostCategory postcategory, PostCategoryViewModel postCategoryVM)
        {
            postcategory.ID = postCategoryVM.ID;
            postcategory.Name = postCategoryVM.Name;
            postcategory.Alias = postCategoryVM.Alias;
            postcategory.Description = postCategoryVM.Description;
            postcategory.ParentID = postCategoryVM.ParentID;
            postcategory.DisplayOrder = postCategoryVM.DisplayOrder;
            postcategory.HomeFlag = postCategoryVM.HomeFlag;
            postcategory.CreatedDate = postCategoryVM.CreatedDate;
            postcategory.CreatedBy = postCategoryVM.CreatedBy;
            postcategory.UpdatedDate = postCategoryVM.UpdatedDate;
            postcategory.UpdatedBy = postCategoryVM.UpdatedBy;
            postcategory.MetaDescription = postCategoryVM.MetaDescription;
            postcategory.Status = postCategoryVM.Status;
        }

        public static void UpdatePost(this Post post, PostViewModel postVM)
        {
            post.ID = postVM.ID;
            post.Name = postVM.Name;
            post.Alias = postVM.Alias;
            post.CategoryID = postVM.CategoryID;
            post.Image = postVM.Image;
            post.Description = postVM.Description;
            post.HomeFlag = postVM.HomeFlag;
            post.HotFlag = postVM.HotFlag;
            post.ViewCount = postVM.ViewCount;

            post.CreatedDate = postVM.CreatedDate;
            post.CreatedBy = postVM.CreatedBy;
            post.UpdatedDate = postVM.UpdatedDate;
            post.UpdatedBy = postVM.UpdatedBy;
            post.MetaDescription = postVM.MetaDescription;
            post.Status = postVM.Status;
        }
    }
}
