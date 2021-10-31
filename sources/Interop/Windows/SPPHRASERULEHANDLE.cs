// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SPPHRASERULEHANDLE : IEquatable<SPPHRASERULEHANDLE>
    {
        public readonly nint Value;

        public static SPPHRASERULEHANDLE NULL => (SPPHRASERULEHANDLE)(0);

        public SPPHRASERULEHANDLE(int value)
        {
            Value = ((nint)(value));
        }

        public SPPHRASERULEHANDLE(uint value)
        {
            Value = ((nint)(value));
        }

        public SPPHRASERULEHANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public SPPHRASERULEHANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public SPPHRASERULEHANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public SPPHRASERULEHANDLE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(SPPHRASERULEHANDLE left, SPPHRASERULEHANDLE right) => left.Value == right.Value;

        public static bool operator !=(SPPHRASERULEHANDLE left, SPPHRASERULEHANDLE right) => left.Value != right.Value;

        public static explicit operator SPPHRASERULEHANDLE(int value) => new SPPHRASERULEHANDLE(value);

        public static explicit operator SPPHRASERULEHANDLE(uint value) => new SPPHRASERULEHANDLE(value);

        public static explicit operator SPPHRASERULEHANDLE(nint value) => new SPPHRASERULEHANDLE(value);

        public static explicit operator SPPHRASERULEHANDLE(nuint value) => new SPPHRASERULEHANDLE(value);

        public static explicit operator SPPHRASERULEHANDLE(void* value) => new SPPHRASERULEHANDLE(value);

        public static explicit operator SPPHRASERULEHANDLE(HANDLE value) => new SPPHRASERULEHANDLE(value);

        public static implicit operator int(SPPHRASERULEHANDLE value) => (int)(value.Value);

        public static implicit operator uint(SPPHRASERULEHANDLE value) => (uint)(value.Value);

        public static implicit operator nint(SPPHRASERULEHANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(SPPHRASERULEHANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(SPPHRASERULEHANDLE value) => (void*)(value.Value);

        public static implicit operator HANDLE(SPPHRASERULEHANDLE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is SPPHRASERULEHANDLE other) && Equals(other);

        public bool Equals(SPPHRASERULEHANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
