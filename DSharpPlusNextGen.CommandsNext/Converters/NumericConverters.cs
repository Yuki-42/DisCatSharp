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

using System.Globalization;
using System.Threading.Tasks;
using DSharpPlusNextGen.Entities;

namespace DSharpPlusNextGen.CommandsNext.Converters
{
    /// <summary>
    /// The bool converter.
    /// </summary>
    public class BoolConverter : IArgumentConverter<bool>
    {
        /// <summary>
        /// Converts a string.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <param name="ctx">The command context.</param>
        Task<Optional<bool>> IArgumentConverter<bool>.ConvertAsync(string value, CommandContext ctx)
        {
            return bool.TryParse(value, out var result)
                ? Task.FromResult(Optional.FromValue(result))
                : Task.FromResult(Optional.FromNoValue<bool>());
        }
    }

    /// <summary>
    /// The int8 converter.
    /// </summary>
    public class Int8Converter : IArgumentConverter<sbyte>
    {
        /// <summary>
        /// Converts a string.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <param name="ctx">The command context.</param>
        Task<Optional<sbyte>> IArgumentConverter<sbyte>.ConvertAsync(string value, CommandContext ctx)
        {
            return sbyte.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var result)
                ? Task.FromResult(Optional.FromValue(result))
                : Task.FromResult(Optional.FromNoValue<sbyte>());
        }
    }

    /// <summary>
    /// The uint8 converter.
    /// </summary>
    public class Uint8Converter : IArgumentConverter<byte>
    {
        /// <summary>
        /// Converts a string.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <param name="ctx">The command context.</param>
        Task<Optional<byte>> IArgumentConverter<byte>.ConvertAsync(string value, CommandContext ctx)
        {
            return byte.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var result)
                ? Task.FromResult(Optional.FromValue(result))
                : Task.FromResult(Optional.FromNoValue<byte>());
        }
    }

    /// <summary>
    /// The int16 converter.
    /// </summary>
    public class Int16Converter : IArgumentConverter<short>
    {
        /// <summary>
        /// Converts a string.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <param name="ctx">The command context.</param>
        Task<Optional<short>> IArgumentConverter<short>.ConvertAsync(string value, CommandContext ctx)
        {
            return short.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var result)
                ? Task.FromResult(Optional.FromValue(result))
                : Task.FromResult(Optional.FromNoValue<short>());
        }
    }

    /// <summary>
    /// The uint16 converter.
    /// </summary>
    public class Uint16Converter : IArgumentConverter<ushort>
    {
        /// <summary>
        /// Converts a string.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <param name="ctx">The command context.</param>
        Task<Optional<ushort>> IArgumentConverter<ushort>.ConvertAsync(string value, CommandContext ctx)
        {
            return ushort.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var result)
                ? Task.FromResult(Optional.FromValue(result))
                : Task.FromResult(Optional.FromNoValue<ushort>());
        }
    }

    /// <summary>
    /// The int32 converter.
    /// </summary>
    public class Int32Converter : IArgumentConverter<int>
    {
        /// <summary>
        /// Converts a string.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <param name="ctx">The command context.</param>
        Task<Optional<int>> IArgumentConverter<int>.ConvertAsync(string value, CommandContext ctx)
        {
            return int.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var result)
                ? Task.FromResult(Optional.FromValue(result))
                : Task.FromResult(Optional.FromNoValue<int>());
        }
    }

    /// <summary>
    /// The uint32 converter.
    /// </summary>
    public class Uint32Converter : IArgumentConverter<uint>
    {
        /// <summary>
        /// Converts a string.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <param name="ctx">The command context.</param>
        Task<Optional<uint>> IArgumentConverter<uint>.ConvertAsync(string value, CommandContext ctx)
        {
            return uint.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var result)
                ? Task.FromResult(Optional.FromValue(result))
                : Task.FromResult(Optional.FromNoValue<uint>());
        }
    }

    /// <summary>
    /// The int64 converter.
    /// </summary>
    public class Int64Converter : IArgumentConverter<long>
    {
        /// <summary>
        /// Converts a string.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <param name="ctx">The command context.</param>
        Task<Optional<long>> IArgumentConverter<long>.ConvertAsync(string value, CommandContext ctx)
        {
            return long.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var result)
                ? Task.FromResult(Optional.FromValue(result))
                : Task.FromResult(Optional.FromNoValue<long>());
        }
    }

    /// <summary>
    /// The uint64 converter.
    /// </summary>
    public class Uint64Converter : IArgumentConverter<ulong>
    {
        /// <summary>
        /// Converts a string.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <param name="ctx">The command context.</param>
        Task<Optional<ulong>> IArgumentConverter<ulong>.ConvertAsync(string value, CommandContext ctx)
        {
            return ulong.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var result)
                ? Task.FromResult(Optional.FromValue(result))
                : Task.FromResult(Optional.FromNoValue<ulong>());
        }
    }

    /// <summary>
    /// The float32 converter.
    /// </summary>
    public class Float32Converter : IArgumentConverter<float>
    {
        /// <summary>
        /// Converts a string.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <param name="ctx">The command context.</param>
        Task<Optional<float>> IArgumentConverter<float>.ConvertAsync(string value, CommandContext ctx)
        {
            return float.TryParse(value, NumberStyles.Number, CultureInfo.InvariantCulture, out var result)
                ? Task.FromResult(Optional.FromValue(result))
                : Task.FromResult(Optional.FromNoValue<float>());
        }
    }

    /// <summary>
    /// The float64 converter.
    /// </summary>
    public class Float64Converter : IArgumentConverter<double>
    {
        /// <summary>
        /// Converts a string.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <param name="ctx">The command context.</param>
        Task<Optional<double>> IArgumentConverter<double>.ConvertAsync(string value, CommandContext ctx)
        {
            return double.TryParse(value, NumberStyles.Number, CultureInfo.InvariantCulture, out var result)
                ? Task.FromResult(Optional.FromValue(result))
                : Task.FromResult(Optional.FromNoValue<double>());
        }
    }

    /// <summary>
    /// The float128 converter.
    /// </summary>
    public class Float128Converter : IArgumentConverter<decimal>
    {
        /// <summary>
        /// Converts a string.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <param name="ctx">The command context.</param>
        Task<Optional<decimal>> IArgumentConverter<decimal>.ConvertAsync(string value, CommandContext ctx)
        {
            return decimal.TryParse(value, NumberStyles.Number, CultureInfo.InvariantCulture, out var result)
                ? Task.FromResult(Optional.FromValue(result))
                : Task.FromResult(Optional.FromNoValue<decimal>());
        }
    }
}