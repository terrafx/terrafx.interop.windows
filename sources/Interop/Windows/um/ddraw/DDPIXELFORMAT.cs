// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct DDPIXELFORMAT
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint dwFourCC;

        [NativeTypeName("_DDPIXELFORMAT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/ddraw.h:712:5)")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("_DDPIXELFORMAT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/ddraw.h:723:5)")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("_DDPIXELFORMAT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/ddraw.h:732:5)")]
        public _Anonymous3_e__Union Anonymous3;

        [NativeTypeName("_DDPIXELFORMAT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/ddraw.h:745:5)")]
        public _Anonymous4_e__Union Anonymous4;

        [NativeTypeName("_DDPIXELFORMAT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/ddraw.h:752:5)")]
        public _Anonymous5_e__Union Anonymous5;

        public ref uint dwRGBBitCount
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.dwRGBBitCount, 1));
            }
        }

        public ref uint dwYUVBitCount
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.dwYUVBitCount, 1));
            }
        }

        public ref uint dwZBufferBitDepth
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.dwZBufferBitDepth, 1));
            }
        }

        public ref uint dwAlphaBitDepth
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.dwAlphaBitDepth, 1));
            }
        }

        public ref uint dwLuminanceBitCount
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.dwLuminanceBitCount, 1));
            }
        }

        public ref uint dwBumpBitCount
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.dwBumpBitCount, 1));
            }
        }

        public ref uint dwPrivateFormatBitCount
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.dwPrivateFormatBitCount, 1));
            }
        }

        public ref uint dwRBitMask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dwRBitMask, 1));
            }
        }

        public ref uint dwYBitMask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dwYBitMask, 1));
            }
        }

        public ref uint dwStencilBitDepth
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dwStencilBitDepth, 1));
            }
        }

        public ref uint dwLuminanceBitMask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dwLuminanceBitMask, 1));
            }
        }

        public ref uint dwBumpDuBitMask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dwBumpDuBitMask, 1));
            }
        }

        public ref uint dwOperations
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dwOperations, 1));
            }
        }

        public ref uint dwGBitMask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous3.dwGBitMask, 1));
            }
        }

        public ref uint dwUBitMask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous3.dwUBitMask, 1));
            }
        }

        public ref uint dwZBitMask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous3.dwZBitMask, 1));
            }
        }

        public ref uint dwBumpDvBitMask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous3.dwBumpDvBitMask, 1));
            }
        }

        public ref _Anonymous3_e__Union._MultiSampleCaps_e__Struct MultiSampleCaps
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous3.MultiSampleCaps, 1));
            }
        }

        public ref uint dwBBitMask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous4.dwBBitMask, 1));
            }
        }

        public ref uint dwVBitMask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous4.dwVBitMask, 1));
            }
        }

        public ref uint dwStencilBitMask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous4.dwStencilBitMask, 1));
            }
        }

        public ref uint dwBumpLuminanceBitMask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous4.dwBumpLuminanceBitMask, 1));
            }
        }

        public ref uint dwRGBAlphaBitMask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous5.dwRGBAlphaBitMask, 1));
            }
        }

        public ref uint dwYUVAlphaBitMask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous5.dwYUVAlphaBitMask, 1));
            }
        }

        public ref uint dwLuminanceAlphaBitMask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous5.dwLuminanceAlphaBitMask, 1));
            }
        }

        public ref uint dwRGBZBitMask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous5.dwRGBZBitMask, 1));
            }
        }

        public ref uint dwYUVZBitMask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous5.dwYUVZBitMask, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwRGBBitCount;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwYUVBitCount;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwZBufferBitDepth;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwAlphaBitDepth;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwLuminanceBitCount;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwBumpBitCount;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwPrivateFormatBitCount;
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwRBitMask;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwYBitMask;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwStencilBitDepth;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwLuminanceBitMask;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwBumpDuBitMask;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwOperations;
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous3_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwGBitMask;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwUBitMask;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwZBitMask;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwBumpDvBitMask;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/ddraw.h:738:9)")]
            public _MultiSampleCaps_e__Struct MultiSampleCaps;

            public partial struct _MultiSampleCaps_e__Struct
            {
                [NativeTypeName("WORD")]
                public ushort wFlipMSTypes;

                [NativeTypeName("WORD")]
                public ushort wBltMSTypes;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous4_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwBBitMask;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwVBitMask;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwStencilBitMask;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwBumpLuminanceBitMask;
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous5_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwRGBAlphaBitMask;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwYUVAlphaBitMask;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwLuminanceAlphaBitMask;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwRGBZBitMask;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwYUVZBitMask;
        }
    }
}
