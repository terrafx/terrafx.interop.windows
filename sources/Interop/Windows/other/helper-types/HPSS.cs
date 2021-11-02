// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HPSS : IEquatable<HPSS>
    {
        public readonly nint Value;

        public HPSS(nint value)
        {
            Value = value;
        }

        public static HPSS INVALID_VALUE => new HPSS(-1);

        public static HPSS NULL => new HPSS(0);

        public static bool operator ==(HPSS left, HPSS right) => left.Value == right.Value;

        public static bool operator !=(HPSS left, HPSS right) => left.Value != right.Value;

        public static explicit operator HPSS(void* value) => new HPSS((nint)(value));

        public static implicit operator void*(HPSS value) => (void*)(value.Value);

        public static explicit operator HPSS(HANDLE value) => new HPSS(value);

        public static implicit operator HANDLE(HPSS value) => new HPSS(value);

        public static explicit operator HPSS(byte value) => new HPSS((nint)(value));

        public static explicit operator byte(HPSS value) => (byte)(value.Value);

        public static explicit operator HPSS(short value) => new HPSS((nint)(value));

        public static explicit operator short(HPSS value) => (short)(value.Value);

        public static explicit operator HPSS(int value) => new HPSS((nint)(value));

        public static explicit operator int(HPSS value) => (int)(value.Value);

        public static explicit operator HPSS(long value) => new HPSS((nint)(value));

        public static implicit operator long(HPSS value) => (long)(value.Value);

        public static explicit operator HPSS(nint value) => new HPSS((nint)(value));

        public static implicit operator nint(HPSS value) => (nint)(value.Value);

        public static explicit operator HPSS(sbyte value) => new HPSS((nint)(value));

        public static explicit operator sbyte(HPSS value) => (sbyte)(value.Value);

        public static explicit operator HPSS(ushort value) => new HPSS((nint)(value));

        public static explicit operator ushort(HPSS value) => (ushort)(value.Value);

        public static explicit operator HPSS(uint value) => new HPSS((nint)(value));

        public static explicit operator uint(HPSS value) => (uint)(value.Value);

        public static explicit operator HPSS(ulong value) => new HPSS((nint)(value));

        public static implicit operator ulong(HPSS value) => (ulong)(value.Value);

        public static explicit operator HPSS(nuint value) => new HPSS((nint)(value));

        public static explicit operator nuint(HPSS value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HPSS other) && Equals(other);

        public bool Equals(HPSS other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
