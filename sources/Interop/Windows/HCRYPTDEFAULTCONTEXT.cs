// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HCRYPTDEFAULTCONTEXT : IEquatable<HCRYPTDEFAULTCONTEXT>
    {
        public readonly nint Value;

        public HCRYPTDEFAULTCONTEXT(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HCRYPTDEFAULTCONTEXT left, HCRYPTDEFAULTCONTEXT right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTDEFAULTCONTEXT left, HCRYPTDEFAULTCONTEXT right) => left.Value != right.Value;

        public static implicit operator HCRYPTDEFAULTCONTEXT(nint value) => new HCRYPTDEFAULTCONTEXT(value);

        public static implicit operator nint(HCRYPTDEFAULTCONTEXT value) => value.Value;

        public override bool Equals(object? obj) => (obj is HCRYPTDEFAULTCONTEXT other) && Equals(other);

        public bool Equals(HCRYPTDEFAULTCONTEXT other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
