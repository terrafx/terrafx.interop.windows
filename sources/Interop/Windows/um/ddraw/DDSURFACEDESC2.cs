// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct DDSURFACEDESC2
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint dwHeight;

        [NativeTypeName("DWORD")]
        public uint dwWidth;

        [NativeTypeName("_DDSURFACEDESC2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/ddraw.h:2268:5)")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("_DDSURFACEDESC2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/ddraw.h:2273:5)")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("_DDSURFACEDESC2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/ddraw.h:2278:5)")]
        public _Anonymous3_e__Union Anonymous3;

        [NativeTypeName("DWORD")]
        public uint dwAlphaBitDepth;

        [NativeTypeName("DWORD")]
        public uint dwReserved;

        [NativeTypeName("LPVOID")]
        public void* lpSurface;

        [NativeTypeName("_DDSURFACEDESC2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/ddraw.h:2288:5)")]
        public _Anonymous4_e__Union Anonymous4;

        public DDCOLORKEY ddckCKDestBlt;

        public DDCOLORKEY ddckCKSrcOverlay;

        public DDCOLORKEY ddckCKSrcBlt;

        [NativeTypeName("_DDSURFACEDESC2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/ddraw.h:2296:5)")]
        public _Anonymous5_e__Union Anonymous5;

        public DDSCAPS2 ddsCaps;

        [NativeTypeName("DWORD")]
        public uint dwTextureStage;

        public ref int lPitch
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.lPitch, 1));
            }
        }

        public ref uint dwLinearSize
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.dwLinearSize, 1));
            }
        }

        public ref uint dwBackBufferCount
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dwBackBufferCount, 1));
            }
        }

        public ref uint dwDepth
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dwDepth, 1));
            }
        }

        public ref uint dwMipMapCount
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous3.dwMipMapCount, 1));
            }
        }

        public ref uint dwRefreshRate
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous3.dwRefreshRate, 1));
            }
        }

        public ref uint dwSrcVBHandle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous3.dwSrcVBHandle, 1));
            }
        }

        public ref DDCOLORKEY ddckCKDestOverlay
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous4.ddckCKDestOverlay, 1));
            }
        }

        public ref uint dwEmptyFaceColor
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous4.dwEmptyFaceColor, 1));
            }
        }

        public ref DDPIXELFORMAT ddpfPixelFormat
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous5.ddpfPixelFormat, 1));
            }
        }

        public ref uint dwFVF
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous5.dwFVF, 1));
            }
        }

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
            public uint dwBackBufferCount;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwDepth;
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous3_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwMipMapCount;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwRefreshRate;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwSrcVBHandle;
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous4_e__Union
        {
            [FieldOffset(0)]
            public DDCOLORKEY ddckCKDestOverlay;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwEmptyFaceColor;
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous5_e__Union
        {
            [FieldOffset(0)]
            public DDPIXELFORMAT ddpfPixelFormat;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwFVF;
        }
    }
}
