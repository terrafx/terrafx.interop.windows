// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct STGMEDIUM
    {
        [NativeTypeName("DWORD")]
        public uint tymed;

        [NativeTypeName("tagSTGMEDIUM::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/ObjIdl.h:11272:36)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref IntPtr hBitmap
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.hBitmap, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->hBitmap;
#endif
            }
        }

        public unsafe ref void* hMetaFilePict
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->hMetaFilePict;
            }
        }

        public unsafe ref IntPtr hEnhMetaFile
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.hEnhMetaFile, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->hEnhMetaFile;
#endif
            }
        }

        public unsafe ref IntPtr hGlobal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.hGlobal, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->hGlobal;
#endif
            }
        }

        public unsafe ref ushort* lpszFileName
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->lpszFileName;
            }
        }

        public unsafe ref IStream* pstm
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->pstm;
            }
        }

        public unsafe ref IStorage* pstg
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->pstg;
            }
        }

        [NativeTypeName("IUnknown *")]
        public IUnknown* pUnkForRelease;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("HBITMAP")]
            public IntPtr hBitmap;

            [FieldOffset(0)]
            [NativeTypeName("HMETAFILEPICT")]
            public void* hMetaFilePict;

            [FieldOffset(0)]
            [NativeTypeName("HENHMETAFILE")]
            public IntPtr hEnhMetaFile;

            [FieldOffset(0)]
            [NativeTypeName("HGLOBAL")]
            public IntPtr hGlobal;

            [FieldOffset(0)]
            [NativeTypeName("LPOLESTR")]
            public ushort* lpszFileName;

            [FieldOffset(0)]
            [NativeTypeName("IStream *")]
            public IStream* pstm;

            [FieldOffset(0)]
            [NativeTypeName("IStorage *")]
            public IStorage* pstg;
        }
    }
}
