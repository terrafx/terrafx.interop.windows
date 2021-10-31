// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HPSSWALK : IEquatable<HPSSWALK>
    {
        public readonly nint Value;

        public static HPSSWALK NULL => (HPSSWALK)(0);

        public HPSSWALK(int value)
        {
            Value = ((nint)(value));
        }

        public HPSSWALK(uint value)
        {
            Value = ((nint)(value));
        }

        public HPSSWALK(nint value)
        {
            Value = ((nint)(value));
        }

        public HPSSWALK(nuint value)
        {
            Value = ((nint)(value));
        }

        public HPSSWALK(void* value)
        {
            Value = ((nint)(value));
        }

        public HPSSWALK(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HPSSWALK left, HPSSWALK right) => left.Value == right.Value;

        public static bool operator !=(HPSSWALK left, HPSSWALK right) => left.Value != right.Value;

        public static explicit operator HPSSWALK(int value) => new HPSSWALK(value);

        public static explicit operator HPSSWALK(uint value) => new HPSSWALK(value);

        public static explicit operator HPSSWALK(nint value) => new HPSSWALK(value);

        public static explicit operator HPSSWALK(nuint value) => new HPSSWALK(value);

        public static explicit operator HPSSWALK(void* value) => new HPSSWALK(value);

        public static explicit operator HPSSWALK(HANDLE value) => new HPSSWALK(value);

        public static explicit operator int(HPSSWALK value) => (int)(value.Value);

        public static explicit operator uint(HPSSWALK value) => (uint)(value.Value);

        public static implicit operator nint(HPSSWALK value) => (nint)(value.Value);

        public static implicit operator nuint(HPSSWALK value) => (nuint)(value.Value);

        public static implicit operator void*(HPSSWALK value) => (void*)(value.Value);

        public static implicit operator HANDLE(HPSSWALK value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HPSSWALK other) && Equals(other);

        public bool Equals(HPSSWALK other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
