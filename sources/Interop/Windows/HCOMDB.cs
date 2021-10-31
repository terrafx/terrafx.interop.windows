// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCOMDB : IEquatable<HCOMDB>
    {
        public readonly nint Value;

        public HCOMDB(nint value)
        {
            Value = ((nint)(value));
        }

        public HCOMDB(nuint value)
        {
            Value = ((nint)(value));
        }

        public HCOMDB(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HCOMDB left, HCOMDB right) => left.Value == right.Value;

        public static bool operator !=(HCOMDB left, HCOMDB right) => left.Value != right.Value;

        public static explicit operator HCOMDB(nint value) => new HCOMDB(value);

        public static explicit operator HCOMDB(nuint value) => new HCOMDB(value);

        public static explicit operator HCOMDB(void* value) => new HCOMDB(value);

        public static implicit operator nint(HCOMDB value) => (nint)(value.Value);

        public static implicit operator nuint(HCOMDB value) => (nuint)(value.Value);

        public static implicit operator void*(HCOMDB value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HCOMDB other) && Equals(other);

        public bool Equals(HCOMDB other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
