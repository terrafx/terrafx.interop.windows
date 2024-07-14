// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SOURCE_MEDIA_A.xml' path='doc/member[@name="SOURCE_MEDIA_A"]/*' />
public unsafe partial struct SOURCE_MEDIA_A
{
    /// <include file='SOURCE_MEDIA_A.xml' path='doc/member[@name="SOURCE_MEDIA_A.Reserved"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* Reserved;

    /// <include file='SOURCE_MEDIA_A.xml' path='doc/member[@name="SOURCE_MEDIA_A.Tagfile"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* Tagfile;

    /// <include file='SOURCE_MEDIA_A.xml' path='doc/member[@name="SOURCE_MEDIA_A.Description"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* Description;

    /// <include file='SOURCE_MEDIA_A.xml' path='doc/member[@name="SOURCE_MEDIA_A.SourcePath"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* SourcePath;

    /// <include file='SOURCE_MEDIA_A.xml' path='doc/member[@name="SOURCE_MEDIA_A.SourceFile"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* SourceFile;

    /// <include file='SOURCE_MEDIA_A.xml' path='doc/member[@name="SOURCE_MEDIA_A.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;
}
