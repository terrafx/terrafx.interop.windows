// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct CBT_CREATEWNDA
    {
        [NativeTypeName("struct tagCREATESTRUCTA *")]
        public CREATESTRUCTA* lpcs;

        [NativeTypeName("HWND")]
        public IntPtr hwndInsertAfter;
    }
}
