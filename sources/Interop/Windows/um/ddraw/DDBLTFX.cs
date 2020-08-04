// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct DDBLTFX
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint dwDDFX;

        [NativeTypeName("DWORD")]
        public uint dwROP;

        [NativeTypeName("DWORD")]
        public uint dwDDROP;

        [NativeTypeName("DWORD")]
        public uint dwRotationAngle;

        [NativeTypeName("DWORD")]
        public uint dwZBufferOpCode;

        [NativeTypeName("DWORD")]
        public uint dwZBufferLow;

        [NativeTypeName("DWORD")]
        public uint dwZBufferHigh;

        [NativeTypeName("DWORD")]
        public uint dwZBufferBaseDest;

        [NativeTypeName("DWORD")]
        public uint dwZDestConstBitDepth;

        [NativeTypeName("_DDBLTFX::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/ddraw.h:287:5)")]
        public _Anonymous1_e__Union Anonymous1;

        public ref uint dwZDestConst => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.dwZDestConst, 1));

        public ref IDirectDrawSurface* lpDDSZBufferDest
        {
            get
            {
                fixed (_Anonymous1_e__Union* pField = &Anonymous1)
                {
                    return ref pField->lpDDSZBufferDest;
                }
            }
        }

        [NativeTypeName("DWORD")]
        public uint dwZSrcConstBitDepth;

        [NativeTypeName("_DDBLTFX::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/ddraw.h:293:5)")]
        public _Anonymous2_e__Union Anonymous2;

        public ref uint dwZSrcConst => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dwZSrcConst, 1));

        public ref IDirectDrawSurface* lpDDSZBufferSrc
        {
            get
            {
                fixed (_Anonymous2_e__Union* pField = &Anonymous2)
                {
                    return ref pField->lpDDSZBufferSrc;
                }
            }
        }

        [NativeTypeName("DWORD")]
        public uint dwAlphaEdgeBlendBitDepth;

        [NativeTypeName("DWORD")]
        public uint dwAlphaEdgeBlend;

        [NativeTypeName("DWORD")]
        public uint dwReserved;

        [NativeTypeName("DWORD")]
        public uint dwAlphaDestConstBitDepth;

        [NativeTypeName("_DDBLTFX::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/ddraw.h:302:5)")]
        public _Anonymous3_e__Union Anonymous3;

        public ref uint dwAlphaDestConst => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous3.dwAlphaDestConst, 1));

        public ref IDirectDrawSurface* lpDDSAlphaDest
        {
            get
            {
                fixed (_Anonymous3_e__Union* pField = &Anonymous3)
                {
                    return ref pField->lpDDSAlphaDest;
                }
            }
        }

        [NativeTypeName("DWORD")]
        public uint dwAlphaSrcConstBitDepth;

        [NativeTypeName("_DDBLTFX::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/ddraw.h:308:5)")]
        public _Anonymous4_e__Union Anonymous4;

        public ref uint dwAlphaSrcConst => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous4.dwAlphaSrcConst, 1));

        public ref IDirectDrawSurface* lpDDSAlphaSrc
        {
            get
            {
                fixed (_Anonymous4_e__Union* pField = &Anonymous4)
                {
                    return ref pField->lpDDSAlphaSrc;
                }
            }
        }

        [NativeTypeName("_DDBLTFX::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/ddraw.h:313:5)")]
        public _Anonymous5_e__Union Anonymous5;

        public ref uint dwFillColor => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous5.dwFillColor, 1));

        public ref uint dwFillDepth => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous5.dwFillDepth, 1));

        public ref uint dwFillPixel => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous5.dwFillPixel, 1));

        public ref IDirectDrawSurface* lpDDSPattern
        {
            get
            {
                fixed (_Anonymous5_e__Union* pField = &Anonymous5)
                {
                    return ref pField->lpDDSPattern;
                }
            }
        }

        public DDCOLORKEY ddckDestColorkey;

        public DDCOLORKEY ddckSrcColorkey;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwZDestConst;

            [FieldOffset(0)]
            [NativeTypeName("LPDIRECTDRAWSURFACE")]
            public IDirectDrawSurface* lpDDSZBufferDest;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwZSrcConst;

            [FieldOffset(0)]
            [NativeTypeName("LPDIRECTDRAWSURFACE")]
            public IDirectDrawSurface* lpDDSZBufferSrc;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous3_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwAlphaDestConst;

            [FieldOffset(0)]
            [NativeTypeName("LPDIRECTDRAWSURFACE")]
            public IDirectDrawSurface* lpDDSAlphaDest;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous4_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwAlphaSrcConst;

            [FieldOffset(0)]
            [NativeTypeName("LPDIRECTDRAWSURFACE")]
            public IDirectDrawSurface* lpDDSAlphaSrc;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous5_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwFillColor;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwFillDepth;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwFillPixel;

            [FieldOffset(0)]
            [NativeTypeName("LPDIRECTDRAWSURFACE")]
            public IDirectDrawSurface* lpDDSPattern;
        }
    }
}
