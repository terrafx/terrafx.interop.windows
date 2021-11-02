// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HADDRESS : IEquatable<HADDRESS>
    {
        public readonly nint Value;

        public HADDRESS(nint value)
        {
            Value = value;
        }

        public static HADDRESS INVALID_HANDLE_VALUE => new HADDRESS(-1);

        public static HADDRESS NULL => new HADDRESS(0);

        public static bool operator ==(HADDRESS left, HADDRESS right) => left.Value == right.Value;

        public static bool operator !=(HADDRESS left, HADDRESS right) => left.Value != right.Value;

        public static explicit operator HADDRESS(void* value) => new HADDRESS((nint)(value));

        public static implicit operator void*(HADDRESS value) => (void*)(value.Value);

        public static explicit operator HADDRESS(HANDLE value) => new HADDRESS(value);

        public static implicit operator HANDLE(HADDRESS value) => new HADDRESS(value);

        public static explicit operator HADDRESS(byte value) => new HADDRESS((nint)(value));

        public static implicit operator byte(HADDRESS value) => (byte)(value.Value);

        public static explicit operator HADDRESS(short value) => new HADDRESS((nint)(value));

        public static implicit operator short(HADDRESS value) => (short)(value.Value);

        public static explicit operator HADDRESS(int value) => new HADDRESS((nint)(value));

        public static implicit operator int(HADDRESS value) => (int)(value.Value);

        public static explicit operator HADDRESS(long value) => new HADDRESS((nint)(value));

        public static explicit operator long(HADDRESS value) => (long)(value.Value);

        public static explicit operator HADDRESS(nint value) => new HADDRESS((nint)(value));

        public static implicit operator nint(HADDRESS value) => (nint)(value.Value);

        public static explicit operator HADDRESS(sbyte value) => new HADDRESS((nint)(value));

        public static implicit operator sbyte(HADDRESS value) => (sbyte)(value.Value);

        public static explicit operator HADDRESS(ushort value) => new HADDRESS((nint)(value));

        public static implicit operator ushort(HADDRESS value) => (ushort)(value.Value);

        public static explicit operator HADDRESS(uint value) => new HADDRESS((nint)(value));

        public static implicit operator uint(HADDRESS value) => (uint)(value.Value);

        public static explicit operator HADDRESS(ulong value) => new HADDRESS((nint)(value));

        public static explicit operator ulong(HADDRESS value) => (ulong)(value.Value);

        public static explicit operator HADDRESS(nuint value) => new HADDRESS((nint)(value));

        public static explicit operator nuint(HADDRESS value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HADDRESS other) && Equals(other);

        public bool Equals(HADDRESS other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
