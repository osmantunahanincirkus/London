using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LondonV1.Controller;

[Route("api/[controller]")]
[ApiController]
public class UserController(
) : ControllerBase
{
    [HttpPost("login")]
    [AllowAnonymous]
    public async Task<IActionResult> Login()
    {
        return Ok("merhaba");
        //return Ok(jwtService.GenerateToken(10, "selman"));
        //return Ok(await userService.Login(body));
    }

    /*[HttpPost("sign-up")]
    [AllowAnonymous]
    public async Task<IActionResult> SignUp([FromBody] SignUpRequestModel body)
    {
        return Ok(await userService.signUp(body));
    }*/
}