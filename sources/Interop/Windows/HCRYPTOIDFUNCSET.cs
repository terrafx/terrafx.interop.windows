// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTOIDFUNCSET : IEquatable<HCRYPTOIDFUNCSET>
    {
        public readonly nint Value;

        public HCRYPTOIDFUNCSET(nint value)
        {
            Value = ((nint)(value));
        }

        public HCRYPTOIDFUNCSET(nuint value)
        {
            Value = ((nint)(value));
        }

        public HCRYPTOIDFUNCSET(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HCRYPTOIDFUNCSET left, HCRYPTOIDFUNCSET right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTOIDFUNCSET left, HCRYPTOIDFUNCSET right) => left.Value != right.Value;

        public static explicit operator HCRYPTOIDFUNCSET(nint value) => new HCRYPTOIDFUNCSET(value);

        public static explicit operator HCRYPTOIDFUNCSET(nuint value) => new HCRYPTOIDFUNCSET(value);

        public static explicit operator HCRYPTOIDFUNCSET(void* value) => new HCRYPTOIDFUNCSET(value);

        public static implicit operator nint(HCRYPTOIDFUNCSET value) => (nint)(value.Value);

        public static implicit operator nuint(HCRYPTOIDFUNCSET value) => (nuint)(value.Value);

        public static implicit operator void*(HCRYPTOIDFUNCSET value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HCRYPTOIDFUNCSET other) && Equals(other);

        public bool Equals(HCRYPTOIDFUNCSET other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
