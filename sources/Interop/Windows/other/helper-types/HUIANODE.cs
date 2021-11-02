// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HUIANODE : IEquatable<HUIANODE>
    {
        public readonly nint Value;

        public HUIANODE(nint value)
        {
            Value = value;
        }

        public static HUIANODE INVALID_VALUE => new HUIANODE(-1);

        public static HUIANODE NULL => new HUIANODE(0);

        public static bool operator ==(HUIANODE left, HUIANODE right) => left.Value == right.Value;

        public static bool operator !=(HUIANODE left, HUIANODE right) => left.Value != right.Value;

        public static explicit operator HUIANODE(void* value) => new HUIANODE((nint)(value));

        public static implicit operator void*(HUIANODE value) => (void*)(value.Value);

        public static explicit operator HUIANODE(HANDLE value) => new HUIANODE(value);

        public static implicit operator HANDLE(HUIANODE value) => new HUIANODE(value);

        public static explicit operator HUIANODE(byte value) => new HUIANODE((nint)(value));

        public static explicit operator byte(HUIANODE value) => (byte)(value.Value);

        public static explicit operator HUIANODE(short value) => new HUIANODE((nint)(value));

        public static explicit operator short(HUIANODE value) => (short)(value.Value);

        public static explicit operator HUIANODE(int value) => new HUIANODE((nint)(value));

        public static explicit operator int(HUIANODE value) => (int)(value.Value);

        public static explicit operator HUIANODE(long value) => new HUIANODE((nint)(value));

        public static implicit operator long(HUIANODE value) => (long)(value.Value);

        public static explicit operator HUIANODE(nint value) => new HUIANODE((nint)(value));

        public static implicit operator nint(HUIANODE value) => (nint)(value.Value);

        public static explicit operator HUIANODE(sbyte value) => new HUIANODE((nint)(value));

        public static explicit operator sbyte(HUIANODE value) => (sbyte)(value.Value);

        public static explicit operator HUIANODE(ushort value) => new HUIANODE((nint)(value));

        public static explicit operator ushort(HUIANODE value) => (ushort)(value.Value);

        public static explicit operator HUIANODE(uint value) => new HUIANODE((nint)(value));

        public static explicit operator uint(HUIANODE value) => (uint)(value.Value);

        public static explicit operator HUIANODE(ulong value) => new HUIANODE((nint)(value));

        public static explicit operator ulong(HUIANODE value) => (ulong)(value.Value);

        public static explicit operator HUIANODE(nuint value) => new HUIANODE((nint)(value));

        public static explicit operator nuint(HUIANODE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HUIANODE other) && Equals(other);

        public bool Equals(HUIANODE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
