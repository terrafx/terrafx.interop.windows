// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HGDIOBJ : IEquatable<HGDIOBJ>
    {
        public readonly nint Value;

        public static HGDIOBJ NULL => (HGDIOBJ)(0);

        public HGDIOBJ(int value)
        {
            Value = ((nint)(value));
        }

        public HGDIOBJ(uint value)
        {
            Value = ((nint)(value));
        }

        public HGDIOBJ(nint value)
        {
            Value = ((nint)(value));
        }

        public HGDIOBJ(nuint value)
        {
            Value = ((nint)(value));
        }

        public HGDIOBJ(void* value)
        {
            Value = ((nint)(value));
        }

        public HGDIOBJ(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HGDIOBJ left, HGDIOBJ right) => left.Value == right.Value;

        public static bool operator !=(HGDIOBJ left, HGDIOBJ right) => left.Value != right.Value;

        public static explicit operator HGDIOBJ(int value) => new HGDIOBJ(value);

        public static explicit operator HGDIOBJ(uint value) => new HGDIOBJ(value);

        public static explicit operator HGDIOBJ(nint value) => new HGDIOBJ(value);

        public static explicit operator HGDIOBJ(nuint value) => new HGDIOBJ(value);

        public static explicit operator HGDIOBJ(void* value) => new HGDIOBJ(value);

        public static explicit operator HGDIOBJ(HANDLE value) => new HGDIOBJ(value);

        public static implicit operator int(HGDIOBJ value) => (int)(value.Value);

        public static implicit operator uint(HGDIOBJ value) => (uint)(value.Value);

        public static implicit operator nint(HGDIOBJ value) => (nint)(value.Value);

        public static implicit operator nuint(HGDIOBJ value) => (nuint)(value.Value);

        public static implicit operator void*(HGDIOBJ value) => (void*)(value.Value);

        public static implicit operator HANDLE(HGDIOBJ value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HGDIOBJ other) && Equals(other);

        public bool Equals(HGDIOBJ other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
