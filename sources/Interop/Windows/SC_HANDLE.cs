// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SC_HANDLE : IEquatable<SC_HANDLE>
    {
        public readonly nint Value;

        public static SC_HANDLE NULL => (SC_HANDLE)(0);

        public SC_HANDLE(int value)
        {
            Value = ((nint)(value));
        }

        public SC_HANDLE(uint value)
        {
            Value = ((nint)(value));
        }

        public SC_HANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public SC_HANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public SC_HANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public SC_HANDLE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(SC_HANDLE left, SC_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(SC_HANDLE left, SC_HANDLE right) => left.Value != right.Value;

        public static explicit operator SC_HANDLE(int value) => new SC_HANDLE(value);

        public static explicit operator SC_HANDLE(uint value) => new SC_HANDLE(value);

        public static explicit operator SC_HANDLE(nint value) => new SC_HANDLE(value);

        public static explicit operator SC_HANDLE(nuint value) => new SC_HANDLE(value);

        public static explicit operator SC_HANDLE(void* value) => new SC_HANDLE(value);

        public static explicit operator SC_HANDLE(HANDLE value) => new SC_HANDLE(value);

        public static implicit operator int(SC_HANDLE value) => (int)(value.Value);

        public static implicit operator uint(SC_HANDLE value) => (uint)(value.Value);

        public static implicit operator nint(SC_HANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(SC_HANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(SC_HANDLE value) => (void*)(value.Value);

        public static implicit operator HANDLE(SC_HANDLE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is SC_HANDLE other) && Equals(other);

        public bool Equals(SC_HANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
