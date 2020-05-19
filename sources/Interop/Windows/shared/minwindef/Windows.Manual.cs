// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/minwindef.h in the Windows SDK for Windows 10.0.18632.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const int FALSE = 0;

        public const int TRUE = 1;

        public const int MAX_PATH = 260;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort MAKEWORD(byte a, byte b) => (ushort)(a | (b << 8));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int MAKELONG(ushort a, ushort b) => a | (b << 16);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort LOWORD(uint l) => unchecked((ushort)l);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort HIWORD(uint l) => unchecked((ushort)(l >> 16));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte LOBYTE(ushort w) => unchecked((byte)w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte HIBYTE(ushort w) => unchecked((byte)(w >> 8));
    }
}
