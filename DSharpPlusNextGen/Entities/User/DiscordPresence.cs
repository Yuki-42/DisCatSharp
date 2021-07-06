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
using DSharpPlusNextGen.Net.Abstractions;
using Newtonsoft.Json;

namespace DSharpPlusNextGen.Entities
{
    /// <summary>
    /// Represents a user presence.
    /// </summary>
    public sealed class DiscordPresence
    {
        /// <summary>
        /// Gets the discord client.
        /// </summary>
        [JsonIgnore]
        internal DiscordClient Discord { get; set; }

        // "The user object within this event can be partial, the only field which must be sent is the id field, everything else is optional."
        /// <summary>
        /// Gets the internal user.
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        internal TransportUser InternalUser { get; set; }

        /// <summary>
        /// Gets the user that owns this presence.
        /// </summary>
        [JsonIgnore]
        public DiscordUser User
            => this.Discord.GetCachedOrEmptyUserInternal(this.InternalUser.Id);

        /// <summary>
        /// Gets the user's current activity.
        /// </summary>
        [JsonIgnore]
        public DiscordActivity Activity { get; internal set; }

        /// <summary>
        /// Gets the raw activity.
        /// </summary>
        internal TransportActivity RawActivity { get; set; }

        /// <summary>
        /// Gets the user's current activities.
        /// </summary>
        [JsonIgnore]
        public IReadOnlyList<DiscordActivity> Activities => this._internalActivities;

        [JsonIgnore]
        internal DiscordActivity[] _internalActivities;

        /// <summary>
        /// Gets the raw activities.
        /// </summary>
        [JsonProperty("activities", NullValueHandling = NullValueHandling.Ignore)]
        internal TransportActivity[] RawActivities { get; set; }

        /// <summary>
        /// Gets this user's status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public UserStatus Status { get; internal set; }

        /// <summary>
        /// Gets the guild id for which this presence was set.
        /// </summary>
        [JsonProperty("guild_id", NullValueHandling = NullValueHandling.Ignore)]
        internal ulong GuildId { get; set; }

        /// <summary>
        /// Gets the guild for which this presence was set.
        /// </summary>
        [JsonIgnore]
        public DiscordGuild Guild
            => this.GuildId != 0 ? this.Discord._guilds[this.GuildId] : null;

        /// <summary>
        /// Gets this user's platform-dependent status.
        /// </summary>
        [JsonProperty("client_status", NullValueHandling = NullValueHandling.Ignore)]
        public DiscordClientStatus ClientStatus { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscordPresence"/> class.
        /// </summary>
        internal DiscordPresence() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscordPresence"/> class.
        /// </summary>
        /// <param name="other">The other.</param>
        internal DiscordPresence(DiscordPresence other)
        {
            this.Discord = other.Discord;
            this.Activity = other.Activity;
            this.RawActivity = other.RawActivity;
            this._internalActivities = (DiscordActivity[])other._internalActivities?.Clone();
            this.RawActivities = (TransportActivity[])other.RawActivities?.Clone();
            this.Status = other.Status;
            this.InternalUser = new TransportUser(other.InternalUser);
        }
    }

    /// <summary>
    /// Represents a client status.
    /// </summary>
    public sealed class DiscordClientStatus
    {
        /// <summary>
        /// Gets the user's status set for an active desktop (Windows, Linux, Mac) application session.
        /// </summary>
        [JsonProperty("desktop", NullValueHandling = NullValueHandling.Ignore)]
        public Optional<UserStatus> Desktop { get; internal set; }

        /// <summary>
        /// Gets the user's status set for an active mobile (iOS, Android) application session.
        /// </summary>
        [JsonProperty("mobile", NullValueHandling = NullValueHandling.Ignore)]
        public Optional<UserStatus> Mobile { get; internal set; }

        /// <summary>
        /// Gets the user's status set for an active web (browser, bot account) application session.
        /// </summary>
        [JsonProperty("web", NullValueHandling = NullValueHandling.Ignore)]
        public Optional<UserStatus> Web { get; internal set; }
    }
}