// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='DDPIXELFORMAT.xml' path='doc/member[@name="DDPIXELFORMAT"]/*' />
public partial struct DDPIXELFORMAT
{
    /// <include file='DDPIXELFORMAT.xml' path='doc/member[@name="DDPIXELFORMAT.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='DDPIXELFORMAT.xml' path='doc/member[@name="DDPIXELFORMAT.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='DDPIXELFORMAT.xml' path='doc/member[@name="DDPIXELFORMAT.dwFourCC"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFourCC;

    /// <include file='DDPIXELFORMAT.xml' path='doc/member[@name="DDPIXELFORMAT.Anonymous1"]/*' />
    [NativeTypeName("_DDPIXELFORMAT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/ddraw.h:712:5)")]
    public _Anonymous1_e__Union Anonymous1;

    /// <include file='DDPIXELFORMAT.xml' path='doc/member[@name="DDPIXELFORMAT.Anonymous2"]/*' />
    [NativeTypeName("_DDPIXELFORMAT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/ddraw.h:723:5)")]
    public _Anonymous2_e__Union Anonymous2;

    /// <include file='DDPIXELFORMAT.xml' path='doc/member[@name="DDPIXELFORMAT.Anonymous3"]/*' />
    [NativeTypeName("_DDPIXELFORMAT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/ddraw.h:732:5)")]
    public _Anonymous3_e__Union Anonymous3;

    /// <include file='DDPIXELFORMAT.xml' path='doc/member[@name="DDPIXELFORMAT.Anonymous4"]/*' />
    [NativeTypeName("_DDPIXELFORMAT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/ddraw.h:745:5)")]
    public _Anonymous4_e__Union Anonymous4;

    /// <include file='DDPIXELFORMAT.xml' path='doc/member[@name="DDPIXELFORMAT.Anonymous5"]/*' />
    [NativeTypeName("_DDPIXELFORMAT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/ddraw.h:752:5)")]
    public _Anonymous5_e__Union Anonymous5;

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwRGBBitCount"]/*' />
    public ref uint dwRGBBitCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.dwRGBBitCount, 1));
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwYUVBitCount"]/*' />
    public ref uint dwYUVBitCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.dwYUVBitCount, 1));
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwZBufferBitDepth"]/*' />
    public ref uint dwZBufferBitDepth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.dwZBufferBitDepth, 1));
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwAlphaBitDepth"]/*' />
    public ref uint dwAlphaBitDepth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.dwAlphaBitDepth, 1));
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwLuminanceBitCount"]/*' />
    public ref uint dwLuminanceBitCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.dwLuminanceBitCount, 1));
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwBumpBitCount"]/*' />
    public ref uint dwBumpBitCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.dwBumpBitCount, 1));
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwPrivateFormatBitCount"]/*' />
    public ref uint dwPrivateFormatBitCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.dwPrivateFormatBitCount, 1));
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwRBitMask"]/*' />
    public ref uint dwRBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dwRBitMask, 1));
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwYBitMask"]/*' />
    public ref uint dwYBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dwYBitMask, 1));
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwStencilBitDepth"]/*' />
    public ref uint dwStencilBitDepth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dwStencilBitDepth, 1));
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwLuminanceBitMask"]/*' />
    public ref uint dwLuminanceBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dwLuminanceBitMask, 1));
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwBumpDuBitMask"]/*' />
    public ref uint dwBumpDuBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dwBumpDuBitMask, 1));
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwOperations"]/*' />
    public ref uint dwOperations
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dwOperations, 1));
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.dwGBitMask"]/*' />
    public ref uint dwGBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous3.dwGBitMask, 1));
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.dwUBitMask"]/*' />
    public ref uint dwUBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous3.dwUBitMask, 1));
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.dwZBitMask"]/*' />
    public ref uint dwZBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous3.dwZBitMask, 1));
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.dwBumpDvBitMask"]/*' />
    public ref uint dwBumpDvBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous3.dwBumpDvBitMask, 1));
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.MultiSampleCaps"]/*' />
    public ref _Anonymous3_e__Union._MultiSampleCaps_e__Struct MultiSampleCaps
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous3.MultiSampleCaps, 1));
        }
    }

    /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.dwBBitMask"]/*' />
    public ref uint dwBBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous4.dwBBitMask, 1));
        }
    }

    /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.dwVBitMask"]/*' />
    public ref uint dwVBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous4.dwVBitMask, 1));
        }
    }

    /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.dwStencilBitMask"]/*' />
    public ref uint dwStencilBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous4.dwStencilBitMask, 1));
        }
    }

    /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.dwBumpLuminanceBitMask"]/*' />
    public ref uint dwBumpLuminanceBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous4.dwBumpLuminanceBitMask, 1));
        }
    }

    /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwRGBAlphaBitMask"]/*' />
    public ref uint dwRGBAlphaBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous5.dwRGBAlphaBitMask, 1));
        }
    }

    /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwYUVAlphaBitMask"]/*' />
    public ref uint dwYUVAlphaBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous5.dwYUVAlphaBitMask, 1));
        }
    }

    /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwLuminanceAlphaBitMask"]/*' />
    public ref uint dwLuminanceAlphaBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous5.dwLuminanceAlphaBitMask, 1));
        }
    }

    /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwRGBZBitMask"]/*' />
    public ref uint dwRGBZBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous5.dwRGBZBitMask, 1));
        }
    }

    /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwYUVZBitMask"]/*' />
    public ref uint dwYUVZBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous5.dwYUVZBitMask, 1));
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous1_e__Union
    {
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwRGBBitCount"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwRGBBitCount;

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwYUVBitCount"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwYUVBitCount;

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwZBufferBitDepth"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwZBufferBitDepth;

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwAlphaBitDepth"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwAlphaBitDepth;

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwLuminanceBitCount"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwLuminanceBitCount;

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwBumpBitCount"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwBumpBitCount;

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwPrivateFormatBitCount"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwPrivateFormatBitCount;
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwRBitMask"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwRBitMask;

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwYBitMask"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwYBitMask;

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwStencilBitDepth"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwStencilBitDepth;

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwLuminanceBitMask"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwLuminanceBitMask;

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwBumpDuBitMask"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwBumpDuBitMask;

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwOperations"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwOperations;
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous3_e__Union
    {
        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.dwGBitMask"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwGBitMask;

        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.dwUBitMask"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwUBitMask;

        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.dwZBitMask"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwZBitMask;

        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.dwBumpDvBitMask"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwBumpDvBitMask;

        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.MultiSampleCaps"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/ddraw.h:738:9)")]
        public _MultiSampleCaps_e__Struct MultiSampleCaps;

        /// <include file='_MultiSampleCaps_e__Struct.xml' path='doc/member[@name="_MultiSampleCaps_e__Struct"]/*' />
        public partial struct _MultiSampleCaps_e__Struct
        {
            /// <include file='_MultiSampleCaps_e__Struct.xml' path='doc/member[@name="_MultiSampleCaps_e__Struct.wFlipMSTypes"]/*' />
            [NativeTypeName("WORD")]
            public ushort wFlipMSTypes;

            /// <include file='_MultiSampleCaps_e__Struct.xml' path='doc/member[@name="_MultiSampleCaps_e__Struct.wBltMSTypes"]/*' />
            [NativeTypeName("WORD")]
            public ushort wBltMSTypes;
        }
    }

    /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous4_e__Union
    {
        /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.dwBBitMask"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwBBitMask;

        /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.dwVBitMask"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwVBitMask;

        /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.dwStencilBitMask"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwStencilBitMask;

        /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.dwBumpLuminanceBitMask"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwBumpLuminanceBitMask;
    }

    /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous5_e__Union
    {
        /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwRGBAlphaBitMask"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwRGBAlphaBitMask;

        /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwYUVAlphaBitMask"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwYUVAlphaBitMask;

        /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwLuminanceAlphaBitMask"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwLuminanceAlphaBitMask;

        /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwRGBZBitMask"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwRGBZBitMask;

        /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwYUVZBitMask"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwYUVZBitMask;
    }
}
