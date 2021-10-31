// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HPOWERNOTIFY : IEquatable<HPOWERNOTIFY>
    {
        public readonly void* Value;

        public HPOWERNOTIFY(int value)
        {
            Value = ((void*)(value));
        }

        public HPOWERNOTIFY(uint value)
        {
            Value = ((void*)(value));
        }

        public HPOWERNOTIFY(nint value)
        {
            Value = ((void*)(value));
        }

        public HPOWERNOTIFY(nuint value)
        {
            Value = ((void*)(value));
        }

        public HPOWERNOTIFY(void* value)
        {
            Value = ((void*)(value));
        }

        public static bool operator ==(HPOWERNOTIFY left, HPOWERNOTIFY right) => left.Value == right.Value;

        public static bool operator !=(HPOWERNOTIFY left, HPOWERNOTIFY right) => left.Value != right.Value;

        public static explicit operator HPOWERNOTIFY(int value) => new HPOWERNOTIFY(value);

        public static explicit operator HPOWERNOTIFY(uint value) => new HPOWERNOTIFY(value);

        public static explicit operator HPOWERNOTIFY(nint value) => new HPOWERNOTIFY(value);

        public static explicit operator HPOWERNOTIFY(nuint value) => new HPOWERNOTIFY(value);

        public static explicit operator HPOWERNOTIFY(void* value) => new HPOWERNOTIFY(value);

        public static implicit operator int(HPOWERNOTIFY value) => (int)(value.Value);

        public static implicit operator uint(HPOWERNOTIFY value) => (uint)(value.Value);

        public static implicit operator nint(HPOWERNOTIFY value) => (nint)(value.Value);

        public static implicit operator nuint(HPOWERNOTIFY value) => (nuint)(value.Value);

        public static implicit operator void*(HPOWERNOTIFY value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HPOWERNOTIFY other) && Equals(other);

        public bool Equals(HPOWERNOTIFY other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
