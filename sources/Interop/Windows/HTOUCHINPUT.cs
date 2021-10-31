// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HTOUCHINPUT : IEquatable<HTOUCHINPUT>
    {
        public readonly nint Value;

        public HTOUCHINPUT(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HTOUCHINPUT left, HTOUCHINPUT right) => left.Value == right.Value;

        public static bool operator !=(HTOUCHINPUT left, HTOUCHINPUT right) => left.Value != right.Value;

        public static implicit operator HTOUCHINPUT(nint value) => new HTOUCHINPUT(value);

        public static implicit operator nint(HTOUCHINPUT value) => value.Value;

        public override bool Equals(object? obj) => (obj is HTOUCHINPUT other) && Equals(other);

        public bool Equals(HTOUCHINPUT other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
