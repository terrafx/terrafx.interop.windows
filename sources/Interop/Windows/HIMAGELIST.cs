// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HIMAGELIST : IEquatable<HIMAGELIST>
    {
        public readonly nint Value;

        public HIMAGELIST(nint value)
        {
            Value = ((nint)(value));
        }

        public HIMAGELIST(nuint value)
        {
            Value = ((nint)(value));
        }

        public HIMAGELIST(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HIMAGELIST left, HIMAGELIST right) => left.Value == right.Value;

        public static bool operator !=(HIMAGELIST left, HIMAGELIST right) => left.Value != right.Value;

        public static explicit operator HIMAGELIST(nint value) => new HIMAGELIST(value);

        public static explicit operator HIMAGELIST(nuint value) => new HIMAGELIST(value);

        public static explicit operator HIMAGELIST(void* value) => new HIMAGELIST(value);

        public static implicit operator nint(HIMAGELIST value) => (nint)(value.Value);

        public static implicit operator nuint(HIMAGELIST value) => (nuint)(value.Value);

        public static implicit operator void*(HIMAGELIST value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HIMAGELIST other) && Equals(other);

        public bool Equals(HIMAGELIST other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
