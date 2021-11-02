// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HFILTER_VOLUME : IEquatable<HFILTER_VOLUME>
    {
        public readonly nint Value;

        public HFILTER_VOLUME(nint value)
        {
            Value = value;
        }

        public static HFILTER_VOLUME INVALID_VALUE => new HFILTER_VOLUME(-1);

        public static HFILTER_VOLUME NULL => new HFILTER_VOLUME(0);

        public static bool operator ==(HFILTER_VOLUME left, HFILTER_VOLUME right) => left.Value == right.Value;

        public static bool operator !=(HFILTER_VOLUME left, HFILTER_VOLUME right) => left.Value != right.Value;

        public static explicit operator HFILTER_VOLUME(void* value) => new HFILTER_VOLUME((nint)(value));

        public static implicit operator void*(HFILTER_VOLUME value) => (void*)(value.Value);

        public static explicit operator HFILTER_VOLUME(HANDLE value) => new HFILTER_VOLUME(value);

        public static implicit operator HANDLE(HFILTER_VOLUME value) => new HFILTER_VOLUME(value);

        public static explicit operator HFILTER_VOLUME(byte value) => new HFILTER_VOLUME((nint)(value));

        public static explicit operator byte(HFILTER_VOLUME value) => (byte)(value.Value);

        public static explicit operator HFILTER_VOLUME(short value) => new HFILTER_VOLUME((nint)(value));

        public static explicit operator short(HFILTER_VOLUME value) => (short)(value.Value);

        public static explicit operator HFILTER_VOLUME(int value) => new HFILTER_VOLUME((nint)(value));

        public static explicit operator int(HFILTER_VOLUME value) => (int)(value.Value);

        public static explicit operator HFILTER_VOLUME(long value) => new HFILTER_VOLUME((nint)(value));

        public static implicit operator long(HFILTER_VOLUME value) => (long)(value.Value);

        public static explicit operator HFILTER_VOLUME(nint value) => new HFILTER_VOLUME((nint)(value));

        public static implicit operator nint(HFILTER_VOLUME value) => (nint)(value.Value);

        public static explicit operator HFILTER_VOLUME(sbyte value) => new HFILTER_VOLUME((nint)(value));

        public static explicit operator sbyte(HFILTER_VOLUME value) => (sbyte)(value.Value);

        public static explicit operator HFILTER_VOLUME(ushort value) => new HFILTER_VOLUME((nint)(value));

        public static explicit operator ushort(HFILTER_VOLUME value) => (ushort)(value.Value);

        public static explicit operator HFILTER_VOLUME(uint value) => new HFILTER_VOLUME((nint)(value));

        public static explicit operator uint(HFILTER_VOLUME value) => (uint)(value.Value);

        public static explicit operator HFILTER_VOLUME(ulong value) => new HFILTER_VOLUME((nint)(value));

        public static implicit operator ulong(HFILTER_VOLUME value) => (ulong)(value.Value);

        public static explicit operator HFILTER_VOLUME(nuint value) => new HFILTER_VOLUME((nint)(value));

        public static explicit operator nuint(HFILTER_VOLUME value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HFILTER_VOLUME other) && Equals(other);

        public bool Equals(HFILTER_VOLUME other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
