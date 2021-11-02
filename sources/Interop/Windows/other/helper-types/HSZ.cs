// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSZ : IEquatable<HSZ>
    {
        public readonly nint Value;

        public HSZ(nint value)
        {
            Value = value;
        }

        public static HSZ INVALID_HANDLE_VALUE => new HSZ(-1);

        public static HSZ NULL => new HSZ(0);

        public static bool operator ==(HSZ left, HSZ right) => left.Value == right.Value;

        public static bool operator !=(HSZ left, HSZ right) => left.Value != right.Value;

        public static explicit operator HSZ(void* value) => new HSZ((nint)(value));

        public static implicit operator void*(HSZ value) => (void*)(value.Value);

        public static explicit operator HSZ(HANDLE value) => new HSZ(value);

        public static implicit operator HANDLE(HSZ value) => new HSZ(value);

        public static explicit operator HSZ(byte value) => new HSZ((nint)(value));

        public static explicit operator byte(HSZ value) => (byte)(value.Value);

        public static explicit operator HSZ(short value) => new HSZ((nint)(value));

        public static explicit operator short(HSZ value) => (short)(value.Value);

        public static explicit operator HSZ(int value) => new HSZ((nint)(value));

        public static explicit operator int(HSZ value) => (int)(value.Value);

        public static explicit operator HSZ(long value) => new HSZ((nint)(value));

        public static implicit operator long(HSZ value) => (long)(value.Value);

        public static explicit operator HSZ(nint value) => new HSZ((nint)(value));

        public static implicit operator nint(HSZ value) => (nint)(value.Value);

        public static explicit operator HSZ(sbyte value) => new HSZ((nint)(value));

        public static explicit operator sbyte(HSZ value) => (sbyte)(value.Value);

        public static explicit operator HSZ(ushort value) => new HSZ((nint)(value));

        public static explicit operator ushort(HSZ value) => (ushort)(value.Value);

        public static explicit operator HSZ(uint value) => new HSZ((nint)(value));

        public static explicit operator uint(HSZ value) => (uint)(value.Value);

        public static explicit operator HSZ(ulong value) => new HSZ((nint)(value));

        public static implicit operator ulong(HSZ value) => (ulong)(value.Value);

        public static explicit operator HSZ(nuint value) => new HSZ((nint)(value));

        public static explicit operator nuint(HSZ value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HSZ other) && Equals(other);

        public bool Equals(HSZ other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
