// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HENHMETAFILE : IEquatable<HENHMETAFILE>
    {
        public readonly nint Value;

        public HENHMETAFILE(nint value)
        {
            Value = ((nint)(value));
        }

        public HENHMETAFILE(nuint value)
        {
            Value = ((nint)(value));
        }

        public HENHMETAFILE(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HENHMETAFILE left, HENHMETAFILE right) => left.Value == right.Value;

        public static bool operator !=(HENHMETAFILE left, HENHMETAFILE right) => left.Value != right.Value;

        public static explicit operator HENHMETAFILE(nint value) => new HENHMETAFILE(value);

        public static explicit operator HENHMETAFILE(nuint value) => new HENHMETAFILE(value);

        public static explicit operator HENHMETAFILE(void* value) => new HENHMETAFILE(value);

        public static implicit operator nint(HENHMETAFILE value) => (nint)(value.Value);

        public static implicit operator nuint(HENHMETAFILE value) => (nuint)(value.Value);

        public static implicit operator void*(HENHMETAFILE value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HENHMETAFILE other) && Equals(other);

        public bool Equals(HENHMETAFILE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
