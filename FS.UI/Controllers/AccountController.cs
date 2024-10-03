using FS.BusinessLogicLayer.Abstract;
using FS.BusinessLogicLayer.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace FS.UI.Controllers
{
    public class AccountController : Controller
    {

        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            CreateUserDto userDto = new();
            return View(userDto);
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] CreateUserDto userDto)
        {
            var result = await _userService.CreateUserAsync(userDto);

            if (result.ResponseType == CoreLayer.Enums.ResponseType.ValidationError)
            {
                foreach (var item in result.ResponseValidationResults)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

                var errors = ModelState.Where(x => x.Value.Errors.Count > 0)
                    .ToDictionary(
                        kvp => kvp.Key,
                        kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray()
                    );

                return Json(new { success = false, errors });
            }
            return View();
        }

    }

}
