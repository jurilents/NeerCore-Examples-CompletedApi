using Mapster;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using NeerCore.Api.Controllers;
using SeniorTemplate.Application.Features.Teas.Models;

namespace SeniorTemplate.Api.Controllers;

public class TeasController : MediatorController
{
    [HttpGet("{id:guid}")]
    public async Task<TeaModel> Get([FromRoute] Guid id) =>
        await Mediator.Send(new TeaByIdQuery(id));

    [HttpGet]
    public async Task<IEnumerable<TeaModel>> Filter([FromQuery] TeaByFilterQuery filter) =>
        await Mediator.Send(filter);

    [HttpPost]
    public async Task<ActionResult<TeaModel>> Post([FromBody] TeaCreateCommand command, CancellationToken cancel)
    {
        var model = await Mediator.Send(command, cancel);
        return CreatedAtAction(nameof(Get), new { id = model.Id }, model);
    }

    [HttpPut("{id:guid}")]
    public async Task<NoContentResult> Put([FromRoute] Guid id, [FromBody] TeaUpdateCommand command, CancellationToken cancel)
    {
        await Mediator.Send(command, cancel);
        return NoContent();
    }

    [HttpPatch("{id:guid}")]
    public async Task<NoContentResult> Patch([FromRoute] Guid id, [FromBody] JsonPatchDocument<TeaModel> patch, CancellationToken cancel)
    {
        var model = await Mediator.Send(new TeaByIdQuery(id), cancel);
        patch.ApplyTo(model);
        await Mediator.Send(model.Adapt<TeaUpdateCommand>(), cancel);
        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    public async Task<NoContentResult> Delete([FromRoute] Guid id, CancellationToken cancel)
    {
        await Mediator.Send(new TeaDeleteCommand(id), cancel);
        return NoContent();
    }
}