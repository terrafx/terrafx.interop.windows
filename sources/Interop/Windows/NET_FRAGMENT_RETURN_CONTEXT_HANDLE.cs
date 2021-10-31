// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct NET_FRAGMENT_RETURN_CONTEXT_HANDLE : IEquatable<NET_FRAGMENT_RETURN_CONTEXT_HANDLE>
    {
        public readonly nint Value;

        public static NET_FRAGMENT_RETURN_CONTEXT_HANDLE NULL => (NET_FRAGMENT_RETURN_CONTEXT_HANDLE)(0);

        public NET_FRAGMENT_RETURN_CONTEXT_HANDLE(int value)
        {
            Value = ((nint)(value));
        }

        public NET_FRAGMENT_RETURN_CONTEXT_HANDLE(uint value)
        {
            Value = ((nint)(value));
        }

        public NET_FRAGMENT_RETURN_CONTEXT_HANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public NET_FRAGMENT_RETURN_CONTEXT_HANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public NET_FRAGMENT_RETURN_CONTEXT_HANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public NET_FRAGMENT_RETURN_CONTEXT_HANDLE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(NET_FRAGMENT_RETURN_CONTEXT_HANDLE left, NET_FRAGMENT_RETURN_CONTEXT_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(NET_FRAGMENT_RETURN_CONTEXT_HANDLE left, NET_FRAGMENT_RETURN_CONTEXT_HANDLE right) => left.Value != right.Value;

        public static explicit operator NET_FRAGMENT_RETURN_CONTEXT_HANDLE(int value) => new NET_FRAGMENT_RETURN_CONTEXT_HANDLE(value);

        public static explicit operator NET_FRAGMENT_RETURN_CONTEXT_HANDLE(uint value) => new NET_FRAGMENT_RETURN_CONTEXT_HANDLE(value);

        public static explicit operator NET_FRAGMENT_RETURN_CONTEXT_HANDLE(nint value) => new NET_FRAGMENT_RETURN_CONTEXT_HANDLE(value);

        public static explicit operator NET_FRAGMENT_RETURN_CONTEXT_HANDLE(nuint value) => new NET_FRAGMENT_RETURN_CONTEXT_HANDLE(value);

        public static explicit operator NET_FRAGMENT_RETURN_CONTEXT_HANDLE(void* value) => new NET_FRAGMENT_RETURN_CONTEXT_HANDLE(value);

        public static explicit operator NET_FRAGMENT_RETURN_CONTEXT_HANDLE(HANDLE value) => new NET_FRAGMENT_RETURN_CONTEXT_HANDLE(value);

        public static implicit operator int(NET_FRAGMENT_RETURN_CONTEXT_HANDLE value) => (int)(value.Value);

        public static implicit operator uint(NET_FRAGMENT_RETURN_CONTEXT_HANDLE value) => (uint)(value.Value);

        public static implicit operator nint(NET_FRAGMENT_RETURN_CONTEXT_HANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(NET_FRAGMENT_RETURN_CONTEXT_HANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(NET_FRAGMENT_RETURN_CONTEXT_HANDLE value) => (void*)(value.Value);

        public static implicit operator HANDLE(NET_FRAGMENT_RETURN_CONTEXT_HANDLE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is NET_FRAGMENT_RETURN_CONTEXT_HANDLE other) && Equals(other);

        public bool Equals(NET_FRAGMENT_RETURN_CONTEXT_HANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
