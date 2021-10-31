// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HVIDEO : IEquatable<HVIDEO>
    {
        public readonly nint Value;

        public HVIDEO(int value)
        {
            Value = ((nint)(value));
        }

        public HVIDEO(uint value)
        {
            Value = ((nint)(value));
        }

        public HVIDEO(nint value)
        {
            Value = ((nint)(value));
        }

        public HVIDEO(nuint value)
        {
            Value = ((nint)(value));
        }

        public HVIDEO(void* value)
        {
            Value = ((nint)(value));
        }

        public HVIDEO(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HVIDEO left, HVIDEO right) => left.Value == right.Value;

        public static bool operator !=(HVIDEO left, HVIDEO right) => left.Value != right.Value;

        public static explicit operator HVIDEO(int value) => new HVIDEO(value);

        public static explicit operator HVIDEO(uint value) => new HVIDEO(value);

        public static explicit operator HVIDEO(nint value) => new HVIDEO(value);

        public static explicit operator HVIDEO(nuint value) => new HVIDEO(value);

        public static explicit operator HVIDEO(void* value) => new HVIDEO(value);

        public static explicit operator HVIDEO(HANDLE value) => new HVIDEO(value);

        public static implicit operator int(HVIDEO value) => (int)(value.Value);

        public static implicit operator uint(HVIDEO value) => (uint)(value.Value);

        public static implicit operator nint(HVIDEO value) => (nint)(value.Value);

        public static implicit operator nuint(HVIDEO value) => (nuint)(value.Value);

        public static implicit operator void*(HVIDEO value) => (void*)(value.Value);

        public static implicit operator HANDLE(HVIDEO value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HVIDEO other) && Equals(other);

        public bool Equals(HVIDEO other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
