// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDEVNOTIFY : IEquatable<HDEVNOTIFY>
    {
        public readonly void* Value;

        public HDEVNOTIFY(int value)
        {
            Value = ((void*)(value));
        }

        public HDEVNOTIFY(uint value)
        {
            Value = ((void*)(value));
        }

        public HDEVNOTIFY(nint value)
        {
            Value = ((void*)(value));
        }

        public HDEVNOTIFY(nuint value)
        {
            Value = ((void*)(value));
        }

        public HDEVNOTIFY(void* value)
        {
            Value = ((void*)(value));
        }

        public static bool operator ==(HDEVNOTIFY left, HDEVNOTIFY right) => left.Value == right.Value;

        public static bool operator !=(HDEVNOTIFY left, HDEVNOTIFY right) => left.Value != right.Value;

        public static explicit operator HDEVNOTIFY(int value) => new HDEVNOTIFY(value);

        public static explicit operator HDEVNOTIFY(uint value) => new HDEVNOTIFY(value);

        public static explicit operator HDEVNOTIFY(nint value) => new HDEVNOTIFY(value);

        public static explicit operator HDEVNOTIFY(nuint value) => new HDEVNOTIFY(value);

        public static explicit operator HDEVNOTIFY(void* value) => new HDEVNOTIFY(value);

        public static explicit operator int(HDEVNOTIFY value) => (int)(value.Value);

        public static explicit operator uint(HDEVNOTIFY value) => (uint)(value.Value);

        public static implicit operator nint(HDEVNOTIFY value) => (nint)(value.Value);

        public static implicit operator nuint(HDEVNOTIFY value) => (nuint)(value.Value);

        public static implicit operator void*(HDEVNOTIFY value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HDEVNOTIFY other) && Equals(other);

        public bool Equals(HDEVNOTIFY other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
