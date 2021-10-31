// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTDEFAULTCONTEXT : IEquatable<HCRYPTDEFAULTCONTEXT>
    {
        public readonly nint Value;

        public HCRYPTDEFAULTCONTEXT(nint value)
        {
            Value = ((nint)(value));
        }

        public HCRYPTDEFAULTCONTEXT(nuint value)
        {
            Value = ((nint)(value));
        }

        public HCRYPTDEFAULTCONTEXT(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HCRYPTDEFAULTCONTEXT left, HCRYPTDEFAULTCONTEXT right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTDEFAULTCONTEXT left, HCRYPTDEFAULTCONTEXT right) => left.Value != right.Value;

        public static explicit operator HCRYPTDEFAULTCONTEXT(nint value) => new HCRYPTDEFAULTCONTEXT(value);

        public static explicit operator HCRYPTDEFAULTCONTEXT(nuint value) => new HCRYPTDEFAULTCONTEXT(value);

        public static explicit operator HCRYPTDEFAULTCONTEXT(void* value) => new HCRYPTDEFAULTCONTEXT(value);

        public static implicit operator nint(HCRYPTDEFAULTCONTEXT value) => (nint)(value.Value);

        public static implicit operator nuint(HCRYPTDEFAULTCONTEXT value) => (nuint)(value.Value);

        public static implicit operator void*(HCRYPTDEFAULTCONTEXT value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HCRYPTDEFAULTCONTEXT other) && Equals(other);

        public bool Equals(HCRYPTDEFAULTCONTEXT other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
