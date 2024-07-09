// <auto-generated />
using System;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore.TestModels.AspNetIdentity;

#pragma warning disable 219, 612, 618
#nullable disable

namespace Scaffolding
{
    public static class IdentityUserUnsafeAccessors<TKey>
        where TKey : IEquatable<TKey>
    {
        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<Id>k__BackingField")]
        public static extern ref TKey Id(IdentityUser<TKey> @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<AccessFailedCount>k__BackingField")]
        public static extern ref int AccessFailedCount(IdentityUser<TKey> @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<ConcurrencyStamp>k__BackingField")]
        public static extern ref string ConcurrencyStamp(IdentityUser<TKey> @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<Email>k__BackingField")]
        public static extern ref string Email(IdentityUser<TKey> @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<EmailConfirmed>k__BackingField")]
        public static extern ref bool EmailConfirmed(IdentityUser<TKey> @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<LockoutEnabled>k__BackingField")]
        public static extern ref bool LockoutEnabled(IdentityUser<TKey> @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<LockoutEnd>k__BackingField")]
        public static extern ref DateTimeOffset? LockoutEnd(IdentityUser<TKey> @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<NormalizedEmail>k__BackingField")]
        public static extern ref string NormalizedEmail(IdentityUser<TKey> @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<NormalizedUserName>k__BackingField")]
        public static extern ref string NormalizedUserName(IdentityUser<TKey> @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<PasswordHash>k__BackingField")]
        public static extern ref string PasswordHash(IdentityUser<TKey> @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<PhoneNumber>k__BackingField")]
        public static extern ref string PhoneNumber(IdentityUser<TKey> @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<PhoneNumberConfirmed>k__BackingField")]
        public static extern ref bool PhoneNumberConfirmed(IdentityUser<TKey> @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<SecurityStamp>k__BackingField")]
        public static extern ref string SecurityStamp(IdentityUser<TKey> @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<TwoFactorEnabled>k__BackingField")]
        public static extern ref bool TwoFactorEnabled(IdentityUser<TKey> @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<UserName>k__BackingField")]
        public static extern ref string UserName(IdentityUser<TKey> @this);
    }
}
