// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct ASYNCCOMPLETIONHANDLE : IEquatable<ASYNCCOMPLETIONHANDLE>
    {
        public readonly nuint Value;

        public ASYNCCOMPLETIONHANDLE(int value)
        {
            Value = ((nuint)(value));
        }

        public ASYNCCOMPLETIONHANDLE(uint value)
        {
            Value = ((nuint)(value));
        }

        public ASYNCCOMPLETIONHANDLE(nint value)
        {
            Value = ((nuint)(value));
        }

        public ASYNCCOMPLETIONHANDLE(nuint value)
        {
            Value = ((nuint)(value));
        }

        public ASYNCCOMPLETIONHANDLE(void* value)
        {
            Value = ((nuint)(value));
        }

        public static bool operator ==(ASYNCCOMPLETIONHANDLE left, ASYNCCOMPLETIONHANDLE right) => left.Value == right.Value;

        public static bool operator !=(ASYNCCOMPLETIONHANDLE left, ASYNCCOMPLETIONHANDLE right) => left.Value != right.Value;

        public static explicit operator ASYNCCOMPLETIONHANDLE(int value) => new ASYNCCOMPLETIONHANDLE(value);

        public static explicit operator ASYNCCOMPLETIONHANDLE(uint value) => new ASYNCCOMPLETIONHANDLE(value);

        public static explicit operator ASYNCCOMPLETIONHANDLE(nint value) => new ASYNCCOMPLETIONHANDLE(value);

        public static explicit operator ASYNCCOMPLETIONHANDLE(nuint value) => new ASYNCCOMPLETIONHANDLE(value);

        public static explicit operator ASYNCCOMPLETIONHANDLE(void* value) => new ASYNCCOMPLETIONHANDLE(value);

        public static implicit operator int(ASYNCCOMPLETIONHANDLE value) => (int)(value.Value);

        public static implicit operator uint(ASYNCCOMPLETIONHANDLE value) => (uint)(value.Value);

        public static implicit operator nint(ASYNCCOMPLETIONHANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(ASYNCCOMPLETIONHANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(ASYNCCOMPLETIONHANDLE value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is ASYNCCOMPLETIONHANDLE other) && Equals(other);

        public bool Equals(ASYNCCOMPLETIONHANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
