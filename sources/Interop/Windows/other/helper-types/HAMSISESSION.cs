// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HAMSISESSION : IEquatable<HAMSISESSION>
    {
        public readonly nint Value;

        public HAMSISESSION(nint value)
        {
            Value = value;
        }

        public static HAMSISESSION INVALID_VALUE => new HAMSISESSION(-1);

        public static HAMSISESSION NULL => new HAMSISESSION(0);

        public static bool operator ==(HAMSISESSION left, HAMSISESSION right) => left.Value == right.Value;

        public static bool operator !=(HAMSISESSION left, HAMSISESSION right) => left.Value != right.Value;

        public static explicit operator HAMSISESSION(void* value) => new HAMSISESSION((nint)(value));

        public static implicit operator void*(HAMSISESSION value) => (void*)(value.Value);

        public static explicit operator HAMSISESSION(HANDLE value) => new HAMSISESSION(value);

        public static implicit operator HANDLE(HAMSISESSION value) => new HAMSISESSION(value);

        public static explicit operator HAMSISESSION(byte value) => new HAMSISESSION((nint)(value));

        public static explicit operator byte(HAMSISESSION value) => (byte)(value.Value);

        public static explicit operator HAMSISESSION(short value) => new HAMSISESSION((nint)(value));

        public static explicit operator short(HAMSISESSION value) => (short)(value.Value);

        public static explicit operator HAMSISESSION(int value) => new HAMSISESSION((nint)(value));

        public static explicit operator int(HAMSISESSION value) => (int)(value.Value);

        public static explicit operator HAMSISESSION(long value) => new HAMSISESSION((nint)(value));

        public static implicit operator long(HAMSISESSION value) => (long)(value.Value);

        public static explicit operator HAMSISESSION(nint value) => new HAMSISESSION((nint)(value));

        public static implicit operator nint(HAMSISESSION value) => (nint)(value.Value);

        public static explicit operator HAMSISESSION(sbyte value) => new HAMSISESSION((nint)(value));

        public static explicit operator sbyte(HAMSISESSION value) => (sbyte)(value.Value);

        public static explicit operator HAMSISESSION(ushort value) => new HAMSISESSION((nint)(value));

        public static explicit operator ushort(HAMSISESSION value) => (ushort)(value.Value);

        public static explicit operator HAMSISESSION(uint value) => new HAMSISESSION((nint)(value));

        public static explicit operator uint(HAMSISESSION value) => (uint)(value.Value);

        public static explicit operator HAMSISESSION(ulong value) => new HAMSISESSION((nint)(value));

        public static implicit operator ulong(HAMSISESSION value) => (ulong)(value.Value);

        public static explicit operator HAMSISESSION(nuint value) => new HAMSISESSION((nint)(value));

        public static explicit operator nuint(HAMSISESSION value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HAMSISESSION other) && Equals(other);

        public bool Equals(HAMSISESSION other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
