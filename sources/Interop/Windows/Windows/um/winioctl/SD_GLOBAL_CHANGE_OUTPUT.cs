// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SD_GLOBAL_CHANGE_OUTPUT.xml' path='doc/member[@name="SD_GLOBAL_CHANGE_OUTPUT"]/*' />
public partial struct SD_GLOBAL_CHANGE_OUTPUT
{
    /// <include file='SD_GLOBAL_CHANGE_OUTPUT.xml' path='doc/member[@name="SD_GLOBAL_CHANGE_OUTPUT.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='SD_GLOBAL_CHANGE_OUTPUT.xml' path='doc/member[@name="SD_GLOBAL_CHANGE_OUTPUT.ChangeType"]/*' />
    [NativeTypeName("DWORD")]
    public uint ChangeType;

    /// <include file='SD_GLOBAL_CHANGE_OUTPUT.xml' path='doc/member[@name="SD_GLOBAL_CHANGE_OUTPUT.Anonymous"]/*' />
    [NativeTypeName("_SD_GLOBAL_CHANGE_OUTPUT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/winioctl.h:14420:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SdChange"]/*' />
    [UnscopedRef]
    public ref SD_CHANGE_MACHINE_SID_OUTPUT SdChange
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.SdChange;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SdQueryStats"]/*' />
    [UnscopedRef]
    public ref SD_QUERY_STATS_OUTPUT SdQueryStats
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.SdQueryStats;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SdEnumSds"]/*' />
    [UnscopedRef]
    public ref SD_ENUM_SDS_OUTPUT SdEnumSds
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.SdEnumSds;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SdChange"]/*' />
        [FieldOffset(0)]
        public SD_CHANGE_MACHINE_SID_OUTPUT SdChange;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SdQueryStats"]/*' />
        [FieldOffset(0)]
        public SD_QUERY_STATS_OUTPUT SdQueryStats;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SdEnumSds"]/*' />
        [FieldOffset(0)]
        public SD_ENUM_SDS_OUTPUT SdEnumSds;
    }
}
