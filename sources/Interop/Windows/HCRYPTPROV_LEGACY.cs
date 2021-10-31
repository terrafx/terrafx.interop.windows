// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTPROV_LEGACY : IEquatable<HCRYPTPROV_LEGACY>
    {
        public readonly nuint Value;

        public HCRYPTPROV_LEGACY(int value)
        {
            Value = ((nuint)(value));
        }

        public HCRYPTPROV_LEGACY(uint value)
        {
            Value = ((nuint)(value));
        }

        public HCRYPTPROV_LEGACY(nint value)
        {
            Value = ((nuint)(value));
        }

        public HCRYPTPROV_LEGACY(nuint value)
        {
            Value = ((nuint)(value));
        }

        public HCRYPTPROV_LEGACY(void* value)
        {
            Value = ((nuint)(value));
        }

        public static bool operator ==(HCRYPTPROV_LEGACY left, HCRYPTPROV_LEGACY right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTPROV_LEGACY left, HCRYPTPROV_LEGACY right) => left.Value != right.Value;

        public static explicit operator HCRYPTPROV_LEGACY(int value) => new HCRYPTPROV_LEGACY(value);

        public static explicit operator HCRYPTPROV_LEGACY(uint value) => new HCRYPTPROV_LEGACY(value);

        public static explicit operator HCRYPTPROV_LEGACY(nint value) => new HCRYPTPROV_LEGACY(value);

        public static explicit operator HCRYPTPROV_LEGACY(nuint value) => new HCRYPTPROV_LEGACY(value);

        public static explicit operator HCRYPTPROV_LEGACY(void* value) => new HCRYPTPROV_LEGACY(value);

        public static implicit operator int(HCRYPTPROV_LEGACY value) => (int)(value.Value);

        public static implicit operator uint(HCRYPTPROV_LEGACY value) => (uint)(value.Value);

        public static implicit operator nint(HCRYPTPROV_LEGACY value) => (nint)(value.Value);

        public static implicit operator nuint(HCRYPTPROV_LEGACY value) => (nuint)(value.Value);

        public static implicit operator void*(HCRYPTPROV_LEGACY value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HCRYPTPROV_LEGACY other) && Equals(other);

        public bool Equals(HCRYPTPROV_LEGACY other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
