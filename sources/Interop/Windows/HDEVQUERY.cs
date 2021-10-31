// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDEVQUERY : IEquatable<HDEVQUERY>
    {
        public readonly nint Value;

        public static HDEVQUERY NULL => (HDEVQUERY)(0);

        public HDEVQUERY(int value)
        {
            Value = ((nint)(value));
        }

        public HDEVQUERY(uint value)
        {
            Value = ((nint)(value));
        }

        public HDEVQUERY(nint value)
        {
            Value = ((nint)(value));
        }

        public HDEVQUERY(nuint value)
        {
            Value = ((nint)(value));
        }

        public HDEVQUERY(void* value)
        {
            Value = ((nint)(value));
        }

        public HDEVQUERY(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HDEVQUERY left, HDEVQUERY right) => left.Value == right.Value;

        public static bool operator !=(HDEVQUERY left, HDEVQUERY right) => left.Value != right.Value;

        public static explicit operator HDEVQUERY(int value) => new HDEVQUERY(value);

        public static explicit operator HDEVQUERY(uint value) => new HDEVQUERY(value);

        public static explicit operator HDEVQUERY(nint value) => new HDEVQUERY(value);

        public static explicit operator HDEVQUERY(nuint value) => new HDEVQUERY(value);

        public static explicit operator HDEVQUERY(void* value) => new HDEVQUERY(value);

        public static explicit operator HDEVQUERY(HANDLE value) => new HDEVQUERY(value);

        public static implicit operator int(HDEVQUERY value) => (int)(value.Value);

        public static implicit operator uint(HDEVQUERY value) => (uint)(value.Value);

        public static implicit operator nint(HDEVQUERY value) => (nint)(value.Value);

        public static implicit operator nuint(HDEVQUERY value) => (nuint)(value.Value);

        public static implicit operator void*(HDEVQUERY value) => (void*)(value.Value);

        public static implicit operator HANDLE(HDEVQUERY value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HDEVQUERY other) && Equals(other);

        public bool Equals(HDEVQUERY other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
