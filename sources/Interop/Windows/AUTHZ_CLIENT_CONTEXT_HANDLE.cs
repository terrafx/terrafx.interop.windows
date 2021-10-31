// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct AUTHZ_CLIENT_CONTEXT_HANDLE : IEquatable<AUTHZ_CLIENT_CONTEXT_HANDLE>
    {
        public readonly nint Value;

        public AUTHZ_CLIENT_CONTEXT_HANDLE(int value)
        {
            Value = ((nint)(value));
        }

        public AUTHZ_CLIENT_CONTEXT_HANDLE(uint value)
        {
            Value = ((nint)(value));
        }

        public AUTHZ_CLIENT_CONTEXT_HANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public AUTHZ_CLIENT_CONTEXT_HANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public AUTHZ_CLIENT_CONTEXT_HANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public AUTHZ_CLIENT_CONTEXT_HANDLE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(AUTHZ_CLIENT_CONTEXT_HANDLE left, AUTHZ_CLIENT_CONTEXT_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(AUTHZ_CLIENT_CONTEXT_HANDLE left, AUTHZ_CLIENT_CONTEXT_HANDLE right) => left.Value != right.Value;

        public static explicit operator AUTHZ_CLIENT_CONTEXT_HANDLE(int value) => new AUTHZ_CLIENT_CONTEXT_HANDLE(value);

        public static explicit operator AUTHZ_CLIENT_CONTEXT_HANDLE(uint value) => new AUTHZ_CLIENT_CONTEXT_HANDLE(value);

        public static explicit operator AUTHZ_CLIENT_CONTEXT_HANDLE(nint value) => new AUTHZ_CLIENT_CONTEXT_HANDLE(value);

        public static explicit operator AUTHZ_CLIENT_CONTEXT_HANDLE(nuint value) => new AUTHZ_CLIENT_CONTEXT_HANDLE(value);

        public static explicit operator AUTHZ_CLIENT_CONTEXT_HANDLE(void* value) => new AUTHZ_CLIENT_CONTEXT_HANDLE(value);

        public static explicit operator AUTHZ_CLIENT_CONTEXT_HANDLE(HANDLE value) => new AUTHZ_CLIENT_CONTEXT_HANDLE(value);

        public static implicit operator int(AUTHZ_CLIENT_CONTEXT_HANDLE value) => (int)(value.Value);

        public static implicit operator uint(AUTHZ_CLIENT_CONTEXT_HANDLE value) => (uint)(value.Value);

        public static implicit operator nint(AUTHZ_CLIENT_CONTEXT_HANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(AUTHZ_CLIENT_CONTEXT_HANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(AUTHZ_CLIENT_CONTEXT_HANDLE value) => (void*)(value.Value);

        public static implicit operator HANDLE(AUTHZ_CLIENT_CONTEXT_HANDLE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is AUTHZ_CLIENT_CONTEXT_HANDLE other) && Equals(other);

        public bool Equals(AUTHZ_CLIENT_CONTEXT_HANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
