// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PHIDP_PREPARSED_DATA : IEquatable<PHIDP_PREPARSED_DATA>
    {
        public readonly nint Value;

        public PHIDP_PREPARSED_DATA(nint value)
        {
            Value = value;
        }

        public static PHIDP_PREPARSED_DATA NULL => new PHIDP_PREPARSED_DATA(0);

        public static bool operator ==(PHIDP_PREPARSED_DATA left, PHIDP_PREPARSED_DATA right) => left.Value == right.Value;

        public static bool operator !=(PHIDP_PREPARSED_DATA left, PHIDP_PREPARSED_DATA right) => left.Value != right.Value;

        public static explicit operator PHIDP_PREPARSED_DATA(void* value) => new PHIDP_PREPARSED_DATA((nint)(value));

        public static implicit operator void*(PHIDP_PREPARSED_DATA value) => (void*)(value.Value);

        public static explicit operator PHIDP_PREPARSED_DATA(byte value) => new PHIDP_PREPARSED_DATA((nint)(value));

        public static explicit operator byte(PHIDP_PREPARSED_DATA value) => (byte)(value.Value);

        public static explicit operator PHIDP_PREPARSED_DATA(short value) => new PHIDP_PREPARSED_DATA((nint)(value));

        public static explicit operator short(PHIDP_PREPARSED_DATA value) => (short)(value.Value);

        public static explicit operator PHIDP_PREPARSED_DATA(int value) => new PHIDP_PREPARSED_DATA((nint)(value));

        public static explicit operator int(PHIDP_PREPARSED_DATA value) => (int)(value.Value);

        public static explicit operator PHIDP_PREPARSED_DATA(long value) => new PHIDP_PREPARSED_DATA((nint)(value));

        public static implicit operator long(PHIDP_PREPARSED_DATA value) => (long)(value.Value);

        public static explicit operator PHIDP_PREPARSED_DATA(nint value) => new PHIDP_PREPARSED_DATA((nint)(value));

        public static implicit operator nint(PHIDP_PREPARSED_DATA value) => (nint)(value.Value);

        public static explicit operator PHIDP_PREPARSED_DATA(sbyte value) => new PHIDP_PREPARSED_DATA((nint)(value));

        public static explicit operator sbyte(PHIDP_PREPARSED_DATA value) => (sbyte)(value.Value);

        public static explicit operator PHIDP_PREPARSED_DATA(ushort value) => new PHIDP_PREPARSED_DATA((nint)(value));

        public static explicit operator ushort(PHIDP_PREPARSED_DATA value) => (ushort)(value.Value);

        public static explicit operator PHIDP_PREPARSED_DATA(uint value) => new PHIDP_PREPARSED_DATA((nint)(value));

        public static explicit operator uint(PHIDP_PREPARSED_DATA value) => (uint)(value.Value);

        public static explicit operator PHIDP_PREPARSED_DATA(ulong value) => new PHIDP_PREPARSED_DATA((nint)(value));

        public static implicit operator ulong(PHIDP_PREPARSED_DATA value) => (ulong)(value.Value);

        public static explicit operator PHIDP_PREPARSED_DATA(nuint value) => new PHIDP_PREPARSED_DATA((nint)(value));

        public static explicit operator nuint(PHIDP_PREPARSED_DATA value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is PHIDP_PREPARSED_DATA other) && Equals(other);

        public bool Equals(PHIDP_PREPARSED_DATA other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
