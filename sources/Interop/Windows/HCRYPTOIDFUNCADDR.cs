// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTOIDFUNCADDR : IEquatable<HCRYPTOIDFUNCADDR>
    {
        public readonly void* Value;

        public HCRYPTOIDFUNCADDR(int value)
        {
            Value = ((void*)(value));
        }

        public HCRYPTOIDFUNCADDR(uint value)
        {
            Value = ((void*)(value));
        }

        public HCRYPTOIDFUNCADDR(nint value)
        {
            Value = ((void*)(value));
        }

        public HCRYPTOIDFUNCADDR(nuint value)
        {
            Value = ((void*)(value));
        }

        public HCRYPTOIDFUNCADDR(void* value)
        {
            Value = ((void*)(value));
        }

        public static bool operator ==(HCRYPTOIDFUNCADDR left, HCRYPTOIDFUNCADDR right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTOIDFUNCADDR left, HCRYPTOIDFUNCADDR right) => left.Value != right.Value;

        public static explicit operator HCRYPTOIDFUNCADDR(int value) => new HCRYPTOIDFUNCADDR(value);

        public static explicit operator HCRYPTOIDFUNCADDR(uint value) => new HCRYPTOIDFUNCADDR(value);

        public static explicit operator HCRYPTOIDFUNCADDR(nint value) => new HCRYPTOIDFUNCADDR(value);

        public static explicit operator HCRYPTOIDFUNCADDR(nuint value) => new HCRYPTOIDFUNCADDR(value);

        public static explicit operator HCRYPTOIDFUNCADDR(void* value) => new HCRYPTOIDFUNCADDR(value);

        public static implicit operator int(HCRYPTOIDFUNCADDR value) => (int)(value.Value);

        public static implicit operator uint(HCRYPTOIDFUNCADDR value) => (uint)(value.Value);

        public static implicit operator nint(HCRYPTOIDFUNCADDR value) => (nint)(value.Value);

        public static implicit operator nuint(HCRYPTOIDFUNCADDR value) => (nuint)(value.Value);

        public static implicit operator void*(HCRYPTOIDFUNCADDR value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HCRYPTOIDFUNCADDR other) && Equals(other);

        public bool Equals(HCRYPTOIDFUNCADDR other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
