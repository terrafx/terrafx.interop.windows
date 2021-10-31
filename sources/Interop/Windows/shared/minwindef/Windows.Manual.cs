// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/minwindef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const int NULL = 0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("WORD")]
        public static ushort MAKEWORD([NativeTypeName("DWORD_PTR")] nuint a, [NativeTypeName("DWORD_PTR")] nuint b) => ((ushort)(((byte)(((nuint)(a)) & 0xff)) | ((ushort)((byte)(((nuint)(b)) & 0xff))) << 8));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("LONG")]
        public static int MAKELONG([NativeTypeName("DWORD_PTR")] nuint a, [NativeTypeName("DWORD_PTR")] nuint b) => ((int)(((ushort)(((nuint)(a)) & 0xffff)) | ((uint)((ushort)(((nuint)(b)) & 0xffff))) << 16));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("WORD")]
        public static ushort LOWORD([NativeTypeName("DWORD_PTR")] nuint l) => ((ushort)(((nuint)(l)) & 0xffff));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort LOWORD(nint l) => LOWORD((nuint)(l));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("WORD")]
        public static ushort HIWORD([NativeTypeName("DWORD_PTR")] nuint l) => ((ushort)((((nuint)(l)) >> 16) & 0xffff));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort HIWORD(nint l) => HIWORD((nuint)(l));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte LOBYTE([NativeTypeName("DWORD_PTR")] nuint w) => ((byte)(((nuint)(w)) & 0xff));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte LOBYTE(nint w) => LOBYTE((nuint)(w));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte HIBYTE([NativeTypeName("DWORD_PTR")] nuint w) => ((byte)((((nuint)(w)) >> 8) & 0xff));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte HIBYTE(nint w) => HIBYTE((nuint)(w));
    }
}
