// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSTR : IEquatable<HSTR>
    {
        public readonly nint Value;

        public HSTR(nint value)
        {
            Value = ((nint)(value));
        }

        public HSTR(nuint value)
        {
            Value = ((nint)(value));
        }

        public HSTR(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HSTR left, HSTR right) => left.Value == right.Value;

        public static bool operator !=(HSTR left, HSTR right) => left.Value != right.Value;

        public static explicit operator HSTR(nint value) => new HSTR(value);

        public static explicit operator HSTR(nuint value) => new HSTR(value);

        public static explicit operator HSTR(void* value) => new HSTR(value);

        public static implicit operator nint(HSTR value) => (nint)(value.Value);

        public static implicit operator nuint(HSTR value) => (nuint)(value.Value);

        public static implicit operator void*(HSTR value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HSTR other) && Equals(other);

        public bool Equals(HSTR other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
