// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PHIDP_PREPARSED_DATA : IEquatable<PHIDP_PREPARSED_DATA>
    {
        public readonly void* Value;

        public PHIDP_PREPARSED_DATA(int value)
        {
            Value = ((void*)(value));
        }

        public PHIDP_PREPARSED_DATA(uint value)
        {
            Value = ((void*)(value));
        }

        public PHIDP_PREPARSED_DATA(nint value)
        {
            Value = ((void*)(value));
        }

        public PHIDP_PREPARSED_DATA(nuint value)
        {
            Value = ((void*)(value));
        }

        public PHIDP_PREPARSED_DATA(void* value)
        {
            Value = ((void*)(value));
        }

        public static bool operator ==(PHIDP_PREPARSED_DATA left, PHIDP_PREPARSED_DATA right) => left.Value == right.Value;

        public static bool operator !=(PHIDP_PREPARSED_DATA left, PHIDP_PREPARSED_DATA right) => left.Value != right.Value;

        public static explicit operator PHIDP_PREPARSED_DATA(int value) => new PHIDP_PREPARSED_DATA(value);

        public static explicit operator PHIDP_PREPARSED_DATA(uint value) => new PHIDP_PREPARSED_DATA(value);

        public static explicit operator PHIDP_PREPARSED_DATA(nint value) => new PHIDP_PREPARSED_DATA(value);

        public static explicit operator PHIDP_PREPARSED_DATA(nuint value) => new PHIDP_PREPARSED_DATA(value);

        public static explicit operator PHIDP_PREPARSED_DATA(void* value) => new PHIDP_PREPARSED_DATA(value);

        public static implicit operator int(PHIDP_PREPARSED_DATA value) => (int)(value.Value);

        public static implicit operator uint(PHIDP_PREPARSED_DATA value) => (uint)(value.Value);

        public static implicit operator nint(PHIDP_PREPARSED_DATA value) => (nint)(value.Value);

        public static implicit operator nuint(PHIDP_PREPARSED_DATA value) => (nuint)(value.Value);

        public static implicit operator void*(PHIDP_PREPARSED_DATA value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is PHIDP_PREPARSED_DATA other) && Equals(other);

        public bool Equals(PHIDP_PREPARSED_DATA other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
