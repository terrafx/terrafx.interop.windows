// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    [NativeTypeName("struct tagMONITORINFOEXW : tagMONITORINFO")]
    public unsafe partial struct MONITORINFOEXW
    {
        public MONITORINFO __AnonymousBase_WinUser_L13553_C43;

        [NativeTypeName("WCHAR [32]")]
        public fixed ushort szDevice[32];
    }
}
