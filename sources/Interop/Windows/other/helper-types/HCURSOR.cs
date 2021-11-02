// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCURSOR : IEquatable<HCURSOR>
    {
        public readonly nint Value;

        public HCURSOR(nint value)
        {
            Value = value;
        }

        public static HCURSOR INVALID_VALUE => new HCURSOR(-1);

        public static HCURSOR NULL => new HCURSOR(0);

        public static bool operator ==(HCURSOR left, HCURSOR right) => left.Value == right.Value;

        public static bool operator !=(HCURSOR left, HCURSOR right) => left.Value != right.Value;

        public static explicit operator HCURSOR(void* value) => new HCURSOR((nint)(value));

        public static implicit operator void*(HCURSOR value) => (void*)(value.Value);

        public static explicit operator HCURSOR(HANDLE value) => new HCURSOR(value);

        public static implicit operator HANDLE(HCURSOR value) => new HCURSOR(value);

        public static explicit operator HCURSOR(byte value) => new HCURSOR((nint)(value));

        public static explicit operator byte(HCURSOR value) => (byte)(value.Value);

        public static explicit operator HCURSOR(short value) => new HCURSOR((nint)(value));

        public static explicit operator short(HCURSOR value) => (short)(value.Value);

        public static explicit operator HCURSOR(int value) => new HCURSOR((nint)(value));

        public static explicit operator int(HCURSOR value) => (int)(value.Value);

        public static explicit operator HCURSOR(long value) => new HCURSOR((nint)(value));

        public static implicit operator long(HCURSOR value) => (long)(value.Value);

        public static explicit operator HCURSOR(nint value) => new HCURSOR((nint)(value));

        public static implicit operator nint(HCURSOR value) => (nint)(value.Value);

        public static explicit operator HCURSOR(sbyte value) => new HCURSOR((nint)(value));

        public static explicit operator sbyte(HCURSOR value) => (sbyte)(value.Value);

        public static explicit operator HCURSOR(ushort value) => new HCURSOR((nint)(value));

        public static explicit operator ushort(HCURSOR value) => (ushort)(value.Value);

        public static explicit operator HCURSOR(uint value) => new HCURSOR((nint)(value));

        public static explicit operator uint(HCURSOR value) => (uint)(value.Value);

        public static explicit operator HCURSOR(ulong value) => new HCURSOR((nint)(value));

        public static explicit operator ulong(HCURSOR value) => (ulong)(value.Value);

        public static explicit operator HCURSOR(nuint value) => new HCURSOR((nint)(value));

        public static explicit operator nuint(HCURSOR value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HCURSOR other) && Equals(other);

        public bool Equals(HCURSOR other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
