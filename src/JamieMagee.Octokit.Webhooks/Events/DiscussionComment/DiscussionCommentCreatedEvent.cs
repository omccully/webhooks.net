namespace JamieMagee.Octokit.Webhooks.Events.DiscussionComment
{
    using System.Text.Json.Serialization;
    using JamieMagee.Octokit.Webhooks.Models;

    [WebhookActionType(DiscussionCommentActionValue.Created)]
    public sealed record DiscussionCommentCreatedEvent : DiscussionCommentEvent
    {
        [JsonPropertyName("action")]
        public override string Action => DiscussionCommentAction.Created;
    }
}