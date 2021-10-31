// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HTTP_PUSH_WAIT_HANDLE : IEquatable<HTTP_PUSH_WAIT_HANDLE>
    {
        public readonly nint Value;

        public static HTTP_PUSH_WAIT_HANDLE NULL => (HTTP_PUSH_WAIT_HANDLE)(0);

        public HTTP_PUSH_WAIT_HANDLE(int value)
        {
            Value = ((nint)(value));
        }

        public HTTP_PUSH_WAIT_HANDLE(uint value)
        {
            Value = ((nint)(value));
        }

        public HTTP_PUSH_WAIT_HANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public HTTP_PUSH_WAIT_HANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public HTTP_PUSH_WAIT_HANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public HTTP_PUSH_WAIT_HANDLE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HTTP_PUSH_WAIT_HANDLE left, HTTP_PUSH_WAIT_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(HTTP_PUSH_WAIT_HANDLE left, HTTP_PUSH_WAIT_HANDLE right) => left.Value != right.Value;

        public static explicit operator HTTP_PUSH_WAIT_HANDLE(int value) => new HTTP_PUSH_WAIT_HANDLE(value);

        public static explicit operator HTTP_PUSH_WAIT_HANDLE(uint value) => new HTTP_PUSH_WAIT_HANDLE(value);

        public static explicit operator HTTP_PUSH_WAIT_HANDLE(nint value) => new HTTP_PUSH_WAIT_HANDLE(value);

        public static explicit operator HTTP_PUSH_WAIT_HANDLE(nuint value) => new HTTP_PUSH_WAIT_HANDLE(value);

        public static explicit operator HTTP_PUSH_WAIT_HANDLE(void* value) => new HTTP_PUSH_WAIT_HANDLE(value);

        public static explicit operator HTTP_PUSH_WAIT_HANDLE(HANDLE value) => new HTTP_PUSH_WAIT_HANDLE(value);

        public static explicit operator int(HTTP_PUSH_WAIT_HANDLE value) => (int)(value.Value);

        public static explicit operator uint(HTTP_PUSH_WAIT_HANDLE value) => (uint)(value.Value);

        public static implicit operator nint(HTTP_PUSH_WAIT_HANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(HTTP_PUSH_WAIT_HANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(HTTP_PUSH_WAIT_HANDLE value) => (void*)(value.Value);

        public static implicit operator HANDLE(HTTP_PUSH_WAIT_HANDLE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HTTP_PUSH_WAIT_HANDLE other) && Equals(other);

        public bool Equals(HTTP_PUSH_WAIT_HANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
