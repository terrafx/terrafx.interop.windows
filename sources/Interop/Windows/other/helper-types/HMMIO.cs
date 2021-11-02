// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HMMIO : IEquatable<HMMIO>
    {
        public readonly nint Value;

        public HMMIO(nint value)
        {
            Value = value;
        }

        public static HMMIO INVALID_VALUE => new HMMIO(-1);

        public static HMMIO NULL => new HMMIO(0);

        public static bool operator ==(HMMIO left, HMMIO right) => left.Value == right.Value;

        public static bool operator !=(HMMIO left, HMMIO right) => left.Value != right.Value;

        public static explicit operator HMMIO(void* value) => new HMMIO((nint)(value));

        public static implicit operator void*(HMMIO value) => (void*)(value.Value);

        public static explicit operator HMMIO(HANDLE value) => new HMMIO(value);

        public static implicit operator HANDLE(HMMIO value) => new HMMIO(value);

        public static explicit operator HMMIO(byte value) => new HMMIO((nint)(value));

        public static explicit operator byte(HMMIO value) => (byte)(value.Value);

        public static explicit operator HMMIO(short value) => new HMMIO((nint)(value));

        public static explicit operator short(HMMIO value) => (short)(value.Value);

        public static explicit operator HMMIO(int value) => new HMMIO((nint)(value));

        public static explicit operator int(HMMIO value) => (int)(value.Value);

        public static explicit operator HMMIO(long value) => new HMMIO((nint)(value));

        public static implicit operator long(HMMIO value) => (long)(value.Value);

        public static explicit operator HMMIO(nint value) => new HMMIO((nint)(value));

        public static implicit operator nint(HMMIO value) => (nint)(value.Value);

        public static explicit operator HMMIO(sbyte value) => new HMMIO((nint)(value));

        public static explicit operator sbyte(HMMIO value) => (sbyte)(value.Value);

        public static explicit operator HMMIO(ushort value) => new HMMIO((nint)(value));

        public static explicit operator ushort(HMMIO value) => (ushort)(value.Value);

        public static explicit operator HMMIO(uint value) => new HMMIO((nint)(value));

        public static explicit operator uint(HMMIO value) => (uint)(value.Value);

        public static explicit operator HMMIO(ulong value) => new HMMIO((nint)(value));

        public static explicit operator ulong(HMMIO value) => (ulong)(value.Value);

        public static explicit operator HMMIO(nuint value) => new HMMIO((nint)(value));

        public static explicit operator nuint(HMMIO value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HMMIO other) && Equals(other);

        public bool Equals(HMMIO other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
