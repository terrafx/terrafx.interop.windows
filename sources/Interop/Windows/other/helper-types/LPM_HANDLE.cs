// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct LPM_HANDLE : IEquatable<LPM_HANDLE>
    {
        public readonly nint Value;

        public LPM_HANDLE(nint value)
        {
            Value = value;
        }

        public static LPM_HANDLE INVALID_VALUE => new LPM_HANDLE(-1);

        public static LPM_HANDLE NULL => new LPM_HANDLE(0);

        public static bool operator ==(LPM_HANDLE left, LPM_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(LPM_HANDLE left, LPM_HANDLE right) => left.Value != right.Value;

        public static explicit operator LPM_HANDLE(void* value) => new LPM_HANDLE((nint)(value));

        public static implicit operator void*(LPM_HANDLE value) => (void*)(value.Value);

        public static explicit operator LPM_HANDLE(HANDLE value) => new LPM_HANDLE(value);

        public static implicit operator HANDLE(LPM_HANDLE value) => new LPM_HANDLE(value);

        public static explicit operator LPM_HANDLE(byte value) => new LPM_HANDLE((nint)(value));

        public static explicit operator byte(LPM_HANDLE value) => (byte)(value.Value);

        public static explicit operator LPM_HANDLE(short value) => new LPM_HANDLE((nint)(value));

        public static explicit operator short(LPM_HANDLE value) => (short)(value.Value);

        public static explicit operator LPM_HANDLE(int value) => new LPM_HANDLE((nint)(value));

        public static explicit operator int(LPM_HANDLE value) => (int)(value.Value);

        public static explicit operator LPM_HANDLE(long value) => new LPM_HANDLE((nint)(value));

        public static implicit operator long(LPM_HANDLE value) => (long)(value.Value);

        public static explicit operator LPM_HANDLE(nint value) => new LPM_HANDLE((nint)(value));

        public static implicit operator nint(LPM_HANDLE value) => (nint)(value.Value);

        public static explicit operator LPM_HANDLE(sbyte value) => new LPM_HANDLE((nint)(value));

        public static explicit operator sbyte(LPM_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator LPM_HANDLE(ushort value) => new LPM_HANDLE((nint)(value));

        public static explicit operator ushort(LPM_HANDLE value) => (ushort)(value.Value);

        public static explicit operator LPM_HANDLE(uint value) => new LPM_HANDLE((nint)(value));

        public static explicit operator uint(LPM_HANDLE value) => (uint)(value.Value);

        public static explicit operator LPM_HANDLE(ulong value) => new LPM_HANDLE((nint)(value));

        public static implicit operator ulong(LPM_HANDLE value) => (ulong)(value.Value);

        public static explicit operator LPM_HANDLE(nuint value) => new LPM_HANDLE((nint)(value));

        public static explicit operator nuint(LPM_HANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is LPM_HANDLE other) && Equals(other);

        public bool Equals(LPM_HANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
