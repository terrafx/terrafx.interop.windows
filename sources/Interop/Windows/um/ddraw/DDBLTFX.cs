// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
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

        public unsafe ref uint dwZDestConst
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.dwZDestConst, 1));
#else
                return ref ((_Anonymous1_e__Union*)Unsafe.AsPointer(ref Anonymous1))->dwZDestConst;
#endif
            }
        }

        public unsafe ref IDirectDrawSurface* lpDDSZBufferDest
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous1_e__Union*)Unsafe.AsPointer(ref Anonymous1))->lpDDSZBufferDest;
            }
        }

        [NativeTypeName("DWORD")]
        public uint dwZSrcConstBitDepth;

        [NativeTypeName("_DDBLTFX::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/ddraw.h:293:5)")]
        public _Anonymous2_e__Union Anonymous2;

        public unsafe ref uint dwZSrcConst
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dwZSrcConst, 1));
#else
                return ref ((_Anonymous2_e__Union*)Unsafe.AsPointer(ref Anonymous2))->dwZSrcConst;
#endif
            }
        }

        public unsafe ref IDirectDrawSurface* lpDDSZBufferSrc
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous2_e__Union*)Unsafe.AsPointer(ref Anonymous2))->lpDDSZBufferSrc;
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

        public unsafe ref uint dwAlphaDestConst
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous3.dwAlphaDestConst, 1));
#else
                return ref ((_Anonymous3_e__Union*)Unsafe.AsPointer(ref Anonymous3))->dwAlphaDestConst;
#endif
            }
        }

        public unsafe ref IDirectDrawSurface* lpDDSAlphaDest
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous3_e__Union*)Unsafe.AsPointer(ref Anonymous3))->lpDDSAlphaDest;
            }
        }

        [NativeTypeName("DWORD")]
        public uint dwAlphaSrcConstBitDepth;

        [NativeTypeName("_DDBLTFX::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/ddraw.h:308:5)")]
        public _Anonymous4_e__Union Anonymous4;

        public unsafe ref uint dwAlphaSrcConst
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous4.dwAlphaSrcConst, 1));
#else
                return ref ((_Anonymous4_e__Union*)Unsafe.AsPointer(ref Anonymous4))->dwAlphaSrcConst;
#endif
            }
        }

        public unsafe ref IDirectDrawSurface* lpDDSAlphaSrc
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous4_e__Union*)Unsafe.AsPointer(ref Anonymous4))->lpDDSAlphaSrc;
            }
        }

        [NativeTypeName("_DDBLTFX::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/ddraw.h:313:5)")]
        public _Anonymous5_e__Union Anonymous5;

        public unsafe ref uint dwFillColor
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous5.dwFillColor, 1));
#else
                return ref ((_Anonymous5_e__Union*)Unsafe.AsPointer(ref Anonymous5))->dwFillColor;
#endif
            }
        }

        public unsafe ref uint dwFillDepth
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous5.dwFillDepth, 1));
#else
                return ref ((_Anonymous5_e__Union*)Unsafe.AsPointer(ref Anonymous5))->dwFillDepth;
#endif
            }
        }

        public unsafe ref uint dwFillPixel
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous5.dwFillPixel, 1));
#else
                return ref ((_Anonymous5_e__Union*)Unsafe.AsPointer(ref Anonymous5))->dwFillPixel;
#endif
            }
        }

        public unsafe ref IDirectDrawSurface* lpDDSPattern
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous5_e__Union*)Unsafe.AsPointer(ref Anonymous5))->lpDDSPattern;
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
