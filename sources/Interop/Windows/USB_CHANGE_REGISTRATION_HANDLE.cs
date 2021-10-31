// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct USB_CHANGE_REGISTRATION_HANDLE : IEquatable<USB_CHANGE_REGISTRATION_HANDLE>
    {
        public readonly nint Value;

        public static USB_CHANGE_REGISTRATION_HANDLE NULL => (USB_CHANGE_REGISTRATION_HANDLE)(0);

        public USB_CHANGE_REGISTRATION_HANDLE(int value)
        {
            Value = ((nint)(value));
        }

        public USB_CHANGE_REGISTRATION_HANDLE(uint value)
        {
            Value = ((nint)(value));
        }

        public USB_CHANGE_REGISTRATION_HANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public USB_CHANGE_REGISTRATION_HANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public USB_CHANGE_REGISTRATION_HANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public USB_CHANGE_REGISTRATION_HANDLE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(USB_CHANGE_REGISTRATION_HANDLE left, USB_CHANGE_REGISTRATION_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(USB_CHANGE_REGISTRATION_HANDLE left, USB_CHANGE_REGISTRATION_HANDLE right) => left.Value != right.Value;

        public static explicit operator USB_CHANGE_REGISTRATION_HANDLE(int value) => new USB_CHANGE_REGISTRATION_HANDLE(value);

        public static explicit operator USB_CHANGE_REGISTRATION_HANDLE(uint value) => new USB_CHANGE_REGISTRATION_HANDLE(value);

        public static explicit operator USB_CHANGE_REGISTRATION_HANDLE(nint value) => new USB_CHANGE_REGISTRATION_HANDLE(value);

        public static explicit operator USB_CHANGE_REGISTRATION_HANDLE(nuint value) => new USB_CHANGE_REGISTRATION_HANDLE(value);

        public static explicit operator USB_CHANGE_REGISTRATION_HANDLE(void* value) => new USB_CHANGE_REGISTRATION_HANDLE(value);

        public static explicit operator USB_CHANGE_REGISTRATION_HANDLE(HANDLE value) => new USB_CHANGE_REGISTRATION_HANDLE(value);

        public static implicit operator int(USB_CHANGE_REGISTRATION_HANDLE value) => (int)(value.Value);

        public static implicit operator uint(USB_CHANGE_REGISTRATION_HANDLE value) => (uint)(value.Value);

        public static implicit operator nint(USB_CHANGE_REGISTRATION_HANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(USB_CHANGE_REGISTRATION_HANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(USB_CHANGE_REGISTRATION_HANDLE value) => (void*)(value.Value);

        public static implicit operator HANDLE(USB_CHANGE_REGISTRATION_HANDLE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is USB_CHANGE_REGISTRATION_HANDLE other) && Equals(other);

        public bool Equals(USB_CHANGE_REGISTRATION_HANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
