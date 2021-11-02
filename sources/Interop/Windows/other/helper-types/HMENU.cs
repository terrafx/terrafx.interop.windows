// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HMENU : IEquatable<HMENU>
    {
        public readonly nint Value;

        public HMENU(nint value)
        {
            Value = value;
        }

        public static HMENU INVALID_HANDLE_VALUE => new HMENU(-1);

        public static HMENU NULL => new HMENU(0);

        public static bool operator ==(HMENU left, HMENU right) => left.Value == right.Value;

        public static bool operator !=(HMENU left, HMENU right) => left.Value != right.Value;

        public static explicit operator HMENU(void* value) => new HMENU((nint)(value));

        public static implicit operator void*(HMENU value) => (void*)(value.Value);

        public static explicit operator HMENU(HANDLE value) => new HMENU(value);

        public static implicit operator HANDLE(HMENU value) => new HMENU(value);

        public static explicit operator HMENU(byte value) => new HMENU((nint)(value));

        public static implicit operator byte(HMENU value) => (byte)(value.Value);

        public static explicit operator HMENU(short value) => new HMENU((nint)(value));

        public static implicit operator short(HMENU value) => (short)(value.Value);

        public static explicit operator HMENU(int value) => new HMENU((nint)(value));

        public static implicit operator int(HMENU value) => (int)(value.Value);

        public static explicit operator HMENU(long value) => new HMENU((nint)(value));

        public static explicit operator long(HMENU value) => (long)(value.Value);

        public static explicit operator HMENU(nint value) => new HMENU((nint)(value));

        public static implicit operator nint(HMENU value) => (nint)(value.Value);

        public static explicit operator HMENU(sbyte value) => new HMENU((nint)(value));

        public static implicit operator sbyte(HMENU value) => (sbyte)(value.Value);

        public static explicit operator HMENU(ushort value) => new HMENU((nint)(value));

        public static implicit operator ushort(HMENU value) => (ushort)(value.Value);

        public static explicit operator HMENU(uint value) => new HMENU((nint)(value));

        public static implicit operator uint(HMENU value) => (uint)(value.Value);

        public static explicit operator HMENU(ulong value) => new HMENU((nint)(value));

        public static explicit operator ulong(HMENU value) => (ulong)(value.Value);

        public static explicit operator HMENU(nuint value) => new HMENU((nint)(value));

        public static explicit operator nuint(HMENU value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HMENU other) && Equals(other);

        public bool Equals(HMENU other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
