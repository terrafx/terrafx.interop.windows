// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HRGN : IEquatable<HRGN>
    {
        public readonly nint Value;

        public HRGN(nint value)
        {
            Value = value;
        }

        public static HRGN INVALID_VALUE => new HRGN(-1);

        public static HRGN NULL => new HRGN(0);

        public static bool operator ==(HRGN left, HRGN right) => left.Value == right.Value;

        public static bool operator !=(HRGN left, HRGN right) => left.Value != right.Value;

        public static explicit operator HRGN(void* value) => new HRGN((nint)(value));

        public static implicit operator void*(HRGN value) => (void*)(value.Value);

        public static explicit operator HRGN(HANDLE value) => new HRGN(value);

        public static implicit operator HANDLE(HRGN value) => new HRGN(value);

        public static explicit operator HRGN(byte value) => new HRGN((nint)(value));

        public static explicit operator byte(HRGN value) => (byte)(value.Value);

        public static explicit operator HRGN(short value) => new HRGN((nint)(value));

        public static explicit operator short(HRGN value) => (short)(value.Value);

        public static explicit operator HRGN(int value) => new HRGN((nint)(value));

        public static explicit operator int(HRGN value) => (int)(value.Value);

        public static explicit operator HRGN(long value) => new HRGN((nint)(value));

        public static implicit operator long(HRGN value) => (long)(value.Value);

        public static explicit operator HRGN(nint value) => new HRGN((nint)(value));

        public static implicit operator nint(HRGN value) => (nint)(value.Value);

        public static explicit operator HRGN(sbyte value) => new HRGN((nint)(value));

        public static explicit operator sbyte(HRGN value) => (sbyte)(value.Value);

        public static explicit operator HRGN(ushort value) => new HRGN((nint)(value));

        public static explicit operator ushort(HRGN value) => (ushort)(value.Value);

        public static explicit operator HRGN(uint value) => new HRGN((nint)(value));

        public static explicit operator uint(HRGN value) => (uint)(value.Value);

        public static explicit operator HRGN(ulong value) => new HRGN((nint)(value));

        public static explicit operator ulong(HRGN value) => (ulong)(value.Value);

        public static explicit operator HRGN(nuint value) => new HRGN((nint)(value));

        public static explicit operator nuint(HRGN value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HRGN other) && Equals(other);

        public bool Equals(HRGN other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
