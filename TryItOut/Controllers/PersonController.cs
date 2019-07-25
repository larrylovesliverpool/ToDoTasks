using System.Web.Mvc;
using TryItOut.Controllers.BaseControllers;
using TryItOut.ViewModels;
using TryItOut.Helpers.Filters;
using TryItOut.ToDoTasks.ViewModels;
using TryItOut.Logic;
using TryItOut.CommonInterfaces;
using TryItOut.Service;

namespace TryItOut.Controllers
{
    [HandleError]
    [Footer]
    public class PersonController : BaseController
    {
        private readonly ILogin_Service loginService = null;

        public PersonController(ILogin_Service loginService)
        {
            this.loginService = loginService;
        }

        public ActionResult Index()
        {
            var person = new PersonViewModel();

            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection frmcollection)
        {
            var vmConfirmation = new ConfirmationViewModel();

            if (ModelState.IsValid)
            {
                var name = frmcollection["Name"].ToString();

                return View("Confirmation", vmConfirmation);
            }

            return View();
        }

        public ActionResult PersonCancel() {

            return Redirect("~/home");
        }

        public ActionResult Login()
        {
            LoginViewModel viewModel = new LoginViewModel();

            return View("Login", viewModel);
        }

        [HttpPost]
        public ActionResult Login(FormCollection frmcollection)
        {
            LoginViewModel viewModel = new LoginViewModel();

            if (ModelState.IsValid)
            {
                var userName = frmcollection["UserName"].ToString();
                var password = frmcollection["password"].ToString();

                /* need dto model for return login success and status */
                var userLogin = loginService.LoginUser(userName, password);

                if (userLogin.IsLoggedIn)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    /* mapper required */
                    viewModel.Message = userLogin.Message;
                }
            }

            return View("Login", viewModel);
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(FormCollection frmcollection)
        {
            return View();
        }

        public ActionResult RegisteredUsers()
        {
            RegisteredUsersViewModel viewModel = new RegisteredUsersViewModel();
            var usersDTO = new RegisteredUsersService().Read();

            /* map DTO to ViewModel */
            if( usersDTO.NumberOf >= 0 )
            {
                viewModel.HasUsers = true;

                foreach(var user in usersDTO.registeredUsers)
                {
                    viewModel.RegUsers.Add(new RegisteredUserViewModel() {
                        Identifier = user.Identifier,
                        Username = user.Username,
                        Password = user.Password,
                        Lastname = user.Lastname,
                        Firstname = user.Firstname,
                        IsActive = user.IsActive
                    });
                }
            }
            else
            {
                viewModel.Message.Text = "No registered Users found.";
            }

            return View(viewModel);
        }

        public ActionResult RegisteredUserDetails()
        {
            return PartialView("_RegisteredUserDetails");
        }

    }
}