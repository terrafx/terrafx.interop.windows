// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDRVOBJ : IEquatable<HDRVOBJ>
    {
        public readonly nint Value;

        public static HDRVOBJ NULL => (HDRVOBJ)(0);

        public HDRVOBJ(int value)
        {
            Value = ((nint)(value));
        }

        public HDRVOBJ(uint value)
        {
            Value = ((nint)(value));
        }

        public HDRVOBJ(nint value)
        {
            Value = ((nint)(value));
        }

        public HDRVOBJ(nuint value)
        {
            Value = ((nint)(value));
        }

        public HDRVOBJ(void* value)
        {
            Value = ((nint)(value));
        }

        public HDRVOBJ(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HDRVOBJ left, HDRVOBJ right) => left.Value == right.Value;

        public static bool operator !=(HDRVOBJ left, HDRVOBJ right) => left.Value != right.Value;

        public static explicit operator HDRVOBJ(int value) => new HDRVOBJ(value);

        public static explicit operator HDRVOBJ(uint value) => new HDRVOBJ(value);

        public static explicit operator HDRVOBJ(nint value) => new HDRVOBJ(value);

        public static explicit operator HDRVOBJ(nuint value) => new HDRVOBJ(value);

        public static explicit operator HDRVOBJ(void* value) => new HDRVOBJ(value);

        public static explicit operator HDRVOBJ(HANDLE value) => new HDRVOBJ(value);

        public static explicit operator int(HDRVOBJ value) => (int)(value.Value);

        public static explicit operator uint(HDRVOBJ value) => (uint)(value.Value);

        public static implicit operator nint(HDRVOBJ value) => (nint)(value.Value);

        public static implicit operator nuint(HDRVOBJ value) => (nuint)(value.Value);

        public static implicit operator void*(HDRVOBJ value) => (void*)(value.Value);

        public static implicit operator HANDLE(HDRVOBJ value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HDRVOBJ other) && Equals(other);

        public bool Equals(HDRVOBJ other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
