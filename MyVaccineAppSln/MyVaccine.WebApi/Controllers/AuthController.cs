﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MyVaccine.WebApi.Dtos;
using MyVaccine.WebApi.Literals;
using MyVaccine.WebApi.Repositories.Contracts;
using MyVaccine.WebApi.Services.Contracts;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MyVaccine.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{

    private readonly IUserService _userService;

    public AuthController(UserManager<IdentityUser> userManager, IUserService UserService)
    {
        _userService = UserService;
    }

    [HttpPost("register")]

    public async Task<IActionResult> Register([FromBody] RegisterRequetDto model)
    {

        var response = await _userService.AddUserAsync(model);
        if (response.IsSucces)
        {
            return Ok(response);

        }
        else
        {
            return BadRequest(response);
        }
    }


    [HttpPost("login")]

    public async Task<IActionResult> Login([FromBody] LoginRequestDto model)
    {
        var response = await _userService.Login(model);
        if (response.IsSucces)
        {
            return Ok(response);
        }
        else
        {
            return Unauthorized(response);
        }


    }

    [Authorize]
    [HttpPost("refresh-token")]
    public async Task<IActionResult> RefreshToken()
    {
        var claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
        var response = await _userService.RefreshToken(claimsIdentity.Name);
        if (response.IsSucces)
        {
            return Ok(response);
        }
        else
        {
            return Unauthorized(response);
        }


        //var result = await _userRepository.AddUser(model);
        //if (!result.Succeeded)
        //{
        //    return BadRequest(result.Errors);
        //}
        //return Ok("User registered successfully");

    }

    [Authorize]
    [HttpGet("user-info")]
    public async Task<IActionResult> GetUserInfo()
    {
        var claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
        var response = await _userService.GetUserInfo(claimsIdentity.Name);

        return Ok(response);
    }
}
