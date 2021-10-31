// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCERTSTOREPROV : IEquatable<HCERTSTOREPROV>
    {
        public readonly void* Value;

        public HCERTSTOREPROV(int value)
        {
            Value = ((void*)(value));
        }

        public HCERTSTOREPROV(uint value)
        {
            Value = ((void*)(value));
        }

        public HCERTSTOREPROV(nint value)
        {
            Value = ((void*)(value));
        }

        public HCERTSTOREPROV(nuint value)
        {
            Value = ((void*)(value));
        }

        public HCERTSTOREPROV(void* value)
        {
            Value = ((void*)(value));
        }

        public static bool operator ==(HCERTSTOREPROV left, HCERTSTOREPROV right) => left.Value == right.Value;

        public static bool operator !=(HCERTSTOREPROV left, HCERTSTOREPROV right) => left.Value != right.Value;

        public static explicit operator HCERTSTOREPROV(int value) => new HCERTSTOREPROV(value);

        public static explicit operator HCERTSTOREPROV(uint value) => new HCERTSTOREPROV(value);

        public static explicit operator HCERTSTOREPROV(nint value) => new HCERTSTOREPROV(value);

        public static explicit operator HCERTSTOREPROV(nuint value) => new HCERTSTOREPROV(value);

        public static explicit operator HCERTSTOREPROV(void* value) => new HCERTSTOREPROV(value);

        public static explicit operator int(HCERTSTOREPROV value) => (int)(value.Value);

        public static explicit operator uint(HCERTSTOREPROV value) => (uint)(value.Value);

        public static implicit operator nint(HCERTSTOREPROV value) => (nint)(value.Value);

        public static implicit operator nuint(HCERTSTOREPROV value) => (nuint)(value.Value);

        public static implicit operator void*(HCERTSTOREPROV value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HCERTSTOREPROV other) && Equals(other);

        public bool Equals(HCERTSTOREPROV other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
