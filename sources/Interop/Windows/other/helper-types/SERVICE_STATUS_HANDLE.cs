// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SERVICE_STATUS_HANDLE : IEquatable<SERVICE_STATUS_HANDLE>
    {
        public readonly nint Value;

        public SERVICE_STATUS_HANDLE(nint value)
        {
            Value = value;
        }

        public static SERVICE_STATUS_HANDLE INVALID_HANDLE_VALUE => new SERVICE_STATUS_HANDLE(-1);

        public static SERVICE_STATUS_HANDLE NULL => new SERVICE_STATUS_HANDLE(0);

        public static bool operator ==(SERVICE_STATUS_HANDLE left, SERVICE_STATUS_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(SERVICE_STATUS_HANDLE left, SERVICE_STATUS_HANDLE right) => left.Value != right.Value;

        public static explicit operator SERVICE_STATUS_HANDLE(void* value) => new SERVICE_STATUS_HANDLE((nint)(value));

        public static implicit operator void*(SERVICE_STATUS_HANDLE value) => (void*)(value.Value);

        public static explicit operator SERVICE_STATUS_HANDLE(HANDLE value) => new SERVICE_STATUS_HANDLE(value);

        public static implicit operator HANDLE(SERVICE_STATUS_HANDLE value) => new SERVICE_STATUS_HANDLE(value);

        public static explicit operator SERVICE_STATUS_HANDLE(byte value) => new SERVICE_STATUS_HANDLE((nint)(value));

        public static explicit operator byte(SERVICE_STATUS_HANDLE value) => (byte)(value.Value);

        public static explicit operator SERVICE_STATUS_HANDLE(short value) => new SERVICE_STATUS_HANDLE((nint)(value));

        public static explicit operator short(SERVICE_STATUS_HANDLE value) => (short)(value.Value);

        public static explicit operator SERVICE_STATUS_HANDLE(int value) => new SERVICE_STATUS_HANDLE((nint)(value));

        public static explicit operator int(SERVICE_STATUS_HANDLE value) => (int)(value.Value);

        public static explicit operator SERVICE_STATUS_HANDLE(long value) => new SERVICE_STATUS_HANDLE((nint)(value));

        public static implicit operator long(SERVICE_STATUS_HANDLE value) => (long)(value.Value);

        public static explicit operator SERVICE_STATUS_HANDLE(nint value) => new SERVICE_STATUS_HANDLE((nint)(value));

        public static implicit operator nint(SERVICE_STATUS_HANDLE value) => (nint)(value.Value);

        public static explicit operator SERVICE_STATUS_HANDLE(sbyte value) => new SERVICE_STATUS_HANDLE((nint)(value));

        public static explicit operator sbyte(SERVICE_STATUS_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator SERVICE_STATUS_HANDLE(ushort value) => new SERVICE_STATUS_HANDLE((nint)(value));

        public static explicit operator ushort(SERVICE_STATUS_HANDLE value) => (ushort)(value.Value);

        public static explicit operator SERVICE_STATUS_HANDLE(uint value) => new SERVICE_STATUS_HANDLE((nint)(value));

        public static explicit operator uint(SERVICE_STATUS_HANDLE value) => (uint)(value.Value);

        public static explicit operator SERVICE_STATUS_HANDLE(ulong value) => new SERVICE_STATUS_HANDLE((nint)(value));

        public static implicit operator ulong(SERVICE_STATUS_HANDLE value) => (ulong)(value.Value);

        public static explicit operator SERVICE_STATUS_HANDLE(nuint value) => new SERVICE_STATUS_HANDLE((nint)(value));

        public static explicit operator nuint(SERVICE_STATUS_HANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is SERVICE_STATUS_HANDLE other) && Equals(other);

        public bool Equals(SERVICE_STATUS_HANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
