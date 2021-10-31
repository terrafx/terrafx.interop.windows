// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HIMCC : IEquatable<HIMCC>
    {
        public readonly nint Value;

        public HIMCC(nint value)
        {
            Value = ((nint)(value));
        }

        public HIMCC(nuint value)
        {
            Value = ((nint)(value));
        }

        public HIMCC(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HIMCC left, HIMCC right) => left.Value == right.Value;

        public static bool operator !=(HIMCC left, HIMCC right) => left.Value != right.Value;

        public static explicit operator HIMCC(nint value) => new HIMCC(value);

        public static explicit operator HIMCC(nuint value) => new HIMCC(value);

        public static explicit operator HIMCC(void* value) => new HIMCC(value);

        public static implicit operator nint(HIMCC value) => (nint)(value.Value);

        public static implicit operator nuint(HIMCC value) => (nuint)(value.Value);

        public static implicit operator void*(HIMCC value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HIMCC other) && Equals(other);

        public bool Equals(HIMCC other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
