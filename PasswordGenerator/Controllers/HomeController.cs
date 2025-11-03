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
        private readonly string specialChars = "!\\#$%&'()*+,-./:;<=>?@[\\]^_`{|}~"; 

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(CreateViewModel model)
        {
          if (!ModelState.IsValid)
          {
            ModelState.AddModelError(string.Empty, "Missing input");
            return RedirectToAction("Index", "Home");
          }  
          // If no complexity option is chosen
          if (!model.LowerCase && !model.UpperCase && !model.LowerCase && !model.SpecialChars && !model.Numbers)
          {
            ModelState.AddModelError(string.Empty, "You must select at least one 'Character Types (Complexity)' option.");
            return View("Index", model);
          }
          // Create char arrays from alphabet strings
          List<char> mix = new List<char>();
          char[] uppercase = uppercaseAlphabet.ToCharArray(); // 26
          char[] lowercase = lowercaseAlphabet.ToCharArray(); // 26
          char[] numbers = numberList.ToCharArray(); // 10
          char[] special = specialChars.ToCharArray(); // 32
          
          // method to add lists to larger list, IF user chose to include them (e.g. uppercase letters)
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
          // Add char lists to combined/mixed list
          addChars(model.UpperCase, uppercase, mix);
          addChars(model.LowerCase, lowercase, mix);
          addChars(model.Numbers, numbers, mix);
          addChars(model.SpecialChars, special, mix);
       
          // Create password by randomly selecting the user defined number of characters from the mixed list of characters
          string password = "";
          Random random = new Random();
          int lengthOfCharsList = mix.Count - 1;
          int passwordLength = Int32.Parse(model.PasswordLength);

          for(int i = 0; i < passwordLength; i++) 
          {
            int j = random.Next(0,lengthOfCharsList);
            password += mix[j];
          }

          model.NewPassword = password;

          // Return new password view with created password
          return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
