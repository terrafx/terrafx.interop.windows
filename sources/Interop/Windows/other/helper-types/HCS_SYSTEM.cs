// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCS_SYSTEM : IEquatable<HCS_SYSTEM>
    {
        public readonly nint Value;

        public HCS_SYSTEM(nint value)
        {
            Value = value;
        }

        public static HCS_SYSTEM INVALID_VALUE => new HCS_SYSTEM(-1);

        public static HCS_SYSTEM NULL => new HCS_SYSTEM(0);

        public static bool operator ==(HCS_SYSTEM left, HCS_SYSTEM right) => left.Value == right.Value;

        public static bool operator !=(HCS_SYSTEM left, HCS_SYSTEM right) => left.Value != right.Value;

        public static explicit operator HCS_SYSTEM(void* value) => new HCS_SYSTEM((nint)(value));

        public static implicit operator void*(HCS_SYSTEM value) => (void*)(value.Value);

        public static explicit operator HCS_SYSTEM(HANDLE value) => new HCS_SYSTEM(value);

        public static implicit operator HANDLE(HCS_SYSTEM value) => new HCS_SYSTEM(value);

        public static explicit operator HCS_SYSTEM(byte value) => new HCS_SYSTEM((nint)(value));

        public static explicit operator byte(HCS_SYSTEM value) => (byte)(value.Value);

        public static explicit operator HCS_SYSTEM(short value) => new HCS_SYSTEM((nint)(value));

        public static explicit operator short(HCS_SYSTEM value) => (short)(value.Value);

        public static explicit operator HCS_SYSTEM(int value) => new HCS_SYSTEM((nint)(value));

        public static explicit operator int(HCS_SYSTEM value) => (int)(value.Value);

        public static explicit operator HCS_SYSTEM(long value) => new HCS_SYSTEM((nint)(value));

        public static implicit operator long(HCS_SYSTEM value) => (long)(value.Value);

        public static explicit operator HCS_SYSTEM(nint value) => new HCS_SYSTEM((nint)(value));

        public static implicit operator nint(HCS_SYSTEM value) => (nint)(value.Value);

        public static explicit operator HCS_SYSTEM(sbyte value) => new HCS_SYSTEM((nint)(value));

        public static explicit operator sbyte(HCS_SYSTEM value) => (sbyte)(value.Value);

        public static explicit operator HCS_SYSTEM(ushort value) => new HCS_SYSTEM((nint)(value));

        public static explicit operator ushort(HCS_SYSTEM value) => (ushort)(value.Value);

        public static explicit operator HCS_SYSTEM(uint value) => new HCS_SYSTEM((nint)(value));

        public static explicit operator uint(HCS_SYSTEM value) => (uint)(value.Value);

        public static explicit operator HCS_SYSTEM(ulong value) => new HCS_SYSTEM((nint)(value));

        public static implicit operator ulong(HCS_SYSTEM value) => (ulong)(value.Value);

        public static explicit operator HCS_SYSTEM(nuint value) => new HCS_SYSTEM((nint)(value));

        public static explicit operator nuint(HCS_SYSTEM value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HCS_SYSTEM other) && Equals(other);

        public bool Equals(HCS_SYSTEM other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
