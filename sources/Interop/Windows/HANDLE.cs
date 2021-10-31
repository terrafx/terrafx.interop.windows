// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HANDLE : IEquatable<HANDLE>
    {
        public readonly nint Value;

        public HANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public HANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public HANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HANDLE left, HANDLE right) => left.Value == right.Value;

        public static bool operator !=(HANDLE left, HANDLE right) => left.Value != right.Value;

        public static explicit operator HANDLE(nint value) => new HANDLE(value);

        public static explicit operator HANDLE(nuint value) => new HANDLE(value);

        public static explicit operator HANDLE(void* value) => new HANDLE(value);

        public static implicit operator nint(HANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(HANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(HANDLE value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HANDLE other) && Equals(other);

        public bool Equals(HANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
