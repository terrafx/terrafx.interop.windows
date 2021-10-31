// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCERTSTORE : IEquatable<HCERTSTORE>
    {
        public readonly nint Value;

        public HCERTSTORE(nint value)
        {
            Value = ((nint)(value));
        }

        public HCERTSTORE(nuint value)
        {
            Value = ((nint)(value));
        }

        public HCERTSTORE(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HCERTSTORE left, HCERTSTORE right) => left.Value == right.Value;

        public static bool operator !=(HCERTSTORE left, HCERTSTORE right) => left.Value != right.Value;

        public static explicit operator HCERTSTORE(nint value) => new HCERTSTORE(value);

        public static explicit operator HCERTSTORE(nuint value) => new HCERTSTORE(value);

        public static explicit operator HCERTSTORE(void* value) => new HCERTSTORE(value);

        public static implicit operator nint(HCERTSTORE value) => (nint)(value.Value);

        public static implicit operator nuint(HCERTSTORE value) => (nuint)(value.Value);

        public static implicit operator void*(HCERTSTORE value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HCERTSTORE other) && Equals(other);

        public bool Equals(HCERTSTORE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
