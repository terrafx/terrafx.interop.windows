// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HWINSTA : IEquatable<HWINSTA>
    {
        public readonly nint Value;

        public HWINSTA(nint value)
        {
            Value = ((nint)(value));
        }

        public HWINSTA(nuint value)
        {
            Value = ((nint)(value));
        }

        public HWINSTA(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HWINSTA left, HWINSTA right) => left.Value == right.Value;

        public static bool operator !=(HWINSTA left, HWINSTA right) => left.Value != right.Value;

        public static explicit operator HWINSTA(nint value) => new HWINSTA(value);

        public static explicit operator HWINSTA(nuint value) => new HWINSTA(value);

        public static explicit operator HWINSTA(void* value) => new HWINSTA(value);

        public static implicit operator nint(HWINSTA value) => (nint)(value.Value);

        public static implicit operator nuint(HWINSTA value) => (nuint)(value.Value);

        public static implicit operator void*(HWINSTA value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HWINSTA other) && Equals(other);

        public bool Equals(HWINSTA other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
