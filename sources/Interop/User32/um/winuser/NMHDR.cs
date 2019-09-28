// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\winuser.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct NMHDR
    {
        [NativeTypeName("HWND")]
        public IntPtr hwndFrom;

        [NativeTypeName("UINT_PTR")]
        public UIntPtr idFrom;

        [NativeTypeName("UINT")]
        public uint code;
    }
}
