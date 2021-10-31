// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HRGN : IEquatable<HRGN>
    {
        public readonly nint Value;

        public static HRGN NULL => (HRGN)(0);

        public HRGN(int value)
        {
            Value = ((nint)(value));
        }

        public HRGN(uint value)
        {
            Value = ((nint)(value));
        }

        public HRGN(nint value)
        {
            Value = ((nint)(value));
        }

        public HRGN(nuint value)
        {
            Value = ((nint)(value));
        }

        public HRGN(void* value)
        {
            Value = ((nint)(value));
        }

        public HRGN(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HRGN left, HRGN right) => left.Value == right.Value;

        public static bool operator !=(HRGN left, HRGN right) => left.Value != right.Value;

        public static explicit operator HRGN(int value) => new HRGN(value);

        public static explicit operator HRGN(uint value) => new HRGN(value);

        public static explicit operator HRGN(nint value) => new HRGN(value);

        public static explicit operator HRGN(nuint value) => new HRGN(value);

        public static explicit operator HRGN(void* value) => new HRGN(value);

        public static explicit operator HRGN(HANDLE value) => new HRGN(value);

        public static explicit operator int(HRGN value) => (int)(value.Value);

        public static explicit operator uint(HRGN value) => (uint)(value.Value);

        public static implicit operator nint(HRGN value) => (nint)(value.Value);

        public static implicit operator nuint(HRGN value) => (nuint)(value.Value);

        public static implicit operator void*(HRGN value) => (void*)(value.Value);

        public static implicit operator HANDLE(HRGN value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HRGN other) && Equals(other);

        public bool Equals(HRGN other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
