// Default URL for triggering event grid function in the local environment.
// http://localhost:7071/runtime/webhooks/EventGrid?functionName={functionname}

using Azure.Messaging;
using Azure.Messaging.EventGrid;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using System;

namespace EventGridReceiverEventGridTrigger;

public class EventGridTriggerWeather
{
    private readonly ILogger<EventGridTriggerWeather> _logger;

    public EventGridTriggerWeather(ILogger<EventGridTriggerWeather> logger)
    {
        _logger = logger;
    }

    [Function(nameof(EventGridTriggerWeather))]
    public void Run([EventGridTrigger] EventGridEvent eventGridEvent)
    {
        _logger.LogInformation("Evento recibido:");
        _logger.LogInformation($"Asunto: {eventGridEvent.Subject}");
        _logger.LogInformation($"Datos: {eventGridEvent.Data}");

        // db, table storage
    }
}