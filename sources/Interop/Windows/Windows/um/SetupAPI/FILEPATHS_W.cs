// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='FILEPATHS_W.xml' path='doc/member[@name="FILEPATHS_W"]/*' />
public unsafe partial struct FILEPATHS_W
{
    /// <include file='FILEPATHS_W.xml' path='doc/member[@name="FILEPATHS_W.Target"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* Target;

    /// <include file='FILEPATHS_W.xml' path='doc/member[@name="FILEPATHS_W.Source"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* Source;

    /// <include file='FILEPATHS_W.xml' path='doc/member[@name="FILEPATHS_W.Win32Error"]/*' />
    public uint Win32Error;

    /// <include file='FILEPATHS_W.xml' path='doc/member[@name="FILEPATHS_W.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;
}
