// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SP_FILE_COPY_PARAMS_A.xml' path='doc/member[@name="SP_FILE_COPY_PARAMS_A"]/*' />
public unsafe partial struct SP_FILE_COPY_PARAMS_A
{
    /// <include file='SP_FILE_COPY_PARAMS_A.xml' path='doc/member[@name="SP_FILE_COPY_PARAMS_A.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SP_FILE_COPY_PARAMS_A.xml' path='doc/member[@name="SP_FILE_COPY_PARAMS_A.QueueHandle"]/*' />
    public HSPFILEQ QueueHandle;

    /// <include file='SP_FILE_COPY_PARAMS_A.xml' path='doc/member[@name="SP_FILE_COPY_PARAMS_A.SourceRootPath"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* SourceRootPath;

    /// <include file='SP_FILE_COPY_PARAMS_A.xml' path='doc/member[@name="SP_FILE_COPY_PARAMS_A.SourcePath"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* SourcePath;

    /// <include file='SP_FILE_COPY_PARAMS_A.xml' path='doc/member[@name="SP_FILE_COPY_PARAMS_A.SourceFilename"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* SourceFilename;

    /// <include file='SP_FILE_COPY_PARAMS_A.xml' path='doc/member[@name="SP_FILE_COPY_PARAMS_A.SourceDescription"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* SourceDescription;

    /// <include file='SP_FILE_COPY_PARAMS_A.xml' path='doc/member[@name="SP_FILE_COPY_PARAMS_A.SourceTagfile"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* SourceTagfile;

    /// <include file='SP_FILE_COPY_PARAMS_A.xml' path='doc/member[@name="SP_FILE_COPY_PARAMS_A.TargetDirectory"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* TargetDirectory;

    /// <include file='SP_FILE_COPY_PARAMS_A.xml' path='doc/member[@name="SP_FILE_COPY_PARAMS_A.TargetFilename"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* TargetFilename;

    /// <include file='SP_FILE_COPY_PARAMS_A.xml' path='doc/member[@name="SP_FILE_COPY_PARAMS_A.CopyStyle"]/*' />
    [NativeTypeName("DWORD")]
    public uint CopyStyle;

    /// <include file='SP_FILE_COPY_PARAMS_A.xml' path='doc/member[@name="SP_FILE_COPY_PARAMS_A.LayoutInf"]/*' />
    public HINF LayoutInf;

    /// <include file='SP_FILE_COPY_PARAMS_A.xml' path='doc/member[@name="SP_FILE_COPY_PARAMS_A.SecurityDescriptor"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* SecurityDescriptor;
}
