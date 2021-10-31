// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HBITMAP : IEquatable<HBITMAP>
    {
        public readonly nint Value;

        public HBITMAP(nint value)
        {
            Value = ((nint)(value));
        }

        public HBITMAP(nuint value)
        {
            Value = ((nint)(value));
        }

        public HBITMAP(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HBITMAP left, HBITMAP right) => left.Value == right.Value;

        public static bool operator !=(HBITMAP left, HBITMAP right) => left.Value != right.Value;

        public static explicit operator HBITMAP(nint value) => new HBITMAP(value);

        public static explicit operator HBITMAP(nuint value) => new HBITMAP(value);

        public static explicit operator HBITMAP(void* value) => new HBITMAP(value);

        public static implicit operator nint(HBITMAP value) => (nint)(value.Value);

        public static implicit operator nuint(HBITMAP value) => (nuint)(value.Value);

        public static implicit operator void*(HBITMAP value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HBITMAP other) && Equals(other);

        public bool Equals(HBITMAP other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
