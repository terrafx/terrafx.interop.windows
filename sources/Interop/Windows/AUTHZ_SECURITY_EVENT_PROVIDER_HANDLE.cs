// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE : IEquatable<AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE>
    {
        public readonly nint Value;

        public static AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE NULL => (AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE)(0);

        public AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE(int value)
        {
            Value = ((nint)(value));
        }

        public AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE(uint value)
        {
            Value = ((nint)(value));
        }

        public AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE left, AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE left, AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE right) => left.Value != right.Value;

        public static explicit operator AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE(int value) => new AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE(value);

        public static explicit operator AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE(uint value) => new AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE(value);

        public static explicit operator AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE(nint value) => new AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE(value);

        public static explicit operator AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE(nuint value) => new AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE(value);

        public static explicit operator AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE(void* value) => new AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE(value);

        public static explicit operator AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE(HANDLE value) => new AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE(value);

        public static explicit operator int(AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE value) => (int)(value.Value);

        public static explicit operator uint(AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE value) => (uint)(value.Value);

        public static implicit operator nint(AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE value) => (void*)(value.Value);

        public static implicit operator HANDLE(AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE other) && Equals(other);

        public bool Equals(AUTHZ_SECURITY_EVENT_PROVIDER_HANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
