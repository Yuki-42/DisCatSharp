// This file is part of the DSharpPlusNextGen project.
//
// Copyright (c) 2021 AITSYS
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System.Collections.Generic;

namespace DSharpPlusNextGen.Entities
{
    /// <summary>
    /// Represents an audit log entry.
    /// </summary>
    public abstract class DiscordAuditLogEntry : SnowflakeObject
    {
        /// <summary>
        /// Gets the entry's action type.
        /// </summary>
        public AuditLogActionType ActionType { get; internal set; }

        /// <summary>
        /// Gets the user responsible for the action.
        /// </summary>
        public DiscordUser UserResponsible { get; internal set; }

        /// <summary>
        /// Gets the reason defined in the action.
        /// </summary>
        public string Reason { get; internal set; }

        /// <summary>
        /// Gets the category under which the action falls.
        /// </summary>
        public AuditLogActionCategory ActionCategory { get; internal set; }
    }

    /// <summary>
    /// Represents a description of how a property changed.
    /// </summary>
    /// <typeparam name="T">Type of the changed property.</typeparam>
    public sealed class PropertyChange<T>
    {
        /// <summary>
        /// The property's value before it was changed.
        /// </summary>
        public T Before { get; internal set; }

        /// <summary>
        /// The property's value after it was changed.
        /// </summary>
        public T After { get; internal set; }
    }

    /// <summary>
    /// Represents a audit log guild entry.
    /// </summary>
    public sealed class DiscordAuditLogGuildEntry : DiscordAuditLogEntry
    {
        /// <summary>
        /// Gets the affected guild.
        /// </summary>
        public DiscordGuild Target { get; internal set; }

        /// <summary>
        /// Gets the description of guild name's change.
        /// </summary>
        public PropertyChange<string> NameChange { get; internal set; }

        /// <summary>
        /// Gets the description of owner's change.
        /// </summary>
        public PropertyChange<DiscordMember> OwnerChange { get; internal set; }

        /// <summary>
        /// Gets the description of icon's change.
        /// </summary>
        public PropertyChange<string> IconChange { get; internal set; }

        /// <summary>
        /// Gets the description of verification level's change.
        /// </summary>
        public PropertyChange<VerificationLevel> VerificationLevelChange { get; internal set; }

        /// <summary>
        /// Gets the description of afk channel's change.
        /// </summary>
        public PropertyChange<DiscordChannel> AfkChannelChange { get; internal set; }

        /// <summary>
        /// Gets the description of widget channel's change.
        /// </summary>
        public PropertyChange<DiscordChannel> EmbedChannelChange { get; internal set; }

        /// <summary>
        /// Gets the description of notification settings' change.
        /// </summary>
        public PropertyChange<DefaultMessageNotifications> NotificationSettingsChange { get; internal set; }

        /// <summary>
        /// Gets the description of system message channel's change.
        /// </summary>
        public PropertyChange<DiscordChannel> SystemChannelChange { get; internal set; }

        /// <summary>
        /// Gets the description of explicit content filter settings' change.
        /// </summary>
        public PropertyChange<ExplicitContentFilter> ExplicitContentFilterChange { get; internal set; }

        /// <summary>
        /// Gets the description of guild's mfa level change.
        /// </summary>
        public PropertyChange<MfaLevel> MfaLevelChange { get; internal set; }

        /// <summary>
        /// Gets the description of invite splash's change.
        /// </summary>
        public PropertyChange<string> SplashChange { get; internal set; }

        /// <summary>
        /// Gets the description of the guild's region change.
        /// </summary>
        public PropertyChange<string> RegionChange { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscordAuditLogGuildEntry"/> class.
        /// </summary>
        internal DiscordAuditLogGuildEntry() { }
    }

    /// <summary>
    /// Represents a audit log channel entry.
    /// </summary>
    public sealed class DiscordAuditLogChannelEntry : DiscordAuditLogEntry
    {
        /// <summary>
        /// Gets the affected channel.
        /// </summary>
        public DiscordChannel Target { get; internal set; }

        /// <summary>
        /// Gets the description of channel's name change.
        /// </summary>
        public PropertyChange<string> NameChange { get; internal set; }

        /// <summary>
        /// Gets the description of channel's type change.
        /// </summary>
        public PropertyChange<ChannelType?> TypeChange { get; internal set; }

        /// <summary>
        /// Gets the description of channel's nsfw flag change.
        /// </summary>
        public PropertyChange<bool?> NsfwChange { get; internal set; }

        /// <summary>
        /// Gets the description of channel's bitrate change.
        /// </summary>
        public PropertyChange<int?> BitrateChange { get; internal set; }

        /// <summary>
        /// Gets the description of channel permission overwrites' change.
        /// </summary>
        public PropertyChange<IReadOnlyList<DiscordOverwrite>> OverwriteChange { get; internal set; }

        /// <summary>
        /// Gets the description of channel's topic change.
        /// </summary>
        public PropertyChange<string> TopicChange { get; internal set; }

        /// <summary>
        /// Gets the description of channel's slow mode timeout change.
        /// </summary>
        public PropertyChange<int?> PerUserRateLimitChange { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscordAuditLogChannelEntry"/> class.
        /// </summary>
        internal DiscordAuditLogChannelEntry() { }
    }

    /// <summary>
    /// Represents a audit log overwrite entry.
    /// </summary>
    public sealed class DiscordAuditLogOverwriteEntry : DiscordAuditLogEntry
    {
        /// <summary>
        /// Gets the affected overwrite.
        /// </summary>
        public DiscordOverwrite Target { get; internal set; }

        /// <summary>
        /// Gets the channel for which the overwrite was changed.
        /// </summary>
        public DiscordChannel Channel { get; internal set; }

        /// <summary>
        /// Gets the description of overwrite's allow value change.
        /// </summary>
        public PropertyChange<Permissions?> AllowChange { get; internal set; }

        /// <summary>
        /// Gets the description of overwrite's deny value change.
        /// </summary>
        public PropertyChange<Permissions?> DenyChange { get; internal set; }

        /// <summary>
        /// Gets the description of overwrite's type change.
        /// </summary>
        public PropertyChange<string> TypeChange { get; internal set; }

        /// <summary>
        /// Gets the description of overwrite's target id change.
        /// </summary>
        public PropertyChange<ulong?> TargetIdChange { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscordAuditLogOverwriteEntry"/> class.
        /// </summary>
        internal DiscordAuditLogOverwriteEntry() { }
    }

    /// <summary>
    /// Represents a audit log kick entry.
    /// </summary>
    public sealed class DiscordAuditLogKickEntry : DiscordAuditLogEntry
    {
        /// <summary>
        /// Gets the kicked member.
        /// </summary>
        public DiscordMember Target { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscordAuditLogKickEntry"/> class.
        /// </summary>
        internal DiscordAuditLogKickEntry() { }
    }

    /// <summary>
    /// Represents a audit log prune entry.
    /// </summary>
    public sealed class DiscordAuditLogPruneEntry : DiscordAuditLogEntry
    {
        /// <summary>
        /// Gets the number inactivity days after which members were pruned.
        /// </summary>
        public int Days { get; internal set; }

        /// <summary>
        /// Gets the number of members pruned.
        /// </summary>
        public int Toll { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscordAuditLogPruneEntry"/> class.
        /// </summary>
        internal DiscordAuditLogPruneEntry() { }
    }

    /// <summary>
    /// Represents a audit log ban entry.
    /// </summary>
    public sealed class DiscordAuditLogBanEntry : DiscordAuditLogEntry
    {
        /// <summary>
        /// Gets the banned member.
        /// </summary>
        public DiscordMember Target { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscordAuditLogBanEntry"/> class.
        /// </summary>
        internal DiscordAuditLogBanEntry() { }
    }

    /// <summary>
    /// Represents a audit log member update entry.
    /// </summary>
    public sealed class DiscordAuditLogMemberUpdateEntry : DiscordAuditLogEntry
    {
        /// <summary>
        /// Gets the affected member.
        /// </summary>
        public DiscordMember Target { get; internal set; }

        /// <summary>
        /// Gets the description of member's nickname change.
        /// </summary>
        public PropertyChange<string> NicknameChange { get; internal set; }

        /// <summary>
        /// Gets the roles that were removed from the member.
        /// </summary>
        public IReadOnlyList<DiscordRole> RemovedRoles { get; internal set; }

        /// <summary>
        /// Gets the roles that were added to the member.
        /// </summary>
        public IReadOnlyList<DiscordRole> AddedRoles { get; internal set; }

        /// <summary>
        /// Gets the description of member's mute status change.
        /// </summary>
        public PropertyChange<bool?> MuteChange { get; internal set; }

        /// <summary>
        /// Gets the description of member's deaf status change.
        /// </summary>
        public PropertyChange<bool?> DeafenChange { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscordAuditLogMemberUpdateEntry"/> class.
        /// </summary>
        internal DiscordAuditLogMemberUpdateEntry() { }
    }

    /// <summary>
    /// Represents a audit log role update entry.
    /// </summary>
    public sealed class DiscordAuditLogRoleUpdateEntry : DiscordAuditLogEntry
    {
        /// <summary>
        /// Gets the affected role.
        /// </summary>
        public DiscordRole Target { get; internal set; }

        /// <summary>
        /// Gets the description of role's name change.
        /// </summary>
        public PropertyChange<string> NameChange { get; internal set; }

        /// <summary>
        /// Gets the description of role's color change.
        /// </summary>
        public PropertyChange<int?> ColorChange { get; internal set; }

        /// <summary>
        /// Gets the description of role's permission set change.
        /// </summary>
        public PropertyChange<Permissions?> PermissionChange { get; internal set; }

        /// <summary>
        /// Gets the description of the role's position change.
        /// </summary>
        public PropertyChange<int?> PositionChange { get; internal set; }

        /// <summary>
        /// Gets the description of the role's mentionability change.
        /// </summary>
        public PropertyChange<bool?> MentionableChange { get; internal set; }

        /// <summary>
        /// Gets the description of the role's hoist status change.
        /// </summary>
        public PropertyChange<bool?> HoistChange { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscordAuditLogRoleUpdateEntry"/> class.
        /// </summary>
        internal DiscordAuditLogRoleUpdateEntry() { }
    }

    /// <summary>
    /// Represents a audit log invite entry.
    /// </summary>
    public sealed class DiscordAuditLogInviteEntry : DiscordAuditLogEntry
    {
        /// <summary>
        /// Gets the affected invite.
        /// </summary>
        public DiscordInvite Target { get; internal set; }

        /// <summary>
        /// Gets the description of invite's max age change.
        /// </summary>
        public PropertyChange<int?> MaxAgeChange { get; internal set; }

        /// <summary>
        /// Gets the description of invite's code change.
        /// </summary>
        public PropertyChange<string> CodeChange { get; internal set; }

        /// <summary>
        /// Gets the description of invite's temporariness change.
        /// </summary>
        public PropertyChange<bool?> TemporaryChange { get; internal set; }

        /// <summary>
        /// Gets the description of invite's inviting member change.
        /// </summary>
        public PropertyChange<DiscordMember> InviterChange { get; internal set; }

        /// <summary>
        /// Gets the description of invite's target channel change.
        /// </summary>
        public PropertyChange<DiscordChannel> ChannelChange { get; internal set; }

        /// <summary>
        /// Gets the description of invite's use count change.
        /// </summary>
        public PropertyChange<int?> UsesChange { get; internal set; }

        /// <summary>
        /// Gets the description of invite's max use count change.
        /// </summary>
        public PropertyChange<int?> MaxUsesChange { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscordAuditLogInviteEntry"/> class.
        /// </summary>
        internal DiscordAuditLogInviteEntry() { }
    }

    /// <summary>
    /// Represents a audit log webhook entry.
    /// </summary>
    public sealed class DiscordAuditLogWebhookEntry : DiscordAuditLogEntry
    {
        /// <summary>
        /// Gets the affected webhook.
        /// </summary>
        public DiscordWebhook Target { get; internal set; }

        /// <summary>
        /// Gets the description of webhook's name change.
        /// </summary>
        public PropertyChange<string> NameChange { get; internal set; }

        /// <summary>
        /// Gets the description of webhook's target channel change.
        /// </summary>
        public PropertyChange<DiscordChannel> ChannelChange { get; internal set; }

        /// <summary>
        /// Gets the description of webhook's type change.
        /// </summary>
        public PropertyChange<int?> TypeChange { get; internal set; }

        /// <summary>
        /// Gets the description of webhook's avatar change.
        /// </summary>
        public PropertyChange<string> AvatarHashChange { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscordAuditLogWebhookEntry"/> class.
        /// </summary>
        internal DiscordAuditLogWebhookEntry() { }
    }

    /// <summary>
    /// Represents a audit log emoji entry.
    /// </summary>
    public sealed class DiscordAuditLogEmojiEntry : DiscordAuditLogEntry
    {
        /// <summary>
        /// Gets the affected emoji.
        /// </summary>
        public DiscordEmoji Target { get; internal set; }

        /// <summary>
        /// Gets the description of emoji's name change.
        /// </summary>
        public PropertyChange<string> NameChange { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscordAuditLogEmojiEntry"/> class.
        /// </summary>
        internal DiscordAuditLogEmojiEntry() { }
    }

    /// <summary>
    /// Represents a audit log sticker entry.
    /// </summary>
    public sealed class DiscordAuditLogStickerEntry : DiscordAuditLogEntry
    {
        /// <summary>
        /// Gets the affected sticker.
        /// </summary>
        public DiscordSticker Target { get; internal set; }

        /// <summary>
        /// Gets the description of sticker's name change.
        /// </summary>
        public PropertyChange<string> NameChange { get; internal set; }

        /// <summary>
        /// Gets the description of sticker's description change.
        /// </summary>
        public PropertyChange<string> DescriptionChange { get; internal set; }

        /// <summary>
        /// Gets the description of sticker's tags change.
        /// </summary>
        public PropertyChange<string> TagsChange { get; internal set; }

        /// <summary>
        /// Gets the description of sticker's tags change.
        /// </summary>
        public PropertyChange<string> AssetChange { get; internal set; }

        /// <summary>
        /// Gets the description of sticker's guild id change.
        /// </summary>
        public PropertyChange<ulong?> GuildIdChange { get; internal set; }

        /// <summary>
        /// Gets the description of sticker's availability change.
        /// </summary>
        public PropertyChange<bool?> AvailabilityChange { get; internal set; }

        /// <summary>
        /// Gets the description of sticker's id change.
        /// </summary>
        public PropertyChange<ulong?> IdChange { get; internal set; }

        /// <summary>
        /// Gets the description of sticker's type change.
        /// </summary>
        public PropertyChange<StickerType?> TypeChange { get; internal set; }

        /// <summary>
        /// Gets the description of sticker's format change.
        /// </summary>
        public PropertyChange<StickerFormat?> FormatChange { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscordAuditLogStickerEntry"/> class.
        /// </summary>
        internal DiscordAuditLogStickerEntry() { }
    }

    /// <summary>
    /// Represents a audit log message entry.
    /// </summary>
    public sealed class DiscordAuditLogMessageEntry : DiscordAuditLogEntry
    {
        /// <summary>
        /// Gets the affected message. Note that more often than not, this will only have ID specified.
        /// </summary>
        public DiscordMessage Target { get; internal set; }

        /// <summary>
        /// Gets the channel in which the action occurred.
        /// </summary>
        public DiscordChannel Channel { get; internal set; }

        /// <summary>
        /// Gets the number of messages that were affected.
        /// </summary>
        public int? MessageCount { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscordAuditLogMessageEntry"/> class.
        /// </summary>
        internal DiscordAuditLogMessageEntry() { }
    }

    /// <summary>
    /// Represents a audit log message pin entry.
    /// </summary>
    public sealed class DiscordAuditLogMessagePinEntry : DiscordAuditLogEntry
    {
        /// <summary>
        /// Gets the affected message's user.
        /// </summary>
        public DiscordUser Target { get; internal set; }

        /// <summary>
        /// Gets the channel the message is in.
        /// </summary>
        public DiscordChannel Channel { get; internal set; }

        /// <summary>
        /// Gets the message the pin action was for.
        /// </summary>
        public DiscordMessage Message { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscordAuditLogMessagePinEntry"/> class.
        /// </summary>
        internal DiscordAuditLogMessagePinEntry() { }
    }

    /// <summary>
    /// Represents a audit log bot add entry.
    /// </summary>
    public sealed class DiscordAuditLogBotAddEntry : DiscordAuditLogEntry
    {
        /// <summary>
        /// Gets the bot that has been added to the guild.
        /// </summary>
        public DiscordUser TargetBot { get; internal set; }
    }

    /// <summary>
    /// Represents a audit log member move entry.
    /// </summary>
    public sealed class DiscordAuditLogMemberMoveEntry : DiscordAuditLogEntry
    {
        /// <summary>
        /// Gets the channel the members were moved in.
        /// </summary>
        public DiscordChannel Channel { get; internal set; }

        /// <summary>
        /// Gets the amount of users that were moved out from the voice channel.
        /// </summary>
        public int UserCount { get; internal set; }
    }

    /// <summary>
    /// Represents a audit log member disconnect entry.
    /// </summary>
    public sealed class DiscordAuditLogMemberDisconnectEntry : DiscordAuditLogEntry
    {
        /// <summary>
        /// Gets the amount of users that were disconnected from the voice channel.
        /// </summary>
        public int UserCount { get; internal set; }
    }

    /// <summary>
    /// Represents a audit log integration entry.
    /// </summary>
    public sealed class DiscordAuditLogIntegrationEntry : DiscordAuditLogEntry
    {
        /// <summary>
        /// Gets the description of emoticons' change.
        /// </summary>
        public PropertyChange<bool?> EnableEmoticons { get; internal set; }

        /// <summary>
        /// Gets the description of expire grace period's change.
        /// </summary>
        public PropertyChange<int?> ExpireGracePeriod { get; internal set; }

        /// <summary>
        /// Gets the description of expire behavior change.
        /// </summary>
        public PropertyChange<int?> ExpireBehavior { get; internal set; }
    }

    /// <summary>
    /// Represents a audit log stage entry.
    /// </summary>
    public sealed class DiscordAuditLogStageEntry : DiscordAuditLogEntry
    {
        /// <summary>
        /// Gets the affected stage instance
        /// </summary>
        public DiscordStageInstance Target { get; internal set; }

        /// <summary>
        /// Gets the description of stage instance's topic change.
        /// </summary>
        public PropertyChange<string> TopicChange { get; internal set; }

        /// <summary>
        /// Gets the description of stage instance's privacy level change.
        /// </summary>
        public PropertyChange<StagePrivacyLevel?> PrivacyLevelChange { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscordAuditLogStageEntry"/> class.
        /// </summary>
        internal DiscordAuditLogStageEntry() { }
    }

    /// <summary>
    /// Represents a audit log event entry.
    /// </summary>
    public sealed class DiscordAuditLogEventEntry : DiscordAuditLogEntry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscordAuditLogEventEntry"/> class.
        /// </summary>
        internal DiscordAuditLogEventEntry() { }
    }

    /// <summary>
    /// Represents a audit log thread entry.
    /// </summary>
    public sealed class DiscordAuditLogThreadEntry : DiscordAuditLogEntry
    {
        /// <summary>
        /// Gets the affected thread
        /// </summary>
        public DiscordThreadChannel Target { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscordAuditLogThreadEntry"/> class.
        /// </summary>
        internal DiscordAuditLogThreadEntry() { }
    }

    /// <summary>
    /// Indicates audit log action category.
    /// </summary>
    public enum AuditLogActionCategory
    {
        /// <summary>
        /// Indicates that this action resulted in creation or addition of an object.
        /// </summary>
        Create,

        /// <summary>
        /// Indicates that this action resulted in update of an object.
        /// </summary>
        Update,

        /// <summary>
        /// Indicates that this action resulted in deletion or removal of an object.
        /// </summary>
        Delete,

        /// <summary>
        /// Indicates that this action resulted in something else than creation, addition, update, deleteion, or removal of an object.
        /// </summary>
        Other
    }

    // below is taken from
    // https://github.com/Rapptz/discord.py/blob/rewrite/discord/enums.py#L125

    /// <summary>
    /// Represents type of the action that was taken in given audit log event.
    /// </summary>
    public enum AuditLogActionType : int
    {
        /// <summary>
        /// Indicates that the guild was updated.
        /// </summary>
        GuildUpdate = 1,

        /// <summary>
        /// Indicates that the channel was created.
        /// </summary>
        ChannelCreate = 10,

        /// <summary>
        /// Indicates that the channel was updated.
        /// </summary>
        ChannelUpdate = 11,

        /// <summary>
        /// Indicates that the channel was deleted.
        /// </summary>
        ChannelDelete = 12,

        /// <summary>
        /// Indicates that the channel permission overwrite was created.
        /// </summary>
        OverwriteCreate = 13,

        /// <summary>
        /// Indicates that the channel permission overwrite was updated.
        /// </summary>
        OverwriteUpdate = 14,

        /// <summary>
        /// Indicates that the channel permission overwrite was deleted.
        /// </summary>
        OverwriteDelete = 15,

        /// <summary>
        /// Indicates that the user was kicked.
        /// </summary>
        Kick = 20,

        /// <summary>
        /// Indicates that users were pruned.
        /// </summary>
        Prune = 21,

        /// <summary>
        /// Indicates that the user was banned.
        /// </summary>
        Ban = 22,

        /// <summary>
        /// Indicates that the user was unbanned.
        /// </summary>
        Unban = 23,

        /// <summary>
        /// Indicates that the member was updated.
        /// </summary>
        MemberUpdate = 24,

        /// <summary>
        /// Indicates that the member's roles were updated.
        /// </summary>
        MemberRoleUpdate = 25,

        /// <summary>
        /// Indicates that the member has moved to another voice channel.
        /// </summary>
        MemberMove = 26,

        /// <summary>
        /// Indicates that the member has disconnected from a voice channel.
        /// </summary>
        MemberDisconnect = 27,

        /// <summary>
        /// Indicates that a bot was added to the guild.
        /// </summary>
        BotAdd = 28,

        /// <summary>
        /// Indicates that the role was created.
        /// </summary>
        RoleCreate = 30,

        /// <summary>
        /// Indicates that the role was updated.
        /// </summary>
        RoleUpdate = 31,

        /// <summary>
        /// Indicates that the role was deleted.
        /// </summary>
        RoleDelete = 32,

        /// <summary>
        /// Indicates that the invite was created.
        /// </summary>
        InviteCreate = 40,

        /// <summary>
        /// Indicates that the invite was updated.
        /// </summary>
        InviteUpdate = 41,

        /// <summary>
        /// Indicates that the invite was deleted.
        /// </summary>
        InviteDelete = 42,

        /// <summary>
        /// Indicates that the webhook was created.
        /// </summary>
        WebhookCreate = 50,

        /// <summary>
        /// Indicates that the webook was updated.
        /// </summary>
        WebhookUpdate = 51,

        /// <summary>
        /// Indicates that the webhook was deleted.
        /// </summary>
        WebhookDelete = 52,

        /// <summary>
        /// Indicates that an emoji was created.
        /// </summary>
        EmojiCreate = 60,

        /// <summary>
        /// Indicates that an emoji was updated.
        /// </summary>
        EmojiUpdate = 61,

        /// <summary>
        /// Indicates that an emoji was deleted.
        /// </summary>
        EmojiDelete = 62,

        /// <summary>
        /// Indicates that the message was deleted.
        /// </summary>
        MessageDelete = 72,

        /// <summary>
        /// Indicates that messages were bulk-deleted.
        /// </summary>
        MessageBulkDelete = 73,

        /// <summary>
        /// Indicates that a message was pinned.
        /// </summary>
        MessagePin = 74,

        /// <summary>
        /// Indicates that a message was unpinned.
        /// </summary>
        MessageUnpin = 75,

        /// <summary>
        /// Indicates that an integration was created.
        /// </summary>
        IntegrationCreate = 80,

        /// <summary>
        /// Indicates that an integration was updated.
        /// </summary>
        IntegrationUpdate = 81,

        /// <summary>
        /// Indicates that an integration was deleted.
        /// </summary>
        IntegrationDelete = 82,

        /// <summary>
        /// Indicates that an stage instance was created.
        /// </summary>
        StageInstanceCreate = 83,

        /// <summary>
        /// Indicates that an stage instance was updated.
        /// </summary>
        StageInstanceUpdate = 84,

        /// <summary>
        /// Indicates that an stage instance was deleted.
        /// </summary>
        StageInstanceDelete = 85,

        /// <summary>
        /// Indicates that an sticker was created.
        /// </summary>
        StickerCreate = 90,

        /// <summary>
        /// Indicates that an sticker was updated.
        /// </summary>
        StickerUpdate = 91,

        /// <summary>
        /// Indicates that an sticker was deleted.
        /// </summary>
        StickerDelete = 92,

        /*
        /// <summary>
        /// Indicates that an event was created.
        /// </summary>
        EventCreate = ,

        /// <summary>
        /// Indicates that an event was updated.
        /// </summary>
        EventUpdate = ,

        /// <summary>
        /// Indicates that an event was deleted.
        /// </summary>
        EventDelete = ,

        /// <summary>
        /// Indicates that an thread was created.
        /// </summary>
        ThreadCreate = ,

        /// <summary>
        /// Indicates that an thread was updated.
        /// </summary>
        ThreadUpdate = ,

        /// <summary>
        /// Indicates that an thread was deleted.
        /// </summary>
        ThreadDelete = ,
        */
    }
}