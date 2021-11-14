// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct STGMEDIUM
    {
        [NativeTypeName("DWORD")]
        public uint tymed;

        [NativeTypeName("tagSTGMEDIUM::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/objidl.h:11954:36)")]
        public _Anonymous_e__Union Anonymous;

        public IUnknown* pUnkForRelease;

        public ref HBITMAP hBitmap
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.hBitmap;
            }
        }

        public ref HMETAFILEPICT hMetaFilePict
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.hMetaFilePict;
            }
        }

        public ref HENHMETAFILE hEnhMetaFile
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.hEnhMetaFile;
            }
        }

        public ref HGLOBAL hGlobal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.hGlobal;
            }
        }

        public ref ushort* lpszFileName
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.lpszFileName;
            }
        }

        public ref IStream* pstm
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.pstm;
            }
        }

        public ref IStorage* pstg
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.pstg;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public HBITMAP hBitmap;

            [FieldOffset(0)]
            public HMETAFILEPICT hMetaFilePict;

            [FieldOffset(0)]
            public HENHMETAFILE hEnhMetaFile;

            [FieldOffset(0)]
            public HGLOBAL hGlobal;

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
