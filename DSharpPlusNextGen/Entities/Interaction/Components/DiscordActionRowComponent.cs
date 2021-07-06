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
using System.Linq;
using DSharpPlusNextGen.Enums;
using Newtonsoft.Json;

namespace DSharpPlusNextGen.Entities
{
    /// <summary>
    /// Represents a row of components. Acion rows can have up to five components.
    /// </summary>
    public sealed class DiscordActionRowComponent : DiscordComponent
    {
        /// <summary>
        /// The components contained within the action row.
        /// </summary>
        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public IReadOnlyCollection<DiscordComponent> Components { get; internal set; }

        /// <summary>
        /// Constructs a new <see cref="DiscordActionRowComponent"/>.
        /// </summary>
        /// <param name="components">List of components</param>
        public DiscordActionRowComponent(IEnumerable<DiscordComponent> components): this()
        {
            this.Components = components.ToList().AsReadOnly();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscordActionRowComponent"/> class.
        /// </summary>
        internal DiscordActionRowComponent()
        {
            this.Type = ComponentType.ActionRow;
        } // For Json.NET
    }
}