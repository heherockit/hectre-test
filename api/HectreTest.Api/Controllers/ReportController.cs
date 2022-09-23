using HectreTest.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HectreTest.Api;

public class ReportController : ControllerBase
{
    private readonly IMediator _mediator;

    public ReportController(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<ActionResult<IEnumerable<Orchard>?>> GetReport([FromQuery] HarvestReportQuery query)
    {
        return Ok(await _mediator.Send(query));
    }
}