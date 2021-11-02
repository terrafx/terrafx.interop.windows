// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct RTM_ENTITY_HANDLE : IEquatable<RTM_ENTITY_HANDLE>
    {
        public readonly nint Value;

        public RTM_ENTITY_HANDLE(nint value)
        {
            Value = value;
        }

        public static RTM_ENTITY_HANDLE NULL => new RTM_ENTITY_HANDLE(0);

        public static bool operator ==(RTM_ENTITY_HANDLE left, RTM_ENTITY_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(RTM_ENTITY_HANDLE left, RTM_ENTITY_HANDLE right) => left.Value != right.Value;

        public static explicit operator RTM_ENTITY_HANDLE(void* value) => new RTM_ENTITY_HANDLE((nint)(value));

        public static implicit operator void*(RTM_ENTITY_HANDLE value) => (void*)(value.Value);

        public static explicit operator RTM_ENTITY_HANDLE(byte value) => new RTM_ENTITY_HANDLE((nint)(value));

        public static explicit operator byte(RTM_ENTITY_HANDLE value) => (byte)(value.Value);

        public static explicit operator RTM_ENTITY_HANDLE(short value) => new RTM_ENTITY_HANDLE((nint)(value));

        public static explicit operator short(RTM_ENTITY_HANDLE value) => (short)(value.Value);

        public static explicit operator RTM_ENTITY_HANDLE(int value) => new RTM_ENTITY_HANDLE((nint)(value));

        public static explicit operator int(RTM_ENTITY_HANDLE value) => (int)(value.Value);

        public static explicit operator RTM_ENTITY_HANDLE(long value) => new RTM_ENTITY_HANDLE((nint)(value));

        public static implicit operator long(RTM_ENTITY_HANDLE value) => (long)(value.Value);

        public static explicit operator RTM_ENTITY_HANDLE(nint value) => new RTM_ENTITY_HANDLE((nint)(value));

        public static implicit operator nint(RTM_ENTITY_HANDLE value) => (nint)(value.Value);

        public static explicit operator RTM_ENTITY_HANDLE(sbyte value) => new RTM_ENTITY_HANDLE((nint)(value));

        public static explicit operator sbyte(RTM_ENTITY_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator RTM_ENTITY_HANDLE(ushort value) => new RTM_ENTITY_HANDLE((nint)(value));

        public static explicit operator ushort(RTM_ENTITY_HANDLE value) => (ushort)(value.Value);

        public static explicit operator RTM_ENTITY_HANDLE(uint value) => new RTM_ENTITY_HANDLE((nint)(value));

        public static explicit operator uint(RTM_ENTITY_HANDLE value) => (uint)(value.Value);

        public static explicit operator RTM_ENTITY_HANDLE(ulong value) => new RTM_ENTITY_HANDLE((nint)(value));

        public static explicit operator ulong(RTM_ENTITY_HANDLE value) => (ulong)(value.Value);

        public static explicit operator RTM_ENTITY_HANDLE(nuint value) => new RTM_ENTITY_HANDLE((nint)(value));

        public static explicit operator nuint(RTM_ENTITY_HANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is RTM_ENTITY_HANDLE other) && Equals(other);

        public bool Equals(RTM_ENTITY_HANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
