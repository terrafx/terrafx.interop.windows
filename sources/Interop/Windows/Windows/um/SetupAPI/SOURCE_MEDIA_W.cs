// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SOURCE_MEDIA_W.xml' path='doc/member[@name="SOURCE_MEDIA_W"]/*' />
public unsafe partial struct SOURCE_MEDIA_W
{
    /// <include file='SOURCE_MEDIA_W.xml' path='doc/member[@name="SOURCE_MEDIA_W.Reserved"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* Reserved;

    /// <include file='SOURCE_MEDIA_W.xml' path='doc/member[@name="SOURCE_MEDIA_W.Tagfile"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* Tagfile;

    /// <include file='SOURCE_MEDIA_W.xml' path='doc/member[@name="SOURCE_MEDIA_W.Description"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* Description;

    /// <include file='SOURCE_MEDIA_W.xml' path='doc/member[@name="SOURCE_MEDIA_W.SourcePath"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* SourcePath;

    /// <include file='SOURCE_MEDIA_W.xml' path='doc/member[@name="SOURCE_MEDIA_W.SourceFile"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* SourceFile;

    /// <include file='SOURCE_MEDIA_W.xml' path='doc/member[@name="SOURCE_MEDIA_W.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;
}
