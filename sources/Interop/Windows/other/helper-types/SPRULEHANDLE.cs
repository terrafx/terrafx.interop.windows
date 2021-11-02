// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SPRULEHANDLE : IEquatable<SPRULEHANDLE>
    {
        public readonly nint Value;

        public SPRULEHANDLE(nint value)
        {
            Value = value;
        }

        public static SPRULEHANDLE INVALID_HANDLE_VALUE => new SPRULEHANDLE(-1);

        public static SPRULEHANDLE NULL => new SPRULEHANDLE(0);

        public static bool operator ==(SPRULEHANDLE left, SPRULEHANDLE right) => left.Value == right.Value;

        public static bool operator !=(SPRULEHANDLE left, SPRULEHANDLE right) => left.Value != right.Value;

        public static explicit operator SPRULEHANDLE(void* value) => new SPRULEHANDLE((nint)(value));

        public static implicit operator void*(SPRULEHANDLE value) => (void*)(value.Value);

        public static explicit operator SPRULEHANDLE(HANDLE value) => new SPRULEHANDLE(value);

        public static implicit operator HANDLE(SPRULEHANDLE value) => new SPRULEHANDLE(value);

        public static explicit operator SPRULEHANDLE(byte value) => new SPRULEHANDLE((nint)(value));

        public static implicit operator byte(SPRULEHANDLE value) => (byte)(value.Value);

        public static explicit operator SPRULEHANDLE(short value) => new SPRULEHANDLE((nint)(value));

        public static implicit operator short(SPRULEHANDLE value) => (short)(value.Value);

        public static explicit operator SPRULEHANDLE(int value) => new SPRULEHANDLE((nint)(value));

        public static implicit operator int(SPRULEHANDLE value) => (int)(value.Value);

        public static explicit operator SPRULEHANDLE(long value) => new SPRULEHANDLE((nint)(value));

        public static explicit operator long(SPRULEHANDLE value) => (long)(value.Value);

        public static explicit operator SPRULEHANDLE(nint value) => new SPRULEHANDLE((nint)(value));

        public static implicit operator nint(SPRULEHANDLE value) => (nint)(value.Value);

        public static explicit operator SPRULEHANDLE(sbyte value) => new SPRULEHANDLE((nint)(value));

        public static implicit operator sbyte(SPRULEHANDLE value) => (sbyte)(value.Value);

        public static explicit operator SPRULEHANDLE(ushort value) => new SPRULEHANDLE((nint)(value));

        public static implicit operator ushort(SPRULEHANDLE value) => (ushort)(value.Value);

        public static explicit operator SPRULEHANDLE(uint value) => new SPRULEHANDLE((nint)(value));

        public static implicit operator uint(SPRULEHANDLE value) => (uint)(value.Value);

        public static explicit operator SPRULEHANDLE(ulong value) => new SPRULEHANDLE((nint)(value));

        public static explicit operator ulong(SPRULEHANDLE value) => (ulong)(value.Value);

        public static explicit operator SPRULEHANDLE(nuint value) => new SPRULEHANDLE((nint)(value));

        public static explicit operator nuint(SPRULEHANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is SPRULEHANDLE other) && Equals(other);

        public bool Equals(SPRULEHANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
