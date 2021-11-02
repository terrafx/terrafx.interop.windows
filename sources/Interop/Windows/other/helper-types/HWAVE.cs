// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HWAVE : IEquatable<HWAVE>
    {
        public readonly nint Value;

        public HWAVE(nint value)
        {
            Value = value;
        }

        public static HWAVE INVALID_HANDLE_VALUE => new HWAVE(-1);

        public static HWAVE NULL => new HWAVE(0);

        public static bool operator ==(HWAVE left, HWAVE right) => left.Value == right.Value;

        public static bool operator !=(HWAVE left, HWAVE right) => left.Value != right.Value;

        public static explicit operator HWAVE(void* value) => new HWAVE((nint)(value));

        public static implicit operator void*(HWAVE value) => (void*)(value.Value);

        public static explicit operator HWAVE(HANDLE value) => new HWAVE(value);

        public static implicit operator HANDLE(HWAVE value) => new HWAVE(value);

        public static explicit operator HWAVE(byte value) => new HWAVE((nint)(value));

        public static implicit operator byte(HWAVE value) => (byte)(value.Value);

        public static explicit operator HWAVE(short value) => new HWAVE((nint)(value));

        public static implicit operator short(HWAVE value) => (short)(value.Value);

        public static explicit operator HWAVE(int value) => new HWAVE((nint)(value));

        public static implicit operator int(HWAVE value) => (int)(value.Value);

        public static explicit operator HWAVE(long value) => new HWAVE((nint)(value));

        public static explicit operator long(HWAVE value) => (long)(value.Value);

        public static explicit operator HWAVE(nint value) => new HWAVE((nint)(value));

        public static implicit operator nint(HWAVE value) => (nint)(value.Value);

        public static explicit operator HWAVE(sbyte value) => new HWAVE((nint)(value));

        public static implicit operator sbyte(HWAVE value) => (sbyte)(value.Value);

        public static explicit operator HWAVE(ushort value) => new HWAVE((nint)(value));

        public static implicit operator ushort(HWAVE value) => (ushort)(value.Value);

        public static explicit operator HWAVE(uint value) => new HWAVE((nint)(value));

        public static implicit operator uint(HWAVE value) => (uint)(value.Value);

        public static explicit operator HWAVE(ulong value) => new HWAVE((nint)(value));

        public static explicit operator ulong(HWAVE value) => (ulong)(value.Value);

        public static explicit operator HWAVE(nuint value) => new HWAVE((nint)(value));

        public static explicit operator nuint(HWAVE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HWAVE other) && Equals(other);

        public bool Equals(HWAVE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
