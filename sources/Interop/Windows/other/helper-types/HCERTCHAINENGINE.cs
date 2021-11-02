// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCERTCHAINENGINE : IEquatable<HCERTCHAINENGINE>
    {
        public readonly nint Value;

        public HCERTCHAINENGINE(nint value)
        {
            Value = value;
        }

        public static HCERTCHAINENGINE INVALID_VALUE => new HCERTCHAINENGINE(-1);

        public static HCERTCHAINENGINE NULL => new HCERTCHAINENGINE(0);

        public static bool operator ==(HCERTCHAINENGINE left, HCERTCHAINENGINE right) => left.Value == right.Value;

        public static bool operator !=(HCERTCHAINENGINE left, HCERTCHAINENGINE right) => left.Value != right.Value;

        public static explicit operator HCERTCHAINENGINE(void* value) => new HCERTCHAINENGINE((nint)(value));

        public static implicit operator void*(HCERTCHAINENGINE value) => (void*)(value.Value);

        public static explicit operator HCERTCHAINENGINE(HANDLE value) => new HCERTCHAINENGINE(value);

        public static implicit operator HANDLE(HCERTCHAINENGINE value) => new HCERTCHAINENGINE(value);

        public static explicit operator HCERTCHAINENGINE(byte value) => new HCERTCHAINENGINE((nint)(value));

        public static explicit operator byte(HCERTCHAINENGINE value) => (byte)(value.Value);

        public static explicit operator HCERTCHAINENGINE(short value) => new HCERTCHAINENGINE((nint)(value));

        public static explicit operator short(HCERTCHAINENGINE value) => (short)(value.Value);

        public static explicit operator HCERTCHAINENGINE(int value) => new HCERTCHAINENGINE((nint)(value));

        public static explicit operator int(HCERTCHAINENGINE value) => (int)(value.Value);

        public static explicit operator HCERTCHAINENGINE(long value) => new HCERTCHAINENGINE((nint)(value));

        public static implicit operator long(HCERTCHAINENGINE value) => (long)(value.Value);

        public static explicit operator HCERTCHAINENGINE(nint value) => new HCERTCHAINENGINE((nint)(value));

        public static implicit operator nint(HCERTCHAINENGINE value) => (nint)(value.Value);

        public static explicit operator HCERTCHAINENGINE(sbyte value) => new HCERTCHAINENGINE((nint)(value));

        public static explicit operator sbyte(HCERTCHAINENGINE value) => (sbyte)(value.Value);

        public static explicit operator HCERTCHAINENGINE(ushort value) => new HCERTCHAINENGINE((nint)(value));

        public static explicit operator ushort(HCERTCHAINENGINE value) => (ushort)(value.Value);

        public static explicit operator HCERTCHAINENGINE(uint value) => new HCERTCHAINENGINE((nint)(value));

        public static explicit operator uint(HCERTCHAINENGINE value) => (uint)(value.Value);

        public static explicit operator HCERTCHAINENGINE(ulong value) => new HCERTCHAINENGINE((nint)(value));

        public static explicit operator ulong(HCERTCHAINENGINE value) => (ulong)(value.Value);

        public static explicit operator HCERTCHAINENGINE(nuint value) => new HCERTCHAINENGINE((nint)(value));

        public static explicit operator nuint(HCERTCHAINENGINE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HCERTCHAINENGINE other) && Equals(other);

        public bool Equals(HCERTCHAINENGINE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
