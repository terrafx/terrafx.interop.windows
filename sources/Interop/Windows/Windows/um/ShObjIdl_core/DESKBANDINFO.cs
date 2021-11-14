// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct DESKBANDINFO
    {
        [NativeTypeName("DWORD")]
        public uint dwMask;

        public POINTL ptMinSize;

        public POINTL ptMaxSize;

        public POINTL ptIntegral;

        public POINTL ptActual;

        [NativeTypeName("WCHAR [256]")]
        public fixed ushort wszTitle[256];

        [NativeTypeName("DWORD")]
        public uint dwModeFlags;

        public COLORREF crBkgnd;
    }
}
