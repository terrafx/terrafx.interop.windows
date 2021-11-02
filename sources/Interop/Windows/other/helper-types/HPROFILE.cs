// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HPROFILE : IEquatable<HPROFILE>
    {
        public readonly nint Value;

        public HPROFILE(nint value)
        {
            Value = value;
        }

        public static HPROFILE INVALID_VALUE => new HPROFILE(-1);

        public static HPROFILE NULL => new HPROFILE(0);

        public static bool operator ==(HPROFILE left, HPROFILE right) => left.Value == right.Value;

        public static bool operator !=(HPROFILE left, HPROFILE right) => left.Value != right.Value;

        public static explicit operator HPROFILE(void* value) => new HPROFILE((nint)(value));

        public static implicit operator void*(HPROFILE value) => (void*)(value.Value);

        public static explicit operator HPROFILE(HANDLE value) => new HPROFILE(value);

        public static implicit operator HANDLE(HPROFILE value) => new HANDLE(value.Value);

        public static explicit operator HPROFILE(byte value) => new HPROFILE((nint)(value));

        public static explicit operator byte(HPROFILE value) => (byte)(value.Value);

        public static explicit operator HPROFILE(short value) => new HPROFILE((nint)(value));

        public static explicit operator short(HPROFILE value) => (short)(value.Value);

        public static explicit operator HPROFILE(int value) => new HPROFILE((nint)(value));

        public static explicit operator int(HPROFILE value) => (int)(value.Value);

        public static explicit operator HPROFILE(long value) => new HPROFILE((nint)(value));

        public static implicit operator long(HPROFILE value) => (long)(value.Value);

        public static explicit operator HPROFILE(nint value) => new HPROFILE((nint)(value));

        public static implicit operator nint(HPROFILE value) => (nint)(value.Value);

        public static explicit operator HPROFILE(sbyte value) => new HPROFILE((nint)(value));

        public static explicit operator sbyte(HPROFILE value) => (sbyte)(value.Value);

        public static explicit operator HPROFILE(ushort value) => new HPROFILE((nint)(value));

        public static explicit operator ushort(HPROFILE value) => (ushort)(value.Value);

        public static explicit operator HPROFILE(uint value) => new HPROFILE((nint)(value));

        public static explicit operator uint(HPROFILE value) => (uint)(value.Value);

        public static explicit operator HPROFILE(ulong value) => new HPROFILE((nint)(value));

        public static explicit operator ulong(HPROFILE value) => (ulong)(value.Value);

        public static explicit operator HPROFILE(nuint value) => new HPROFILE((nint)(value));

        public static explicit operator nuint(HPROFILE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HPROFILE other) && Equals(other);

        public bool Equals(HPROFILE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
