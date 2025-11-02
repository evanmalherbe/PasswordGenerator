using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PasswordGenerator.Models;
using PasswordGenerator.ViewModels;

namespace PasswordGenerator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly string lowercaseAlphabet = "abcdefghijklmnopqrstuvwxyz";
        private readonly string uppercaseAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private readonly string numberList = "0123456789";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Create(CreateViewModel model)
        {
          List<char> mix = new List<char>();
          char[] uppercase = uppercaseAlphabet.ToCharArray(); // 26
          char[] lowercase = lowercaseAlphabet.ToCharArray(); // 26
          char[] numbers = numberList.ToCharArray(); // 10
          
          static void addChars(bool toInclude,char[] theArray, List<char> mixList)
          { 
            List<char> theList = new List<char>();
            if (toInclude)
            {
              foreach(char letter in theArray)
              {
                mixList.Add(letter);
              }
            }
          };
          
          addChars(model.UpperCase, uppercase, mix);
          addChars(model.LowerCase, lowercase, mix);
          addChars(model.Numbers, numbers, mix);
       
          string password = "";
          Random random = new Random();
          int lengthOfCharsList = mix.Count - 1;

          for(int i = 0; i < model.Length; i++) 
          {
            int j = random.Next(0,lengthOfCharsList);
            password += mix[j];
          }
          model.NewPassword = password;
          return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
