// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HIFTIMESTAMPCHANGE : IEquatable<HIFTIMESTAMPCHANGE>
    {
        public readonly nint Value;

        public HIFTIMESTAMPCHANGE(nint value)
        {
            Value = ((nint)(value));
        }

        public HIFTIMESTAMPCHANGE(nuint value)
        {
            Value = ((nint)(value));
        }

        public HIFTIMESTAMPCHANGE(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HIFTIMESTAMPCHANGE left, HIFTIMESTAMPCHANGE right) => left.Value == right.Value;

        public static bool operator !=(HIFTIMESTAMPCHANGE left, HIFTIMESTAMPCHANGE right) => left.Value != right.Value;

        public static explicit operator HIFTIMESTAMPCHANGE(nint value) => new HIFTIMESTAMPCHANGE(value);

        public static explicit operator HIFTIMESTAMPCHANGE(nuint value) => new HIFTIMESTAMPCHANGE(value);

        public static explicit operator HIFTIMESTAMPCHANGE(void* value) => new HIFTIMESTAMPCHANGE(value);

        public static implicit operator nint(HIFTIMESTAMPCHANGE value) => (nint)(value.Value);

        public static implicit operator nuint(HIFTIMESTAMPCHANGE value) => (nuint)(value.Value);

        public static implicit operator void*(HIFTIMESTAMPCHANGE value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HIFTIMESTAMPCHANGE other) && Equals(other);

        public bool Equals(HIFTIMESTAMPCHANGE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
