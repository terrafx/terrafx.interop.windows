// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HIMAGELIST : IEquatable<HIMAGELIST>
    {
        public readonly nint Value;

        public HIMAGELIST(nint value)
        {
            Value = value;
        }

        public static HIMAGELIST INVALID_VALUE => new HIMAGELIST(-1);

        public static HIMAGELIST NULL => new HIMAGELIST(0);

        public static bool operator ==(HIMAGELIST left, HIMAGELIST right) => left.Value == right.Value;

        public static bool operator !=(HIMAGELIST left, HIMAGELIST right) => left.Value != right.Value;

        public static explicit operator HIMAGELIST(void* value) => new HIMAGELIST((nint)(value));

        public static implicit operator void*(HIMAGELIST value) => (void*)(value.Value);

        public static explicit operator HIMAGELIST(HANDLE value) => new HIMAGELIST(value);

        public static implicit operator HANDLE(HIMAGELIST value) => new HIMAGELIST(value);

        public static explicit operator HIMAGELIST(byte value) => new HIMAGELIST((nint)(value));

        public static explicit operator byte(HIMAGELIST value) => (byte)(value.Value);

        public static explicit operator HIMAGELIST(short value) => new HIMAGELIST((nint)(value));

        public static explicit operator short(HIMAGELIST value) => (short)(value.Value);

        public static explicit operator HIMAGELIST(int value) => new HIMAGELIST((nint)(value));

        public static explicit operator int(HIMAGELIST value) => (int)(value.Value);

        public static explicit operator HIMAGELIST(long value) => new HIMAGELIST((nint)(value));

        public static implicit operator long(HIMAGELIST value) => (long)(value.Value);

        public static explicit operator HIMAGELIST(nint value) => new HIMAGELIST((nint)(value));

        public static implicit operator nint(HIMAGELIST value) => (nint)(value.Value);

        public static explicit operator HIMAGELIST(sbyte value) => new HIMAGELIST((nint)(value));

        public static explicit operator sbyte(HIMAGELIST value) => (sbyte)(value.Value);

        public static explicit operator HIMAGELIST(ushort value) => new HIMAGELIST((nint)(value));

        public static explicit operator ushort(HIMAGELIST value) => (ushort)(value.Value);

        public static explicit operator HIMAGELIST(uint value) => new HIMAGELIST((nint)(value));

        public static explicit operator uint(HIMAGELIST value) => (uint)(value.Value);

        public static explicit operator HIMAGELIST(ulong value) => new HIMAGELIST((nint)(value));

        public static implicit operator ulong(HIMAGELIST value) => (ulong)(value.Value);

        public static explicit operator HIMAGELIST(nuint value) => new HIMAGELIST((nint)(value));

        public static explicit operator nuint(HIMAGELIST value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HIMAGELIST other) && Equals(other);

        public bool Equals(HIMAGELIST other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
