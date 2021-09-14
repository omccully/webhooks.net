﻿namespace JamieMagee.Octokit.Webhooks.Events
{
    using System.Text.Json.Serialization;
    using JamieMagee.Octokit.Webhooks.Converter;

    [WebhookEventType(WebhookEventType.Star)]
    [JsonConverter(typeof(WebhookConverter<StarEvent>))]
    public abstract record StarEvent : WebhookEvent
    {
    }
}