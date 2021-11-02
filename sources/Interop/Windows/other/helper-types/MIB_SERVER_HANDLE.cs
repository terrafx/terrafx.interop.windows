// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct MIB_SERVER_HANDLE : IEquatable<MIB_SERVER_HANDLE>
    {
        public readonly nint Value;

        public MIB_SERVER_HANDLE(nint value)
        {
            Value = value;
        }

        public static MIB_SERVER_HANDLE INVALID_VALUE => new MIB_SERVER_HANDLE(-1);

        public static MIB_SERVER_HANDLE NULL => new MIB_SERVER_HANDLE(0);

        public static bool operator ==(MIB_SERVER_HANDLE left, MIB_SERVER_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(MIB_SERVER_HANDLE left, MIB_SERVER_HANDLE right) => left.Value != right.Value;

        public static explicit operator MIB_SERVER_HANDLE(void* value) => new MIB_SERVER_HANDLE((nint)(value));

        public static implicit operator void*(MIB_SERVER_HANDLE value) => (void*)(value.Value);

        public static explicit operator MIB_SERVER_HANDLE(HANDLE value) => new MIB_SERVER_HANDLE(value);

        public static implicit operator HANDLE(MIB_SERVER_HANDLE value) => new MIB_SERVER_HANDLE(value);

        public static explicit operator MIB_SERVER_HANDLE(byte value) => new MIB_SERVER_HANDLE((nint)(value));

        public static explicit operator byte(MIB_SERVER_HANDLE value) => (byte)(value.Value);

        public static explicit operator MIB_SERVER_HANDLE(short value) => new MIB_SERVER_HANDLE((nint)(value));

        public static explicit operator short(MIB_SERVER_HANDLE value) => (short)(value.Value);

        public static explicit operator MIB_SERVER_HANDLE(int value) => new MIB_SERVER_HANDLE((nint)(value));

        public static explicit operator int(MIB_SERVER_HANDLE value) => (int)(value.Value);

        public static explicit operator MIB_SERVER_HANDLE(long value) => new MIB_SERVER_HANDLE((nint)(value));

        public static implicit operator long(MIB_SERVER_HANDLE value) => (long)(value.Value);

        public static explicit operator MIB_SERVER_HANDLE(nint value) => new MIB_SERVER_HANDLE((nint)(value));

        public static implicit operator nint(MIB_SERVER_HANDLE value) => (nint)(value.Value);

        public static explicit operator MIB_SERVER_HANDLE(sbyte value) => new MIB_SERVER_HANDLE((nint)(value));

        public static explicit operator sbyte(MIB_SERVER_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator MIB_SERVER_HANDLE(ushort value) => new MIB_SERVER_HANDLE((nint)(value));

        public static explicit operator ushort(MIB_SERVER_HANDLE value) => (ushort)(value.Value);

        public static explicit operator MIB_SERVER_HANDLE(uint value) => new MIB_SERVER_HANDLE((nint)(value));

        public static explicit operator uint(MIB_SERVER_HANDLE value) => (uint)(value.Value);

        public static explicit operator MIB_SERVER_HANDLE(ulong value) => new MIB_SERVER_HANDLE((nint)(value));

        public static implicit operator ulong(MIB_SERVER_HANDLE value) => (ulong)(value.Value);

        public static explicit operator MIB_SERVER_HANDLE(nuint value) => new MIB_SERVER_HANDLE((nint)(value));

        public static explicit operator nuint(MIB_SERVER_HANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is MIB_SERVER_HANDLE other) && Equals(other);

        public bool Equals(MIB_SERVER_HANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
