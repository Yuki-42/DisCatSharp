// This file is part of the DisCatSharp project.
//
// Copyright (c) 2023 AITSYS
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
// FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using DisCatSharp.Lavalink.Enums;

using Newtonsoft.Json;

namespace DisCatSharp.Lavalink.Entities;

/// <summary>
/// Represents a lavalink exception.
/// </summary>
public sealed class LavalinkException
{
	/// <summary>
	/// Gets message of the exception.
	/// </summary>
	[JsonProperty("message")]
	public string? Message { get; internal set; }

	/// <summary>
	/// Gets the severity of the exception
	/// </summary>
	[JsonProperty("severity")]
	public Severity Severity { get; internal set; }

	/// <summary>
	/// Gets the cause of the exception.
	/// </summary>
	[JsonProperty("cause")]
	public string Cause { get; internal set; }
}
