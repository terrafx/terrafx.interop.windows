// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SP_REGISTER_CONTROL_STATUSA.xml' path='doc/member[@name="SP_REGISTER_CONTROL_STATUSA"]/*' />
public unsafe partial struct SP_REGISTER_CONTROL_STATUSA
{
    /// <include file='SP_REGISTER_CONTROL_STATUSA.xml' path='doc/member[@name="SP_REGISTER_CONTROL_STATUSA.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SP_REGISTER_CONTROL_STATUSA.xml' path='doc/member[@name="SP_REGISTER_CONTROL_STATUSA.FileName"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* FileName;

    /// <include file='SP_REGISTER_CONTROL_STATUSA.xml' path='doc/member[@name="SP_REGISTER_CONTROL_STATUSA.Win32Error"]/*' />
    [NativeTypeName("DWORD")]
    public uint Win32Error;

    /// <include file='SP_REGISTER_CONTROL_STATUSA.xml' path='doc/member[@name="SP_REGISTER_CONTROL_STATUSA.FailureCode"]/*' />
    [NativeTypeName("DWORD")]
    public uint FailureCode;
}
