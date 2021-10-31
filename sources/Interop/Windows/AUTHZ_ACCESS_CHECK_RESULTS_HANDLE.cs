// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct AUTHZ_ACCESS_CHECK_RESULTS_HANDLE : IEquatable<AUTHZ_ACCESS_CHECK_RESULTS_HANDLE>
    {
        public readonly nint Value;

        public AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(int value)
        {
            Value = ((nint)(value));
        }

        public AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(uint value)
        {
            Value = ((nint)(value));
        }

        public AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(AUTHZ_ACCESS_CHECK_RESULTS_HANDLE left, AUTHZ_ACCESS_CHECK_RESULTS_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(AUTHZ_ACCESS_CHECK_RESULTS_HANDLE left, AUTHZ_ACCESS_CHECK_RESULTS_HANDLE right) => left.Value != right.Value;

        public static explicit operator AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(int value) => new AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(value);

        public static explicit operator AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(uint value) => new AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(value);

        public static explicit operator AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(nint value) => new AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(value);

        public static explicit operator AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(nuint value) => new AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(value);

        public static explicit operator AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(void* value) => new AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(value);

        public static explicit operator AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(HANDLE value) => new AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(value);

        public static implicit operator int(AUTHZ_ACCESS_CHECK_RESULTS_HANDLE value) => (int)(value.Value);

        public static implicit operator uint(AUTHZ_ACCESS_CHECK_RESULTS_HANDLE value) => (uint)(value.Value);

        public static implicit operator nint(AUTHZ_ACCESS_CHECK_RESULTS_HANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(AUTHZ_ACCESS_CHECK_RESULTS_HANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(AUTHZ_ACCESS_CHECK_RESULTS_HANDLE value) => (void*)(value.Value);

        public static implicit operator HANDLE(AUTHZ_ACCESS_CHECK_RESULTS_HANDLE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is AUTHZ_ACCESS_CHECK_RESULTS_HANDLE other) && Equals(other);

        public bool Equals(AUTHZ_ACCESS_CHECK_RESULTS_HANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
