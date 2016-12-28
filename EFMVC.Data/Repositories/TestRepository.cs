using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EFMVC.Data.Infrastructure;
using EFMVC.Model;
namespace EFMVC.Data.Repositories
{

    public class Test 
    {
        public int Id{get;set;}

    }

    public class TestRepository : RepositoryBase<Test>, ITestRepository
    {
        public TestRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
        
    }
    public interface ITestRepository : IRepository<Test>
    {
        //IEnumerable<CategoryWithExpense> GetCategoryWithExpenses();
    }
    

}