// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE"]/*' />
public partial struct STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE
{
    /// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE.ResponseLevel"]/*' />
    [NativeTypeName("DWORD")]
    public uint ResponseLevel;

    /// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE.NumberEntries"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumberEntries;

    /// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE.Anonymous"]/*' />
    [NativeTypeName("_STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/winioctl.h:14049:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Lev1Depends"]/*' />
    public ref STORAGE_QUERY_DEPENDENT_VOLUME_LEV1_ENTRY Lev1Depends
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Lev1Depends, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Lev2Depends"]/*' />
    public ref STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY Lev2Depends
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Lev2Depends, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Lev1Depends"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("STORAGE_QUERY_DEPENDENT_VOLUME_LEV1_ENTRY []")]
        public STORAGE_QUERY_DEPENDENT_VOLUME_LEV1_ENTRY Lev1Depends;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Lev2Depends"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY []")]
        public STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY Lev2Depends;
    }
}
