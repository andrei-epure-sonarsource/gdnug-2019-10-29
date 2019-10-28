using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Nullability
{
    internal class Annotations
    {
        public string ScreenName
        {
            get => screenName;
            set => screenName = value ?? "default";
        }

        private string screenName;

        [DisallowNull]
        public string? ReviewComment
        {
            get => _comment;
            set => _comment = value ?? throw new ArgumentNullException(nameof(value), "Cannot set to null");
        }

        private string? _comment;

        [return: MaybeNull]
        public T Find<T>(IEnumerable<T> sequence, Func<T, bool> match)
            => sequence.FirstOrDefault(match);

        [return: NotNull]
        public string Find2<T>(IEnumerable<string> sequence, Func<string, bool> match)
            => sequence.FirstOrDefault(match) ?? "default";

        // NotNullWhen[bool]
        // bool IsNullOrEmpty([NotNullWhen(false)]string? value);
        public int TestIsNullOrEmpty(string? input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                return input.Length; // no null check needed.
            }
            return 0;
        }

        [return: NotNullIfNotNull("url")]
        private string? GetTopLevelDomainFromFullUrl(string? url) =>
            url?.Split(" ").First();
    }
}