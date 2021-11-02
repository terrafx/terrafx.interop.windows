// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCS_CALLBACK : IEquatable<HCS_CALLBACK>
    {
        public readonly nint Value;

        public HCS_CALLBACK(nint value)
        {
            Value = value;
        }

        public static HCS_CALLBACK INVALID_VALUE => new HCS_CALLBACK(-1);

        public static HCS_CALLBACK NULL => new HCS_CALLBACK(0);

        public static bool operator ==(HCS_CALLBACK left, HCS_CALLBACK right) => left.Value == right.Value;

        public static bool operator !=(HCS_CALLBACK left, HCS_CALLBACK right) => left.Value != right.Value;

        public static explicit operator HCS_CALLBACK(void* value) => new HCS_CALLBACK((nint)(value));

        public static implicit operator void*(HCS_CALLBACK value) => (void*)(value.Value);

        public static explicit operator HCS_CALLBACK(HANDLE value) => new HCS_CALLBACK(value);

        public static implicit operator HANDLE(HCS_CALLBACK value) => new HCS_CALLBACK(value);

        public static explicit operator HCS_CALLBACK(byte value) => new HCS_CALLBACK((nint)(value));

        public static explicit operator byte(HCS_CALLBACK value) => (byte)(value.Value);

        public static explicit operator HCS_CALLBACK(short value) => new HCS_CALLBACK((nint)(value));

        public static explicit operator short(HCS_CALLBACK value) => (short)(value.Value);

        public static explicit operator HCS_CALLBACK(int value) => new HCS_CALLBACK((nint)(value));

        public static explicit operator int(HCS_CALLBACK value) => (int)(value.Value);

        public static explicit operator HCS_CALLBACK(long value) => new HCS_CALLBACK((nint)(value));

        public static implicit operator long(HCS_CALLBACK value) => (long)(value.Value);

        public static explicit operator HCS_CALLBACK(nint value) => new HCS_CALLBACK((nint)(value));

        public static implicit operator nint(HCS_CALLBACK value) => (nint)(value.Value);

        public static explicit operator HCS_CALLBACK(sbyte value) => new HCS_CALLBACK((nint)(value));

        public static explicit operator sbyte(HCS_CALLBACK value) => (sbyte)(value.Value);

        public static explicit operator HCS_CALLBACK(ushort value) => new HCS_CALLBACK((nint)(value));

        public static explicit operator ushort(HCS_CALLBACK value) => (ushort)(value.Value);

        public static explicit operator HCS_CALLBACK(uint value) => new HCS_CALLBACK((nint)(value));

        public static explicit operator uint(HCS_CALLBACK value) => (uint)(value.Value);

        public static explicit operator HCS_CALLBACK(ulong value) => new HCS_CALLBACK((nint)(value));

        public static implicit operator ulong(HCS_CALLBACK value) => (ulong)(value.Value);

        public static explicit operator HCS_CALLBACK(nuint value) => new HCS_CALLBACK((nint)(value));

        public static explicit operator nuint(HCS_CALLBACK value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HCS_CALLBACK other) && Equals(other);

        public bool Equals(HCS_CALLBACK other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
