// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct InstanceHandle : IEquatable<InstanceHandle>
    {
        public readonly ulong Value;

        public InstanceHandle(ulong value)
        {
            Value = value;
        }

        public static bool operator ==(InstanceHandle left, InstanceHandle right) => left.Value == right.Value;

        public static bool operator !=(InstanceHandle left, InstanceHandle right) => left.Value != right.Value;

        public static explicit operator InstanceHandle(byte value) => new InstanceHandle((ulong)(value));

        public static implicit operator byte(InstanceHandle value) => (byte)(value.Value);

        public static explicit operator InstanceHandle(short value) => new InstanceHandle((ulong)(value));

        public static implicit operator short(InstanceHandle value) => (short)(value.Value);

        public static explicit operator InstanceHandle(int value) => new InstanceHandle((ulong)(value));

        public static implicit operator int(InstanceHandle value) => (int)(value.Value);

        public static explicit operator InstanceHandle(long value) => new InstanceHandle((ulong)(value));

        public static explicit operator long(InstanceHandle value) => (long)(value.Value);

        public static explicit operator InstanceHandle(nint value) => new InstanceHandle((ulong)(value));

        public static implicit operator nint(InstanceHandle value) => (nint)(value.Value);

        public static explicit operator InstanceHandle(sbyte value) => new InstanceHandle((ulong)(value));

        public static implicit operator sbyte(InstanceHandle value) => (sbyte)(value.Value);

        public static explicit operator InstanceHandle(ushort value) => new InstanceHandle((ulong)(value));

        public static implicit operator ushort(InstanceHandle value) => (ushort)(value.Value);

        public static explicit operator InstanceHandle(uint value) => new InstanceHandle((ulong)(value));

        public static implicit operator uint(InstanceHandle value) => (uint)(value.Value);

        public static implicit operator InstanceHandle(ulong value) => new InstanceHandle((ulong)(value));

        public static implicit operator ulong(InstanceHandle value) => (ulong)(value.Value);

        public static explicit operator InstanceHandle(nuint value) => new InstanceHandle((ulong)(value));

        public static implicit operator nuint(InstanceHandle value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is InstanceHandle other) && Equals(other);

        public bool Equals(InstanceHandle other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
