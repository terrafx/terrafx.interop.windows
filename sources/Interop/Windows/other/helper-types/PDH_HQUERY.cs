// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PDH_HQUERY : IEquatable<PDH_HQUERY>
    {
        public readonly nint Value;

        public PDH_HQUERY(nint value)
        {
            Value = value;
        }

        public static PDH_HQUERY INVALID_VALUE => new PDH_HQUERY(-1);

        public static PDH_HQUERY NULL => new PDH_HQUERY(0);

        public static bool operator ==(PDH_HQUERY left, PDH_HQUERY right) => left.Value == right.Value;

        public static bool operator !=(PDH_HQUERY left, PDH_HQUERY right) => left.Value != right.Value;

        public static explicit operator PDH_HQUERY(void* value) => new PDH_HQUERY((nint)(value));

        public static implicit operator void*(PDH_HQUERY value) => (void*)(value.Value);

        public static explicit operator PDH_HQUERY(HANDLE value) => new PDH_HQUERY(value);

        public static implicit operator HANDLE(PDH_HQUERY value) => new PDH_HQUERY(value);

        public static explicit operator PDH_HQUERY(byte value) => new PDH_HQUERY((nint)(value));

        public static explicit operator byte(PDH_HQUERY value) => (byte)(value.Value);

        public static explicit operator PDH_HQUERY(short value) => new PDH_HQUERY((nint)(value));

        public static explicit operator short(PDH_HQUERY value) => (short)(value.Value);

        public static explicit operator PDH_HQUERY(int value) => new PDH_HQUERY((nint)(value));

        public static explicit operator int(PDH_HQUERY value) => (int)(value.Value);

        public static explicit operator PDH_HQUERY(long value) => new PDH_HQUERY((nint)(value));

        public static implicit operator long(PDH_HQUERY value) => (long)(value.Value);

        public static explicit operator PDH_HQUERY(nint value) => new PDH_HQUERY((nint)(value));

        public static implicit operator nint(PDH_HQUERY value) => (nint)(value.Value);

        public static explicit operator PDH_HQUERY(sbyte value) => new PDH_HQUERY((nint)(value));

        public static explicit operator sbyte(PDH_HQUERY value) => (sbyte)(value.Value);

        public static explicit operator PDH_HQUERY(ushort value) => new PDH_HQUERY((nint)(value));

        public static explicit operator ushort(PDH_HQUERY value) => (ushort)(value.Value);

        public static explicit operator PDH_HQUERY(uint value) => new PDH_HQUERY((nint)(value));

        public static explicit operator uint(PDH_HQUERY value) => (uint)(value.Value);

        public static explicit operator PDH_HQUERY(ulong value) => new PDH_HQUERY((nint)(value));

        public static explicit operator ulong(PDH_HQUERY value) => (ulong)(value.Value);

        public static explicit operator PDH_HQUERY(nuint value) => new PDH_HQUERY((nint)(value));

        public static explicit operator nuint(PDH_HQUERY value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is PDH_HQUERY other) && Equals(other);

        public bool Equals(PDH_HQUERY other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
