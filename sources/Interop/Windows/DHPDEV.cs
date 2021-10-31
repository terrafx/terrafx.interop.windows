// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct DHPDEV : IEquatable<DHPDEV>
    {
        public readonly nint Value;

        public DHPDEV(int value)
        {
            Value = ((nint)(value));
        }

        public DHPDEV(uint value)
        {
            Value = ((nint)(value));
        }

        public DHPDEV(nint value)
        {
            Value = ((nint)(value));
        }

        public DHPDEV(nuint value)
        {
            Value = ((nint)(value));
        }

        public DHPDEV(void* value)
        {
            Value = ((nint)(value));
        }

        public DHPDEV(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(DHPDEV left, DHPDEV right) => left.Value == right.Value;

        public static bool operator !=(DHPDEV left, DHPDEV right) => left.Value != right.Value;

        public static explicit operator DHPDEV(int value) => new DHPDEV(value);

        public static explicit operator DHPDEV(uint value) => new DHPDEV(value);

        public static explicit operator DHPDEV(nint value) => new DHPDEV(value);

        public static explicit operator DHPDEV(nuint value) => new DHPDEV(value);

        public static explicit operator DHPDEV(void* value) => new DHPDEV(value);

        public static explicit operator DHPDEV(HANDLE value) => new DHPDEV(value);

        public static implicit operator int(DHPDEV value) => (int)(value.Value);

        public static implicit operator uint(DHPDEV value) => (uint)(value.Value);

        public static implicit operator nint(DHPDEV value) => (nint)(value.Value);

        public static implicit operator nuint(DHPDEV value) => (nuint)(value.Value);

        public static implicit operator void*(DHPDEV value) => (void*)(value.Value);

        public static implicit operator HANDLE(DHPDEV value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is DHPDEV other) && Equals(other);

        public bool Equals(DHPDEV other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
