// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSPRITE : IEquatable<HSPRITE>
    {
        public readonly nint Value;

        public HSPRITE(nint value)
        {
            Value = ((nint)(value));
        }

        public HSPRITE(nuint value)
        {
            Value = ((nint)(value));
        }

        public HSPRITE(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HSPRITE left, HSPRITE right) => left.Value == right.Value;

        public static bool operator !=(HSPRITE left, HSPRITE right) => left.Value != right.Value;

        public static explicit operator HSPRITE(nint value) => new HSPRITE(value);

        public static explicit operator HSPRITE(nuint value) => new HSPRITE(value);

        public static explicit operator HSPRITE(void* value) => new HSPRITE(value);

        public static implicit operator nint(HSPRITE value) => (nint)(value.Value);

        public static implicit operator nuint(HSPRITE value) => (nuint)(value.Value);

        public static implicit operator void*(HSPRITE value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HSPRITE other) && Equals(other);

        public bool Equals(HSPRITE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
