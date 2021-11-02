// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HMIDISTRM : IEquatable<HMIDISTRM>
    {
        public readonly nint Value;

        public HMIDISTRM(nint value)
        {
            Value = value;
        }

        public static HMIDISTRM INVALID_HANDLE_VALUE => new HMIDISTRM(-1);

        public static HMIDISTRM NULL => new HMIDISTRM(0);

        public static bool operator ==(HMIDISTRM left, HMIDISTRM right) => left.Value == right.Value;

        public static bool operator !=(HMIDISTRM left, HMIDISTRM right) => left.Value != right.Value;

        public static explicit operator HMIDISTRM(void* value) => new HMIDISTRM((nint)(value));

        public static implicit operator void*(HMIDISTRM value) => (void*)(value.Value);

        public static explicit operator HMIDISTRM(HANDLE value) => new HMIDISTRM(value);

        public static implicit operator HANDLE(HMIDISTRM value) => new HMIDISTRM(value);

        public static explicit operator HMIDISTRM(byte value) => new HMIDISTRM((nint)(value));

        public static explicit operator byte(HMIDISTRM value) => (byte)(value.Value);

        public static explicit operator HMIDISTRM(short value) => new HMIDISTRM((nint)(value));

        public static explicit operator short(HMIDISTRM value) => (short)(value.Value);

        public static explicit operator HMIDISTRM(int value) => new HMIDISTRM((nint)(value));

        public static explicit operator int(HMIDISTRM value) => (int)(value.Value);

        public static explicit operator HMIDISTRM(long value) => new HMIDISTRM((nint)(value));

        public static implicit operator long(HMIDISTRM value) => (long)(value.Value);

        public static explicit operator HMIDISTRM(nint value) => new HMIDISTRM((nint)(value));

        public static implicit operator nint(HMIDISTRM value) => (nint)(value.Value);

        public static explicit operator HMIDISTRM(sbyte value) => new HMIDISTRM((nint)(value));

        public static explicit operator sbyte(HMIDISTRM value) => (sbyte)(value.Value);

        public static explicit operator HMIDISTRM(ushort value) => new HMIDISTRM((nint)(value));

        public static explicit operator ushort(HMIDISTRM value) => (ushort)(value.Value);

        public static explicit operator HMIDISTRM(uint value) => new HMIDISTRM((nint)(value));

        public static explicit operator uint(HMIDISTRM value) => (uint)(value.Value);

        public static explicit operator HMIDISTRM(ulong value) => new HMIDISTRM((nint)(value));

        public static implicit operator ulong(HMIDISTRM value) => (ulong)(value.Value);

        public static explicit operator HMIDISTRM(nuint value) => new HMIDISTRM((nint)(value));

        public static explicit operator nuint(HMIDISTRM value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HMIDISTRM other) && Equals(other);

        public bool Equals(HMIDISTRM other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
