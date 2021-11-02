// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HTASK : IEquatable<HTASK>
    {
        public readonly nint Value;

        public HTASK(nint value)
        {
            Value = value;
        }

        public static HTASK INVALID_VALUE => new HTASK(-1);

        public static HTASK NULL => new HTASK(0);

        public static bool operator ==(HTASK left, HTASK right) => left.Value == right.Value;

        public static bool operator !=(HTASK left, HTASK right) => left.Value != right.Value;

        public static explicit operator HTASK(void* value) => new HTASK((nint)(value));

        public static implicit operator void*(HTASK value) => (void*)(value.Value);

        public static explicit operator HTASK(HANDLE value) => new HTASK(value);

        public static implicit operator HANDLE(HTASK value) => new HTASK(value);

        public static explicit operator HTASK(byte value) => new HTASK((nint)(value));

        public static explicit operator byte(HTASK value) => (byte)(value.Value);

        public static explicit operator HTASK(short value) => new HTASK((nint)(value));

        public static explicit operator short(HTASK value) => (short)(value.Value);

        public static explicit operator HTASK(int value) => new HTASK((nint)(value));

        public static explicit operator int(HTASK value) => (int)(value.Value);

        public static explicit operator HTASK(long value) => new HTASK((nint)(value));

        public static implicit operator long(HTASK value) => (long)(value.Value);

        public static explicit operator HTASK(nint value) => new HTASK((nint)(value));

        public static implicit operator nint(HTASK value) => (nint)(value.Value);

        public static explicit operator HTASK(sbyte value) => new HTASK((nint)(value));

        public static explicit operator sbyte(HTASK value) => (sbyte)(value.Value);

        public static explicit operator HTASK(ushort value) => new HTASK((nint)(value));

        public static explicit operator ushort(HTASK value) => (ushort)(value.Value);

        public static explicit operator HTASK(uint value) => new HTASK((nint)(value));

        public static explicit operator uint(HTASK value) => (uint)(value.Value);

        public static explicit operator HTASK(ulong value) => new HTASK((nint)(value));

        public static implicit operator ulong(HTASK value) => (ulong)(value.Value);

        public static explicit operator HTASK(nuint value) => new HTASK((nint)(value));

        public static explicit operator nuint(HTASK value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HTASK other) && Equals(other);

        public bool Equals(HTASK other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
