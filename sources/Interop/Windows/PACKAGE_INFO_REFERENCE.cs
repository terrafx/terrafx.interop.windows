// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PACKAGE_INFO_REFERENCE : IEquatable<PACKAGE_INFO_REFERENCE>
    {
        public readonly nint Value;

        public PACKAGE_INFO_REFERENCE(nint value)
        {
            Value = ((nint)(value));
        }

        public PACKAGE_INFO_REFERENCE(nuint value)
        {
            Value = ((nint)(value));
        }

        public PACKAGE_INFO_REFERENCE(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(PACKAGE_INFO_REFERENCE left, PACKAGE_INFO_REFERENCE right) => left.Value == right.Value;

        public static bool operator !=(PACKAGE_INFO_REFERENCE left, PACKAGE_INFO_REFERENCE right) => left.Value != right.Value;

        public static explicit operator PACKAGE_INFO_REFERENCE(nint value) => new PACKAGE_INFO_REFERENCE(value);

        public static explicit operator PACKAGE_INFO_REFERENCE(nuint value) => new PACKAGE_INFO_REFERENCE(value);

        public static explicit operator PACKAGE_INFO_REFERENCE(void* value) => new PACKAGE_INFO_REFERENCE(value);

        public static implicit operator nint(PACKAGE_INFO_REFERENCE value) => (nint)(value.Value);

        public static implicit operator nuint(PACKAGE_INFO_REFERENCE value) => (nuint)(value.Value);

        public static implicit operator void*(PACKAGE_INFO_REFERENCE value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is PACKAGE_INFO_REFERENCE other) && Equals(other);

        public bool Equals(PACKAGE_INFO_REFERENCE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
