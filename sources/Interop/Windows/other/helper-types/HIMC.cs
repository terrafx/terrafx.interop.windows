// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HIMC : IEquatable<HIMC>
    {
        public readonly nint Value;

        public HIMC(nint value)
        {
            Value = value;
        }

        public static HIMC INVALID_HANDLE_VALUE => new HIMC(-1);

        public static HIMC NULL => new HIMC(0);

        public static bool operator ==(HIMC left, HIMC right) => left.Value == right.Value;

        public static bool operator !=(HIMC left, HIMC right) => left.Value != right.Value;

        public static explicit operator HIMC(void* value) => new HIMC((nint)(value));

        public static implicit operator void*(HIMC value) => (void*)(value.Value);

        public static explicit operator HIMC(HANDLE value) => new HIMC(value);

        public static implicit operator HANDLE(HIMC value) => new HIMC(value);

        public static explicit operator HIMC(byte value) => new HIMC((nint)(value));

        public static implicit operator byte(HIMC value) => (byte)(value.Value);

        public static explicit operator HIMC(short value) => new HIMC((nint)(value));

        public static implicit operator short(HIMC value) => (short)(value.Value);

        public static explicit operator HIMC(int value) => new HIMC((nint)(value));

        public static implicit operator int(HIMC value) => (int)(value.Value);

        public static explicit operator HIMC(long value) => new HIMC((nint)(value));

        public static explicit operator long(HIMC value) => (long)(value.Value);

        public static explicit operator HIMC(nint value) => new HIMC((nint)(value));

        public static implicit operator nint(HIMC value) => (nint)(value.Value);

        public static explicit operator HIMC(sbyte value) => new HIMC((nint)(value));

        public static implicit operator sbyte(HIMC value) => (sbyte)(value.Value);

        public static explicit operator HIMC(ushort value) => new HIMC((nint)(value));

        public static implicit operator ushort(HIMC value) => (ushort)(value.Value);

        public static explicit operator HIMC(uint value) => new HIMC((nint)(value));

        public static implicit operator uint(HIMC value) => (uint)(value.Value);

        public static explicit operator HIMC(ulong value) => new HIMC((nint)(value));

        public static explicit operator ulong(HIMC value) => (ulong)(value.Value);

        public static explicit operator HIMC(nuint value) => new HIMC((nint)(value));

        public static explicit operator nuint(HIMC value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HIMC other) && Equals(other);

        public bool Equals(HIMC other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
