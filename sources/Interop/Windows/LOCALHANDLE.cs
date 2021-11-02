// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct LOCALHANDLE : IEquatable<LOCALHANDLE>
    {
        public readonly nint Value;

        public LOCALHANDLE(nint value)
        {
            Value = value;
        }

        public static LOCALHANDLE INVALID_HANDLE_VALUE => new LOCALHANDLE(-1);

        public static LOCALHANDLE NULL => new LOCALHANDLE(0);

        public static bool operator ==(LOCALHANDLE left, LOCALHANDLE right) => left.Value == right.Value;

        public static bool operator !=(LOCALHANDLE left, LOCALHANDLE right) => left.Value != right.Value;

        public static explicit operator LOCALHANDLE(void* value) => new LOCALHANDLE((nint)(value));

        public static implicit operator void*(LOCALHANDLE value) => (void*)(value.Value);

        public static explicit operator LOCALHANDLE(HANDLE value) => new LOCALHANDLE(value);

        public static implicit operator HANDLE(LOCALHANDLE value) => new LOCALHANDLE(value);

        public static explicit operator LOCALHANDLE(byte value) => new LOCALHANDLE((nint)(value));

        public static implicit operator byte(LOCALHANDLE value) => (byte)(value.Value);

        public static explicit operator LOCALHANDLE(short value) => new LOCALHANDLE((nint)(value));

        public static implicit operator short(LOCALHANDLE value) => (short)(value.Value);

        public static explicit operator LOCALHANDLE(int value) => new LOCALHANDLE((nint)(value));

        public static implicit operator int(LOCALHANDLE value) => (int)(value.Value);

        public static explicit operator LOCALHANDLE(long value) => new LOCALHANDLE((nint)(value));

        public static explicit operator long(LOCALHANDLE value) => (long)(value.Value);

        public static explicit operator LOCALHANDLE(nint value) => new LOCALHANDLE((nint)(value));

        public static implicit operator nint(LOCALHANDLE value) => (nint)(value.Value);

        public static explicit operator LOCALHANDLE(sbyte value) => new LOCALHANDLE((nint)(value));

        public static implicit operator sbyte(LOCALHANDLE value) => (sbyte)(value.Value);

        public static explicit operator LOCALHANDLE(ushort value) => new LOCALHANDLE((nint)(value));

        public static implicit operator ushort(LOCALHANDLE value) => (ushort)(value.Value);

        public static explicit operator LOCALHANDLE(uint value) => new LOCALHANDLE((nint)(value));

        public static implicit operator uint(LOCALHANDLE value) => (uint)(value.Value);

        public static explicit operator LOCALHANDLE(ulong value) => new LOCALHANDLE((nint)(value));

        public static explicit operator ulong(LOCALHANDLE value) => (ulong)(value.Value);

        public static explicit operator LOCALHANDLE(nuint value) => new LOCALHANDLE((nint)(value));

        public static explicit operator nuint(LOCALHANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is LOCALHANDLE other) && Equals(other);

        public bool Equals(LOCALHANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
