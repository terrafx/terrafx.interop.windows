// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HUIAPATTERNOBJECT : IEquatable<HUIAPATTERNOBJECT>
    {
        public readonly nint Value;

        public static HUIAPATTERNOBJECT NULL => (HUIAPATTERNOBJECT)(0);

        public HUIAPATTERNOBJECT(int value)
        {
            Value = ((nint)(value));
        }

        public HUIAPATTERNOBJECT(uint value)
        {
            Value = ((nint)(value));
        }

        public HUIAPATTERNOBJECT(nint value)
        {
            Value = ((nint)(value));
        }

        public HUIAPATTERNOBJECT(nuint value)
        {
            Value = ((nint)(value));
        }

        public HUIAPATTERNOBJECT(void* value)
        {
            Value = ((nint)(value));
        }

        public HUIAPATTERNOBJECT(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HUIAPATTERNOBJECT left, HUIAPATTERNOBJECT right) => left.Value == right.Value;

        public static bool operator !=(HUIAPATTERNOBJECT left, HUIAPATTERNOBJECT right) => left.Value != right.Value;

        public static explicit operator HUIAPATTERNOBJECT(int value) => new HUIAPATTERNOBJECT(value);

        public static explicit operator HUIAPATTERNOBJECT(uint value) => new HUIAPATTERNOBJECT(value);

        public static explicit operator HUIAPATTERNOBJECT(nint value) => new HUIAPATTERNOBJECT(value);

        public static explicit operator HUIAPATTERNOBJECT(nuint value) => new HUIAPATTERNOBJECT(value);

        public static explicit operator HUIAPATTERNOBJECT(void* value) => new HUIAPATTERNOBJECT(value);

        public static explicit operator HUIAPATTERNOBJECT(HANDLE value) => new HUIAPATTERNOBJECT(value);

        public static explicit operator int(HUIAPATTERNOBJECT value) => (int)(value.Value);

        public static explicit operator uint(HUIAPATTERNOBJECT value) => (uint)(value.Value);

        public static implicit operator nint(HUIAPATTERNOBJECT value) => (nint)(value.Value);

        public static implicit operator nuint(HUIAPATTERNOBJECT value) => (nuint)(value.Value);

        public static implicit operator void*(HUIAPATTERNOBJECT value) => (void*)(value.Value);

        public static implicit operator HANDLE(HUIAPATTERNOBJECT value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HUIAPATTERNOBJECT other) && Equals(other);

        public bool Equals(HUIAPATTERNOBJECT other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
