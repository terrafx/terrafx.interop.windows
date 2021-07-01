// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PAINTSTRUCT
    {
        [NativeTypeName("HDC")]
        public IntPtr hdc;

        [NativeTypeName("BOOL")]
        public int fErase;

        public RECT rcPaint;

        [NativeTypeName("BOOL")]
        public int fRestore;

        [NativeTypeName("BOOL")]
        public int fIncUpdate;

        [NativeTypeName("BYTE [32]")]
        public fixed byte rgbReserved[32];
    }
}
