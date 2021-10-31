// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HMENU : IEquatable<HMENU>
    {
        public readonly nint Value;

        public static HMENU NULL => (HMENU)(0);

        public HMENU(int value)
        {
            Value = ((nint)(value));
        }

        public HMENU(uint value)
        {
            Value = ((nint)(value));
        }

        public HMENU(nint value)
        {
            Value = ((nint)(value));
        }

        public HMENU(nuint value)
        {
            Value = ((nint)(value));
        }

        public HMENU(void* value)
        {
            Value = ((nint)(value));
        }

        public HMENU(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HMENU left, HMENU right) => left.Value == right.Value;

        public static bool operator !=(HMENU left, HMENU right) => left.Value != right.Value;

        public static explicit operator HMENU(int value) => new HMENU(value);

        public static explicit operator HMENU(uint value) => new HMENU(value);

        public static explicit operator HMENU(nint value) => new HMENU(value);

        public static explicit operator HMENU(nuint value) => new HMENU(value);

        public static explicit operator HMENU(void* value) => new HMENU(value);

        public static explicit operator HMENU(HANDLE value) => new HMENU(value);

        public static implicit operator int(HMENU value) => (int)(value.Value);

        public static implicit operator uint(HMENU value) => (uint)(value.Value);

        public static implicit operator nint(HMENU value) => (nint)(value.Value);

        public static implicit operator nuint(HMENU value) => (nuint)(value.Value);

        public static implicit operator void*(HMENU value) => (void*)(value.Value);

        public static implicit operator HANDLE(HMENU value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HMENU other) && Equals(other);

        public bool Equals(HMENU other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
