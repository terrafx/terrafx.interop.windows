// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HMIDIIN : IEquatable<HMIDIIN>
    {
        public readonly nint Value;

        public HMIDIIN(nint value)
        {
            Value = ((nint)(value));
        }

        public HMIDIIN(nuint value)
        {
            Value = ((nint)(value));
        }

        public HMIDIIN(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HMIDIIN left, HMIDIIN right) => left.Value == right.Value;

        public static bool operator !=(HMIDIIN left, HMIDIIN right) => left.Value != right.Value;

        public static explicit operator HMIDIIN(nint value) => new HMIDIIN(value);

        public static explicit operator HMIDIIN(nuint value) => new HMIDIIN(value);

        public static explicit operator HMIDIIN(void* value) => new HMIDIIN(value);

        public static implicit operator nint(HMIDIIN value) => (nint)(value.Value);

        public static implicit operator nuint(HMIDIIN value) => (nuint)(value.Value);

        public static implicit operator void*(HMIDIIN value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HMIDIIN other) && Equals(other);

        public bool Equals(HMIDIIN other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
