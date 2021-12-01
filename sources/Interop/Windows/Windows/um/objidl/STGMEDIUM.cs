// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='STGMEDIUM.xml' path='doc/member[@name="STGMEDIUM"]/*' />
public unsafe partial struct STGMEDIUM
{
    /// <include file='STGMEDIUM.xml' path='doc/member[@name="STGMEDIUM.tymed"]/*' />
    [NativeTypeName("DWORD")]
    public uint tymed;

    /// <include file='STGMEDIUM.xml' path='doc/member[@name="STGMEDIUM.Anonymous"]/*' />
    [NativeTypeName("tagSTGMEDIUM::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/objidl.h:11954:36)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='STGMEDIUM.xml' path='doc/member[@name="STGMEDIUM.pUnkForRelease"]/*' />
    public IUnknown* pUnkForRelease;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hBitmap"]/*' />
    public ref HBITMAP hBitmap
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.hBitmap;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hMetaFilePict"]/*' />
    public ref HMETAFILEPICT hMetaFilePict
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.hMetaFilePict;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hEnhMetaFile"]/*' />
    public ref HENHMETAFILE hEnhMetaFile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.hEnhMetaFile;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hGlobal"]/*' />
    public ref HGLOBAL hGlobal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.hGlobal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.lpszFileName"]/*' />
    public ref ushort* lpszFileName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.lpszFileName;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pstm"]/*' />
    public ref IStream* pstm
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.pstm;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pstg"]/*' />
    public ref IStorage* pstg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.pstg;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hBitmap"]/*' />
        [FieldOffset(0)]
        public HBITMAP hBitmap;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hMetaFilePict"]/*' />
        [FieldOffset(0)]
        public HMETAFILEPICT hMetaFilePict;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hEnhMetaFile"]/*' />
        [FieldOffset(0)]
        public HENHMETAFILE hEnhMetaFile;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hGlobal"]/*' />
        [FieldOffset(0)]
        public HGLOBAL hGlobal;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.lpszFileName"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPOLESTR")]
        public ushort* lpszFileName;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pstm"]/*' />
        [FieldOffset(0)]
        public IStream* pstm;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pstg"]/*' />
        [FieldOffset(0)]
        public IStorage* pstg;
    }
}
