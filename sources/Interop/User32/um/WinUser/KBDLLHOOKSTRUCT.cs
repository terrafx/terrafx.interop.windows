// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct KBDLLHOOKSTRUCT
    {
        [NativeTypeName("DWORD")]
        public uint vkCode;

        [NativeTypeName("DWORD")]
        public uint scanCode;

        [NativeTypeName("DWORD")]
        public uint flags;

        [NativeTypeName("DWORD")]
        public uint time;

        [NativeTypeName("ULONG_PTR")]
        public UIntPtr dwExtraInfo;
    }
}
