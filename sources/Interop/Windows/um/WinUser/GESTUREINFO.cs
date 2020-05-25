// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct GESTUREINFO
    {
        [NativeTypeName("UINT")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint dwID;

        [NativeTypeName("HWND")]
        public IntPtr hwndTarget;

        public POINTS ptsLocation;

        [NativeTypeName("DWORD")]
        public uint dwInstanceID;

        [NativeTypeName("DWORD")]
        public uint dwSequenceID;

        [NativeTypeName("ULONGLONG")]
        public ulong ullArguments;

        [NativeTypeName("UINT")]
        public uint cbExtraArgs;
    }
}
