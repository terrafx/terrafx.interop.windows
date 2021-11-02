// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSPFILELOG : IEquatable<HSPFILELOG>
    {
        public readonly nint Value;

        public HSPFILELOG(nint value)
        {
            Value = value;
        }

        public static HSPFILELOG INVALID_VALUE => new HSPFILELOG(-1);

        public static HSPFILELOG NULL => new HSPFILELOG(0);

        public static bool operator ==(HSPFILELOG left, HSPFILELOG right) => left.Value == right.Value;

        public static bool operator !=(HSPFILELOG left, HSPFILELOG right) => left.Value != right.Value;

        public static explicit operator HSPFILELOG(void* value) => new HSPFILELOG((nint)(value));

        public static implicit operator void*(HSPFILELOG value) => (void*)(value.Value);

        public static explicit operator HSPFILELOG(HANDLE value) => new HSPFILELOG(value);

        public static implicit operator HANDLE(HSPFILELOG value) => new HANDLE(value.Value);

        public static explicit operator HSPFILELOG(byte value) => new HSPFILELOG((nint)(value));

        public static explicit operator byte(HSPFILELOG value) => (byte)(value.Value);

        public static explicit operator HSPFILELOG(short value) => new HSPFILELOG((nint)(value));

        public static explicit operator short(HSPFILELOG value) => (short)(value.Value);

        public static explicit operator HSPFILELOG(int value) => new HSPFILELOG((nint)(value));

        public static explicit operator int(HSPFILELOG value) => (int)(value.Value);

        public static explicit operator HSPFILELOG(long value) => new HSPFILELOG((nint)(value));

        public static implicit operator long(HSPFILELOG value) => (long)(value.Value);

        public static explicit operator HSPFILELOG(nint value) => new HSPFILELOG((nint)(value));

        public static implicit operator nint(HSPFILELOG value) => (nint)(value.Value);

        public static explicit operator HSPFILELOG(sbyte value) => new HSPFILELOG((nint)(value));

        public static explicit operator sbyte(HSPFILELOG value) => (sbyte)(value.Value);

        public static explicit operator HSPFILELOG(ushort value) => new HSPFILELOG((nint)(value));

        public static explicit operator ushort(HSPFILELOG value) => (ushort)(value.Value);

        public static explicit operator HSPFILELOG(uint value) => new HSPFILELOG((nint)(value));

        public static explicit operator uint(HSPFILELOG value) => (uint)(value.Value);

        public static explicit operator HSPFILELOG(ulong value) => new HSPFILELOG((nint)(value));

        public static explicit operator ulong(HSPFILELOG value) => (ulong)(value.Value);

        public static explicit operator HSPFILELOG(nuint value) => new HSPFILELOG((nint)(value));

        public static explicit operator nuint(HSPFILELOG value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HSPFILELOG other) && Equals(other);

        public bool Equals(HSPFILELOG other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
