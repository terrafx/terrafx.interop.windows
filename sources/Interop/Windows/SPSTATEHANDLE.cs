// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SPSTATEHANDLE : IEquatable<SPSTATEHANDLE>
    {
        public readonly nint Value;

        public SPSTATEHANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public SPSTATEHANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public SPSTATEHANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(SPSTATEHANDLE left, SPSTATEHANDLE right) => left.Value == right.Value;

        public static bool operator !=(SPSTATEHANDLE left, SPSTATEHANDLE right) => left.Value != right.Value;

        public static explicit operator SPSTATEHANDLE(nint value) => new SPSTATEHANDLE(value);

        public static explicit operator SPSTATEHANDLE(nuint value) => new SPSTATEHANDLE(value);

        public static explicit operator SPSTATEHANDLE(void* value) => new SPSTATEHANDLE(value);

        public static implicit operator nint(SPSTATEHANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(SPSTATEHANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(SPSTATEHANDLE value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is SPSTATEHANDLE other) && Equals(other);

        public bool Equals(SPSTATEHANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
