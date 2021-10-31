// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HUIAEVENT : IEquatable<HUIAEVENT>
    {
        public readonly nint Value;

        public static HUIAEVENT NULL => (HUIAEVENT)(0);

        public HUIAEVENT(int value)
        {
            Value = ((nint)(value));
        }

        public HUIAEVENT(uint value)
        {
            Value = ((nint)(value));
        }

        public HUIAEVENT(nint value)
        {
            Value = ((nint)(value));
        }

        public HUIAEVENT(nuint value)
        {
            Value = ((nint)(value));
        }

        public HUIAEVENT(void* value)
        {
            Value = ((nint)(value));
        }

        public HUIAEVENT(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HUIAEVENT left, HUIAEVENT right) => left.Value == right.Value;

        public static bool operator !=(HUIAEVENT left, HUIAEVENT right) => left.Value != right.Value;

        public static explicit operator HUIAEVENT(int value) => new HUIAEVENT(value);

        public static explicit operator HUIAEVENT(uint value) => new HUIAEVENT(value);

        public static explicit operator HUIAEVENT(nint value) => new HUIAEVENT(value);

        public static explicit operator HUIAEVENT(nuint value) => new HUIAEVENT(value);

        public static explicit operator HUIAEVENT(void* value) => new HUIAEVENT(value);

        public static explicit operator HUIAEVENT(HANDLE value) => new HUIAEVENT(value);

        public static explicit operator int(HUIAEVENT value) => (int)(value.Value);

        public static explicit operator uint(HUIAEVENT value) => (uint)(value.Value);

        public static implicit operator nint(HUIAEVENT value) => (nint)(value.Value);

        public static implicit operator nuint(HUIAEVENT value) => (nuint)(value.Value);

        public static implicit operator void*(HUIAEVENT value) => (void*)(value.Value);

        public static implicit operator HANDLE(HUIAEVENT value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HUIAEVENT other) && Equals(other);

        public bool Equals(HUIAEVENT other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
