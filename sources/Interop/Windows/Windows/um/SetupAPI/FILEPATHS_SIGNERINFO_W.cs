// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='FILEPATHS_SIGNERINFO_W.xml' path='doc/member[@name="FILEPATHS_SIGNERINFO_W"]/*' />
public unsafe partial struct FILEPATHS_SIGNERINFO_W
{
    /// <include file='FILEPATHS_SIGNERINFO_W.xml' path='doc/member[@name="FILEPATHS_SIGNERINFO_W.Target"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* Target;

    /// <include file='FILEPATHS_SIGNERINFO_W.xml' path='doc/member[@name="FILEPATHS_SIGNERINFO_W.Source"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* Source;

    /// <include file='FILEPATHS_SIGNERINFO_W.xml' path='doc/member[@name="FILEPATHS_SIGNERINFO_W.Win32Error"]/*' />
    public uint Win32Error;

    /// <include file='FILEPATHS_SIGNERINFO_W.xml' path='doc/member[@name="FILEPATHS_SIGNERINFO_W.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='FILEPATHS_SIGNERINFO_W.xml' path='doc/member[@name="FILEPATHS_SIGNERINFO_W.DigitalSigner"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* DigitalSigner;

    /// <include file='FILEPATHS_SIGNERINFO_W.xml' path='doc/member[@name="FILEPATHS_SIGNERINFO_W.Version"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* Version;

    /// <include file='FILEPATHS_SIGNERINFO_W.xml' path='doc/member[@name="FILEPATHS_SIGNERINFO_W.CatalogFile"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* CatalogFile;
}
