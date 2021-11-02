// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSPFILEQ : IEquatable<HSPFILEQ>
    {
        public readonly nint Value;

        public HSPFILEQ(nint value)
        {
            Value = value;
        }

        public static HSPFILEQ INVALID_VALUE => new HSPFILEQ(-1);

        public static HSPFILEQ NULL => new HSPFILEQ(0);

        public static bool operator ==(HSPFILEQ left, HSPFILEQ right) => left.Value == right.Value;

        public static bool operator !=(HSPFILEQ left, HSPFILEQ right) => left.Value != right.Value;

        public static explicit operator HSPFILEQ(void* value) => new HSPFILEQ((nint)(value));

        public static implicit operator void*(HSPFILEQ value) => (void*)(value.Value);

        public static explicit operator HSPFILEQ(HANDLE value) => new HSPFILEQ(value);

        public static implicit operator HANDLE(HSPFILEQ value) => new HSPFILEQ(value);

        public static explicit operator HSPFILEQ(byte value) => new HSPFILEQ((nint)(value));

        public static explicit operator byte(HSPFILEQ value) => (byte)(value.Value);

        public static explicit operator HSPFILEQ(short value) => new HSPFILEQ((nint)(value));

        public static explicit operator short(HSPFILEQ value) => (short)(value.Value);

        public static explicit operator HSPFILEQ(int value) => new HSPFILEQ((nint)(value));

        public static explicit operator int(HSPFILEQ value) => (int)(value.Value);

        public static explicit operator HSPFILEQ(long value) => new HSPFILEQ((nint)(value));

        public static implicit operator long(HSPFILEQ value) => (long)(value.Value);

        public static explicit operator HSPFILEQ(nint value) => new HSPFILEQ((nint)(value));

        public static implicit operator nint(HSPFILEQ value) => (nint)(value.Value);

        public static explicit operator HSPFILEQ(sbyte value) => new HSPFILEQ((nint)(value));

        public static explicit operator sbyte(HSPFILEQ value) => (sbyte)(value.Value);

        public static explicit operator HSPFILEQ(ushort value) => new HSPFILEQ((nint)(value));

        public static explicit operator ushort(HSPFILEQ value) => (ushort)(value.Value);

        public static explicit operator HSPFILEQ(uint value) => new HSPFILEQ((nint)(value));

        public static explicit operator uint(HSPFILEQ value) => (uint)(value.Value);

        public static explicit operator HSPFILEQ(ulong value) => new HSPFILEQ((nint)(value));

        public static implicit operator ulong(HSPFILEQ value) => (ulong)(value.Value);

        public static explicit operator HSPFILEQ(nuint value) => new HSPFILEQ((nint)(value));

        public static explicit operator nuint(HSPFILEQ value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HSPFILEQ other) && Equals(other);

        public bool Equals(HSPFILEQ other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
