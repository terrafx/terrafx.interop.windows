// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDRAWDIB : IEquatable<HDRAWDIB>
    {
        public readonly nint Value;

        public HDRAWDIB(nint value)
        {
            Value = value;
        }

        public static HDRAWDIB INVALID_VALUE => new HDRAWDIB(-1);

        public static HDRAWDIB NULL => new HDRAWDIB(0);

        public static bool operator ==(HDRAWDIB left, HDRAWDIB right) => left.Value == right.Value;

        public static bool operator !=(HDRAWDIB left, HDRAWDIB right) => left.Value != right.Value;

        public static explicit operator HDRAWDIB(void* value) => new HDRAWDIB((nint)(value));

        public static implicit operator void*(HDRAWDIB value) => (void*)(value.Value);

        public static explicit operator HDRAWDIB(HANDLE value) => new HDRAWDIB(value);

        public static implicit operator HANDLE(HDRAWDIB value) => new HDRAWDIB(value);

        public static explicit operator HDRAWDIB(byte value) => new HDRAWDIB((nint)(value));

        public static explicit operator byte(HDRAWDIB value) => (byte)(value.Value);

        public static explicit operator HDRAWDIB(short value) => new HDRAWDIB((nint)(value));

        public static explicit operator short(HDRAWDIB value) => (short)(value.Value);

        public static explicit operator HDRAWDIB(int value) => new HDRAWDIB((nint)(value));

        public static explicit operator int(HDRAWDIB value) => (int)(value.Value);

        public static explicit operator HDRAWDIB(long value) => new HDRAWDIB((nint)(value));

        public static implicit operator long(HDRAWDIB value) => (long)(value.Value);

        public static explicit operator HDRAWDIB(nint value) => new HDRAWDIB((nint)(value));

        public static implicit operator nint(HDRAWDIB value) => (nint)(value.Value);

        public static explicit operator HDRAWDIB(sbyte value) => new HDRAWDIB((nint)(value));

        public static explicit operator sbyte(HDRAWDIB value) => (sbyte)(value.Value);

        public static explicit operator HDRAWDIB(ushort value) => new HDRAWDIB((nint)(value));

        public static explicit operator ushort(HDRAWDIB value) => (ushort)(value.Value);

        public static explicit operator HDRAWDIB(uint value) => new HDRAWDIB((nint)(value));

        public static explicit operator uint(HDRAWDIB value) => (uint)(value.Value);

        public static explicit operator HDRAWDIB(ulong value) => new HDRAWDIB((nint)(value));

        public static explicit operator ulong(HDRAWDIB value) => (ulong)(value.Value);

        public static explicit operator HDRAWDIB(nuint value) => new HDRAWDIB((nint)(value));

        public static explicit operator nuint(HDRAWDIB value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HDRAWDIB other) && Equals(other);

        public bool Equals(HDRAWDIB other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
