// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HRSRC : IEquatable<HRSRC>
    {
        public readonly nint Value;

        public HRSRC(nint value)
        {
            Value = ((nint)(value));
        }

        public HRSRC(nuint value)
        {
            Value = ((nint)(value));
        }

        public HRSRC(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HRSRC left, HRSRC right) => left.Value == right.Value;

        public static bool operator !=(HRSRC left, HRSRC right) => left.Value != right.Value;

        public static explicit operator HRSRC(nint value) => new HRSRC(value);

        public static explicit operator HRSRC(nuint value) => new HRSRC(value);

        public static explicit operator HRSRC(void* value) => new HRSRC(value);

        public static implicit operator nint(HRSRC value) => (nint)(value.Value);

        public static implicit operator nuint(HRSRC value) => (nuint)(value.Value);

        public static implicit operator void*(HRSRC value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HRSRC other) && Equals(other);

        public bool Equals(HRSRC other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
