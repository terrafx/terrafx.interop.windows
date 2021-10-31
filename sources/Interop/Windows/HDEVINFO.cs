// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDEVINFO : IEquatable<HDEVINFO>
    {
        public readonly void* Value;

        public HDEVINFO(int value)
        {
            Value = ((void*)(value));
        }

        public HDEVINFO(uint value)
        {
            Value = ((void*)(value));
        }

        public HDEVINFO(nint value)
        {
            Value = ((void*)(value));
        }

        public HDEVINFO(nuint value)
        {
            Value = ((void*)(value));
        }

        public HDEVINFO(void* value)
        {
            Value = ((void*)(value));
        }

        public static bool operator ==(HDEVINFO left, HDEVINFO right) => left.Value == right.Value;

        public static bool operator !=(HDEVINFO left, HDEVINFO right) => left.Value != right.Value;

        public static explicit operator HDEVINFO(int value) => new HDEVINFO(value);

        public static explicit operator HDEVINFO(uint value) => new HDEVINFO(value);

        public static explicit operator HDEVINFO(nint value) => new HDEVINFO(value);

        public static explicit operator HDEVINFO(nuint value) => new HDEVINFO(value);

        public static explicit operator HDEVINFO(void* value) => new HDEVINFO(value);

        public static implicit operator int(HDEVINFO value) => (int)(value.Value);

        public static implicit operator uint(HDEVINFO value) => (uint)(value.Value);

        public static implicit operator nint(HDEVINFO value) => (nint)(value.Value);

        public static implicit operator nuint(HDEVINFO value) => (nuint)(value.Value);

        public static implicit operator void*(HDEVINFO value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HDEVINFO other) && Equals(other);

        public bool Equals(HDEVINFO other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
