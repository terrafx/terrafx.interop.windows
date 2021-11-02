// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HINF : IEquatable<HINF>
    {
        public readonly nint Value;

        public HINF(nint value)
        {
            Value = value;
        }

        public static HINF INVALID_VALUE => new HINF(-1);

        public static HINF NULL => new HINF(0);

        public static bool operator ==(HINF left, HINF right) => left.Value == right.Value;

        public static bool operator !=(HINF left, HINF right) => left.Value != right.Value;

        public static explicit operator HINF(void* value) => new HINF((nint)(value));

        public static implicit operator void*(HINF value) => (void*)(value.Value);

        public static explicit operator HINF(HANDLE value) => new HINF(value);

        public static implicit operator HANDLE(HINF value) => new HANDLE(value.Value);

        public static explicit operator HINF(byte value) => new HINF((nint)(value));

        public static explicit operator byte(HINF value) => (byte)(value.Value);

        public static explicit operator HINF(short value) => new HINF((nint)(value));

        public static explicit operator short(HINF value) => (short)(value.Value);

        public static explicit operator HINF(int value) => new HINF((nint)(value));

        public static explicit operator int(HINF value) => (int)(value.Value);

        public static explicit operator HINF(long value) => new HINF((nint)(value));

        public static implicit operator long(HINF value) => (long)(value.Value);

        public static explicit operator HINF(nint value) => new HINF((nint)(value));

        public static implicit operator nint(HINF value) => (nint)(value.Value);

        public static explicit operator HINF(sbyte value) => new HINF((nint)(value));

        public static explicit operator sbyte(HINF value) => (sbyte)(value.Value);

        public static explicit operator HINF(ushort value) => new HINF((nint)(value));

        public static explicit operator ushort(HINF value) => (ushort)(value.Value);

        public static explicit operator HINF(uint value) => new HINF((nint)(value));

        public static explicit operator uint(HINF value) => (uint)(value.Value);

        public static explicit operator HINF(ulong value) => new HINF((nint)(value));

        public static explicit operator ulong(HINF value) => (ulong)(value.Value);

        public static explicit operator HINF(nuint value) => new HINF((nint)(value));

        public static explicit operator nuint(HINF value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HINF other) && Equals(other);

        public bool Equals(HINF other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
