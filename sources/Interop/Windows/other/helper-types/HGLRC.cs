// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HGLRC : IEquatable<HGLRC>
    {
        public readonly nint Value;

        public HGLRC(nint value)
        {
            Value = value;
        }

        public static HGLRC INVALID_VALUE => new HGLRC(-1);

        public static HGLRC NULL => new HGLRC(0);

        public static bool operator ==(HGLRC left, HGLRC right) => left.Value == right.Value;

        public static bool operator !=(HGLRC left, HGLRC right) => left.Value != right.Value;

        public static explicit operator HGLRC(void* value) => new HGLRC((nint)(value));

        public static implicit operator void*(HGLRC value) => (void*)(value.Value);

        public static explicit operator HGLRC(HANDLE value) => new HGLRC(value);

        public static implicit operator HANDLE(HGLRC value) => new HGLRC(value);

        public static explicit operator HGLRC(byte value) => new HGLRC((nint)(value));

        public static explicit operator byte(HGLRC value) => (byte)(value.Value);

        public static explicit operator HGLRC(short value) => new HGLRC((nint)(value));

        public static explicit operator short(HGLRC value) => (short)(value.Value);

        public static explicit operator HGLRC(int value) => new HGLRC((nint)(value));

        public static explicit operator int(HGLRC value) => (int)(value.Value);

        public static explicit operator HGLRC(long value) => new HGLRC((nint)(value));

        public static implicit operator long(HGLRC value) => (long)(value.Value);

        public static explicit operator HGLRC(nint value) => new HGLRC((nint)(value));

        public static implicit operator nint(HGLRC value) => (nint)(value.Value);

        public static explicit operator HGLRC(sbyte value) => new HGLRC((nint)(value));

        public static explicit operator sbyte(HGLRC value) => (sbyte)(value.Value);

        public static explicit operator HGLRC(ushort value) => new HGLRC((nint)(value));

        public static explicit operator ushort(HGLRC value) => (ushort)(value.Value);

        public static explicit operator HGLRC(uint value) => new HGLRC((nint)(value));

        public static explicit operator uint(HGLRC value) => (uint)(value.Value);

        public static explicit operator HGLRC(ulong value) => new HGLRC((nint)(value));

        public static implicit operator ulong(HGLRC value) => (ulong)(value.Value);

        public static explicit operator HGLRC(nuint value) => new HGLRC((nint)(value));

        public static explicit operator nuint(HGLRC value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HGLRC other) && Equals(other);

        public bool Equals(HGLRC other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
