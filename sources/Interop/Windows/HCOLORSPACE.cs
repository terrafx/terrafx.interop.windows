// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCOLORSPACE : IEquatable<HCOLORSPACE>
    {
        public readonly nint Value;

        public static HCOLORSPACE NULL => (HCOLORSPACE)(0);

        public HCOLORSPACE(int value)
        {
            Value = ((nint)(value));
        }

        public HCOLORSPACE(uint value)
        {
            Value = ((nint)(value));
        }

        public HCOLORSPACE(nint value)
        {
            Value = ((nint)(value));
        }

        public HCOLORSPACE(nuint value)
        {
            Value = ((nint)(value));
        }

        public HCOLORSPACE(void* value)
        {
            Value = ((nint)(value));
        }

        public HCOLORSPACE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HCOLORSPACE left, HCOLORSPACE right) => left.Value == right.Value;

        public static bool operator !=(HCOLORSPACE left, HCOLORSPACE right) => left.Value != right.Value;

        public static explicit operator HCOLORSPACE(int value) => new HCOLORSPACE(value);

        public static explicit operator HCOLORSPACE(uint value) => new HCOLORSPACE(value);

        public static explicit operator HCOLORSPACE(nint value) => new HCOLORSPACE(value);

        public static explicit operator HCOLORSPACE(nuint value) => new HCOLORSPACE(value);

        public static explicit operator HCOLORSPACE(void* value) => new HCOLORSPACE(value);

        public static explicit operator HCOLORSPACE(HANDLE value) => new HCOLORSPACE(value);

        public static explicit operator int(HCOLORSPACE value) => (int)(value.Value);

        public static explicit operator uint(HCOLORSPACE value) => (uint)(value.Value);

        public static implicit operator nint(HCOLORSPACE value) => (nint)(value.Value);

        public static implicit operator nuint(HCOLORSPACE value) => (nuint)(value.Value);

        public static implicit operator void*(HCOLORSPACE value) => (void*)(value.Value);

        public static implicit operator HANDLE(HCOLORSPACE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HCOLORSPACE other) && Equals(other);

        public bool Equals(HCOLORSPACE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
