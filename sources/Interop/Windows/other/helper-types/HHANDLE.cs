// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HHANDLE : IEquatable<HHANDLE>
    {
        public readonly nint Value;

        public HHANDLE(nint value)
        {
            Value = value;
        }

        public static HHANDLE INVALID_HANDLE_VALUE => new HHANDLE(-1);

        public static HHANDLE NULL => new HHANDLE(0);

        public static bool operator ==(HHANDLE left, HHANDLE right) => left.Value == right.Value;

        public static bool operator !=(HHANDLE left, HHANDLE right) => left.Value != right.Value;

        public static explicit operator HHANDLE(void* value) => new HHANDLE((nint)(value));

        public static implicit operator void*(HHANDLE value) => (void*)(value.Value);

        public static explicit operator HHANDLE(HANDLE value) => new HHANDLE(value);

        public static implicit operator HANDLE(HHANDLE value) => new HHANDLE(value);

        public static explicit operator HHANDLE(byte value) => new HHANDLE((nint)(value));

        public static explicit operator byte(HHANDLE value) => (byte)(value.Value);

        public static explicit operator HHANDLE(short value) => new HHANDLE((nint)(value));

        public static explicit operator short(HHANDLE value) => (short)(value.Value);

        public static explicit operator HHANDLE(int value) => new HHANDLE((nint)(value));

        public static explicit operator int(HHANDLE value) => (int)(value.Value);

        public static explicit operator HHANDLE(long value) => new HHANDLE((nint)(value));

        public static implicit operator long(HHANDLE value) => (long)(value.Value);

        public static explicit operator HHANDLE(nint value) => new HHANDLE((nint)(value));

        public static implicit operator nint(HHANDLE value) => (nint)(value.Value);

        public static explicit operator HHANDLE(sbyte value) => new HHANDLE((nint)(value));

        public static explicit operator sbyte(HHANDLE value) => (sbyte)(value.Value);

        public static explicit operator HHANDLE(ushort value) => new HHANDLE((nint)(value));

        public static explicit operator ushort(HHANDLE value) => (ushort)(value.Value);

        public static explicit operator HHANDLE(uint value) => new HHANDLE((nint)(value));

        public static explicit operator uint(HHANDLE value) => (uint)(value.Value);

        public static explicit operator HHANDLE(ulong value) => new HHANDLE((nint)(value));

        public static implicit operator ulong(HHANDLE value) => (ulong)(value.Value);

        public static explicit operator HHANDLE(nuint value) => new HHANDLE((nint)(value));

        public static explicit operator nuint(HHANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HHANDLE other) && Equals(other);

        public bool Equals(HHANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
