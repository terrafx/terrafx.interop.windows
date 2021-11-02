// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSNMP_VBL : IEquatable<HSNMP_VBL>
    {
        public readonly nint Value;

        public HSNMP_VBL(nint value)
        {
            Value = value;
        }

        public static HSNMP_VBL INVALID_VALUE => new HSNMP_VBL(-1);

        public static HSNMP_VBL NULL => new HSNMP_VBL(0);

        public static bool operator ==(HSNMP_VBL left, HSNMP_VBL right) => left.Value == right.Value;

        public static bool operator !=(HSNMP_VBL left, HSNMP_VBL right) => left.Value != right.Value;

        public static explicit operator HSNMP_VBL(void* value) => new HSNMP_VBL((nint)(value));

        public static implicit operator void*(HSNMP_VBL value) => (void*)(value.Value);

        public static explicit operator HSNMP_VBL(HANDLE value) => new HSNMP_VBL(value);

        public static implicit operator HANDLE(HSNMP_VBL value) => new HSNMP_VBL(value);

        public static explicit operator HSNMP_VBL(byte value) => new HSNMP_VBL((nint)(value));

        public static explicit operator byte(HSNMP_VBL value) => (byte)(value.Value);

        public static explicit operator HSNMP_VBL(short value) => new HSNMP_VBL((nint)(value));

        public static explicit operator short(HSNMP_VBL value) => (short)(value.Value);

        public static explicit operator HSNMP_VBL(int value) => new HSNMP_VBL((nint)(value));

        public static explicit operator int(HSNMP_VBL value) => (int)(value.Value);

        public static explicit operator HSNMP_VBL(long value) => new HSNMP_VBL((nint)(value));

        public static implicit operator long(HSNMP_VBL value) => (long)(value.Value);

        public static explicit operator HSNMP_VBL(nint value) => new HSNMP_VBL((nint)(value));

        public static implicit operator nint(HSNMP_VBL value) => (nint)(value.Value);

        public static explicit operator HSNMP_VBL(sbyte value) => new HSNMP_VBL((nint)(value));

        public static explicit operator sbyte(HSNMP_VBL value) => (sbyte)(value.Value);

        public static explicit operator HSNMP_VBL(ushort value) => new HSNMP_VBL((nint)(value));

        public static explicit operator ushort(HSNMP_VBL value) => (ushort)(value.Value);

        public static explicit operator HSNMP_VBL(uint value) => new HSNMP_VBL((nint)(value));

        public static explicit operator uint(HSNMP_VBL value) => (uint)(value.Value);

        public static explicit operator HSNMP_VBL(ulong value) => new HSNMP_VBL((nint)(value));

        public static implicit operator ulong(HSNMP_VBL value) => (ulong)(value.Value);

        public static explicit operator HSNMP_VBL(nuint value) => new HSNMP_VBL((nint)(value));

        public static explicit operator nuint(HSNMP_VBL value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HSNMP_VBL other) && Equals(other);

        public bool Equals(HSNMP_VBL other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
