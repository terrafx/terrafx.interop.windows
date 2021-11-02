// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PAPPSTATE_REGISTRATION : IEquatable<PAPPSTATE_REGISTRATION>
    {
        public readonly nint Value;

        public PAPPSTATE_REGISTRATION(nint value)
        {
            Value = value;
        }

        public static PAPPSTATE_REGISTRATION NULL => new PAPPSTATE_REGISTRATION(0);

        public static bool operator ==(PAPPSTATE_REGISTRATION left, PAPPSTATE_REGISTRATION right) => left.Value == right.Value;

        public static bool operator !=(PAPPSTATE_REGISTRATION left, PAPPSTATE_REGISTRATION right) => left.Value != right.Value;

        public static explicit operator PAPPSTATE_REGISTRATION(void* value) => new PAPPSTATE_REGISTRATION((nint)(value));

        public static implicit operator void*(PAPPSTATE_REGISTRATION value) => (void*)(value.Value);

        public static explicit operator PAPPSTATE_REGISTRATION(byte value) => new PAPPSTATE_REGISTRATION((nint)(value));

        public static explicit operator byte(PAPPSTATE_REGISTRATION value) => (byte)(value.Value);

        public static explicit operator PAPPSTATE_REGISTRATION(short value) => new PAPPSTATE_REGISTRATION((nint)(value));

        public static explicit operator short(PAPPSTATE_REGISTRATION value) => (short)(value.Value);

        public static explicit operator PAPPSTATE_REGISTRATION(int value) => new PAPPSTATE_REGISTRATION((nint)(value));

        public static explicit operator int(PAPPSTATE_REGISTRATION value) => (int)(value.Value);

        public static explicit operator PAPPSTATE_REGISTRATION(long value) => new PAPPSTATE_REGISTRATION((nint)(value));

        public static implicit operator long(PAPPSTATE_REGISTRATION value) => (long)(value.Value);

        public static explicit operator PAPPSTATE_REGISTRATION(nint value) => new PAPPSTATE_REGISTRATION((nint)(value));

        public static implicit operator nint(PAPPSTATE_REGISTRATION value) => (nint)(value.Value);

        public static explicit operator PAPPSTATE_REGISTRATION(sbyte value) => new PAPPSTATE_REGISTRATION((nint)(value));

        public static explicit operator sbyte(PAPPSTATE_REGISTRATION value) => (sbyte)(value.Value);

        public static explicit operator PAPPSTATE_REGISTRATION(ushort value) => new PAPPSTATE_REGISTRATION((nint)(value));

        public static explicit operator ushort(PAPPSTATE_REGISTRATION value) => (ushort)(value.Value);

        public static explicit operator PAPPSTATE_REGISTRATION(uint value) => new PAPPSTATE_REGISTRATION((nint)(value));

        public static explicit operator uint(PAPPSTATE_REGISTRATION value) => (uint)(value.Value);

        public static explicit operator PAPPSTATE_REGISTRATION(ulong value) => new PAPPSTATE_REGISTRATION((nint)(value));

        public static implicit operator ulong(PAPPSTATE_REGISTRATION value) => (ulong)(value.Value);

        public static explicit operator PAPPSTATE_REGISTRATION(nuint value) => new PAPPSTATE_REGISTRATION((nint)(value));

        public static explicit operator nuint(PAPPSTATE_REGISTRATION value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is PAPPSTATE_REGISTRATION other) && Equals(other);

        public bool Equals(PAPPSTATE_REGISTRATION other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
