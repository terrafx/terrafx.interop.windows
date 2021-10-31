// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HPROPSHEETPAGE : IEquatable<HPROPSHEETPAGE>
    {
        public readonly void* Value;

        public HPROPSHEETPAGE(int value)
        {
            Value = ((void*)(value));
        }

        public HPROPSHEETPAGE(uint value)
        {
            Value = ((void*)(value));
        }

        public HPROPSHEETPAGE(nint value)
        {
            Value = ((void*)(value));
        }

        public HPROPSHEETPAGE(nuint value)
        {
            Value = ((void*)(value));
        }

        public HPROPSHEETPAGE(void* value)
        {
            Value = ((void*)(value));
        }

        public static bool operator ==(HPROPSHEETPAGE left, HPROPSHEETPAGE right) => left.Value == right.Value;

        public static bool operator !=(HPROPSHEETPAGE left, HPROPSHEETPAGE right) => left.Value != right.Value;

        public static explicit operator HPROPSHEETPAGE(int value) => new HPROPSHEETPAGE(value);

        public static explicit operator HPROPSHEETPAGE(uint value) => new HPROPSHEETPAGE(value);

        public static explicit operator HPROPSHEETPAGE(nint value) => new HPROPSHEETPAGE(value);

        public static explicit operator HPROPSHEETPAGE(nuint value) => new HPROPSHEETPAGE(value);

        public static explicit operator HPROPSHEETPAGE(void* value) => new HPROPSHEETPAGE(value);

        public static explicit operator int(HPROPSHEETPAGE value) => (int)(value.Value);

        public static explicit operator uint(HPROPSHEETPAGE value) => (uint)(value.Value);

        public static implicit operator nint(HPROPSHEETPAGE value) => (nint)(value.Value);

        public static implicit operator nuint(HPROPSHEETPAGE value) => (nuint)(value.Value);

        public static implicit operator void*(HPROPSHEETPAGE value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HPROPSHEETPAGE other) && Equals(other);

        public bool Equals(HPROPSHEETPAGE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
