// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HINTERNET : IEquatable<HINTERNET>
    {
        public readonly nint Value;

        public HINTERNET(nint value)
        {
            Value = ((nint)(value));
        }

        public HINTERNET(nuint value)
        {
            Value = ((nint)(value));
        }

        public HINTERNET(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HINTERNET left, HINTERNET right) => left.Value == right.Value;

        public static bool operator !=(HINTERNET left, HINTERNET right) => left.Value != right.Value;

        public static explicit operator HINTERNET(nint value) => new HINTERNET(value);

        public static explicit operator HINTERNET(nuint value) => new HINTERNET(value);

        public static explicit operator HINTERNET(void* value) => new HINTERNET(value);

        public static implicit operator nint(HINTERNET value) => (nint)(value.Value);

        public static implicit operator nuint(HINTERNET value) => (nuint)(value.Value);

        public static implicit operator void*(HINTERNET value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HINTERNET other) && Equals(other);

        public bool Equals(HINTERNET other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
