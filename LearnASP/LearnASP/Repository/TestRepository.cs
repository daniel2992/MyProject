using LearnASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnASP.Repository
{
    public class TestRepository
    {
        public List<TestModel> TestAllList()
        {
            return DataSource();
        }

        public TestModel TestById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<TestModel> TestWithSearch(string title, string author)
        {
            return DataSource().Where(x => x.Title.Contains(title) && x.Author.Contains(author)).ToList();
        }

        private List<TestModel> DataSource()
        {
            return new List<TestModel>()
            {
                new TestModel() { Id=1, Title="MVC", Author="Dani"},
                new TestModel() { Id=2, Title="Razor", Author="da"},
                new TestModel() { Id=1, Title="ASP", Author="Daniel"}
            };
        }
    }
}
