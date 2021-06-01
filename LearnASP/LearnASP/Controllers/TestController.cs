using LearnASP.Models;
using LearnASP.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnASP.Controllers
{
    public class TestController : Controller
    {
        private readonly TestRepository testRepository;

        public TestController()
        {
            testRepository = new TestRepository();
        }
        public IActionResult Index()
        {
            return View();
        }

        public List<TestModel> T()
        {
            return testRepository.TestAllList();
        }

        public TestModel Twid(int id)
        {
            return testRepository.TestById(id);
        }

        public List<TestModel> Tsearch(string title,string author)
        {
            return testRepository.TestWithSearch(title,author);
        }
    }
}
