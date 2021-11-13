// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct VMRVIDEOSTREAMINFO
    {
        [NativeTypeName("LPDIRECTDRAWSURFACE7")]
        public IDirectDrawSurface7* pddsVideoSurface;

        [NativeTypeName("DWORD")]
        public uint dwWidth;

        [NativeTypeName("DWORD")]
        public uint dwHeight;

        [NativeTypeName("DWORD")]
        public uint dwStrmID;

        public float fAlpha;

        public DDCOLORKEY ddClrKey;

        public NORMALIZEDRECT rNormal;
    }
}
