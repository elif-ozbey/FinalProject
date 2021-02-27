using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>( _categoryDal.GetAll());
        }
        //Select * from Categories where CategoryId=verilen deger. Bu iafadeyi yazmis olduk linq ile
        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>( _categoryDal.Get(c => c.CategoryId == categoryId));
        }
    }
}
