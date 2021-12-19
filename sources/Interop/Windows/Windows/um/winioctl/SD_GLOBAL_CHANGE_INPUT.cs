// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SD_GLOBAL_CHANGE_INPUT.xml' path='doc/member[@name="SD_GLOBAL_CHANGE_INPUT"]/*' />
public partial struct SD_GLOBAL_CHANGE_INPUT
{
    /// <include file='SD_GLOBAL_CHANGE_INPUT.xml' path='doc/member[@name="SD_GLOBAL_CHANGE_INPUT.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='SD_GLOBAL_CHANGE_INPUT.xml' path='doc/member[@name="SD_GLOBAL_CHANGE_INPUT.ChangeType"]/*' />
    [NativeTypeName("DWORD")]
    public uint ChangeType;

    /// <include file='SD_GLOBAL_CHANGE_INPUT.xml' path='doc/member[@name="SD_GLOBAL_CHANGE_INPUT.Anonymous"]/*' />
    [NativeTypeName("_SD_GLOBAL_CHANGE_INPUT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/winioctl.h:14327:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SdChange"]/*' />
    public ref SD_CHANGE_MACHINE_SID_INPUT SdChange
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.SdChange, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SdQueryStats"]/*' />
    public ref SD_QUERY_STATS_INPUT SdQueryStats
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.SdQueryStats, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SdEnumSds"]/*' />
    public ref SD_ENUM_SDS_INPUT SdEnumSds
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.SdEnumSds, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SdChange"]/*' />
        [FieldOffset(0)]
        public SD_CHANGE_MACHINE_SID_INPUT SdChange;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SdQueryStats"]/*' />
        [FieldOffset(0)]
        public SD_QUERY_STATS_INPUT SdQueryStats;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SdEnumSds"]/*' />
        [FieldOffset(0)]
        public SD_ENUM_SDS_INPUT SdEnumSds;
    }
}
