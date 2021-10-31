// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCERTSTOREPROV : IEquatable<HCERTSTOREPROV>
    {
        public readonly nint Value;

        public HCERTSTOREPROV(nint value)
        {
            Value = ((nint)(value));
        }

        public HCERTSTOREPROV(nuint value)
        {
            Value = ((nint)(value));
        }

        public HCERTSTOREPROV(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HCERTSTOREPROV left, HCERTSTOREPROV right) => left.Value == right.Value;

        public static bool operator !=(HCERTSTOREPROV left, HCERTSTOREPROV right) => left.Value != right.Value;

        public static explicit operator HCERTSTOREPROV(nint value) => new HCERTSTOREPROV(value);

        public static explicit operator HCERTSTOREPROV(nuint value) => new HCERTSTOREPROV(value);

        public static explicit operator HCERTSTOREPROV(void* value) => new HCERTSTOREPROV(value);

        public static implicit operator nint(HCERTSTOREPROV value) => (nint)(value.Value);

        public static implicit operator nuint(HCERTSTOREPROV value) => (nuint)(value.Value);

        public static implicit operator void*(HCERTSTOREPROV value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HCERTSTOREPROV other) && Equals(other);

        public bool Equals(HCERTSTOREPROV other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
