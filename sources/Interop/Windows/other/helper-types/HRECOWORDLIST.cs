// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HRECOWORDLIST : IEquatable<HRECOWORDLIST>
    {
        public readonly nint Value;

        public HRECOWORDLIST(nint value)
        {
            Value = value;
        }

        public static HRECOWORDLIST INVALID_VALUE => new HRECOWORDLIST(-1);

        public static HRECOWORDLIST NULL => new HRECOWORDLIST(0);

        public static bool operator ==(HRECOWORDLIST left, HRECOWORDLIST right) => left.Value == right.Value;

        public static bool operator !=(HRECOWORDLIST left, HRECOWORDLIST right) => left.Value != right.Value;

        public static explicit operator HRECOWORDLIST(void* value) => new HRECOWORDLIST((nint)(value));

        public static implicit operator void*(HRECOWORDLIST value) => (void*)(value.Value);

        public static explicit operator HRECOWORDLIST(HANDLE value) => new HRECOWORDLIST(value);

        public static implicit operator HANDLE(HRECOWORDLIST value) => new HANDLE(value.Value);

        public static explicit operator HRECOWORDLIST(byte value) => new HRECOWORDLIST((nint)(value));

        public static explicit operator byte(HRECOWORDLIST value) => (byte)(value.Value);

        public static explicit operator HRECOWORDLIST(short value) => new HRECOWORDLIST((nint)(value));

        public static explicit operator short(HRECOWORDLIST value) => (short)(value.Value);

        public static explicit operator HRECOWORDLIST(int value) => new HRECOWORDLIST((nint)(value));

        public static explicit operator int(HRECOWORDLIST value) => (int)(value.Value);

        public static explicit operator HRECOWORDLIST(long value) => new HRECOWORDLIST((nint)(value));

        public static implicit operator long(HRECOWORDLIST value) => (long)(value.Value);

        public static explicit operator HRECOWORDLIST(nint value) => new HRECOWORDLIST((nint)(value));

        public static implicit operator nint(HRECOWORDLIST value) => (nint)(value.Value);

        public static explicit operator HRECOWORDLIST(sbyte value) => new HRECOWORDLIST((nint)(value));

        public static explicit operator sbyte(HRECOWORDLIST value) => (sbyte)(value.Value);

        public static explicit operator HRECOWORDLIST(ushort value) => new HRECOWORDLIST((nint)(value));

        public static explicit operator ushort(HRECOWORDLIST value) => (ushort)(value.Value);

        public static explicit operator HRECOWORDLIST(uint value) => new HRECOWORDLIST((nint)(value));

        public static explicit operator uint(HRECOWORDLIST value) => (uint)(value.Value);

        public static explicit operator HRECOWORDLIST(ulong value) => new HRECOWORDLIST((nint)(value));

        public static explicit operator ulong(HRECOWORDLIST value) => (ulong)(value.Value);

        public static explicit operator HRECOWORDLIST(nuint value) => new HRECOWORDLIST((nint)(value));

        public static explicit operator nuint(HRECOWORDLIST value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HRECOWORDLIST other) && Equals(other);

        public bool Equals(HRECOWORDLIST other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
