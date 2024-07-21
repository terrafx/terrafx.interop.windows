// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapo.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='XAPO_REGISTRATION_PROPERTIES.xml' path='doc/member[@name="XAPO_REGISTRATION_PROPERTIES"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct XAPO_REGISTRATION_PROPERTIES
{
    /// <include file='XAPO_REGISTRATION_PROPERTIES.xml' path='doc/member[@name="XAPO_REGISTRATION_PROPERTIES.clsid"]/*' />
    [NativeTypeName("CLSID")]
    public Guid clsid;

    /// <include file='XAPO_REGISTRATION_PROPERTIES.xml' path='doc/member[@name="XAPO_REGISTRATION_PROPERTIES.FriendlyName"]/*' />
    [NativeTypeName("WCHAR[256]")]
    public _FriendlyName_e__FixedBuffer FriendlyName;

    /// <include file='XAPO_REGISTRATION_PROPERTIES.xml' path='doc/member[@name="XAPO_REGISTRATION_PROPERTIES.CopyrightInfo"]/*' />
    [NativeTypeName("WCHAR[256]")]
    public _CopyrightInfo_e__FixedBuffer CopyrightInfo;

    /// <include file='XAPO_REGISTRATION_PROPERTIES.xml' path='doc/member[@name="XAPO_REGISTRATION_PROPERTIES.MajorVersion"]/*' />
    [NativeTypeName("UINT32")]
    public uint MajorVersion;

    /// <include file='XAPO_REGISTRATION_PROPERTIES.xml' path='doc/member[@name="XAPO_REGISTRATION_PROPERTIES.MinorVersion"]/*' />
    [NativeTypeName("UINT32")]
    public uint MinorVersion;

    /// <include file='XAPO_REGISTRATION_PROPERTIES.xml' path='doc/member[@name="XAPO_REGISTRATION_PROPERTIES.Flags"]/*' />
    [NativeTypeName("UINT32")]
    public uint Flags;

    /// <include file='XAPO_REGISTRATION_PROPERTIES.xml' path='doc/member[@name="XAPO_REGISTRATION_PROPERTIES.MinInputBufferCount"]/*' />
    [NativeTypeName("UINT32")]
    public uint MinInputBufferCount;

    /// <include file='XAPO_REGISTRATION_PROPERTIES.xml' path='doc/member[@name="XAPO_REGISTRATION_PROPERTIES.MaxInputBufferCount"]/*' />
    [NativeTypeName("UINT32")]
    public uint MaxInputBufferCount;

    /// <include file='XAPO_REGISTRATION_PROPERTIES.xml' path='doc/member[@name="XAPO_REGISTRATION_PROPERTIES.MinOutputBufferCount"]/*' />
    [NativeTypeName("UINT32")]
    public uint MinOutputBufferCount;

    /// <include file='XAPO_REGISTRATION_PROPERTIES.xml' path='doc/member[@name="XAPO_REGISTRATION_PROPERTIES.MaxOutputBufferCount"]/*' />
    [NativeTypeName("UINT32")]
    public uint MaxOutputBufferCount;

    /// <include file='_FriendlyName_e__FixedBuffer.xml' path='doc/member[@name="_FriendlyName_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(256)]
    public partial struct _FriendlyName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_CopyrightInfo_e__FixedBuffer.xml' path='doc/member[@name="_CopyrightInfo_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(256)]
    public partial struct _CopyrightInfo_e__FixedBuffer
    {
        public char e0;
    }
}
