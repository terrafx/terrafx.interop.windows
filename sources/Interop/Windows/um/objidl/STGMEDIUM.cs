// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
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

        [NativeTypeName("tagSTGMEDIUM::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/objidl.h:11954:36)")]
        public _Anonymous_e__Union Anonymous;

        public IUnknown* pUnkForRelease;

        public ref IntPtr hBitmap
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.hBitmap, 1));
            }
        }

        public ref IntPtr hMetaFilePict
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.hMetaFilePict, 1));
            }
        }

        public ref IntPtr hEnhMetaFile
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.hEnhMetaFile, 1));
            }
        }

        public ref IntPtr hGlobal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.hGlobal, 1));
            }
        }

        public ref ushort* lpszFileName
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->lpszFileName;
                }
            }
        }

        public ref IStream* pstm
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pstm;
                }
            }
        }

        public ref IStorage* pstg
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pstg;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("HBITMAP")]
            public IntPtr hBitmap;

            [FieldOffset(0)]
            [NativeTypeName("HMETAFILEPICT")]
            public IntPtr hMetaFilePict;

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
            public IStream* pstm;

            [FieldOffset(0)]
            public IStorage* pstg;
        }
    }
}
