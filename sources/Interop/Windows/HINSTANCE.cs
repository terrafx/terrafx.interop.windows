// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HINSTANCE : IEquatable<HINSTANCE>
    {
        public readonly nint Value;

        public HINSTANCE(nint value)
        {
            Value = ((nint)(value));
        }

        public HINSTANCE(nuint value)
        {
            Value = ((nint)(value));
        }

        public HINSTANCE(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HINSTANCE left, HINSTANCE right) => left.Value == right.Value;

        public static bool operator !=(HINSTANCE left, HINSTANCE right) => left.Value != right.Value;

        public static explicit operator HINSTANCE(nint value) => new HINSTANCE(value);

        public static explicit operator HINSTANCE(nuint value) => new HINSTANCE(value);

        public static explicit operator HINSTANCE(void* value) => new HINSTANCE(value);

        public static implicit operator nint(HINSTANCE value) => (nint)(value.Value);

        public static implicit operator nuint(HINSTANCE value) => (nuint)(value.Value);

        public static implicit operator void*(HINSTANCE value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HINSTANCE other) && Equals(other);

        public bool Equals(HINSTANCE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
