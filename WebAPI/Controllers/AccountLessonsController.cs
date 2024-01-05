﻿using Business.Abstracts;
using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Microsoft.AspNetCore.Mvc;
using Business.Rules.ValidationRules.FluentValidation.CreateRequestValidators;
using Core.CrossCuttingConcerns.Validation;
using Business.Rules.ValidationRules.FluentValidation.UpdateRequestValidators;
using Core.DataAccess.Paging;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountLessonsController : ControllerBase
{
    IAccountLessonService _accountLessonService;

    public AccountLessonsController(IAccountLessonService accountLessonService)
    {
        _accountLessonService = accountLessonService;
    }

    [HttpGet("GetList")]
    public async Task<IActionResult> GetListAsync([FromQuery] PageRequest pageRequest)
    {
        var result = await _accountLessonService.GetListAsync(pageRequest);
        return Ok(result);
    }


    [HttpGet("GetById")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        var result = await _accountLessonService.GetByIdAsync(id);
        return Ok(result);
    }


    [HttpPost("Add")]
    public async Task<IActionResult> AddAsync([FromBody] CreateAccountLessonRequest createAccountLessonRequest)
    {
        var result = await _accountLessonService.AddAsync(createAccountLessonRequest);
        return Ok(result);
    }


    [HttpPost("Update")]
    public async Task<IActionResult> UpdateAsync([FromBody] UpdateAccountLessonRequest updateAccountLessonRequest)
    {
        var result = await _accountLessonService.UpdateAsync(updateAccountLessonRequest);
        return Ok(result);
    }


    [HttpPost("Delete")]
    public async Task<IActionResult> DeleteAsync([FromBody] DeleteAccountLessonRequest deleteAccountLessonRequest)
    {
        var result = await _accountLessonService.DeleteAsync(deleteAccountLessonRequest);
        return Ok(result);
    }
}
