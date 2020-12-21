// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct DDSURFACEDESC
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint dwHeight;

        [NativeTypeName("DWORD")]
        public uint dwWidth;

        [NativeTypeName("_DDSURFACEDESC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/ddraw.h:2236:5)")]
        public _Anonymous1_e__Union Anonymous1;

        public unsafe ref int lPitch
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.lPitch, 1));
#else
                return ref ((_Anonymous1_e__Union*)Unsafe.AsPointer(ref Anonymous1))->lPitch;
#endif
            }
        }

        public unsafe ref uint dwLinearSize
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.dwLinearSize, 1));
#else
                return ref ((_Anonymous1_e__Union*)Unsafe.AsPointer(ref Anonymous1))->dwLinearSize;
#endif
            }
        }

        [NativeTypeName("DWORD")]
        public uint dwBackBufferCount;

        [NativeTypeName("_DDSURFACEDESC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/ddraw.h:2242:5)")]
        public _Anonymous2_e__Union Anonymous2;

        public unsafe ref uint dwMipMapCount
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dwMipMapCount, 1));
#else
                return ref ((_Anonymous2_e__Union*)Unsafe.AsPointer(ref Anonymous2))->dwMipMapCount;
#endif
            }
        }

        public unsafe ref uint dwZBufferBitDepth
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dwZBufferBitDepth, 1));
#else
                return ref ((_Anonymous2_e__Union*)Unsafe.AsPointer(ref Anonymous2))->dwZBufferBitDepth;
#endif
            }
        }

        public unsafe ref uint dwRefreshRate
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dwRefreshRate, 1));
#else
                return ref ((_Anonymous2_e__Union*)Unsafe.AsPointer(ref Anonymous2))->dwRefreshRate;
#endif
            }
        }

        [NativeTypeName("DWORD")]
        public uint dwAlphaBitDepth;

        [NativeTypeName("DWORD")]
        public uint dwReserved;

        [NativeTypeName("LPVOID")]
        public void* lpSurface;

        public DDCOLORKEY ddckCKDestOverlay;

        public DDCOLORKEY ddckCKDestBlt;

        public DDCOLORKEY ddckCKSrcOverlay;

        public DDCOLORKEY ddckCKSrcBlt;

        public DDPIXELFORMAT ddpfPixelFormat;

        public DDSCAPS ddsCaps;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("LONG")]
            public int lPitch;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwLinearSize;
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwMipMapCount;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwZBufferBitDepth;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwRefreshRate;
        }
    }
}
