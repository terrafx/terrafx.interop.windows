// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE : IEquatable<AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE>
    {
        public readonly nint Value;

        public static AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE NULL => (AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE)(0);

        public AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(int value)
        {
            Value = ((nint)(value));
        }

        public AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(uint value)
        {
            Value = ((nint)(value));
        }

        public AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE left, AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE left, AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE right) => left.Value != right.Value;

        public static explicit operator AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(int value) => new AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(value);

        public static explicit operator AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(uint value) => new AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(value);

        public static explicit operator AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(nint value) => new AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(value);

        public static explicit operator AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(nuint value) => new AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(value);

        public static explicit operator AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(void* value) => new AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(value);

        public static explicit operator AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(HANDLE value) => new AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE(value);

        public static explicit operator int(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE value) => (int)(value.Value);

        public static explicit operator uint(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE value) => (uint)(value.Value);

        public static implicit operator nint(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE value) => (void*)(value.Value);

        public static implicit operator HANDLE(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE other) && Equals(other);

        public bool Equals(AUTHZ_CAP_CHANGE_SUBSCRIPTION_HANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
