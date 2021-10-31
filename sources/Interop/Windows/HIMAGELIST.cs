// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HIMAGELIST : IEquatable<HIMAGELIST>
    {
        public readonly void* Value;

        public HIMAGELIST(int value)
        {
            Value = ((void*)(value));
        }

        public HIMAGELIST(uint value)
        {
            Value = ((void*)(value));
        }

        public HIMAGELIST(nint value)
        {
            Value = ((void*)(value));
        }

        public HIMAGELIST(nuint value)
        {
            Value = ((void*)(value));
        }

        public HIMAGELIST(void* value)
        {
            Value = ((void*)(value));
        }

        public static bool operator ==(HIMAGELIST left, HIMAGELIST right) => left.Value == right.Value;

        public static bool operator !=(HIMAGELIST left, HIMAGELIST right) => left.Value != right.Value;

        public static explicit operator HIMAGELIST(int value) => new HIMAGELIST(value);

        public static explicit operator HIMAGELIST(uint value) => new HIMAGELIST(value);

        public static explicit operator HIMAGELIST(nint value) => new HIMAGELIST(value);

        public static explicit operator HIMAGELIST(nuint value) => new HIMAGELIST(value);

        public static explicit operator HIMAGELIST(void* value) => new HIMAGELIST(value);

        public static implicit operator int(HIMAGELIST value) => (int)(value.Value);

        public static implicit operator uint(HIMAGELIST value) => (uint)(value.Value);

        public static implicit operator nint(HIMAGELIST value) => (nint)(value.Value);

        public static implicit operator nuint(HIMAGELIST value) => (nuint)(value.Value);

        public static implicit operator void*(HIMAGELIST value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HIMAGELIST other) && Equals(other);

        public bool Equals(HIMAGELIST other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
