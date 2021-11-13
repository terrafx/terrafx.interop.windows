// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct PAINTSTRUCT
    {
        public HDC hdc;

        public BOOL fErase;

        public RECT rcPaint;

        public BOOL fRestore;

        public BOOL fIncUpdate;

        [NativeTypeName("BYTE [32]")]
        public fixed byte rgbReserved[32];
    }
}
