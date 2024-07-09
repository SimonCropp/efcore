// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Text;

namespace Microsoft.EntityFrameworkCore.Infrastructure;

/// <summary>
///     Provides methods for manipulating string identifiers.
/// </summary>
/// <remarks>
///     See <see href="https://aka.ms/efcore-docs-providers">Implementation of database providers and extensions</see>
///     for more information and examples.
/// </remarks>
public static class Uniquifier
{
    /// <summary>
    ///     Creates a unique identifier by appending a number to the given string.
    /// </summary>
    /// <typeparam name="T">The type of the object the identifier maps to.</typeparam>
    /// <param name="currentIdentifier">The base identifier.</param>
    /// <param name="otherIdentifiers">A dictionary where the identifier will be used as a key.</param>
    /// <param name="maxLength">The maximum length of the identifier.</param>
    /// <returns>A unique identifier.</returns>
    public static string Uniquify<T>(
        string currentIdentifier,
        IReadOnlyDictionary<string, T> otherIdentifiers,
        int maxLength)
        => Uniquify(currentIdentifier, otherIdentifiers, s => s, maxLength);

    /// <summary>
    ///     Creates a unique identifier by appending a number to the given string.
    /// </summary>
    /// <typeparam name="T">The type of the object the identifier maps to.</typeparam>
    /// <param name="currentIdentifier">The base identifier.</param>
    /// <param name="otherIdentifiers">A dictionary where the identifier will be used as a key.</param>
    /// <param name="suffix">An optional suffix to add after the uniquifier.</param>
    /// <param name="maxLength">The maximum length of the identifier.</param>
    /// <returns>A unique identifier.</returns>
    public static string Uniquify<T>(
        string currentIdentifier,
        IReadOnlyDictionary<string, T> otherIdentifiers,
        string? suffix,
        int maxLength)
        => Uniquify(currentIdentifier, otherIdentifiers, s => s, suffix, maxLength);

    /// <summary>
    ///     Creates a unique identifier by appending a number to the given string.
    /// </summary>
    /// <typeparam name="TKey">The type of the key that contains the identifier.</typeparam>
    /// <typeparam name="TValue">The type of the object the identifier maps to.</typeparam>
    /// <param name="currentIdentifier">The base identifier.</param>
    /// <param name="otherIdentifiers">A dictionary where the identifier will be used as part of the key.</param>
    /// <param name="keySelector">Creates the key object from an identifier.</param>
    /// <param name="maxLength">The maximum length of the identifier.</param>
    /// <returns>A unique identifier.</returns>
    public static string Uniquify<TKey, TValue>(
        string currentIdentifier,
        IReadOnlyDictionary<TKey, TValue> otherIdentifiers,
        Func<string, TKey> keySelector,
        int maxLength)
        => Uniquify(currentIdentifier, otherIdentifiers, keySelector, suffix: null, maxLength);

    /// <summary>
    ///     Creates a unique identifier by appending a number to the given string.
    /// </summary>
    /// <typeparam name="TKey">The type of the key that contains the identifier.</typeparam>
    /// <typeparam name="TValue">The type of the object the identifier maps to.</typeparam>
    /// <param name="currentIdentifier">The base identifier.</param>
    /// <param name="otherIdentifiers">A dictionary where the identifier will be used as part of the key.</param>
    /// <param name="suffix">An optional suffix to add after the uniquifier.</param>
    /// <param name="keySelector">Creates the key object from an identifier.</param>
    /// <param name="maxLength">The maximum length of the identifier.</param>
    /// <returns>A unique identifier.</returns>
    public static string Uniquify<TKey, TValue>(
        string currentIdentifier,
        IReadOnlyDictionary<TKey, TValue> otherIdentifiers,
        Func<string, TKey> keySelector,
        string? suffix,
        int maxLength)
    {
        var finalIdentifier = Truncate(currentIdentifier, maxLength, suffix);
        var uniquifier = 1;
        while (otherIdentifiers.ContainsKey(keySelector(finalIdentifier)))
        {
            finalIdentifier = Truncate(currentIdentifier, maxLength, suffix, uniquifier++);
        }

        return finalIdentifier;
    }

    /// <summary>
    ///     Creates a unique identifier by appending a number to the given string.
    /// </summary>
    /// <param name="currentIdentifier">The base identifier.</param>
    /// <param name="otherIdentifiers">A dictionary where the identifier will be used as part of the key.</param>
    /// <param name="suffix">An optional suffix to add after the uniquifier.</param>
    /// <param name="maxLength">The maximum length of the identifier.</param>
    /// <returns>A unique identifier.</returns>
    public static string Uniquify(
        string currentIdentifier,
        ISet<string> otherIdentifiers,
        string? suffix,
        int maxLength)
    {
        var finalIdentifier = Truncate(currentIdentifier, maxLength, suffix);
        var uniquifier = 1;
        while (otherIdentifiers.Contains(finalIdentifier))
        {
            finalIdentifier = Truncate(currentIdentifier, maxLength, suffix, uniquifier++);
        }

        return finalIdentifier;
    }

    /// <summary>
    ///     Ensures the given identifier is shorter than the given length by removing the extra characters from the end.
    /// </summary>
    /// <param name="identifier">The identifier to shorten.</param>
    /// <param name="maxLength">The maximum length of the identifier.</param>
    /// <param name="uniquifier">An optional number that will be appended to the identifier.</param>
    /// <returns>The shortened identifier.</returns>
    public static string Truncate(string identifier, int maxLength, int? uniquifier = null)
        => Truncate(identifier, maxLength, null, uniquifier);

    /// <summary>
    ///     Ensures the given identifier is shorter than the given length by removing the extra characters from the end.
    /// </summary>
    /// <param name="identifier">The identifier to shorten.</param>
    /// <param name="maxLength">The maximum length of the identifier.</param>
    /// <param name="suffix">An optional suffix to add after the uniquifier.</param>
    /// <param name="uniquifier">An optional number that will be appended to the identifier.</param>
    /// <returns>The shortened identifier.</returns>
    public static string Truncate(string identifier, int maxLength, string? suffix, int? uniquifier = null)
    {
        var uniquifierLength = GetLength(uniquifier) + (suffix?.Length ?? 0);
        var maxNameLength = maxLength - uniquifierLength;
        if (maxNameLength <= 0)
        {
            throw new ArgumentException(nameof(maxLength));
        }

        var builder = new StringBuilder();
        if (identifier.Length <= maxNameLength)
        {
            builder.Append(identifier);
        }
        else
        {
            builder.Append(identifier, 0, maxNameLength - 1);
            builder.Append('~');
        }

        if (uniquifier != null)
        {
            builder.Append(uniquifier.Value);
        }

        builder.Append(suffix);

        return builder.ToString();
    }

    private static int GetLength(int? number)
    {
        if (number == null)
        {
            return 0;
        }

        var length = 0;
        do
        {
            number /= 10;
            length++;
        }
        while (number.Value >= 1);

        return length;
    }
}
