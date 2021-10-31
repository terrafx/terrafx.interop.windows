// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HRAWINPUT : IEquatable<HRAWINPUT>
    {
        public readonly nint Value;

        public HRAWINPUT(nint value)
        {
            Value = ((nint)(value));
        }

        public HRAWINPUT(nuint value)
        {
            Value = ((nint)(value));
        }

        public HRAWINPUT(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HRAWINPUT left, HRAWINPUT right) => left.Value == right.Value;

        public static bool operator !=(HRAWINPUT left, HRAWINPUT right) => left.Value != right.Value;

        public static explicit operator HRAWINPUT(nint value) => new HRAWINPUT(value);

        public static explicit operator HRAWINPUT(nuint value) => new HRAWINPUT(value);

        public static explicit operator HRAWINPUT(void* value) => new HRAWINPUT(value);

        public static implicit operator nint(HRAWINPUT value) => (nint)(value.Value);

        public static implicit operator nuint(HRAWINPUT value) => (nuint)(value.Value);

        public static implicit operator void*(HRAWINPUT value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HRAWINPUT other) && Equals(other);

        public bool Equals(HRAWINPUT other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
