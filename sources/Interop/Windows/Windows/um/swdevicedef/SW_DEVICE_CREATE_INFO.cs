// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/swdevicedef.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='SW_DEVICE_CREATE_INFO.xml' path='doc/member[@name="SW_DEVICE_CREATE_INFO"]/*' />
public unsafe partial struct SW_DEVICE_CREATE_INFO
{
    /// <include file='SW_DEVICE_CREATE_INFO.xml' path='doc/member[@name="SW_DEVICE_CREATE_INFO.cbSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint cbSize;

    /// <include file='SW_DEVICE_CREATE_INFO.xml' path='doc/member[@name="SW_DEVICE_CREATE_INFO.pszInstanceId"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* pszInstanceId;

    /// <include file='SW_DEVICE_CREATE_INFO.xml' path='doc/member[@name="SW_DEVICE_CREATE_INFO.pszzHardwareIds"]/*' />
    [NativeTypeName("PCZZWSTR")]
    public char* pszzHardwareIds;

    /// <include file='SW_DEVICE_CREATE_INFO.xml' path='doc/member[@name="SW_DEVICE_CREATE_INFO.pszzCompatibleIds"]/*' />
    [NativeTypeName("PCZZWSTR")]
    public char* pszzCompatibleIds;

    /// <include file='SW_DEVICE_CREATE_INFO.xml' path='doc/member[@name="SW_DEVICE_CREATE_INFO.pContainerId"]/*' />
    [NativeTypeName("const GUID *")]
    public Guid* pContainerId;

    /// <include file='SW_DEVICE_CREATE_INFO.xml' path='doc/member[@name="SW_DEVICE_CREATE_INFO.CapabilityFlags"]/*' />
    [NativeTypeName("ULONG")]
    public uint CapabilityFlags;

    /// <include file='SW_DEVICE_CREATE_INFO.xml' path='doc/member[@name="SW_DEVICE_CREATE_INFO.pszDeviceDescription"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* pszDeviceDescription;

    /// <include file='SW_DEVICE_CREATE_INFO.xml' path='doc/member[@name="SW_DEVICE_CREATE_INFO.pszDeviceLocation"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* pszDeviceLocation;

    /// <include file='SW_DEVICE_CREATE_INFO.xml' path='doc/member[@name="SW_DEVICE_CREATE_INFO.pSecurityDescriptor"]/*' />
    [NativeTypeName("const SECURITY_DESCRIPTOR *")]
    public SECURITY_DESCRIPTOR* pSecurityDescriptor;
}
