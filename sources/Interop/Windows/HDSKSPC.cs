// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDSKSPC : IEquatable<HDSKSPC>
    {
        public readonly void* Value;

        public HDSKSPC(int value)
        {
            Value = ((void*)(value));
        }

        public HDSKSPC(uint value)
        {
            Value = ((void*)(value));
        }

        public HDSKSPC(nint value)
        {
            Value = ((void*)(value));
        }

        public HDSKSPC(nuint value)
        {
            Value = ((void*)(value));
        }

        public HDSKSPC(void* value)
        {
            Value = ((void*)(value));
        }

        public static bool operator ==(HDSKSPC left, HDSKSPC right) => left.Value == right.Value;

        public static bool operator !=(HDSKSPC left, HDSKSPC right) => left.Value != right.Value;

        public static explicit operator HDSKSPC(int value) => new HDSKSPC(value);

        public static explicit operator HDSKSPC(uint value) => new HDSKSPC(value);

        public static explicit operator HDSKSPC(nint value) => new HDSKSPC(value);

        public static explicit operator HDSKSPC(nuint value) => new HDSKSPC(value);

        public static explicit operator HDSKSPC(void* value) => new HDSKSPC(value);

        public static explicit operator int(HDSKSPC value) => (int)(value.Value);

        public static explicit operator uint(HDSKSPC value) => (uint)(value.Value);

        public static implicit operator nint(HDSKSPC value) => (nint)(value.Value);

        public static implicit operator nuint(HDSKSPC value) => (nuint)(value.Value);

        public static implicit operator void*(HDSKSPC value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HDSKSPC other) && Equals(other);

        public bool Equals(HDSKSPC other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
