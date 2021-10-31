// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HPSXA : IEquatable<HPSXA>
    {
        public readonly nint Value;

        public HPSXA(nint value)
        {
            Value = ((nint)(value));
        }

        public HPSXA(nuint value)
        {
            Value = ((nint)(value));
        }

        public HPSXA(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HPSXA left, HPSXA right) => left.Value == right.Value;

        public static bool operator !=(HPSXA left, HPSXA right) => left.Value != right.Value;

        public static explicit operator HPSXA(nint value) => new HPSXA(value);

        public static explicit operator HPSXA(nuint value) => new HPSXA(value);

        public static explicit operator HPSXA(void* value) => new HPSXA(value);

        public static implicit operator nint(HPSXA value) => (nint)(value.Value);

        public static implicit operator nuint(HPSXA value) => (nuint)(value.Value);

        public static implicit operator void*(HPSXA value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HPSXA other) && Equals(other);

        public bool Equals(HPSXA other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
