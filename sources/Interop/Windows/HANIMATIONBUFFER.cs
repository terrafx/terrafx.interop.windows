// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HANIMATIONBUFFER : IEquatable<HANIMATIONBUFFER>
    {
        public readonly nint Value;

        public HANIMATIONBUFFER(nint value)
        {
            Value = value;
        }

        public static HANIMATIONBUFFER INVALID_HANDLE_VALUE => new HANIMATIONBUFFER(-1);

        public static HANIMATIONBUFFER NULL => new HANIMATIONBUFFER(0);

        public static bool operator ==(HANIMATIONBUFFER left, HANIMATIONBUFFER right) => left.Value == right.Value;

        public static bool operator !=(HANIMATIONBUFFER left, HANIMATIONBUFFER right) => left.Value != right.Value;

        public static explicit operator HANIMATIONBUFFER(void* value) => new HANIMATIONBUFFER((nint)(value));

        public static implicit operator void*(HANIMATIONBUFFER value) => (void*)(value.Value);

        public static explicit operator HANIMATIONBUFFER(HANDLE value) => new HANIMATIONBUFFER(value);

        public static implicit operator HANDLE(HANIMATIONBUFFER value) => new HANIMATIONBUFFER(value);

        public static explicit operator HANIMATIONBUFFER(byte value) => new HANIMATIONBUFFER((nint)(value));

        public static implicit operator byte(HANIMATIONBUFFER value) => (byte)(value.Value);

        public static explicit operator HANIMATIONBUFFER(short value) => new HANIMATIONBUFFER((nint)(value));

        public static implicit operator short(HANIMATIONBUFFER value) => (short)(value.Value);

        public static explicit operator HANIMATIONBUFFER(int value) => new HANIMATIONBUFFER((nint)(value));

        public static implicit operator int(HANIMATIONBUFFER value) => (int)(value.Value);

        public static explicit operator HANIMATIONBUFFER(long value) => new HANIMATIONBUFFER((nint)(value));

        public static explicit operator long(HANIMATIONBUFFER value) => (long)(value.Value);

        public static explicit operator HANIMATIONBUFFER(nint value) => new HANIMATIONBUFFER((nint)(value));

        public static implicit operator nint(HANIMATIONBUFFER value) => (nint)(value.Value);

        public static explicit operator HANIMATIONBUFFER(sbyte value) => new HANIMATIONBUFFER((nint)(value));

        public static implicit operator sbyte(HANIMATIONBUFFER value) => (sbyte)(value.Value);

        public static explicit operator HANIMATIONBUFFER(ushort value) => new HANIMATIONBUFFER((nint)(value));

        public static implicit operator ushort(HANIMATIONBUFFER value) => (ushort)(value.Value);

        public static explicit operator HANIMATIONBUFFER(uint value) => new HANIMATIONBUFFER((nint)(value));

        public static implicit operator uint(HANIMATIONBUFFER value) => (uint)(value.Value);

        public static explicit operator HANIMATIONBUFFER(ulong value) => new HANIMATIONBUFFER((nint)(value));

        public static explicit operator ulong(HANIMATIONBUFFER value) => (ulong)(value.Value);

        public static explicit operator HANIMATIONBUFFER(nuint value) => new HANIMATIONBUFFER((nint)(value));

        public static explicit operator nuint(HANIMATIONBUFFER value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HANIMATIONBUFFER other) && Equals(other);

        public bool Equals(HANIMATIONBUFFER other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
