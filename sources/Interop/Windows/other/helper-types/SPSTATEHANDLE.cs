// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SPSTATEHANDLE : IEquatable<SPSTATEHANDLE>
    {
        public readonly nint Value;

        public SPSTATEHANDLE(nint value)
        {
            Value = value;
        }

        public static SPSTATEHANDLE INVALID_HANDLE_VALUE => new SPSTATEHANDLE(-1);

        public static SPSTATEHANDLE NULL => new SPSTATEHANDLE(0);

        public static bool operator ==(SPSTATEHANDLE left, SPSTATEHANDLE right) => left.Value == right.Value;

        public static bool operator !=(SPSTATEHANDLE left, SPSTATEHANDLE right) => left.Value != right.Value;

        public static explicit operator SPSTATEHANDLE(void* value) => new SPSTATEHANDLE((nint)(value));

        public static implicit operator void*(SPSTATEHANDLE value) => (void*)(value.Value);

        public static explicit operator SPSTATEHANDLE(HANDLE value) => new SPSTATEHANDLE(value);

        public static implicit operator HANDLE(SPSTATEHANDLE value) => new SPSTATEHANDLE(value);

        public static explicit operator SPSTATEHANDLE(byte value) => new SPSTATEHANDLE((nint)(value));

        public static explicit operator byte(SPSTATEHANDLE value) => (byte)(value.Value);

        public static explicit operator SPSTATEHANDLE(short value) => new SPSTATEHANDLE((nint)(value));

        public static explicit operator short(SPSTATEHANDLE value) => (short)(value.Value);

        public static explicit operator SPSTATEHANDLE(int value) => new SPSTATEHANDLE((nint)(value));

        public static explicit operator int(SPSTATEHANDLE value) => (int)(value.Value);

        public static explicit operator SPSTATEHANDLE(long value) => new SPSTATEHANDLE((nint)(value));

        public static implicit operator long(SPSTATEHANDLE value) => (long)(value.Value);

        public static explicit operator SPSTATEHANDLE(nint value) => new SPSTATEHANDLE((nint)(value));

        public static implicit operator nint(SPSTATEHANDLE value) => (nint)(value.Value);

        public static explicit operator SPSTATEHANDLE(sbyte value) => new SPSTATEHANDLE((nint)(value));

        public static explicit operator sbyte(SPSTATEHANDLE value) => (sbyte)(value.Value);

        public static explicit operator SPSTATEHANDLE(ushort value) => new SPSTATEHANDLE((nint)(value));

        public static explicit operator ushort(SPSTATEHANDLE value) => (ushort)(value.Value);

        public static explicit operator SPSTATEHANDLE(uint value) => new SPSTATEHANDLE((nint)(value));

        public static explicit operator uint(SPSTATEHANDLE value) => (uint)(value.Value);

        public static explicit operator SPSTATEHANDLE(ulong value) => new SPSTATEHANDLE((nint)(value));

        public static implicit operator ulong(SPSTATEHANDLE value) => (ulong)(value.Value);

        public static explicit operator SPSTATEHANDLE(nuint value) => new SPSTATEHANDLE((nint)(value));

        public static explicit operator nuint(SPSTATEHANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is SPSTATEHANDLE other) && Equals(other);

        public bool Equals(SPSTATEHANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
