// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct OAHWND : IEquatable<OAHWND>
    {
        public readonly nint Value;

        public OAHWND(int value)
        {
            Value = ((nint)(value));
        }

        public OAHWND(uint value)
        {
            Value = ((nint)(value));
        }

        public OAHWND(nint value)
        {
            Value = ((nint)(value));
        }

        public OAHWND(nuint value)
        {
            Value = ((nint)(value));
        }

        public OAHWND(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(OAHWND left, OAHWND right) => left.Value == right.Value;

        public static bool operator !=(OAHWND left, OAHWND right) => left.Value != right.Value;

        public static explicit operator OAHWND(int value) => new OAHWND(value);

        public static explicit operator OAHWND(uint value) => new OAHWND(value);

        public static explicit operator OAHWND(nint value) => new OAHWND(value);

        public static explicit operator OAHWND(nuint value) => new OAHWND(value);

        public static explicit operator OAHWND(void* value) => new OAHWND(value);

        public static implicit operator int(OAHWND value) => (int)(value.Value);

        public static implicit operator uint(OAHWND value) => (uint)(value.Value);

        public static implicit operator nint(OAHWND value) => (nint)(value.Value);

        public static implicit operator nuint(OAHWND value) => (nuint)(value.Value);

        public static implicit operator void*(OAHWND value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is OAHWND other) && Equals(other);

        public bool Equals(OAHWND other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
