// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCOLORSPACE : IEquatable<HCOLORSPACE>
    {
        public readonly nint Value;

        public HCOLORSPACE(nint value)
        {
            Value = value;
        }

        public static HCOLORSPACE INVALID_HANDLE_VALUE => new HCOLORSPACE(-1);

        public static HCOLORSPACE NULL => new HCOLORSPACE(0);

        public static bool operator ==(HCOLORSPACE left, HCOLORSPACE right) => left.Value == right.Value;

        public static bool operator !=(HCOLORSPACE left, HCOLORSPACE right) => left.Value != right.Value;

        public static explicit operator HCOLORSPACE(void* value) => new HCOLORSPACE((nint)(value));

        public static implicit operator void*(HCOLORSPACE value) => (void*)(value.Value);

        public static explicit operator HCOLORSPACE(HANDLE value) => new HCOLORSPACE(value);

        public static implicit operator HANDLE(HCOLORSPACE value) => new HCOLORSPACE(value);

        public static explicit operator HCOLORSPACE(byte value) => new HCOLORSPACE((nint)(value));

        public static explicit operator byte(HCOLORSPACE value) => (byte)(value.Value);

        public static explicit operator HCOLORSPACE(short value) => new HCOLORSPACE((nint)(value));

        public static explicit operator short(HCOLORSPACE value) => (short)(value.Value);

        public static explicit operator HCOLORSPACE(int value) => new HCOLORSPACE((nint)(value));

        public static explicit operator int(HCOLORSPACE value) => (int)(value.Value);

        public static explicit operator HCOLORSPACE(long value) => new HCOLORSPACE((nint)(value));

        public static implicit operator long(HCOLORSPACE value) => (long)(value.Value);

        public static explicit operator HCOLORSPACE(nint value) => new HCOLORSPACE((nint)(value));

        public static implicit operator nint(HCOLORSPACE value) => (nint)(value.Value);

        public static explicit operator HCOLORSPACE(sbyte value) => new HCOLORSPACE((nint)(value));

        public static explicit operator sbyte(HCOLORSPACE value) => (sbyte)(value.Value);

        public static explicit operator HCOLORSPACE(ushort value) => new HCOLORSPACE((nint)(value));

        public static explicit operator ushort(HCOLORSPACE value) => (ushort)(value.Value);

        public static explicit operator HCOLORSPACE(uint value) => new HCOLORSPACE((nint)(value));

        public static explicit operator uint(HCOLORSPACE value) => (uint)(value.Value);

        public static explicit operator HCOLORSPACE(ulong value) => new HCOLORSPACE((nint)(value));

        public static implicit operator ulong(HCOLORSPACE value) => (ulong)(value.Value);

        public static explicit operator HCOLORSPACE(nuint value) => new HCOLORSPACE((nint)(value));

        public static explicit operator nuint(HCOLORSPACE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HCOLORSPACE other) && Equals(other);

        public bool Equals(HCOLORSPACE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
