// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HMIDI : IEquatable<HMIDI>
    {
        public readonly nint Value;

        public HMIDI(nint value)
        {
            Value = value;
        }

        public static HMIDI INVALID_HANDLE_VALUE => new HMIDI(-1);

        public static HMIDI NULL => new HMIDI(0);

        public static bool operator ==(HMIDI left, HMIDI right) => left.Value == right.Value;

        public static bool operator !=(HMIDI left, HMIDI right) => left.Value != right.Value;

        public static explicit operator HMIDI(void* value) => new HMIDI((nint)(value));

        public static implicit operator void*(HMIDI value) => (void*)(value.Value);

        public static explicit operator HMIDI(HANDLE value) => new HMIDI(value);

        public static implicit operator HANDLE(HMIDI value) => new HMIDI(value);

        public static explicit operator HMIDI(byte value) => new HMIDI((nint)(value));

        public static explicit operator byte(HMIDI value) => (byte)(value.Value);

        public static explicit operator HMIDI(short value) => new HMIDI((nint)(value));

        public static explicit operator short(HMIDI value) => (short)(value.Value);

        public static explicit operator HMIDI(int value) => new HMIDI((nint)(value));

        public static explicit operator int(HMIDI value) => (int)(value.Value);

        public static explicit operator HMIDI(long value) => new HMIDI((nint)(value));

        public static implicit operator long(HMIDI value) => (long)(value.Value);

        public static explicit operator HMIDI(nint value) => new HMIDI((nint)(value));

        public static implicit operator nint(HMIDI value) => (nint)(value.Value);

        public static explicit operator HMIDI(sbyte value) => new HMIDI((nint)(value));

        public static explicit operator sbyte(HMIDI value) => (sbyte)(value.Value);

        public static explicit operator HMIDI(ushort value) => new HMIDI((nint)(value));

        public static explicit operator ushort(HMIDI value) => (ushort)(value.Value);

        public static explicit operator HMIDI(uint value) => new HMIDI((nint)(value));

        public static explicit operator uint(HMIDI value) => (uint)(value.Value);

        public static explicit operator HMIDI(ulong value) => new HMIDI((nint)(value));

        public static implicit operator ulong(HMIDI value) => (ulong)(value.Value);

        public static explicit operator HMIDI(nuint value) => new HMIDI((nint)(value));

        public static explicit operator nuint(HMIDI value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HMIDI other) && Equals(other);

        public bool Equals(HMIDI other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
