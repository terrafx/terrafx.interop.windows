// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HMIDIOUT : IEquatable<HMIDIOUT>
    {
        public readonly nint Value;

        public HMIDIOUT(nint value)
        {
            Value = ((nint)(value));
        }

        public HMIDIOUT(nuint value)
        {
            Value = ((nint)(value));
        }

        public HMIDIOUT(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HMIDIOUT left, HMIDIOUT right) => left.Value == right.Value;

        public static bool operator !=(HMIDIOUT left, HMIDIOUT right) => left.Value != right.Value;

        public static explicit operator HMIDIOUT(nint value) => new HMIDIOUT(value);

        public static explicit operator HMIDIOUT(nuint value) => new HMIDIOUT(value);

        public static explicit operator HMIDIOUT(void* value) => new HMIDIOUT(value);

        public static implicit operator nint(HMIDIOUT value) => (nint)(value.Value);

        public static implicit operator nuint(HMIDIOUT value) => (nuint)(value.Value);

        public static implicit operator void*(HMIDIOUT value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HMIDIOUT other) && Equals(other);

        public bool Equals(HMIDIOUT other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
