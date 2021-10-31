// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSPFILELOG : IEquatable<HSPFILELOG>
    {
        public readonly nint Value;

        public HSPFILELOG(nint value)
        {
            Value = ((nint)(value));
        }

        public HSPFILELOG(nuint value)
        {
            Value = ((nint)(value));
        }

        public HSPFILELOG(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HSPFILELOG left, HSPFILELOG right) => left.Value == right.Value;

        public static bool operator !=(HSPFILELOG left, HSPFILELOG right) => left.Value != right.Value;

        public static explicit operator HSPFILELOG(nint value) => new HSPFILELOG(value);

        public static explicit operator HSPFILELOG(nuint value) => new HSPFILELOG(value);

        public static explicit operator HSPFILELOG(void* value) => new HSPFILELOG(value);

        public static implicit operator nint(HSPFILELOG value) => (nint)(value.Value);

        public static implicit operator nuint(HSPFILELOG value) => (nuint)(value.Value);

        public static implicit operator void*(HSPFILELOG value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HSPFILELOG other) && Equals(other);

        public bool Equals(HSPFILELOG other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
