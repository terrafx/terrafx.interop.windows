// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HPROPSHEETPAGE : IEquatable<HPROPSHEETPAGE>
    {
        public readonly nint Value;

        public HPROPSHEETPAGE(nint value)
        {
            Value = ((nint)(value));
        }

        public HPROPSHEETPAGE(nuint value)
        {
            Value = ((nint)(value));
        }

        public HPROPSHEETPAGE(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HPROPSHEETPAGE left, HPROPSHEETPAGE right) => left.Value == right.Value;

        public static bool operator !=(HPROPSHEETPAGE left, HPROPSHEETPAGE right) => left.Value != right.Value;

        public static explicit operator HPROPSHEETPAGE(nint value) => new HPROPSHEETPAGE(value);

        public static explicit operator HPROPSHEETPAGE(nuint value) => new HPROPSHEETPAGE(value);

        public static explicit operator HPROPSHEETPAGE(void* value) => new HPROPSHEETPAGE(value);

        public static implicit operator nint(HPROPSHEETPAGE value) => (nint)(value.Value);

        public static implicit operator nuint(HPROPSHEETPAGE value) => (nuint)(value.Value);

        public static implicit operator void*(HPROPSHEETPAGE value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HPROPSHEETPAGE other) && Equals(other);

        public bool Equals(HPROPSHEETPAGE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
