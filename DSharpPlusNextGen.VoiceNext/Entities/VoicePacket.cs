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

using System;

namespace DSharpPlusNextGen.VoiceNext.Entities
{
    internal struct VoicePacket
    {
        /// <summary>
        /// Gets the bytes.
        /// </summary>
        public ReadOnlyMemory<byte> Bytes { get; }
        /// <summary>
        /// Gets the millisecond duration.
        /// </summary>
        public int MillisecondDuration { get; }
        /// <summary>
        /// Gets or sets a value indicating whether is silence.
        /// </summary>
        public bool IsSilence { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicePacket"/> class.
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        /// <param name="msDuration">The ms duration.</param>
        /// <param name="isSilence">If true, is silence.</param>
        public VoicePacket(ReadOnlyMemory<byte> bytes, int msDuration, bool isSilence = false)
        {
            this.Bytes = bytes;
            this.MillisecondDuration = msDuration;
            this.IsSilence = isSilence;
        }
    }
}