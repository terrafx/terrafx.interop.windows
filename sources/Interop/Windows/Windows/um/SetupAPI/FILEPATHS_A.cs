// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='FILEPATHS_A.xml' path='doc/member[@name="FILEPATHS_A"]/*' />
public unsafe partial struct FILEPATHS_A
{
    /// <include file='FILEPATHS_A.xml' path='doc/member[@name="FILEPATHS_A.Target"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* Target;

    /// <include file='FILEPATHS_A.xml' path='doc/member[@name="FILEPATHS_A.Source"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* Source;

    /// <include file='FILEPATHS_A.xml' path='doc/member[@name="FILEPATHS_A.Win32Error"]/*' />
    public uint Win32Error;

    /// <include file='FILEPATHS_A.xml' path='doc/member[@name="FILEPATHS_A.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;
}
