// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HADDRESS : IEquatable<HADDRESS>
    {
        public readonly nint Value;

        public HADDRESS(int value)
        {
            Value = ((nint)(value));
        }

        public HADDRESS(uint value)
        {
            Value = ((nint)(value));
        }

        public HADDRESS(nint value)
        {
            Value = ((nint)(value));
        }

        public HADDRESS(nuint value)
        {
            Value = ((nint)(value));
        }

        public HADDRESS(void* value)
        {
            Value = ((nint)(value));
        }

        public HADDRESS(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HADDRESS left, HADDRESS right) => left.Value == right.Value;

        public static bool operator !=(HADDRESS left, HADDRESS right) => left.Value != right.Value;

        public static explicit operator HADDRESS(int value) => new HADDRESS(value);

        public static explicit operator HADDRESS(uint value) => new HADDRESS(value);

        public static explicit operator HADDRESS(nint value) => new HADDRESS(value);

        public static explicit operator HADDRESS(nuint value) => new HADDRESS(value);

        public static explicit operator HADDRESS(void* value) => new HADDRESS(value);

        public static explicit operator HADDRESS(HANDLE value) => new HADDRESS(value);

        public static implicit operator int(HADDRESS value) => (int)(value.Value);

        public static implicit operator uint(HADDRESS value) => (uint)(value.Value);

        public static implicit operator nint(HADDRESS value) => (nint)(value.Value);

        public static implicit operator nuint(HADDRESS value) => (nuint)(value.Value);

        public static implicit operator void*(HADDRESS value) => (void*)(value.Value);

        public static implicit operator HANDLE(HADDRESS value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HADDRESS other) && Equals(other);

        public bool Equals(HADDRESS other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
