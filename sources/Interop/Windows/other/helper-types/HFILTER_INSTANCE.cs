// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HFILTER_INSTANCE : IEquatable<HFILTER_INSTANCE>
    {
        public readonly nint Value;

        public HFILTER_INSTANCE(nint value)
        {
            Value = value;
        }

        public static HFILTER_INSTANCE INVALID_VALUE => new HFILTER_INSTANCE(-1);

        public static HFILTER_INSTANCE NULL => new HFILTER_INSTANCE(0);

        public static bool operator ==(HFILTER_INSTANCE left, HFILTER_INSTANCE right) => left.Value == right.Value;

        public static bool operator !=(HFILTER_INSTANCE left, HFILTER_INSTANCE right) => left.Value != right.Value;

        public static explicit operator HFILTER_INSTANCE(void* value) => new HFILTER_INSTANCE((nint)(value));

        public static implicit operator void*(HFILTER_INSTANCE value) => (void*)(value.Value);

        public static explicit operator HFILTER_INSTANCE(HANDLE value) => new HFILTER_INSTANCE(value);

        public static implicit operator HANDLE(HFILTER_INSTANCE value) => new HANDLE(value.Value);

        public static explicit operator HFILTER_INSTANCE(byte value) => new HFILTER_INSTANCE((nint)(value));

        public static explicit operator byte(HFILTER_INSTANCE value) => (byte)(value.Value);

        public static explicit operator HFILTER_INSTANCE(short value) => new HFILTER_INSTANCE((nint)(value));

        public static explicit operator short(HFILTER_INSTANCE value) => (short)(value.Value);

        public static explicit operator HFILTER_INSTANCE(int value) => new HFILTER_INSTANCE((nint)(value));

        public static explicit operator int(HFILTER_INSTANCE value) => (int)(value.Value);

        public static explicit operator HFILTER_INSTANCE(long value) => new HFILTER_INSTANCE((nint)(value));

        public static implicit operator long(HFILTER_INSTANCE value) => (long)(value.Value);

        public static explicit operator HFILTER_INSTANCE(nint value) => new HFILTER_INSTANCE((nint)(value));

        public static implicit operator nint(HFILTER_INSTANCE value) => (nint)(value.Value);

        public static explicit operator HFILTER_INSTANCE(sbyte value) => new HFILTER_INSTANCE((nint)(value));

        public static explicit operator sbyte(HFILTER_INSTANCE value) => (sbyte)(value.Value);

        public static explicit operator HFILTER_INSTANCE(ushort value) => new HFILTER_INSTANCE((nint)(value));

        public static explicit operator ushort(HFILTER_INSTANCE value) => (ushort)(value.Value);

        public static explicit operator HFILTER_INSTANCE(uint value) => new HFILTER_INSTANCE((nint)(value));

        public static explicit operator uint(HFILTER_INSTANCE value) => (uint)(value.Value);

        public static explicit operator HFILTER_INSTANCE(ulong value) => new HFILTER_INSTANCE((nint)(value));

        public static explicit operator ulong(HFILTER_INSTANCE value) => (ulong)(value.Value);

        public static explicit operator HFILTER_INSTANCE(nuint value) => new HFILTER_INSTANCE((nint)(value));

        public static explicit operator nuint(HFILTER_INSTANCE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HFILTER_INSTANCE other) && Equals(other);

        public bool Equals(HFILTER_INSTANCE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
