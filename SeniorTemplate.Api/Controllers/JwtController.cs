﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NeerCore.Api.Controllers;
using SeniorTemplate.Application.Features.Auth;
using SeniorTemplate.Application.Features.Auth.Check;
using SeniorTemplate.Application.Features.Auth.Complete;
using SeniorTemplate.Application.Features.Auth.Refresh;

namespace SeniorTemplate.Api.Controllers;

[AllowAnonymous]
public class JwtController : MediatorController
{
    [HttpPost("check")]
    public async Task<AuthCheckResult> CheckAsync([FromBody] AuthCheckQuery query) =>
        await Mediator.Send(query);

    [HttpPost("complete")]
    public async Task<AuthResult> CompleteAsync([FromBody] AuthCompleteCommand command, CancellationToken cancel) =>
        await Mediator.Send(command, cancel);

    [HttpPut("refresh")]
    public async Task<AuthResult> RefreshAsync([FromBody] AuthRefreshCommand command, CancellationToken cancel) =>
        await Mediator.Send(command, cancel);
}