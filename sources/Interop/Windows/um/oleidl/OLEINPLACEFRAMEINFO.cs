// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct OLEINPLACEFRAMEINFO
    {
        [NativeTypeName("UINT")]
        public uint cb;

        public BOOL fMDIApp;

        [NativeTypeName("HWND")]
        public IntPtr hwndFrame;

        [NativeTypeName("HACCEL")]
        public IntPtr haccel;

        [NativeTypeName("UINT")]
        public uint cAccelEntries;
    }
}
