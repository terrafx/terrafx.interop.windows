// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct WEB_SOCKET_HANDLE : IEquatable<WEB_SOCKET_HANDLE>
    {
        public readonly nint Value;

        public static WEB_SOCKET_HANDLE NULL => (WEB_SOCKET_HANDLE)(0);

        public WEB_SOCKET_HANDLE(int value)
        {
            Value = ((nint)(value));
        }

        public WEB_SOCKET_HANDLE(uint value)
        {
            Value = ((nint)(value));
        }

        public WEB_SOCKET_HANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public WEB_SOCKET_HANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public WEB_SOCKET_HANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public WEB_SOCKET_HANDLE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(WEB_SOCKET_HANDLE left, WEB_SOCKET_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(WEB_SOCKET_HANDLE left, WEB_SOCKET_HANDLE right) => left.Value != right.Value;

        public static explicit operator WEB_SOCKET_HANDLE(int value) => new WEB_SOCKET_HANDLE(value);

        public static explicit operator WEB_SOCKET_HANDLE(uint value) => new WEB_SOCKET_HANDLE(value);

        public static explicit operator WEB_SOCKET_HANDLE(nint value) => new WEB_SOCKET_HANDLE(value);

        public static explicit operator WEB_SOCKET_HANDLE(nuint value) => new WEB_SOCKET_HANDLE(value);

        public static explicit operator WEB_SOCKET_HANDLE(void* value) => new WEB_SOCKET_HANDLE(value);

        public static explicit operator WEB_SOCKET_HANDLE(HANDLE value) => new WEB_SOCKET_HANDLE(value);

        public static explicit operator int(WEB_SOCKET_HANDLE value) => (int)(value.Value);

        public static explicit operator uint(WEB_SOCKET_HANDLE value) => (uint)(value.Value);

        public static implicit operator nint(WEB_SOCKET_HANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(WEB_SOCKET_HANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(WEB_SOCKET_HANDLE value) => (void*)(value.Value);

        public static implicit operator HANDLE(WEB_SOCKET_HANDLE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is WEB_SOCKET_HANDLE other) && Equals(other);

        public bool Equals(WEB_SOCKET_HANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
