// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTHASH : IEquatable<HCRYPTHASH>
    {
        public readonly nint Value;

        public HCRYPTHASH(nint value)
        {
            Value = ((nint)(value));
        }

        public HCRYPTHASH(nuint value)
        {
            Value = ((nint)(value));
        }

        public HCRYPTHASH(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HCRYPTHASH left, HCRYPTHASH right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTHASH left, HCRYPTHASH right) => left.Value != right.Value;

        public static explicit operator HCRYPTHASH(nint value) => new HCRYPTHASH(value);

        public static explicit operator HCRYPTHASH(nuint value) => new HCRYPTHASH(value);

        public static explicit operator HCRYPTHASH(void* value) => new HCRYPTHASH(value);

        public static implicit operator nint(HCRYPTHASH value) => (nint)(value.Value);

        public static implicit operator nuint(HCRYPTHASH value) => (nuint)(value.Value);

        public static implicit operator void*(HCRYPTHASH value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HCRYPTHASH other) && Equals(other);

        public bool Equals(HCRYPTHASH other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
