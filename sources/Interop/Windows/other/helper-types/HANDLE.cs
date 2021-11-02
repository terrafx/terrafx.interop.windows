// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HANDLE : IEquatable<HANDLE>
    {
        public readonly nint Value;

        public HANDLE(nint value)
        {
            Value = value;
        }

        public static HANDLE INVALID_VALUE => new HANDLE(-1);

        public static HANDLE NULL => new HANDLE(0);

        public static bool operator ==(HANDLE left, HANDLE right) => left.Value == right.Value;

        public static bool operator !=(HANDLE left, HANDLE right) => left.Value != right.Value;

        public static explicit operator HANDLE(void* value) => new HANDLE((nint)(value));

        public static implicit operator void*(HANDLE value) => (void*)(value.Value);

        public static explicit operator HANDLE(byte value) => new HANDLE((nint)(value));

        public static explicit operator byte(HANDLE value) => (byte)(value.Value);

        public static explicit operator HANDLE(short value) => new HANDLE((nint)(value));

        public static explicit operator short(HANDLE value) => (short)(value.Value);

        public static explicit operator HANDLE(int value) => new HANDLE((nint)(value));

        public static explicit operator int(HANDLE value) => (int)(value.Value);

        public static explicit operator HANDLE(long value) => new HANDLE((nint)(value));

        public static implicit operator long(HANDLE value) => (long)(value.Value);

        public static explicit operator HANDLE(nint value) => new HANDLE((nint)(value));

        public static implicit operator nint(HANDLE value) => (nint)(value.Value);

        public static explicit operator HANDLE(sbyte value) => new HANDLE((nint)(value));

        public static explicit operator sbyte(HANDLE value) => (sbyte)(value.Value);

        public static explicit operator HANDLE(ushort value) => new HANDLE((nint)(value));

        public static explicit operator ushort(HANDLE value) => (ushort)(value.Value);

        public static explicit operator HANDLE(uint value) => new HANDLE((nint)(value));

        public static explicit operator uint(HANDLE value) => (uint)(value.Value);

        public static explicit operator HANDLE(ulong value) => new HANDLE((nint)(value));

        public static explicit operator ulong(HANDLE value) => (ulong)(value.Value);

        public static explicit operator HANDLE(nuint value) => new HANDLE((nint)(value));

        public static explicit operator nuint(HANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HANDLE other) && Equals(other);

        public bool Equals(HANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
