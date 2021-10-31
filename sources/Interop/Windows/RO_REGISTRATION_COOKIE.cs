// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct RO_REGISTRATION_COOKIE : IEquatable<RO_REGISTRATION_COOKIE>
    {
        public readonly void* Value;

        public RO_REGISTRATION_COOKIE(int value)
        {
            Value = ((void*)(value));
        }

        public RO_REGISTRATION_COOKIE(uint value)
        {
            Value = ((void*)(value));
        }

        public RO_REGISTRATION_COOKIE(nint value)
        {
            Value = ((void*)(value));
        }

        public RO_REGISTRATION_COOKIE(nuint value)
        {
            Value = ((void*)(value));
        }

        public RO_REGISTRATION_COOKIE(void* value)
        {
            Value = ((void*)(value));
        }

        public static bool operator ==(RO_REGISTRATION_COOKIE left, RO_REGISTRATION_COOKIE right) => left.Value == right.Value;

        public static bool operator !=(RO_REGISTRATION_COOKIE left, RO_REGISTRATION_COOKIE right) => left.Value != right.Value;

        public static explicit operator RO_REGISTRATION_COOKIE(int value) => new RO_REGISTRATION_COOKIE(value);

        public static explicit operator RO_REGISTRATION_COOKIE(uint value) => new RO_REGISTRATION_COOKIE(value);

        public static explicit operator RO_REGISTRATION_COOKIE(nint value) => new RO_REGISTRATION_COOKIE(value);

        public static explicit operator RO_REGISTRATION_COOKIE(nuint value) => new RO_REGISTRATION_COOKIE(value);

        public static explicit operator RO_REGISTRATION_COOKIE(void* value) => new RO_REGISTRATION_COOKIE(value);

        public static explicit operator int(RO_REGISTRATION_COOKIE value) => (int)(value.Value);

        public static explicit operator uint(RO_REGISTRATION_COOKIE value) => (uint)(value.Value);

        public static implicit operator nint(RO_REGISTRATION_COOKIE value) => (nint)(value.Value);

        public static implicit operator nuint(RO_REGISTRATION_COOKIE value) => (nuint)(value.Value);

        public static implicit operator void*(RO_REGISTRATION_COOKIE value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is RO_REGISTRATION_COOKIE other) && Equals(other);

        public bool Equals(RO_REGISTRATION_COOKIE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
