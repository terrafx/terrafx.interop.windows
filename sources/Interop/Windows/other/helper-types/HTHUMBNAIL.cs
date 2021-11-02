// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HTHUMBNAIL : IEquatable<HTHUMBNAIL>
    {
        public readonly nint Value;

        public HTHUMBNAIL(nint value)
        {
            Value = value;
        }

        public static HTHUMBNAIL INVALID_VALUE => new HTHUMBNAIL(-1);

        public static HTHUMBNAIL NULL => new HTHUMBNAIL(0);

        public static bool operator ==(HTHUMBNAIL left, HTHUMBNAIL right) => left.Value == right.Value;

        public static bool operator !=(HTHUMBNAIL left, HTHUMBNAIL right) => left.Value != right.Value;

        public static explicit operator HTHUMBNAIL(void* value) => new HTHUMBNAIL((nint)(value));

        public static implicit operator void*(HTHUMBNAIL value) => (void*)(value.Value);

        public static explicit operator HTHUMBNAIL(HANDLE value) => new HTHUMBNAIL(value);

        public static implicit operator HANDLE(HTHUMBNAIL value) => new HTHUMBNAIL(value);

        public static explicit operator HTHUMBNAIL(byte value) => new HTHUMBNAIL((nint)(value));

        public static explicit operator byte(HTHUMBNAIL value) => (byte)(value.Value);

        public static explicit operator HTHUMBNAIL(short value) => new HTHUMBNAIL((nint)(value));

        public static explicit operator short(HTHUMBNAIL value) => (short)(value.Value);

        public static explicit operator HTHUMBNAIL(int value) => new HTHUMBNAIL((nint)(value));

        public static explicit operator int(HTHUMBNAIL value) => (int)(value.Value);

        public static explicit operator HTHUMBNAIL(long value) => new HTHUMBNAIL((nint)(value));

        public static implicit operator long(HTHUMBNAIL value) => (long)(value.Value);

        public static explicit operator HTHUMBNAIL(nint value) => new HTHUMBNAIL((nint)(value));

        public static implicit operator nint(HTHUMBNAIL value) => (nint)(value.Value);

        public static explicit operator HTHUMBNAIL(sbyte value) => new HTHUMBNAIL((nint)(value));

        public static explicit operator sbyte(HTHUMBNAIL value) => (sbyte)(value.Value);

        public static explicit operator HTHUMBNAIL(ushort value) => new HTHUMBNAIL((nint)(value));

        public static explicit operator ushort(HTHUMBNAIL value) => (ushort)(value.Value);

        public static explicit operator HTHUMBNAIL(uint value) => new HTHUMBNAIL((nint)(value));

        public static explicit operator uint(HTHUMBNAIL value) => (uint)(value.Value);

        public static explicit operator HTHUMBNAIL(ulong value) => new HTHUMBNAIL((nint)(value));

        public static implicit operator ulong(HTHUMBNAIL value) => (ulong)(value.Value);

        public static explicit operator HTHUMBNAIL(nuint value) => new HTHUMBNAIL((nint)(value));

        public static explicit operator nuint(HTHUMBNAIL value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HTHUMBNAIL other) && Equals(other);

        public bool Equals(HTHUMBNAIL other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
