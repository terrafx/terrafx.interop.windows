// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HICON : IEquatable<HICON>
    {
        public readonly nint Value;

        public HICON(nint value)
        {
            Value = value;
        }

        public static HICON INVALID_VALUE => new HICON(-1);

        public static HICON NULL => new HICON(0);

        public static bool operator ==(HICON left, HICON right) => left.Value == right.Value;

        public static bool operator !=(HICON left, HICON right) => left.Value != right.Value;

        public static explicit operator HICON(void* value) => new HICON((nint)(value));

        public static implicit operator void*(HICON value) => (void*)(value.Value);

        public static explicit operator HICON(HANDLE value) => new HICON(value);

        public static implicit operator HANDLE(HICON value) => new HICON(value);

        public static explicit operator HICON(byte value) => new HICON((nint)(value));

        public static explicit operator byte(HICON value) => (byte)(value.Value);

        public static explicit operator HICON(short value) => new HICON((nint)(value));

        public static explicit operator short(HICON value) => (short)(value.Value);

        public static explicit operator HICON(int value) => new HICON((nint)(value));

        public static explicit operator int(HICON value) => (int)(value.Value);

        public static explicit operator HICON(long value) => new HICON((nint)(value));

        public static implicit operator long(HICON value) => (long)(value.Value);

        public static explicit operator HICON(nint value) => new HICON((nint)(value));

        public static implicit operator nint(HICON value) => (nint)(value.Value);

        public static explicit operator HICON(sbyte value) => new HICON((nint)(value));

        public static explicit operator sbyte(HICON value) => (sbyte)(value.Value);

        public static explicit operator HICON(ushort value) => new HICON((nint)(value));

        public static explicit operator ushort(HICON value) => (ushort)(value.Value);

        public static explicit operator HICON(uint value) => new HICON((nint)(value));

        public static explicit operator uint(HICON value) => (uint)(value.Value);

        public static explicit operator HICON(ulong value) => new HICON((nint)(value));

        public static implicit operator ulong(HICON value) => (ulong)(value.Value);

        public static explicit operator HICON(nuint value) => new HICON((nint)(value));

        public static explicit operator nuint(HICON value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HICON other) && Equals(other);

        public bool Equals(HICON other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
