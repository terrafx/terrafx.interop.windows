// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HGESTUREINFO : IEquatable<HGESTUREINFO>
    {
        public readonly nint Value;

        public HGESTUREINFO(nint value)
        {
            Value = ((nint)(value));
        }

        public HGESTUREINFO(nuint value)
        {
            Value = ((nint)(value));
        }

        public HGESTUREINFO(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HGESTUREINFO left, HGESTUREINFO right) => left.Value == right.Value;

        public static bool operator !=(HGESTUREINFO left, HGESTUREINFO right) => left.Value != right.Value;

        public static explicit operator HGESTUREINFO(nint value) => new HGESTUREINFO(value);

        public static explicit operator HGESTUREINFO(nuint value) => new HGESTUREINFO(value);

        public static explicit operator HGESTUREINFO(void* value) => new HGESTUREINFO(value);

        public static implicit operator nint(HGESTUREINFO value) => (nint)(value.Value);

        public static implicit operator nuint(HGESTUREINFO value) => (nuint)(value.Value);

        public static implicit operator void*(HGESTUREINFO value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HGESTUREINFO other) && Equals(other);

        public bool Equals(HGESTUREINFO other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
