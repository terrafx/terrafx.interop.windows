// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct EVT_OBJECT_ARRAY_PROPERTY_HANDLE : IEquatable<EVT_OBJECT_ARRAY_PROPERTY_HANDLE>
    {
        public readonly nint Value;

        public EVT_OBJECT_ARRAY_PROPERTY_HANDLE(nint value)
        {
            Value = value;
        }

        public static EVT_OBJECT_ARRAY_PROPERTY_HANDLE INVALID_HANDLE_VALUE => new EVT_OBJECT_ARRAY_PROPERTY_HANDLE(-1);

        public static EVT_OBJECT_ARRAY_PROPERTY_HANDLE NULL => new EVT_OBJECT_ARRAY_PROPERTY_HANDLE(0);

        public static bool operator ==(EVT_OBJECT_ARRAY_PROPERTY_HANDLE left, EVT_OBJECT_ARRAY_PROPERTY_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(EVT_OBJECT_ARRAY_PROPERTY_HANDLE left, EVT_OBJECT_ARRAY_PROPERTY_HANDLE right) => left.Value != right.Value;

        public static explicit operator EVT_OBJECT_ARRAY_PROPERTY_HANDLE(void* value) => new EVT_OBJECT_ARRAY_PROPERTY_HANDLE((nint)(value));

        public static implicit operator void*(EVT_OBJECT_ARRAY_PROPERTY_HANDLE value) => (void*)(value.Value);

        public static explicit operator EVT_OBJECT_ARRAY_PROPERTY_HANDLE(HANDLE value) => new EVT_OBJECT_ARRAY_PROPERTY_HANDLE(value);

        public static implicit operator HANDLE(EVT_OBJECT_ARRAY_PROPERTY_HANDLE value) => new EVT_OBJECT_ARRAY_PROPERTY_HANDLE(value);

        public static explicit operator EVT_OBJECT_ARRAY_PROPERTY_HANDLE(byte value) => new EVT_OBJECT_ARRAY_PROPERTY_HANDLE((nint)(value));

        public static explicit operator byte(EVT_OBJECT_ARRAY_PROPERTY_HANDLE value) => (byte)(value.Value);

        public static explicit operator EVT_OBJECT_ARRAY_PROPERTY_HANDLE(short value) => new EVT_OBJECT_ARRAY_PROPERTY_HANDLE((nint)(value));

        public static explicit operator short(EVT_OBJECT_ARRAY_PROPERTY_HANDLE value) => (short)(value.Value);

        public static explicit operator EVT_OBJECT_ARRAY_PROPERTY_HANDLE(int value) => new EVT_OBJECT_ARRAY_PROPERTY_HANDLE((nint)(value));

        public static explicit operator int(EVT_OBJECT_ARRAY_PROPERTY_HANDLE value) => (int)(value.Value);

        public static explicit operator EVT_OBJECT_ARRAY_PROPERTY_HANDLE(long value) => new EVT_OBJECT_ARRAY_PROPERTY_HANDLE((nint)(value));

        public static implicit operator long(EVT_OBJECT_ARRAY_PROPERTY_HANDLE value) => (long)(value.Value);

        public static explicit operator EVT_OBJECT_ARRAY_PROPERTY_HANDLE(nint value) => new EVT_OBJECT_ARRAY_PROPERTY_HANDLE((nint)(value));

        public static implicit operator nint(EVT_OBJECT_ARRAY_PROPERTY_HANDLE value) => (nint)(value.Value);

        public static explicit operator EVT_OBJECT_ARRAY_PROPERTY_HANDLE(sbyte value) => new EVT_OBJECT_ARRAY_PROPERTY_HANDLE((nint)(value));

        public static explicit operator sbyte(EVT_OBJECT_ARRAY_PROPERTY_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator EVT_OBJECT_ARRAY_PROPERTY_HANDLE(ushort value) => new EVT_OBJECT_ARRAY_PROPERTY_HANDLE((nint)(value));

        public static explicit operator ushort(EVT_OBJECT_ARRAY_PROPERTY_HANDLE value) => (ushort)(value.Value);

        public static explicit operator EVT_OBJECT_ARRAY_PROPERTY_HANDLE(uint value) => new EVT_OBJECT_ARRAY_PROPERTY_HANDLE((nint)(value));

        public static explicit operator uint(EVT_OBJECT_ARRAY_PROPERTY_HANDLE value) => (uint)(value.Value);

        public static explicit operator EVT_OBJECT_ARRAY_PROPERTY_HANDLE(ulong value) => new EVT_OBJECT_ARRAY_PROPERTY_HANDLE((nint)(value));

        public static implicit operator ulong(EVT_OBJECT_ARRAY_PROPERTY_HANDLE value) => (ulong)(value.Value);

        public static explicit operator EVT_OBJECT_ARRAY_PROPERTY_HANDLE(nuint value) => new EVT_OBJECT_ARRAY_PROPERTY_HANDLE((nint)(value));

        public static explicit operator nuint(EVT_OBJECT_ARRAY_PROPERTY_HANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is EVT_OBJECT_ARRAY_PROPERTY_HANDLE other) && Equals(other);

        public bool Equals(EVT_OBJECT_ARRAY_PROPERTY_HANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
