// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct RAS_SERVER_HANDLE : IEquatable<RAS_SERVER_HANDLE>
    {
        public readonly nint Value;

        public RAS_SERVER_HANDLE(nint value)
        {
            Value = value;
        }

        public static RAS_SERVER_HANDLE INVALID_HANDLE_VALUE => new RAS_SERVER_HANDLE(-1);

        public static RAS_SERVER_HANDLE NULL => new RAS_SERVER_HANDLE(0);

        public static bool operator ==(RAS_SERVER_HANDLE left, RAS_SERVER_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(RAS_SERVER_HANDLE left, RAS_SERVER_HANDLE right) => left.Value != right.Value;

        public static explicit operator RAS_SERVER_HANDLE(void* value) => new RAS_SERVER_HANDLE((nint)(value));

        public static implicit operator void*(RAS_SERVER_HANDLE value) => (void*)(value.Value);

        public static explicit operator RAS_SERVER_HANDLE(HANDLE value) => new RAS_SERVER_HANDLE(value);

        public static implicit operator HANDLE(RAS_SERVER_HANDLE value) => new RAS_SERVER_HANDLE(value);

        public static explicit operator RAS_SERVER_HANDLE(byte value) => new RAS_SERVER_HANDLE((nint)(value));

        public static implicit operator byte(RAS_SERVER_HANDLE value) => (byte)(value.Value);

        public static explicit operator RAS_SERVER_HANDLE(short value) => new RAS_SERVER_HANDLE((nint)(value));

        public static implicit operator short(RAS_SERVER_HANDLE value) => (short)(value.Value);

        public static explicit operator RAS_SERVER_HANDLE(int value) => new RAS_SERVER_HANDLE((nint)(value));

        public static implicit operator int(RAS_SERVER_HANDLE value) => (int)(value.Value);

        public static explicit operator RAS_SERVER_HANDLE(long value) => new RAS_SERVER_HANDLE((nint)(value));

        public static explicit operator long(RAS_SERVER_HANDLE value) => (long)(value.Value);

        public static explicit operator RAS_SERVER_HANDLE(nint value) => new RAS_SERVER_HANDLE((nint)(value));

        public static implicit operator nint(RAS_SERVER_HANDLE value) => (nint)(value.Value);

        public static explicit operator RAS_SERVER_HANDLE(sbyte value) => new RAS_SERVER_HANDLE((nint)(value));

        public static implicit operator sbyte(RAS_SERVER_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator RAS_SERVER_HANDLE(ushort value) => new RAS_SERVER_HANDLE((nint)(value));

        public static implicit operator ushort(RAS_SERVER_HANDLE value) => (ushort)(value.Value);

        public static explicit operator RAS_SERVER_HANDLE(uint value) => new RAS_SERVER_HANDLE((nint)(value));

        public static implicit operator uint(RAS_SERVER_HANDLE value) => (uint)(value.Value);

        public static explicit operator RAS_SERVER_HANDLE(ulong value) => new RAS_SERVER_HANDLE((nint)(value));

        public static explicit operator ulong(RAS_SERVER_HANDLE value) => (ulong)(value.Value);

        public static explicit operator RAS_SERVER_HANDLE(nuint value) => new RAS_SERVER_HANDLE((nint)(value));

        public static explicit operator nuint(RAS_SERVER_HANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is RAS_SERVER_HANDLE other) && Equals(other);

        public bool Equals(RAS_SERVER_HANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
