// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HINSTANCE : IEquatable<HINSTANCE>
    {
        public readonly nint Value;

        public HINSTANCE(nint value)
        {
            Value = value;
        }

        public static HINSTANCE INVALID_HANDLE_VALUE => new HINSTANCE(-1);

        public static HINSTANCE NULL => new HINSTANCE(0);

        public static bool operator ==(HINSTANCE left, HINSTANCE right) => left.Value == right.Value;

        public static bool operator !=(HINSTANCE left, HINSTANCE right) => left.Value != right.Value;

        public static explicit operator HINSTANCE(void* value) => new HINSTANCE((nint)(value));

        public static implicit operator void*(HINSTANCE value) => (void*)(value.Value);

        public static explicit operator HINSTANCE(HANDLE value) => new HINSTANCE(value);

        public static implicit operator HANDLE(HINSTANCE value) => new HINSTANCE(value);

        public static explicit operator HINSTANCE(byte value) => new HINSTANCE((nint)(value));

        public static implicit operator byte(HINSTANCE value) => (byte)(value.Value);

        public static explicit operator HINSTANCE(short value) => new HINSTANCE((nint)(value));

        public static implicit operator short(HINSTANCE value) => (short)(value.Value);

        public static explicit operator HINSTANCE(int value) => new HINSTANCE((nint)(value));

        public static implicit operator int(HINSTANCE value) => (int)(value.Value);

        public static explicit operator HINSTANCE(long value) => new HINSTANCE((nint)(value));

        public static explicit operator long(HINSTANCE value) => (long)(value.Value);

        public static explicit operator HINSTANCE(nint value) => new HINSTANCE((nint)(value));

        public static implicit operator nint(HINSTANCE value) => (nint)(value.Value);

        public static explicit operator HINSTANCE(sbyte value) => new HINSTANCE((nint)(value));

        public static implicit operator sbyte(HINSTANCE value) => (sbyte)(value.Value);

        public static explicit operator HINSTANCE(ushort value) => new HINSTANCE((nint)(value));

        public static implicit operator ushort(HINSTANCE value) => (ushort)(value.Value);

        public static explicit operator HINSTANCE(uint value) => new HINSTANCE((nint)(value));

        public static implicit operator uint(HINSTANCE value) => (uint)(value.Value);

        public static explicit operator HINSTANCE(ulong value) => new HINSTANCE((nint)(value));

        public static explicit operator ulong(HINSTANCE value) => (ulong)(value.Value);

        public static explicit operator HINSTANCE(nuint value) => new HINSTANCE((nint)(value));

        public static explicit operator nuint(HINSTANCE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HINSTANCE other) && Equals(other);

        public bool Equals(HINSTANCE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
