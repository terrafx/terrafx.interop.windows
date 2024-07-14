// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='FILE_IN_CABINET_INFO_A.xml' path='doc/member[@name="FILE_IN_CABINET_INFO_A"]/*' />
public unsafe partial struct FILE_IN_CABINET_INFO_A
{
    /// <include file='FILE_IN_CABINET_INFO_A.xml' path='doc/member[@name="FILE_IN_CABINET_INFO_A.NameInCabinet"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* NameInCabinet;

    /// <include file='FILE_IN_CABINET_INFO_A.xml' path='doc/member[@name="FILE_IN_CABINET_INFO_A.FileSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint FileSize;

    /// <include file='FILE_IN_CABINET_INFO_A.xml' path='doc/member[@name="FILE_IN_CABINET_INFO_A.Win32Error"]/*' />
    [NativeTypeName("DWORD")]
    public uint Win32Error;

    /// <include file='FILE_IN_CABINET_INFO_A.xml' path='doc/member[@name="FILE_IN_CABINET_INFO_A.DosDate"]/*' />
    [NativeTypeName("WORD")]
    public ushort DosDate;

    /// <include file='FILE_IN_CABINET_INFO_A.xml' path='doc/member[@name="FILE_IN_CABINET_INFO_A.DosTime"]/*' />
    [NativeTypeName("WORD")]
    public ushort DosTime;

    /// <include file='FILE_IN_CABINET_INFO_A.xml' path='doc/member[@name="FILE_IN_CABINET_INFO_A.DosAttribs"]/*' />
    [NativeTypeName("WORD")]
    public ushort DosAttribs;

    /// <include file='FILE_IN_CABINET_INFO_A.xml' path='doc/member[@name="FILE_IN_CABINET_INFO_A.FullTargetName"]/*' />
    [NativeTypeName("CHAR[260]")]
    public _FullTargetName_e__FixedBuffer FullTargetName;

    /// <include file='_FullTargetName_e__FixedBuffer.xml' path='doc/member[@name="_FullTargetName_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _FullTargetName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
