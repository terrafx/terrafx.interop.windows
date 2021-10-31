// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HPSS : IEquatable<HPSS>
    {
        public readonly nint Value;

        public static HPSS NULL => (HPSS)(0);

        public HPSS(int value)
        {
            Value = ((nint)(value));
        }

        public HPSS(uint value)
        {
            Value = ((nint)(value));
        }

        public HPSS(nint value)
        {
            Value = ((nint)(value));
        }

        public HPSS(nuint value)
        {
            Value = ((nint)(value));
        }

        public HPSS(void* value)
        {
            Value = ((nint)(value));
        }

        public HPSS(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HPSS left, HPSS right) => left.Value == right.Value;

        public static bool operator !=(HPSS left, HPSS right) => left.Value != right.Value;

        public static explicit operator HPSS(int value) => new HPSS(value);

        public static explicit operator HPSS(uint value) => new HPSS(value);

        public static explicit operator HPSS(nint value) => new HPSS(value);

        public static explicit operator HPSS(nuint value) => new HPSS(value);

        public static explicit operator HPSS(void* value) => new HPSS(value);

        public static explicit operator HPSS(HANDLE value) => new HPSS(value);

        public static explicit operator int(HPSS value) => (int)(value.Value);

        public static explicit operator uint(HPSS value) => (uint)(value.Value);

        public static implicit operator nint(HPSS value) => (nint)(value.Value);

        public static implicit operator nuint(HPSS value) => (nuint)(value.Value);

        public static implicit operator void*(HPSS value) => (void*)(value.Value);

        public static implicit operator HANDLE(HPSS value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HPSS other) && Equals(other);

        public bool Equals(HPSS other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
