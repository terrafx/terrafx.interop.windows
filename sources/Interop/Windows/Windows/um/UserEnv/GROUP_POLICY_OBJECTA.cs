// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UserEnv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='GROUP_POLICY_OBJECTA.xml' path='doc/member[@name="GROUP_POLICY_OBJECTA"]/*' />
public unsafe partial struct GROUP_POLICY_OBJECTA
{
    /// <include file='GROUP_POLICY_OBJECTA.xml' path='doc/member[@name="GROUP_POLICY_OBJECTA.dwOptions"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOptions;

    /// <include file='GROUP_POLICY_OBJECTA.xml' path='doc/member[@name="GROUP_POLICY_OBJECTA.dwVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVersion;

    /// <include file='GROUP_POLICY_OBJECTA.xml' path='doc/member[@name="GROUP_POLICY_OBJECTA.lpDSPath"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* lpDSPath;

    /// <include file='GROUP_POLICY_OBJECTA.xml' path='doc/member[@name="GROUP_POLICY_OBJECTA.lpFileSysPath"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* lpFileSysPath;

    /// <include file='GROUP_POLICY_OBJECTA.xml' path='doc/member[@name="GROUP_POLICY_OBJECTA.lpDisplayName"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* lpDisplayName;

    /// <include file='GROUP_POLICY_OBJECTA.xml' path='doc/member[@name="GROUP_POLICY_OBJECTA.szGPOName"]/*' />
    [NativeTypeName("CHAR[50]")]
    public _szGPOName_e__FixedBuffer szGPOName;

    /// <include file='GROUP_POLICY_OBJECTA.xml' path='doc/member[@name="GROUP_POLICY_OBJECTA.GPOLink"]/*' />
    public GPO_LINK GPOLink;

    /// <include file='GROUP_POLICY_OBJECTA.xml' path='doc/member[@name="GROUP_POLICY_OBJECTA.lParam"]/*' />
    public LPARAM lParam;

    /// <include file='GROUP_POLICY_OBJECTA.xml' path='doc/member[@name="GROUP_POLICY_OBJECTA.pNext"]/*' />
    [NativeTypeName("struct _GROUP_POLICY_OBJECTA *")]
    public GROUP_POLICY_OBJECTA* pNext;

    /// <include file='GROUP_POLICY_OBJECTA.xml' path='doc/member[@name="GROUP_POLICY_OBJECTA.pPrev"]/*' />
    [NativeTypeName("struct _GROUP_POLICY_OBJECTA *")]
    public GROUP_POLICY_OBJECTA* pPrev;

    /// <include file='GROUP_POLICY_OBJECTA.xml' path='doc/member[@name="GROUP_POLICY_OBJECTA.lpExtensions"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* lpExtensions;

    /// <include file='GROUP_POLICY_OBJECTA.xml' path='doc/member[@name="GROUP_POLICY_OBJECTA.lParam2"]/*' />
    public LPARAM lParam2;

    /// <include file='GROUP_POLICY_OBJECTA.xml' path='doc/member[@name="GROUP_POLICY_OBJECTA.lpLink"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* lpLink;

    /// <include file='_szGPOName_e__FixedBuffer.xml' path='doc/member[@name="_szGPOName_e__FixedBuffer"]/*' />
    [InlineArray(50)]
    public partial struct _szGPOName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
