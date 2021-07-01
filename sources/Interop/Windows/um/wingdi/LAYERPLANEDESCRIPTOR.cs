// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct LAYERPLANEDESCRIPTOR
    {
        [NativeTypeName("WORD")]
        public ushort nSize;

        [NativeTypeName("WORD")]
        public ushort nVersion;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("BYTE")]
        public byte iPixelType;

        [NativeTypeName("BYTE")]
        public byte cColorBits;

        [NativeTypeName("BYTE")]
        public byte cRedBits;

        [NativeTypeName("BYTE")]
        public byte cRedShift;

        [NativeTypeName("BYTE")]
        public byte cGreenBits;

        [NativeTypeName("BYTE")]
        public byte cGreenShift;

        [NativeTypeName("BYTE")]
        public byte cBlueBits;

        [NativeTypeName("BYTE")]
        public byte cBlueShift;

        [NativeTypeName("BYTE")]
        public byte cAlphaBits;

        [NativeTypeName("BYTE")]
        public byte cAlphaShift;

        [NativeTypeName("BYTE")]
        public byte cAccumBits;

        [NativeTypeName("BYTE")]
        public byte cAccumRedBits;

        [NativeTypeName("BYTE")]
        public byte cAccumGreenBits;

        [NativeTypeName("BYTE")]
        public byte cAccumBlueBits;

        [NativeTypeName("BYTE")]
        public byte cAccumAlphaBits;

        [NativeTypeName("BYTE")]
        public byte cDepthBits;

        [NativeTypeName("BYTE")]
        public byte cStencilBits;

        [NativeTypeName("BYTE")]
        public byte cAuxBuffers;

        [NativeTypeName("BYTE")]
        public byte iLayerPlane;

        [NativeTypeName("BYTE")]
        public byte bReserved;

        [NativeTypeName("COLORREF")]
        public uint crTransparent;
    }
}
