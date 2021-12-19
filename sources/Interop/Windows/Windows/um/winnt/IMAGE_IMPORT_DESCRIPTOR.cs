// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IMAGE_IMPORT_DESCRIPTOR.xml' path='doc/member[@name="IMAGE_IMPORT_DESCRIPTOR"]/*' />
public partial struct IMAGE_IMPORT_DESCRIPTOR
{
    /// <include file='IMAGE_IMPORT_DESCRIPTOR.xml' path='doc/member[@name="IMAGE_IMPORT_DESCRIPTOR.Anonymous"]/*' />
    [NativeTypeName("_IMAGE_IMPORT_DESCRIPTOR::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/winnt.h:19561:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='IMAGE_IMPORT_DESCRIPTOR.xml' path='doc/member[@name="IMAGE_IMPORT_DESCRIPTOR.TimeDateStamp"]/*' />
    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;

    /// <include file='IMAGE_IMPORT_DESCRIPTOR.xml' path='doc/member[@name="IMAGE_IMPORT_DESCRIPTOR.ForwarderChain"]/*' />
    [NativeTypeName("DWORD")]
    public uint ForwarderChain;

    /// <include file='IMAGE_IMPORT_DESCRIPTOR.xml' path='doc/member[@name="IMAGE_IMPORT_DESCRIPTOR.Name"]/*' />
    [NativeTypeName("DWORD")]
    public uint Name;

    /// <include file='IMAGE_IMPORT_DESCRIPTOR.xml' path='doc/member[@name="IMAGE_IMPORT_DESCRIPTOR.FirstThunk"]/*' />
    [NativeTypeName("DWORD")]
    public uint FirstThunk;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Characteristics"]/*' />
    public ref uint Characteristics
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Characteristics, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.OriginalFirstThunk"]/*' />
    public ref uint OriginalFirstThunk
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.OriginalFirstThunk, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Characteristics"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint Characteristics;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.OriginalFirstThunk"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint OriginalFirstThunk;
    }
}
