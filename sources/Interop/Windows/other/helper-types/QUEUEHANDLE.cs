// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct QUEUEHANDLE : IEquatable<QUEUEHANDLE>
    {
        public readonly nint Value;

        public QUEUEHANDLE(nint value)
        {
            Value = value;
        }

        public static QUEUEHANDLE INVALID_VALUE => new QUEUEHANDLE(-1);

        public static QUEUEHANDLE NULL => new QUEUEHANDLE(0);

        public static bool operator ==(QUEUEHANDLE left, QUEUEHANDLE right) => left.Value == right.Value;

        public static bool operator !=(QUEUEHANDLE left, QUEUEHANDLE right) => left.Value != right.Value;

        public static explicit operator QUEUEHANDLE(void* value) => new QUEUEHANDLE((nint)(value));

        public static implicit operator void*(QUEUEHANDLE value) => (void*)(value.Value);

        public static explicit operator QUEUEHANDLE(HANDLE value) => new QUEUEHANDLE(value);

        public static implicit operator HANDLE(QUEUEHANDLE value) => new HANDLE(value.Value);

        public static explicit operator QUEUEHANDLE(byte value) => new QUEUEHANDLE((nint)(value));

        public static explicit operator byte(QUEUEHANDLE value) => (byte)(value.Value);

        public static explicit operator QUEUEHANDLE(short value) => new QUEUEHANDLE((nint)(value));

        public static explicit operator short(QUEUEHANDLE value) => (short)(value.Value);

        public static explicit operator QUEUEHANDLE(int value) => new QUEUEHANDLE((nint)(value));

        public static explicit operator int(QUEUEHANDLE value) => (int)(value.Value);

        public static explicit operator QUEUEHANDLE(long value) => new QUEUEHANDLE((nint)(value));

        public static implicit operator long(QUEUEHANDLE value) => (long)(value.Value);

        public static explicit operator QUEUEHANDLE(nint value) => new QUEUEHANDLE((nint)(value));

        public static implicit operator nint(QUEUEHANDLE value) => (nint)(value.Value);

        public static explicit operator QUEUEHANDLE(sbyte value) => new QUEUEHANDLE((nint)(value));

        public static explicit operator sbyte(QUEUEHANDLE value) => (sbyte)(value.Value);

        public static explicit operator QUEUEHANDLE(ushort value) => new QUEUEHANDLE((nint)(value));

        public static explicit operator ushort(QUEUEHANDLE value) => (ushort)(value.Value);

        public static explicit operator QUEUEHANDLE(uint value) => new QUEUEHANDLE((nint)(value));

        public static explicit operator uint(QUEUEHANDLE value) => (uint)(value.Value);

        public static explicit operator QUEUEHANDLE(ulong value) => new QUEUEHANDLE((nint)(value));

        public static explicit operator ulong(QUEUEHANDLE value) => (ulong)(value.Value);

        public static explicit operator QUEUEHANDLE(nuint value) => new QUEUEHANDLE((nint)(value));

        public static explicit operator nuint(QUEUEHANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is QUEUEHANDLE other) && Equals(other);

        public bool Equals(QUEUEHANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
