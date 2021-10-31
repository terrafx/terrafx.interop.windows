// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSTRING_BUFFER : IEquatable<HSTRING_BUFFER>
    {
        public readonly nint Value;

        public HSTRING_BUFFER(nint value)
        {
            Value = ((nint)(value));
        }

        public HSTRING_BUFFER(nuint value)
        {
            Value = ((nint)(value));
        }

        public HSTRING_BUFFER(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HSTRING_BUFFER left, HSTRING_BUFFER right) => left.Value == right.Value;

        public static bool operator !=(HSTRING_BUFFER left, HSTRING_BUFFER right) => left.Value != right.Value;

        public static explicit operator HSTRING_BUFFER(nint value) => new HSTRING_BUFFER(value);

        public static explicit operator HSTRING_BUFFER(nuint value) => new HSTRING_BUFFER(value);

        public static explicit operator HSTRING_BUFFER(void* value) => new HSTRING_BUFFER(value);

        public static implicit operator nint(HSTRING_BUFFER value) => (nint)(value.Value);

        public static implicit operator nuint(HSTRING_BUFFER value) => (nuint)(value.Value);

        public static implicit operator void*(HSTRING_BUFFER value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HSTRING_BUFFER other) && Equals(other);

        public bool Equals(HSTRING_BUFFER other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
