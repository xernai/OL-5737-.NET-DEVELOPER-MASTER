// Default URL for triggering event grid function in the local environment.
// http://localhost:7071/runtime/webhooks/EventGrid?functionName={functionname}

using Azure.Messaging;
using Azure.Messaging.EventGrid;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using System;

namespace EventGridReceiver;

public class Function1
{
    private readonly ILogger<Function1> _logger;

    public Function1(ILogger<Function1> logger)
    {
        _logger = logger;
    }

    [Function(nameof(Function1))]
    public void Run([EventGridTrigger] EventGridEvent eventGridEvent)
    {
        _logger.LogInformation("Evento recibido:");
        _logger.LogInformation($"Asunto: {eventGridEvent.Subject}");
        _logger.LogInformation($"Datos: {eventGridEvent.Data}");
        //_logger.LogInformation("Event type: {type}, Event subject: {subject}", cloudEvent.Type, cloudEvent.Subject);
    }
}