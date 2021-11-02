// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PTP_POOL : IEquatable<PTP_POOL>
    {
        public readonly nint Value;

        public PTP_POOL(nint value)
        {
            Value = value;
        }

        public static PTP_POOL NULL => new PTP_POOL(0);

        public static bool operator ==(PTP_POOL left, PTP_POOL right) => left.Value == right.Value;

        public static bool operator !=(PTP_POOL left, PTP_POOL right) => left.Value != right.Value;

        public static explicit operator PTP_POOL(void* value) => new PTP_POOL((nint)(value));

        public static implicit operator void*(PTP_POOL value) => (void*)(value.Value);

        public static explicit operator PTP_POOL(byte value) => new PTP_POOL((nint)(value));

        public static explicit operator byte(PTP_POOL value) => (byte)(value.Value);

        public static explicit operator PTP_POOL(short value) => new PTP_POOL((nint)(value));

        public static explicit operator short(PTP_POOL value) => (short)(value.Value);

        public static explicit operator PTP_POOL(int value) => new PTP_POOL((nint)(value));

        public static explicit operator int(PTP_POOL value) => (int)(value.Value);

        public static explicit operator PTP_POOL(long value) => new PTP_POOL((nint)(value));

        public static implicit operator long(PTP_POOL value) => (long)(value.Value);

        public static explicit operator PTP_POOL(nint value) => new PTP_POOL((nint)(value));

        public static implicit operator nint(PTP_POOL value) => (nint)(value.Value);

        public static explicit operator PTP_POOL(sbyte value) => new PTP_POOL((nint)(value));

        public static explicit operator sbyte(PTP_POOL value) => (sbyte)(value.Value);

        public static explicit operator PTP_POOL(ushort value) => new PTP_POOL((nint)(value));

        public static explicit operator ushort(PTP_POOL value) => (ushort)(value.Value);

        public static explicit operator PTP_POOL(uint value) => new PTP_POOL((nint)(value));

        public static explicit operator uint(PTP_POOL value) => (uint)(value.Value);

        public static explicit operator PTP_POOL(ulong value) => new PTP_POOL((nint)(value));

        public static explicit operator ulong(PTP_POOL value) => (ulong)(value.Value);

        public static explicit operator PTP_POOL(nuint value) => new PTP_POOL((nint)(value));

        public static explicit operator nuint(PTP_POOL value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is PTP_POOL other) && Equals(other);

        public bool Equals(PTP_POOL other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
