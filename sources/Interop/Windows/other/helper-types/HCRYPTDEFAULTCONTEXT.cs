// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTDEFAULTCONTEXT : IEquatable<HCRYPTDEFAULTCONTEXT>
    {
        public readonly nint Value;

        public HCRYPTDEFAULTCONTEXT(nint value)
        {
            Value = value;
        }

        public static HCRYPTDEFAULTCONTEXT INVALID_VALUE => new HCRYPTDEFAULTCONTEXT(-1);

        public static HCRYPTDEFAULTCONTEXT NULL => new HCRYPTDEFAULTCONTEXT(0);

        public static bool operator ==(HCRYPTDEFAULTCONTEXT left, HCRYPTDEFAULTCONTEXT right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTDEFAULTCONTEXT left, HCRYPTDEFAULTCONTEXT right) => left.Value != right.Value;

        public static explicit operator HCRYPTDEFAULTCONTEXT(void* value) => new HCRYPTDEFAULTCONTEXT((nint)(value));

        public static implicit operator void*(HCRYPTDEFAULTCONTEXT value) => (void*)(value.Value);

        public static explicit operator HCRYPTDEFAULTCONTEXT(HANDLE value) => new HCRYPTDEFAULTCONTEXT(value);

        public static implicit operator HANDLE(HCRYPTDEFAULTCONTEXT value) => new HCRYPTDEFAULTCONTEXT(value);

        public static explicit operator HCRYPTDEFAULTCONTEXT(byte value) => new HCRYPTDEFAULTCONTEXT((nint)(value));

        public static explicit operator byte(HCRYPTDEFAULTCONTEXT value) => (byte)(value.Value);

        public static explicit operator HCRYPTDEFAULTCONTEXT(short value) => new HCRYPTDEFAULTCONTEXT((nint)(value));

        public static explicit operator short(HCRYPTDEFAULTCONTEXT value) => (short)(value.Value);

        public static explicit operator HCRYPTDEFAULTCONTEXT(int value) => new HCRYPTDEFAULTCONTEXT((nint)(value));

        public static explicit operator int(HCRYPTDEFAULTCONTEXT value) => (int)(value.Value);

        public static explicit operator HCRYPTDEFAULTCONTEXT(long value) => new HCRYPTDEFAULTCONTEXT((nint)(value));

        public static implicit operator long(HCRYPTDEFAULTCONTEXT value) => (long)(value.Value);

        public static explicit operator HCRYPTDEFAULTCONTEXT(nint value) => new HCRYPTDEFAULTCONTEXT((nint)(value));

        public static implicit operator nint(HCRYPTDEFAULTCONTEXT value) => (nint)(value.Value);

        public static explicit operator HCRYPTDEFAULTCONTEXT(sbyte value) => new HCRYPTDEFAULTCONTEXT((nint)(value));

        public static explicit operator sbyte(HCRYPTDEFAULTCONTEXT value) => (sbyte)(value.Value);

        public static explicit operator HCRYPTDEFAULTCONTEXT(ushort value) => new HCRYPTDEFAULTCONTEXT((nint)(value));

        public static explicit operator ushort(HCRYPTDEFAULTCONTEXT value) => (ushort)(value.Value);

        public static explicit operator HCRYPTDEFAULTCONTEXT(uint value) => new HCRYPTDEFAULTCONTEXT((nint)(value));

        public static explicit operator uint(HCRYPTDEFAULTCONTEXT value) => (uint)(value.Value);

        public static explicit operator HCRYPTDEFAULTCONTEXT(ulong value) => new HCRYPTDEFAULTCONTEXT((nint)(value));

        public static explicit operator ulong(HCRYPTDEFAULTCONTEXT value) => (ulong)(value.Value);

        public static explicit operator HCRYPTDEFAULTCONTEXT(nuint value) => new HCRYPTDEFAULTCONTEXT((nint)(value));

        public static explicit operator nuint(HCRYPTDEFAULTCONTEXT value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HCRYPTDEFAULTCONTEXT other) && Equals(other);

        public bool Equals(HCRYPTDEFAULTCONTEXT other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
