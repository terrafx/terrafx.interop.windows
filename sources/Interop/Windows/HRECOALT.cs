// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HRECOALT : IEquatable<HRECOALT>
    {
        public readonly nint Value;

        public static HRECOALT NULL => (HRECOALT)(0);

        public HRECOALT(int value)
        {
            Value = ((nint)(value));
        }

        public HRECOALT(uint value)
        {
            Value = ((nint)(value));
        }

        public HRECOALT(nint value)
        {
            Value = ((nint)(value));
        }

        public HRECOALT(nuint value)
        {
            Value = ((nint)(value));
        }

        public HRECOALT(void* value)
        {
            Value = ((nint)(value));
        }

        public HRECOALT(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HRECOALT left, HRECOALT right) => left.Value == right.Value;

        public static bool operator !=(HRECOALT left, HRECOALT right) => left.Value != right.Value;

        public static explicit operator HRECOALT(int value) => new HRECOALT(value);

        public static explicit operator HRECOALT(uint value) => new HRECOALT(value);

        public static explicit operator HRECOALT(nint value) => new HRECOALT(value);

        public static explicit operator HRECOALT(nuint value) => new HRECOALT(value);

        public static explicit operator HRECOALT(void* value) => new HRECOALT(value);

        public static explicit operator HRECOALT(HANDLE value) => new HRECOALT(value);

        public static implicit operator int(HRECOALT value) => (int)(value.Value);

        public static implicit operator uint(HRECOALT value) => (uint)(value.Value);

        public static implicit operator nint(HRECOALT value) => (nint)(value.Value);

        public static implicit operator nuint(HRECOALT value) => (nuint)(value.Value);

        public static implicit operator void*(HRECOALT value) => (void*)(value.Value);

        public static implicit operator HANDLE(HRECOALT value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HRECOALT other) && Equals(other);

        public bool Equals(HRECOALT other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
