// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct MENUGETOBJECTINFO
    {
        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("UINT")]
        public uint uPos;

        [NativeTypeName("HMENU")]
        public IntPtr hmenu;

        [NativeTypeName("PVOID")]
        public void* riid;

        [NativeTypeName("PVOID")]
        public void* pvObj;
    }
}
