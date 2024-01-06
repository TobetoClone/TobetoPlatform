﻿using Business.Abstracts;
using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Rules.ValidationRules.FluentValidation.CreateRequestValidators;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Logging.SeriLog.Logger;
using Core.CrossCuttingConcerns.Logging;
using Core.CrossCuttingConcerns.Validation;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountsController : ControllerBase
{
    IAccountService _accountService;

    public AccountsController(IAccountService accountService)
    {
        _accountService = accountService;
    }


    [Logging(typeof(MsSqlLogger))]
    [Logging(typeof(FileLogger))]
    [Cache(60)]
    [HttpGet("GetList")]
    public async Task<IActionResult> GetListAsync([FromQuery] PageRequest pageRequest)
    {
        var result = await _accountService.GetListAsync(pageRequest);
        return Ok(result);
    }


    [Logging(typeof(MsSqlLogger))]
    [Logging(typeof(FileLogger))]
    [Cache]
    [HttpGet("GetBySessionId")]
    public async Task<IActionResult> GetBySessionIdAsync(Guid id)
    {
        var result = await _accountService.GetBySessionIdAsync(id);
        return Ok(result);
    }


    [Logging(typeof(MsSqlLogger))]
    [Logging(typeof(FileLogger))]
    [Cache]
    [HttpGet("GetById")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        var result = await _accountService.GetByIdAsync(id);
        return Ok(result);
    }


    [Logging(typeof(MsSqlLogger))]
    [Logging(typeof(FileLogger))]
    [CacheRemove("Accounts.Get")]
    [CustomValidation(typeof(CreateAccountRequestValidator))]
    [HttpPost("Add")]
    public async Task<IActionResult> AddAsync([FromBody] CreateAccountRequest createAccountRequest)
    {
        var result = await _accountService.AddAsync(createAccountRequest);
        return Ok(result);
    }


    [Logging(typeof(MsSqlLogger))]
    [Logging(typeof(FileLogger))]
    [CacheRemove("Accounts.Get")]
    [CustomValidation(typeof(UpdateAccountRequestValidator))]
    [HttpPost("Update")]
    public async Task<IActionResult> UpdateAsync([FromBody] UpdateAccountRequest updateAccountRequest)
    {
        var result = await _accountService.UpdateAsync(updateAccountRequest);
        return Ok(result);
    }


    [Logging(typeof(MsSqlLogger))]
    [Logging(typeof(FileLogger))]
    [CacheRemove("Accounts.Get")]
    [HttpPost("Delete")]
    public async Task<IActionResult> DeleteAsync([FromBody] DeleteAccountRequest deleteAccountRequest)
    {
        var result = await _accountService.DeleteAsync(deleteAccountRequest);
        return Ok(result);
    }
}
