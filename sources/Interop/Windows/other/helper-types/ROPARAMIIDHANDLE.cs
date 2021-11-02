// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct ROPARAMIIDHANDLE : IEquatable<ROPARAMIIDHANDLE>
    {
        public readonly nint Value;

        public ROPARAMIIDHANDLE(nint value)
        {
            Value = value;
        }

        public static ROPARAMIIDHANDLE INVALID_HANDLE_VALUE => new ROPARAMIIDHANDLE(-1);

        public static ROPARAMIIDHANDLE NULL => new ROPARAMIIDHANDLE(0);

        public static bool operator ==(ROPARAMIIDHANDLE left, ROPARAMIIDHANDLE right) => left.Value == right.Value;

        public static bool operator !=(ROPARAMIIDHANDLE left, ROPARAMIIDHANDLE right) => left.Value != right.Value;

        public static explicit operator ROPARAMIIDHANDLE(void* value) => new ROPARAMIIDHANDLE((nint)(value));

        public static implicit operator void*(ROPARAMIIDHANDLE value) => (void*)(value.Value);

        public static explicit operator ROPARAMIIDHANDLE(HANDLE value) => new ROPARAMIIDHANDLE(value);

        public static implicit operator HANDLE(ROPARAMIIDHANDLE value) => new ROPARAMIIDHANDLE(value);

        public static explicit operator ROPARAMIIDHANDLE(byte value) => new ROPARAMIIDHANDLE((nint)(value));

        public static explicit operator byte(ROPARAMIIDHANDLE value) => (byte)(value.Value);

        public static explicit operator ROPARAMIIDHANDLE(short value) => new ROPARAMIIDHANDLE((nint)(value));

        public static explicit operator short(ROPARAMIIDHANDLE value) => (short)(value.Value);

        public static explicit operator ROPARAMIIDHANDLE(int value) => new ROPARAMIIDHANDLE((nint)(value));

        public static explicit operator int(ROPARAMIIDHANDLE value) => (int)(value.Value);

        public static explicit operator ROPARAMIIDHANDLE(long value) => new ROPARAMIIDHANDLE((nint)(value));

        public static implicit operator long(ROPARAMIIDHANDLE value) => (long)(value.Value);

        public static explicit operator ROPARAMIIDHANDLE(nint value) => new ROPARAMIIDHANDLE((nint)(value));

        public static implicit operator nint(ROPARAMIIDHANDLE value) => (nint)(value.Value);

        public static explicit operator ROPARAMIIDHANDLE(sbyte value) => new ROPARAMIIDHANDLE((nint)(value));

        public static explicit operator sbyte(ROPARAMIIDHANDLE value) => (sbyte)(value.Value);

        public static explicit operator ROPARAMIIDHANDLE(ushort value) => new ROPARAMIIDHANDLE((nint)(value));

        public static explicit operator ushort(ROPARAMIIDHANDLE value) => (ushort)(value.Value);

        public static explicit operator ROPARAMIIDHANDLE(uint value) => new ROPARAMIIDHANDLE((nint)(value));

        public static explicit operator uint(ROPARAMIIDHANDLE value) => (uint)(value.Value);

        public static explicit operator ROPARAMIIDHANDLE(ulong value) => new ROPARAMIIDHANDLE((nint)(value));

        public static implicit operator ulong(ROPARAMIIDHANDLE value) => (ulong)(value.Value);

        public static explicit operator ROPARAMIIDHANDLE(nuint value) => new ROPARAMIIDHANDLE((nint)(value));

        public static explicit operator nuint(ROPARAMIIDHANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is ROPARAMIIDHANDLE other) && Equals(other);

        public bool Equals(ROPARAMIIDHANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
