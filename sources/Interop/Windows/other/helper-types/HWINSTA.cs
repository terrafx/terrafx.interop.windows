// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HWINSTA : IEquatable<HWINSTA>
    {
        public readonly nint Value;

        public HWINSTA(nint value)
        {
            Value = value;
        }

        public static HWINSTA INVALID_HANDLE_VALUE => new HWINSTA(-1);

        public static HWINSTA NULL => new HWINSTA(0);

        public static bool operator ==(HWINSTA left, HWINSTA right) => left.Value == right.Value;

        public static bool operator !=(HWINSTA left, HWINSTA right) => left.Value != right.Value;

        public static explicit operator HWINSTA(void* value) => new HWINSTA((nint)(value));

        public static implicit operator void*(HWINSTA value) => (void*)(value.Value);

        public static explicit operator HWINSTA(HANDLE value) => new HWINSTA(value);

        public static implicit operator HANDLE(HWINSTA value) => new HWINSTA(value);

        public static explicit operator HWINSTA(byte value) => new HWINSTA((nint)(value));

        public static explicit operator byte(HWINSTA value) => (byte)(value.Value);

        public static explicit operator HWINSTA(short value) => new HWINSTA((nint)(value));

        public static explicit operator short(HWINSTA value) => (short)(value.Value);

        public static explicit operator HWINSTA(int value) => new HWINSTA((nint)(value));

        public static explicit operator int(HWINSTA value) => (int)(value.Value);

        public static explicit operator HWINSTA(long value) => new HWINSTA((nint)(value));

        public static implicit operator long(HWINSTA value) => (long)(value.Value);

        public static explicit operator HWINSTA(nint value) => new HWINSTA((nint)(value));

        public static implicit operator nint(HWINSTA value) => (nint)(value.Value);

        public static explicit operator HWINSTA(sbyte value) => new HWINSTA((nint)(value));

        public static explicit operator sbyte(HWINSTA value) => (sbyte)(value.Value);

        public static explicit operator HWINSTA(ushort value) => new HWINSTA((nint)(value));

        public static explicit operator ushort(HWINSTA value) => (ushort)(value.Value);

        public static explicit operator HWINSTA(uint value) => new HWINSTA((nint)(value));

        public static explicit operator uint(HWINSTA value) => (uint)(value.Value);

        public static explicit operator HWINSTA(ulong value) => new HWINSTA((nint)(value));

        public static implicit operator ulong(HWINSTA value) => (ulong)(value.Value);

        public static explicit operator HWINSTA(nuint value) => new HWINSTA((nint)(value));

        public static explicit operator nuint(HWINSTA value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HWINSTA other) && Equals(other);

        public bool Equals(HWINSTA other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
