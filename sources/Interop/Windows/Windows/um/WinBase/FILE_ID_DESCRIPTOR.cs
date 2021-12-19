// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='FILE_ID_DESCRIPTOR.xml' path='doc/member[@name="FILE_ID_DESCRIPTOR"]/*' />
public partial struct FILE_ID_DESCRIPTOR
{
    /// <include file='FILE_ID_DESCRIPTOR.xml' path='doc/member[@name="FILE_ID_DESCRIPTOR.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='FILE_ID_DESCRIPTOR.xml' path='doc/member[@name="FILE_ID_DESCRIPTOR.Type"]/*' />
    public FILE_ID_TYPE Type;

    /// <include file='FILE_ID_DESCRIPTOR.xml' path='doc/member[@name="FILE_ID_DESCRIPTOR.Anonymous"]/*' />
    [NativeTypeName("FILE_ID_DESCRIPTOR::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/WinBase.h:9164:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FileId"]/*' />
    public ref LARGE_INTEGER FileId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.FileId, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ObjectId"]/*' />
    public ref Guid ObjectId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ObjectId, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ExtendedFileId"]/*' />
    public ref FILE_ID_128 ExtendedFileId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ExtendedFileId, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FileId"]/*' />
        [FieldOffset(0)]
        public LARGE_INTEGER FileId;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ObjectId"]/*' />
        [FieldOffset(0)]
        public Guid ObjectId;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ExtendedFileId"]/*' />
        [FieldOffset(0)]
        public FILE_ID_128 ExtendedFileId;
    }
}
