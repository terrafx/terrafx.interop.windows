// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCS_OPERATION : IEquatable<HCS_OPERATION>
    {
        public readonly nint Value;

        public HCS_OPERATION(nint value)
        {
            Value = value;
        }

        public static HCS_OPERATION INVALID_VALUE => new HCS_OPERATION(-1);

        public static HCS_OPERATION NULL => new HCS_OPERATION(0);

        public static bool operator ==(HCS_OPERATION left, HCS_OPERATION right) => left.Value == right.Value;

        public static bool operator !=(HCS_OPERATION left, HCS_OPERATION right) => left.Value != right.Value;

        public static explicit operator HCS_OPERATION(void* value) => new HCS_OPERATION((nint)(value));

        public static implicit operator void*(HCS_OPERATION value) => (void*)(value.Value);

        public static explicit operator HCS_OPERATION(HANDLE value) => new HCS_OPERATION(value);

        public static implicit operator HANDLE(HCS_OPERATION value) => new HANDLE(value.Value);

        public static explicit operator HCS_OPERATION(byte value) => new HCS_OPERATION((nint)(value));

        public static explicit operator byte(HCS_OPERATION value) => (byte)(value.Value);

        public static explicit operator HCS_OPERATION(short value) => new HCS_OPERATION((nint)(value));

        public static explicit operator short(HCS_OPERATION value) => (short)(value.Value);

        public static explicit operator HCS_OPERATION(int value) => new HCS_OPERATION((nint)(value));

        public static explicit operator int(HCS_OPERATION value) => (int)(value.Value);

        public static explicit operator HCS_OPERATION(long value) => new HCS_OPERATION((nint)(value));

        public static implicit operator long(HCS_OPERATION value) => (long)(value.Value);

        public static explicit operator HCS_OPERATION(nint value) => new HCS_OPERATION((nint)(value));

        public static implicit operator nint(HCS_OPERATION value) => (nint)(value.Value);

        public static explicit operator HCS_OPERATION(sbyte value) => new HCS_OPERATION((nint)(value));

        public static explicit operator sbyte(HCS_OPERATION value) => (sbyte)(value.Value);

        public static explicit operator HCS_OPERATION(ushort value) => new HCS_OPERATION((nint)(value));

        public static explicit operator ushort(HCS_OPERATION value) => (ushort)(value.Value);

        public static explicit operator HCS_OPERATION(uint value) => new HCS_OPERATION((nint)(value));

        public static explicit operator uint(HCS_OPERATION value) => (uint)(value.Value);

        public static explicit operator HCS_OPERATION(ulong value) => new HCS_OPERATION((nint)(value));

        public static explicit operator ulong(HCS_OPERATION value) => (ulong)(value.Value);

        public static explicit operator HCS_OPERATION(nuint value) => new HCS_OPERATION((nint)(value));

        public static explicit operator nuint(HCS_OPERATION value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HCS_OPERATION other) && Equals(other);

        public bool Equals(HCS_OPERATION other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
