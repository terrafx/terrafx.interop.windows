// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HACMOBJ : IEquatable<HACMOBJ>
    {
        public readonly nint Value;

        public static HACMOBJ NULL => (HACMOBJ)(0);

        public HACMOBJ(int value)
        {
            Value = ((nint)(value));
        }

        public HACMOBJ(uint value)
        {
            Value = ((nint)(value));
        }

        public HACMOBJ(nint value)
        {
            Value = ((nint)(value));
        }

        public HACMOBJ(nuint value)
        {
            Value = ((nint)(value));
        }

        public HACMOBJ(void* value)
        {
            Value = ((nint)(value));
        }

        public HACMOBJ(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HACMOBJ left, HACMOBJ right) => left.Value == right.Value;

        public static bool operator !=(HACMOBJ left, HACMOBJ right) => left.Value != right.Value;

        public static explicit operator HACMOBJ(int value) => new HACMOBJ(value);

        public static explicit operator HACMOBJ(uint value) => new HACMOBJ(value);

        public static explicit operator HACMOBJ(nint value) => new HACMOBJ(value);

        public static explicit operator HACMOBJ(nuint value) => new HACMOBJ(value);

        public static explicit operator HACMOBJ(void* value) => new HACMOBJ(value);

        public static explicit operator HACMOBJ(HANDLE value) => new HACMOBJ(value);

        public static implicit operator int(HACMOBJ value) => (int)(value.Value);

        public static implicit operator uint(HACMOBJ value) => (uint)(value.Value);

        public static implicit operator nint(HACMOBJ value) => (nint)(value.Value);

        public static implicit operator nuint(HACMOBJ value) => (nuint)(value.Value);

        public static implicit operator void*(HACMOBJ value) => (void*)(value.Value);

        public static implicit operator HANDLE(HACMOBJ value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HACMOBJ other) && Equals(other);

        public bool Equals(HACMOBJ other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
