using Sovanny_Yun_CST356_Lab7.Data;
using Sovanny_Yun_CST356_Lab7.Data.Entities;
using Sovanny_Yun_CST356_Lab7.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using Sovanny_Yun_CST356_Lab7.Models.View;
using Sovanny_Yun_CST356_Lab7.Repository;
using Sovanny_Yun_CST356_Lab7.Services;

namespace Sovanny_Yun_CST356_Lab7.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService _userService)
        {
            this._userService = _userService;
        }
        public ActionResult Index()
        {
            return View(_userService.GetAllUsers());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                _userService.Create(userViewModel);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            return View(_userService.GetUser(id));
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var user = _userService.GetUser(id);

            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                _userService.Edit(userViewModel);

                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Delete(int id)
        {
            _userService.DeleteUser(id);
            return RedirectToAction("Index");
        }

        private UserViewModel GetUser(int id)
        {
            return _userService.GetUser(id);
        }


    }
}