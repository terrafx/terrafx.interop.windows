// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct CO_MTA_USAGE_COOKIE : IEquatable<CO_MTA_USAGE_COOKIE>
    {
        public readonly nint Value;

        public CO_MTA_USAGE_COOKIE(nint value)
        {
            Value = ((nint)(value));
        }

        public CO_MTA_USAGE_COOKIE(nuint value)
        {
            Value = ((nint)(value));
        }

        public CO_MTA_USAGE_COOKIE(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(CO_MTA_USAGE_COOKIE left, CO_MTA_USAGE_COOKIE right) => left.Value == right.Value;

        public static bool operator !=(CO_MTA_USAGE_COOKIE left, CO_MTA_USAGE_COOKIE right) => left.Value != right.Value;

        public static explicit operator CO_MTA_USAGE_COOKIE(nint value) => new CO_MTA_USAGE_COOKIE(value);

        public static explicit operator CO_MTA_USAGE_COOKIE(nuint value) => new CO_MTA_USAGE_COOKIE(value);

        public static explicit operator CO_MTA_USAGE_COOKIE(void* value) => new CO_MTA_USAGE_COOKIE(value);

        public static implicit operator nint(CO_MTA_USAGE_COOKIE value) => (nint)(value.Value);

        public static implicit operator nuint(CO_MTA_USAGE_COOKIE value) => (nuint)(value.Value);

        public static implicit operator void*(CO_MTA_USAGE_COOKIE value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is CO_MTA_USAGE_COOKIE other) && Equals(other);

        public bool Equals(CO_MTA_USAGE_COOKIE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
