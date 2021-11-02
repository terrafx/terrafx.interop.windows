// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HMIDIIN : IEquatable<HMIDIIN>
    {
        public readonly nint Value;

        public HMIDIIN(nint value)
        {
            Value = value;
        }

        public static HMIDIIN INVALID_HANDLE_VALUE => new HMIDIIN(-1);

        public static HMIDIIN NULL => new HMIDIIN(0);

        public static bool operator ==(HMIDIIN left, HMIDIIN right) => left.Value == right.Value;

        public static bool operator !=(HMIDIIN left, HMIDIIN right) => left.Value != right.Value;

        public static explicit operator HMIDIIN(void* value) => new HMIDIIN((nint)(value));

        public static implicit operator void*(HMIDIIN value) => (void*)(value.Value);

        public static explicit operator HMIDIIN(HANDLE value) => new HMIDIIN(value);

        public static implicit operator HANDLE(HMIDIIN value) => new HMIDIIN(value);

        public static explicit operator HMIDIIN(byte value) => new HMIDIIN((nint)(value));

        public static implicit operator byte(HMIDIIN value) => (byte)(value.Value);

        public static explicit operator HMIDIIN(short value) => new HMIDIIN((nint)(value));

        public static implicit operator short(HMIDIIN value) => (short)(value.Value);

        public static explicit operator HMIDIIN(int value) => new HMIDIIN((nint)(value));

        public static implicit operator int(HMIDIIN value) => (int)(value.Value);

        public static explicit operator HMIDIIN(long value) => new HMIDIIN((nint)(value));

        public static explicit operator long(HMIDIIN value) => (long)(value.Value);

        public static explicit operator HMIDIIN(nint value) => new HMIDIIN((nint)(value));

        public static implicit operator nint(HMIDIIN value) => (nint)(value.Value);

        public static explicit operator HMIDIIN(sbyte value) => new HMIDIIN((nint)(value));

        public static implicit operator sbyte(HMIDIIN value) => (sbyte)(value.Value);

        public static explicit operator HMIDIIN(ushort value) => new HMIDIIN((nint)(value));

        public static implicit operator ushort(HMIDIIN value) => (ushort)(value.Value);

        public static explicit operator HMIDIIN(uint value) => new HMIDIIN((nint)(value));

        public static implicit operator uint(HMIDIIN value) => (uint)(value.Value);

        public static explicit operator HMIDIIN(ulong value) => new HMIDIIN((nint)(value));

        public static explicit operator ulong(HMIDIIN value) => (ulong)(value.Value);

        public static explicit operator HMIDIIN(nuint value) => new HMIDIIN((nint)(value));

        public static explicit operator nuint(HMIDIIN value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HMIDIIN other) && Equals(other);

        public bool Equals(HMIDIIN other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
