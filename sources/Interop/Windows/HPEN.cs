// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HPEN : IEquatable<HPEN>
    {
        public readonly nint Value;

        public HPEN(nint value)
        {
            Value = ((nint)(value));
        }

        public HPEN(nuint value)
        {
            Value = ((nint)(value));
        }

        public HPEN(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HPEN left, HPEN right) => left.Value == right.Value;

        public static bool operator !=(HPEN left, HPEN right) => left.Value != right.Value;

        public static explicit operator HPEN(nint value) => new HPEN(value);

        public static explicit operator HPEN(nuint value) => new HPEN(value);

        public static explicit operator HPEN(void* value) => new HPEN(value);

        public static implicit operator nint(HPEN value) => (nint)(value.Value);

        public static implicit operator nuint(HPEN value) => (nuint)(value.Value);

        public static implicit operator void*(HPEN value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HPEN other) && Equals(other);

        public bool Equals(HPEN other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
