// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\minwindef.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const int FALSE = 0;

        public const int TRUE = 1;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort MAKEWORD(IntPtr a, IntPtr b)
        {
            return MAKEWORD((UIntPtr)(void*)a, (UIntPtr)(void*)b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort MAKEWORD(UIntPtr a, UIntPtr b)
        {
            return (ushort)((byte)a | ((byte)b << 8));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int MAKELONG(IntPtr a, IntPtr b)
        {
            return MAKELONG((UIntPtr)(void*)a, (UIntPtr)(void*)b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int MAKELONG(UIntPtr a, UIntPtr b)
        {
            return (int)(uint)((ushort)a | ((ushort)b << 16));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort LOWORD(IntPtr l)
        {
            return LOWORD((UIntPtr)(void*)l);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort LOWORD(UIntPtr l)
        {
            return (ushort)l;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort HIWORD(IntPtr l)
        {
            return HIWORD((UIntPtr)(void*)l);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort HIWORD(UIntPtr l)
        {
            return (ushort)((uint)l >> 16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte LOBYTE(IntPtr w)
        {
            return LOBYTE((UIntPtr)(void*)w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte LOBYTE(UIntPtr w)
        {
            return (byte)w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte HIBYTE(IntPtr w)
        {
            return HIBYTE((UIntPtr)(void*)w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte HIBYTE(UIntPtr w)
        {
            return (byte)((ushort)w >> 8);
        }
    }
}
