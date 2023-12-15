// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MIXERLINEW.xml' path='doc/member[@name="MIXERLINEW"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MIXERLINEW
{
    /// <include file='MIXERLINEW.xml' path='doc/member[@name="MIXERLINEW.cbStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    /// <include file='MIXERLINEW.xml' path='doc/member[@name="MIXERLINEW.dwDestination"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDestination;

    /// <include file='MIXERLINEW.xml' path='doc/member[@name="MIXERLINEW.dwSource"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSource;

    /// <include file='MIXERLINEW.xml' path='doc/member[@name="MIXERLINEW.dwLineID"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLineID;

    /// <include file='MIXERLINEW.xml' path='doc/member[@name="MIXERLINEW.fdwLine"]/*' />
    [NativeTypeName("DWORD")]
    public uint fdwLine;

    /// <include file='MIXERLINEW.xml' path='doc/member[@name="MIXERLINEW.dwUser"]/*' />
    [NativeTypeName("DWORD_PTR")]
    public nuint dwUser;

    /// <include file='MIXERLINEW.xml' path='doc/member[@name="MIXERLINEW.dwComponentType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwComponentType;

    /// <include file='MIXERLINEW.xml' path='doc/member[@name="MIXERLINEW.cChannels"]/*' />
    [NativeTypeName("DWORD")]
    public uint cChannels;

    /// <include file='MIXERLINEW.xml' path='doc/member[@name="MIXERLINEW.cConnections"]/*' />
    [NativeTypeName("DWORD")]
    public uint cConnections;

    /// <include file='MIXERLINEW.xml' path='doc/member[@name="MIXERLINEW.cControls"]/*' />
    [NativeTypeName("DWORD")]
    public uint cControls;

    /// <include file='MIXERLINEW.xml' path='doc/member[@name="MIXERLINEW.szShortName"]/*' />
    [NativeTypeName("WCHAR[16]")]
    public _szShortName_e__FixedBuffer szShortName;

    /// <include file='MIXERLINEW.xml' path='doc/member[@name="MIXERLINEW.szName"]/*' />
    [NativeTypeName("WCHAR[64]")]
    public _szName_e__FixedBuffer szName;

    /// <include file='MIXERLINEW.xml' path='doc/member[@name="MIXERLINEW.Target"]/*' />
    [NativeTypeName("__AnonymousRecord_mmeapi_L1901_C5")]
    public _Target_e__Struct Target;

    /// <include file='_Target_e__Struct.xml' path='doc/member[@name="_Target_e__Struct"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _Target_e__Struct
    {
        /// <include file='_Target_e__Struct.xml' path='doc/member[@name="_Target_e__Struct.dwType"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwType;

        /// <include file='_Target_e__Struct.xml' path='doc/member[@name="_Target_e__Struct.dwDeviceID"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwDeviceID;

        /// <include file='_Target_e__Struct.xml' path='doc/member[@name="_Target_e__Struct.wMid"]/*' />
        [NativeTypeName("WORD")]
        public ushort wMid;

        /// <include file='_Target_e__Struct.xml' path='doc/member[@name="_Target_e__Struct.wPid"]/*' />
        [NativeTypeName("WORD")]
        public ushort wPid;

        /// <include file='_Target_e__Struct.xml' path='doc/member[@name="_Target_e__Struct.vDriverVersion"]/*' />
        [NativeTypeName("MMVERSION")]
        public uint vDriverVersion;

        /// <include file='_Target_e__Struct.xml' path='doc/member[@name="_Target_e__Struct.szPname"]/*' />
        [NativeTypeName("WCHAR[32]")]
        public _szPname_e__FixedBuffer szPname;

        /// <include file='_szPname_e__FixedBuffer.xml' path='doc/member[@name="_szPname_e__FixedBuffer"]/*' />
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        [InlineArray(32)]
        [Obsolete("Possible string represented as a fixed-sized buffer.")]
        public partial struct _szPname_e__FixedBuffer
        {
            public char e0;
        }
    }

    /// <include file='_szShortName_e__FixedBuffer.xml' path='doc/member[@name="_szShortName_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(16)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szShortName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_szName_e__FixedBuffer.xml' path='doc/member[@name="_szName_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(64)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szName_e__FixedBuffer
    {
        public char e0;
    }
}
