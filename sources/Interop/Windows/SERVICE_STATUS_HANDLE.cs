// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SERVICE_STATUS_HANDLE : IEquatable<SERVICE_STATUS_HANDLE>
    {
        public readonly nint Value;

        public static SERVICE_STATUS_HANDLE NULL => (SERVICE_STATUS_HANDLE)(0);

        public SERVICE_STATUS_HANDLE(int value)
        {
            Value = ((nint)(value));
        }

        public SERVICE_STATUS_HANDLE(uint value)
        {
            Value = ((nint)(value));
        }

        public SERVICE_STATUS_HANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public SERVICE_STATUS_HANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public SERVICE_STATUS_HANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public SERVICE_STATUS_HANDLE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(SERVICE_STATUS_HANDLE left, SERVICE_STATUS_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(SERVICE_STATUS_HANDLE left, SERVICE_STATUS_HANDLE right) => left.Value != right.Value;

        public static explicit operator SERVICE_STATUS_HANDLE(int value) => new SERVICE_STATUS_HANDLE(value);

        public static explicit operator SERVICE_STATUS_HANDLE(uint value) => new SERVICE_STATUS_HANDLE(value);

        public static explicit operator SERVICE_STATUS_HANDLE(nint value) => new SERVICE_STATUS_HANDLE(value);

        public static explicit operator SERVICE_STATUS_HANDLE(nuint value) => new SERVICE_STATUS_HANDLE(value);

        public static explicit operator SERVICE_STATUS_HANDLE(void* value) => new SERVICE_STATUS_HANDLE(value);

        public static explicit operator SERVICE_STATUS_HANDLE(HANDLE value) => new SERVICE_STATUS_HANDLE(value);

        public static implicit operator int(SERVICE_STATUS_HANDLE value) => (int)(value.Value);

        public static implicit operator uint(SERVICE_STATUS_HANDLE value) => (uint)(value.Value);

        public static implicit operator nint(SERVICE_STATUS_HANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(SERVICE_STATUS_HANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(SERVICE_STATUS_HANDLE value) => (void*)(value.Value);

        public static implicit operator HANDLE(SERVICE_STATUS_HANDLE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is SERVICE_STATUS_HANDLE other) && Equals(other);

        public bool Equals(SERVICE_STATUS_HANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
