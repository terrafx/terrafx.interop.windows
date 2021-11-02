// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCONVLIST : IEquatable<HCONVLIST>
    {
        public readonly nint Value;

        public HCONVLIST(nint value)
        {
            Value = value;
        }

        public static HCONVLIST INVALID_VALUE => new HCONVLIST(-1);

        public static HCONVLIST NULL => new HCONVLIST(0);

        public static bool operator ==(HCONVLIST left, HCONVLIST right) => left.Value == right.Value;

        public static bool operator !=(HCONVLIST left, HCONVLIST right) => left.Value != right.Value;

        public static explicit operator HCONVLIST(void* value) => new HCONVLIST((nint)(value));

        public static implicit operator void*(HCONVLIST value) => (void*)(value.Value);

        public static explicit operator HCONVLIST(HANDLE value) => new HCONVLIST(value);

        public static implicit operator HANDLE(HCONVLIST value) => new HANDLE(value.Value);

        public static explicit operator HCONVLIST(byte value) => new HCONVLIST((nint)(value));

        public static explicit operator byte(HCONVLIST value) => (byte)(value.Value);

        public static explicit operator HCONVLIST(short value) => new HCONVLIST((nint)(value));

        public static explicit operator short(HCONVLIST value) => (short)(value.Value);

        public static explicit operator HCONVLIST(int value) => new HCONVLIST((nint)(value));

        public static explicit operator int(HCONVLIST value) => (int)(value.Value);

        public static explicit operator HCONVLIST(long value) => new HCONVLIST((nint)(value));

        public static implicit operator long(HCONVLIST value) => (long)(value.Value);

        public static explicit operator HCONVLIST(nint value) => new HCONVLIST((nint)(value));

        public static implicit operator nint(HCONVLIST value) => (nint)(value.Value);

        public static explicit operator HCONVLIST(sbyte value) => new HCONVLIST((nint)(value));

        public static explicit operator sbyte(HCONVLIST value) => (sbyte)(value.Value);

        public static explicit operator HCONVLIST(ushort value) => new HCONVLIST((nint)(value));

        public static explicit operator ushort(HCONVLIST value) => (ushort)(value.Value);

        public static explicit operator HCONVLIST(uint value) => new HCONVLIST((nint)(value));

        public static explicit operator uint(HCONVLIST value) => (uint)(value.Value);

        public static explicit operator HCONVLIST(ulong value) => new HCONVLIST((nint)(value));

        public static explicit operator ulong(HCONVLIST value) => (ulong)(value.Value);

        public static explicit operator HCONVLIST(nuint value) => new HCONVLIST((nint)(value));

        public static explicit operator nuint(HCONVLIST value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HCONVLIST other) && Equals(other);

        public bool Equals(HCONVLIST other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
