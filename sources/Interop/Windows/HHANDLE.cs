// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HHANDLE : IEquatable<HHANDLE>
    {
        public readonly nint Value;

        public HHANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public HHANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public HHANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HHANDLE left, HHANDLE right) => left.Value == right.Value;

        public static bool operator !=(HHANDLE left, HHANDLE right) => left.Value != right.Value;

        public static explicit operator HHANDLE(nint value) => new HHANDLE(value);

        public static explicit operator HHANDLE(nuint value) => new HHANDLE(value);

        public static explicit operator HHANDLE(void* value) => new HHANDLE(value);

        public static implicit operator nint(HHANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(HHANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(HHANDLE value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HHANDLE other) && Equals(other);

        public bool Equals(HHANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
