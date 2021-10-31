// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SPPHRASEPROPERTYHANDLE : IEquatable<SPPHRASEPROPERTYHANDLE>
    {
        public readonly nint Value;

        public SPPHRASEPROPERTYHANDLE(int value)
        {
            Value = ((nint)(value));
        }

        public SPPHRASEPROPERTYHANDLE(uint value)
        {
            Value = ((nint)(value));
        }

        public SPPHRASEPROPERTYHANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public SPPHRASEPROPERTYHANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public SPPHRASEPROPERTYHANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public SPPHRASEPROPERTYHANDLE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(SPPHRASEPROPERTYHANDLE left, SPPHRASEPROPERTYHANDLE right) => left.Value == right.Value;

        public static bool operator !=(SPPHRASEPROPERTYHANDLE left, SPPHRASEPROPERTYHANDLE right) => left.Value != right.Value;

        public static explicit operator SPPHRASEPROPERTYHANDLE(int value) => new SPPHRASEPROPERTYHANDLE(value);

        public static explicit operator SPPHRASEPROPERTYHANDLE(uint value) => new SPPHRASEPROPERTYHANDLE(value);

        public static explicit operator SPPHRASEPROPERTYHANDLE(nint value) => new SPPHRASEPROPERTYHANDLE(value);

        public static explicit operator SPPHRASEPROPERTYHANDLE(nuint value) => new SPPHRASEPROPERTYHANDLE(value);

        public static explicit operator SPPHRASEPROPERTYHANDLE(void* value) => new SPPHRASEPROPERTYHANDLE(value);

        public static explicit operator SPPHRASEPROPERTYHANDLE(HANDLE value) => new SPPHRASEPROPERTYHANDLE(value);

        public static implicit operator int(SPPHRASEPROPERTYHANDLE value) => (int)(value.Value);

        public static implicit operator uint(SPPHRASEPROPERTYHANDLE value) => (uint)(value.Value);

        public static implicit operator nint(SPPHRASEPROPERTYHANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(SPPHRASEPROPERTYHANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(SPPHRASEPROPERTYHANDLE value) => (void*)(value.Value);

        public static implicit operator HANDLE(SPPHRASEPROPERTYHANDLE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is SPPHRASEPROPERTYHANDLE other) && Equals(other);

        public bool Equals(SPPHRASEPROPERTYHANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
