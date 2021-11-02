// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct NET_FRAGMENT_RETURN_CONTEXT_HANDLE : IEquatable<NET_FRAGMENT_RETURN_CONTEXT_HANDLE>
    {
        public readonly nint Value;

        public NET_FRAGMENT_RETURN_CONTEXT_HANDLE(nint value)
        {
            Value = value;
        }

        public static NET_FRAGMENT_RETURN_CONTEXT_HANDLE INVALID_VALUE => new NET_FRAGMENT_RETURN_CONTEXT_HANDLE(-1);

        public static NET_FRAGMENT_RETURN_CONTEXT_HANDLE NULL => new NET_FRAGMENT_RETURN_CONTEXT_HANDLE(0);

        public static bool operator ==(NET_FRAGMENT_RETURN_CONTEXT_HANDLE left, NET_FRAGMENT_RETURN_CONTEXT_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(NET_FRAGMENT_RETURN_CONTEXT_HANDLE left, NET_FRAGMENT_RETURN_CONTEXT_HANDLE right) => left.Value != right.Value;

        public static explicit operator NET_FRAGMENT_RETURN_CONTEXT_HANDLE(void* value) => new NET_FRAGMENT_RETURN_CONTEXT_HANDLE((nint)(value));

        public static implicit operator void*(NET_FRAGMENT_RETURN_CONTEXT_HANDLE value) => (void*)(value.Value);

        public static explicit operator NET_FRAGMENT_RETURN_CONTEXT_HANDLE(HANDLE value) => new NET_FRAGMENT_RETURN_CONTEXT_HANDLE(value);

        public static implicit operator HANDLE(NET_FRAGMENT_RETURN_CONTEXT_HANDLE value) => new NET_FRAGMENT_RETURN_CONTEXT_HANDLE(value);

        public static explicit operator NET_FRAGMENT_RETURN_CONTEXT_HANDLE(byte value) => new NET_FRAGMENT_RETURN_CONTEXT_HANDLE((nint)(value));

        public static explicit operator byte(NET_FRAGMENT_RETURN_CONTEXT_HANDLE value) => (byte)(value.Value);

        public static explicit operator NET_FRAGMENT_RETURN_CONTEXT_HANDLE(short value) => new NET_FRAGMENT_RETURN_CONTEXT_HANDLE((nint)(value));

        public static explicit operator short(NET_FRAGMENT_RETURN_CONTEXT_HANDLE value) => (short)(value.Value);

        public static explicit operator NET_FRAGMENT_RETURN_CONTEXT_HANDLE(int value) => new NET_FRAGMENT_RETURN_CONTEXT_HANDLE((nint)(value));

        public static explicit operator int(NET_FRAGMENT_RETURN_CONTEXT_HANDLE value) => (int)(value.Value);

        public static explicit operator NET_FRAGMENT_RETURN_CONTEXT_HANDLE(long value) => new NET_FRAGMENT_RETURN_CONTEXT_HANDLE((nint)(value));

        public static implicit operator long(NET_FRAGMENT_RETURN_CONTEXT_HANDLE value) => (long)(value.Value);

        public static explicit operator NET_FRAGMENT_RETURN_CONTEXT_HANDLE(nint value) => new NET_FRAGMENT_RETURN_CONTEXT_HANDLE((nint)(value));

        public static implicit operator nint(NET_FRAGMENT_RETURN_CONTEXT_HANDLE value) => (nint)(value.Value);

        public static explicit operator NET_FRAGMENT_RETURN_CONTEXT_HANDLE(sbyte value) => new NET_FRAGMENT_RETURN_CONTEXT_HANDLE((nint)(value));

        public static explicit operator sbyte(NET_FRAGMENT_RETURN_CONTEXT_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator NET_FRAGMENT_RETURN_CONTEXT_HANDLE(ushort value) => new NET_FRAGMENT_RETURN_CONTEXT_HANDLE((nint)(value));

        public static explicit operator ushort(NET_FRAGMENT_RETURN_CONTEXT_HANDLE value) => (ushort)(value.Value);

        public static explicit operator NET_FRAGMENT_RETURN_CONTEXT_HANDLE(uint value) => new NET_FRAGMENT_RETURN_CONTEXT_HANDLE((nint)(value));

        public static explicit operator uint(NET_FRAGMENT_RETURN_CONTEXT_HANDLE value) => (uint)(value.Value);

        public static explicit operator NET_FRAGMENT_RETURN_CONTEXT_HANDLE(ulong value) => new NET_FRAGMENT_RETURN_CONTEXT_HANDLE((nint)(value));

        public static explicit operator ulong(NET_FRAGMENT_RETURN_CONTEXT_HANDLE value) => (ulong)(value.Value);

        public static explicit operator NET_FRAGMENT_RETURN_CONTEXT_HANDLE(nuint value) => new NET_FRAGMENT_RETURN_CONTEXT_HANDLE((nint)(value));

        public static explicit operator nuint(NET_FRAGMENT_RETURN_CONTEXT_HANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is NET_FRAGMENT_RETURN_CONTEXT_HANDLE other) && Equals(other);

        public bool Equals(NET_FRAGMENT_RETURN_CONTEXT_HANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
