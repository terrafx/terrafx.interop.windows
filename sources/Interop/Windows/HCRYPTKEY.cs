// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTKEY : IEquatable<HCRYPTKEY>
    {
        public readonly nint Value;

        public HCRYPTKEY(nint value)
        {
            Value = ((nint)(value));
        }

        public HCRYPTKEY(nuint value)
        {
            Value = ((nint)(value));
        }

        public HCRYPTKEY(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HCRYPTKEY left, HCRYPTKEY right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTKEY left, HCRYPTKEY right) => left.Value != right.Value;

        public static explicit operator HCRYPTKEY(nint value) => new HCRYPTKEY(value);

        public static explicit operator HCRYPTKEY(nuint value) => new HCRYPTKEY(value);

        public static explicit operator HCRYPTKEY(void* value) => new HCRYPTKEY(value);

        public static implicit operator nint(HCRYPTKEY value) => (nint)(value.Value);

        public static implicit operator nuint(HCRYPTKEY value) => (nuint)(value.Value);

        public static implicit operator void*(HCRYPTKEY value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HCRYPTKEY other) && Equals(other);

        public bool Equals(HCRYPTKEY other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
