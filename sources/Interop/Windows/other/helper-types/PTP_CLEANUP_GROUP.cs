// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PTP_CLEANUP_GROUP : IEquatable<PTP_CLEANUP_GROUP>
    {
        public readonly nint Value;

        public PTP_CLEANUP_GROUP(nint value)
        {
            Value = value;
        }

        public static PTP_CLEANUP_GROUP NULL => new PTP_CLEANUP_GROUP(0);

        public static bool operator ==(PTP_CLEANUP_GROUP left, PTP_CLEANUP_GROUP right) => left.Value == right.Value;

        public static bool operator !=(PTP_CLEANUP_GROUP left, PTP_CLEANUP_GROUP right) => left.Value != right.Value;

        public static explicit operator PTP_CLEANUP_GROUP(void* value) => new PTP_CLEANUP_GROUP((nint)(value));

        public static implicit operator void*(PTP_CLEANUP_GROUP value) => (void*)(value.Value);

        public static explicit operator PTP_CLEANUP_GROUP(byte value) => new PTP_CLEANUP_GROUP((nint)(value));

        public static explicit operator byte(PTP_CLEANUP_GROUP value) => (byte)(value.Value);

        public static explicit operator PTP_CLEANUP_GROUP(short value) => new PTP_CLEANUP_GROUP((nint)(value));

        public static explicit operator short(PTP_CLEANUP_GROUP value) => (short)(value.Value);

        public static explicit operator PTP_CLEANUP_GROUP(int value) => new PTP_CLEANUP_GROUP((nint)(value));

        public static explicit operator int(PTP_CLEANUP_GROUP value) => (int)(value.Value);

        public static explicit operator PTP_CLEANUP_GROUP(long value) => new PTP_CLEANUP_GROUP((nint)(value));

        public static implicit operator long(PTP_CLEANUP_GROUP value) => (long)(value.Value);

        public static explicit operator PTP_CLEANUP_GROUP(nint value) => new PTP_CLEANUP_GROUP((nint)(value));

        public static implicit operator nint(PTP_CLEANUP_GROUP value) => (nint)(value.Value);

        public static explicit operator PTP_CLEANUP_GROUP(sbyte value) => new PTP_CLEANUP_GROUP((nint)(value));

        public static explicit operator sbyte(PTP_CLEANUP_GROUP value) => (sbyte)(value.Value);

        public static explicit operator PTP_CLEANUP_GROUP(ushort value) => new PTP_CLEANUP_GROUP((nint)(value));

        public static explicit operator ushort(PTP_CLEANUP_GROUP value) => (ushort)(value.Value);

        public static explicit operator PTP_CLEANUP_GROUP(uint value) => new PTP_CLEANUP_GROUP((nint)(value));

        public static explicit operator uint(PTP_CLEANUP_GROUP value) => (uint)(value.Value);

        public static explicit operator PTP_CLEANUP_GROUP(ulong value) => new PTP_CLEANUP_GROUP((nint)(value));

        public static explicit operator ulong(PTP_CLEANUP_GROUP value) => (ulong)(value.Value);

        public static explicit operator PTP_CLEANUP_GROUP(nuint value) => new PTP_CLEANUP_GROUP((nint)(value));

        public static explicit operator nuint(PTP_CLEANUP_GROUP value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is PTP_CLEANUP_GROUP other) && Equals(other);

        public bool Equals(PTP_CLEANUP_GROUP other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
