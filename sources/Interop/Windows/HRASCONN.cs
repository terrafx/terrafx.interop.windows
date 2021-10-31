// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HRASCONN : IEquatable<HRASCONN>
    {
        public readonly nint Value;

        public HRASCONN(int value)
        {
            Value = ((nint)(value));
        }

        public HRASCONN(uint value)
        {
            Value = ((nint)(value));
        }

        public HRASCONN(nint value)
        {
            Value = ((nint)(value));
        }

        public HRASCONN(nuint value)
        {
            Value = ((nint)(value));
        }

        public HRASCONN(void* value)
        {
            Value = ((nint)(value));
        }

        public HRASCONN(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HRASCONN left, HRASCONN right) => left.Value == right.Value;

        public static bool operator !=(HRASCONN left, HRASCONN right) => left.Value != right.Value;

        public static explicit operator HRASCONN(int value) => new HRASCONN(value);

        public static explicit operator HRASCONN(uint value) => new HRASCONN(value);

        public static explicit operator HRASCONN(nint value) => new HRASCONN(value);

        public static explicit operator HRASCONN(nuint value) => new HRASCONN(value);

        public static explicit operator HRASCONN(void* value) => new HRASCONN(value);

        public static explicit operator HRASCONN(HANDLE value) => new HRASCONN(value);

        public static implicit operator int(HRASCONN value) => (int)(value.Value);

        public static implicit operator uint(HRASCONN value) => (uint)(value.Value);

        public static implicit operator nint(HRASCONN value) => (nint)(value.Value);

        public static implicit operator nuint(HRASCONN value) => (nuint)(value.Value);

        public static implicit operator void*(HRASCONN value) => (void*)(value.Value);

        public static implicit operator HANDLE(HRASCONN value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HRASCONN other) && Equals(other);

        public bool Equals(HRASCONN other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
