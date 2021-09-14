﻿namespace JamieMagee.Octokit.Webhooks.Models.ProjectEvent
{
    using System.Text.Json.Serialization;

    public sealed record ChangesName
    {
        [JsonPropertyName("from")]
        public string From { get; init; } = null!;
    };
}