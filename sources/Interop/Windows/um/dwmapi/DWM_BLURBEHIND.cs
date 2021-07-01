// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct DWM_BLURBEHIND
    {
        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("BOOL")]
        public int fEnable;

        [NativeTypeName("HRGN")]
        public IntPtr hRgnBlur;

        [NativeTypeName("BOOL")]
        public int fTransitionOnMaximized;
    }
}
