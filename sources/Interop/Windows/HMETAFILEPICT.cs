// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HMETAFILEPICT : IEquatable<HMETAFILEPICT>
    {
        public readonly nint Value;

        public HMETAFILEPICT(nint value)
        {
            Value = ((nint)(value));
        }

        public HMETAFILEPICT(nuint value)
        {
            Value = ((nint)(value));
        }

        public HMETAFILEPICT(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HMETAFILEPICT left, HMETAFILEPICT right) => left.Value == right.Value;

        public static bool operator !=(HMETAFILEPICT left, HMETAFILEPICT right) => left.Value != right.Value;

        public static explicit operator HMETAFILEPICT(nint value) => new HMETAFILEPICT(value);

        public static explicit operator HMETAFILEPICT(nuint value) => new HMETAFILEPICT(value);

        public static explicit operator HMETAFILEPICT(void* value) => new HMETAFILEPICT(value);

        public static implicit operator nint(HMETAFILEPICT value) => (nint)(value.Value);

        public static implicit operator nuint(HMETAFILEPICT value) => (nuint)(value.Value);

        public static implicit operator void*(HMETAFILEPICT value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HMETAFILEPICT other) && Equals(other);

        public bool Equals(HMETAFILEPICT other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
