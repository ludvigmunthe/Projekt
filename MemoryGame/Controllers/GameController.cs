using Microsoft.AspNetCore.Mvc;
using MemoryGame.Data;
using MemoryGame.Models;
using Microsoft.Data.SqlClient;
using System.Linq;

namespace MemoryGame.Controllers
{
    public class GameController : Controller
    {
        public IActionResult CreateGame(){
            return View();
        }
        public IActionResult JoinGame(){
            return View();
        }
        public IActionResult Login(){
            return View();
        }
        public IActionResult Logout(){
            return View();
        }
        public IActionResult Play(){
            return View();
        }
    }
        
}