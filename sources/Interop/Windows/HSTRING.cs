// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSTRING : IEquatable<HSTRING>
    {
        public readonly nint Value;

        public HSTRING(nint value)
        {
            Value = ((nint)(value));
        }

        public HSTRING(nuint value)
        {
            Value = ((nint)(value));
        }

        public HSTRING(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HSTRING left, HSTRING right) => left.Value == right.Value;

        public static bool operator !=(HSTRING left, HSTRING right) => left.Value != right.Value;

        public static explicit operator HSTRING(nint value) => new HSTRING(value);

        public static explicit operator HSTRING(nuint value) => new HSTRING(value);

        public static explicit operator HSTRING(void* value) => new HSTRING(value);

        public static implicit operator nint(HSTRING value) => (nint)(value.Value);

        public static implicit operator nuint(HSTRING value) => (nuint)(value.Value);

        public static implicit operator void*(HSTRING value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HSTRING other) && Equals(other);

        public bool Equals(HSTRING other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
