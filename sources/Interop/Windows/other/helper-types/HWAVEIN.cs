// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HWAVEIN : IEquatable<HWAVEIN>
    {
        public readonly nint Value;

        public HWAVEIN(nint value)
        {
            Value = value;
        }

        public static HWAVEIN INVALID_VALUE => new HWAVEIN(-1);

        public static HWAVEIN NULL => new HWAVEIN(0);

        public static bool operator ==(HWAVEIN left, HWAVEIN right) => left.Value == right.Value;

        public static bool operator !=(HWAVEIN left, HWAVEIN right) => left.Value != right.Value;

        public static explicit operator HWAVEIN(void* value) => new HWAVEIN((nint)(value));

        public static implicit operator void*(HWAVEIN value) => (void*)(value.Value);

        public static explicit operator HWAVEIN(HANDLE value) => new HWAVEIN(value);

        public static implicit operator HANDLE(HWAVEIN value) => new HWAVEIN(value);

        public static explicit operator HWAVEIN(byte value) => new HWAVEIN((nint)(value));

        public static explicit operator byte(HWAVEIN value) => (byte)(value.Value);

        public static explicit operator HWAVEIN(short value) => new HWAVEIN((nint)(value));

        public static explicit operator short(HWAVEIN value) => (short)(value.Value);

        public static explicit operator HWAVEIN(int value) => new HWAVEIN((nint)(value));

        public static explicit operator int(HWAVEIN value) => (int)(value.Value);

        public static explicit operator HWAVEIN(long value) => new HWAVEIN((nint)(value));

        public static implicit operator long(HWAVEIN value) => (long)(value.Value);

        public static explicit operator HWAVEIN(nint value) => new HWAVEIN((nint)(value));

        public static implicit operator nint(HWAVEIN value) => (nint)(value.Value);

        public static explicit operator HWAVEIN(sbyte value) => new HWAVEIN((nint)(value));

        public static explicit operator sbyte(HWAVEIN value) => (sbyte)(value.Value);

        public static explicit operator HWAVEIN(ushort value) => new HWAVEIN((nint)(value));

        public static explicit operator ushort(HWAVEIN value) => (ushort)(value.Value);

        public static explicit operator HWAVEIN(uint value) => new HWAVEIN((nint)(value));

        public static explicit operator uint(HWAVEIN value) => (uint)(value.Value);

        public static explicit operator HWAVEIN(ulong value) => new HWAVEIN((nint)(value));

        public static implicit operator ulong(HWAVEIN value) => (ulong)(value.Value);

        public static explicit operator HWAVEIN(nuint value) => new HWAVEIN((nint)(value));

        public static explicit operator nuint(HWAVEIN value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HWAVEIN other) && Equals(other);

        public bool Equals(HWAVEIN other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
