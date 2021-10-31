// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDRVR : IEquatable<HDRVR>
    {
        public readonly nint Value;

        public HDRVR(int value)
        {
            Value = ((nint)(value));
        }

        public HDRVR(uint value)
        {
            Value = ((nint)(value));
        }

        public HDRVR(nint value)
        {
            Value = ((nint)(value));
        }

        public HDRVR(nuint value)
        {
            Value = ((nint)(value));
        }

        public HDRVR(void* value)
        {
            Value = ((nint)(value));
        }

        public HDRVR(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HDRVR left, HDRVR right) => left.Value == right.Value;

        public static bool operator !=(HDRVR left, HDRVR right) => left.Value != right.Value;

        public static explicit operator HDRVR(int value) => new HDRVR(value);

        public static explicit operator HDRVR(uint value) => new HDRVR(value);

        public static explicit operator HDRVR(nint value) => new HDRVR(value);

        public static explicit operator HDRVR(nuint value) => new HDRVR(value);

        public static explicit operator HDRVR(void* value) => new HDRVR(value);

        public static explicit operator HDRVR(HANDLE value) => new HDRVR(value);

        public static implicit operator int(HDRVR value) => (int)(value.Value);

        public static implicit operator uint(HDRVR value) => (uint)(value.Value);

        public static implicit operator nint(HDRVR value) => (nint)(value.Value);

        public static implicit operator nuint(HDRVR value) => (nuint)(value.Value);

        public static implicit operator void*(HDRVR value) => (void*)(value.Value);

        public static implicit operator HANDLE(HDRVR value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HDRVR other) && Equals(other);

        public bool Equals(HDRVR other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
