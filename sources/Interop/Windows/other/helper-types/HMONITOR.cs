// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HMONITOR : IEquatable<HMONITOR>
    {
        public readonly nint Value;

        public HMONITOR(nint value)
        {
            Value = value;
        }

        public static HMONITOR INVALID_HANDLE_VALUE => new HMONITOR(-1);

        public static HMONITOR NULL => new HMONITOR(0);

        public static bool operator ==(HMONITOR left, HMONITOR right) => left.Value == right.Value;

        public static bool operator !=(HMONITOR left, HMONITOR right) => left.Value != right.Value;

        public static explicit operator HMONITOR(void* value) => new HMONITOR((nint)(value));

        public static implicit operator void*(HMONITOR value) => (void*)(value.Value);

        public static explicit operator HMONITOR(HANDLE value) => new HMONITOR(value);

        public static implicit operator HANDLE(HMONITOR value) => new HMONITOR(value);

        public static explicit operator HMONITOR(byte value) => new HMONITOR((nint)(value));

        public static explicit operator byte(HMONITOR value) => (byte)(value.Value);

        public static explicit operator HMONITOR(short value) => new HMONITOR((nint)(value));

        public static explicit operator short(HMONITOR value) => (short)(value.Value);

        public static explicit operator HMONITOR(int value) => new HMONITOR((nint)(value));

        public static explicit operator int(HMONITOR value) => (int)(value.Value);

        public static explicit operator HMONITOR(long value) => new HMONITOR((nint)(value));

        public static implicit operator long(HMONITOR value) => (long)(value.Value);

        public static explicit operator HMONITOR(nint value) => new HMONITOR((nint)(value));

        public static implicit operator nint(HMONITOR value) => (nint)(value.Value);

        public static explicit operator HMONITOR(sbyte value) => new HMONITOR((nint)(value));

        public static explicit operator sbyte(HMONITOR value) => (sbyte)(value.Value);

        public static explicit operator HMONITOR(ushort value) => new HMONITOR((nint)(value));

        public static explicit operator ushort(HMONITOR value) => (ushort)(value.Value);

        public static explicit operator HMONITOR(uint value) => new HMONITOR((nint)(value));

        public static explicit operator uint(HMONITOR value) => (uint)(value.Value);

        public static explicit operator HMONITOR(ulong value) => new HMONITOR((nint)(value));

        public static implicit operator ulong(HMONITOR value) => (ulong)(value.Value);

        public static explicit operator HMONITOR(nuint value) => new HMONITOR((nint)(value));

        public static explicit operator nuint(HMONITOR value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HMONITOR other) && Equals(other);

        public bool Equals(HMONITOR other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
