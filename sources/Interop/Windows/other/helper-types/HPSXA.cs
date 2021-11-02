// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HPSXA : IEquatable<HPSXA>
    {
        public readonly nint Value;

        public HPSXA(nint value)
        {
            Value = value;
        }

        public static HPSXA INVALID_VALUE => new HPSXA(-1);

        public static HPSXA NULL => new HPSXA(0);

        public static bool operator ==(HPSXA left, HPSXA right) => left.Value == right.Value;

        public static bool operator !=(HPSXA left, HPSXA right) => left.Value != right.Value;

        public static explicit operator HPSXA(void* value) => new HPSXA((nint)(value));

        public static implicit operator void*(HPSXA value) => (void*)(value.Value);

        public static explicit operator HPSXA(HANDLE value) => new HPSXA(value);

        public static implicit operator HANDLE(HPSXA value) => new HANDLE(value.Value);

        public static explicit operator HPSXA(byte value) => new HPSXA((nint)(value));

        public static explicit operator byte(HPSXA value) => (byte)(value.Value);

        public static explicit operator HPSXA(short value) => new HPSXA((nint)(value));

        public static explicit operator short(HPSXA value) => (short)(value.Value);

        public static explicit operator HPSXA(int value) => new HPSXA((nint)(value));

        public static explicit operator int(HPSXA value) => (int)(value.Value);

        public static explicit operator HPSXA(long value) => new HPSXA((nint)(value));

        public static implicit operator long(HPSXA value) => (long)(value.Value);

        public static explicit operator HPSXA(nint value) => new HPSXA((nint)(value));

        public static implicit operator nint(HPSXA value) => (nint)(value.Value);

        public static explicit operator HPSXA(sbyte value) => new HPSXA((nint)(value));

        public static explicit operator sbyte(HPSXA value) => (sbyte)(value.Value);

        public static explicit operator HPSXA(ushort value) => new HPSXA((nint)(value));

        public static explicit operator ushort(HPSXA value) => (ushort)(value.Value);

        public static explicit operator HPSXA(uint value) => new HPSXA((nint)(value));

        public static explicit operator uint(HPSXA value) => (uint)(value.Value);

        public static explicit operator HPSXA(ulong value) => new HPSXA((nint)(value));

        public static explicit operator ulong(HPSXA value) => (ulong)(value.Value);

        public static explicit operator HPSXA(nuint value) => new HPSXA((nint)(value));

        public static explicit operator nuint(HPSXA value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HPSXA other) && Equals(other);

        public bool Equals(HPSXA other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
