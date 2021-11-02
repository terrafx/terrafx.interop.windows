// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HACMDRIVER : IEquatable<HACMDRIVER>
    {
        public readonly nint Value;

        public HACMDRIVER(nint value)
        {
            Value = value;
        }

        public static HACMDRIVER INVALID_HANDLE_VALUE => new HACMDRIVER(-1);

        public static HACMDRIVER NULL => new HACMDRIVER(0);

        public static bool operator ==(HACMDRIVER left, HACMDRIVER right) => left.Value == right.Value;

        public static bool operator !=(HACMDRIVER left, HACMDRIVER right) => left.Value != right.Value;

        public static explicit operator HACMDRIVER(void* value) => new HACMDRIVER((nint)(value));

        public static implicit operator void*(HACMDRIVER value) => (void*)(value.Value);

        public static explicit operator HACMDRIVER(HANDLE value) => new HACMDRIVER(value);

        public static implicit operator HANDLE(HACMDRIVER value) => new HACMDRIVER(value);

        public static explicit operator HACMDRIVER(byte value) => new HACMDRIVER((nint)(value));

        public static implicit operator byte(HACMDRIVER value) => (byte)(value.Value);

        public static explicit operator HACMDRIVER(short value) => new HACMDRIVER((nint)(value));

        public static implicit operator short(HACMDRIVER value) => (short)(value.Value);

        public static explicit operator HACMDRIVER(int value) => new HACMDRIVER((nint)(value));

        public static implicit operator int(HACMDRIVER value) => (int)(value.Value);

        public static explicit operator HACMDRIVER(long value) => new HACMDRIVER((nint)(value));

        public static explicit operator long(HACMDRIVER value) => (long)(value.Value);

        public static explicit operator HACMDRIVER(nint value) => new HACMDRIVER((nint)(value));

        public static implicit operator nint(HACMDRIVER value) => (nint)(value.Value);

        public static explicit operator HACMDRIVER(sbyte value) => new HACMDRIVER((nint)(value));

        public static implicit operator sbyte(HACMDRIVER value) => (sbyte)(value.Value);

        public static explicit operator HACMDRIVER(ushort value) => new HACMDRIVER((nint)(value));

        public static implicit operator ushort(HACMDRIVER value) => (ushort)(value.Value);

        public static explicit operator HACMDRIVER(uint value) => new HACMDRIVER((nint)(value));

        public static implicit operator uint(HACMDRIVER value) => (uint)(value.Value);

        public static explicit operator HACMDRIVER(ulong value) => new HACMDRIVER((nint)(value));

        public static explicit operator ulong(HACMDRIVER value) => (ulong)(value.Value);

        public static explicit operator HACMDRIVER(nuint value) => new HACMDRIVER((nint)(value));

        public static explicit operator nuint(HACMDRIVER value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HACMDRIVER other) && Equals(other);

        public bool Equals(HACMDRIVER other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
