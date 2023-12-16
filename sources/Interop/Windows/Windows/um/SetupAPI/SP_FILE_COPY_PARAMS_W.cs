// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SP_FILE_COPY_PARAMS_W.xml' path='doc/member[@name="SP_FILE_COPY_PARAMS_W"]/*' />
public unsafe partial struct SP_FILE_COPY_PARAMS_W
{
    /// <include file='SP_FILE_COPY_PARAMS_W.xml' path='doc/member[@name="SP_FILE_COPY_PARAMS_W.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SP_FILE_COPY_PARAMS_W.xml' path='doc/member[@name="SP_FILE_COPY_PARAMS_W.QueueHandle"]/*' />
    public HSPFILEQ QueueHandle;

    /// <include file='SP_FILE_COPY_PARAMS_W.xml' path='doc/member[@name="SP_FILE_COPY_PARAMS_W.SourceRootPath"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* SourceRootPath;

    /// <include file='SP_FILE_COPY_PARAMS_W.xml' path='doc/member[@name="SP_FILE_COPY_PARAMS_W.SourcePath"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* SourcePath;

    /// <include file='SP_FILE_COPY_PARAMS_W.xml' path='doc/member[@name="SP_FILE_COPY_PARAMS_W.SourceFilename"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* SourceFilename;

    /// <include file='SP_FILE_COPY_PARAMS_W.xml' path='doc/member[@name="SP_FILE_COPY_PARAMS_W.SourceDescription"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* SourceDescription;

    /// <include file='SP_FILE_COPY_PARAMS_W.xml' path='doc/member[@name="SP_FILE_COPY_PARAMS_W.SourceTagfile"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* SourceTagfile;

    /// <include file='SP_FILE_COPY_PARAMS_W.xml' path='doc/member[@name="SP_FILE_COPY_PARAMS_W.TargetDirectory"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* TargetDirectory;

    /// <include file='SP_FILE_COPY_PARAMS_W.xml' path='doc/member[@name="SP_FILE_COPY_PARAMS_W.TargetFilename"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* TargetFilename;

    /// <include file='SP_FILE_COPY_PARAMS_W.xml' path='doc/member[@name="SP_FILE_COPY_PARAMS_W.CopyStyle"]/*' />
    [NativeTypeName("DWORD")]
    public uint CopyStyle;

    /// <include file='SP_FILE_COPY_PARAMS_W.xml' path='doc/member[@name="SP_FILE_COPY_PARAMS_W.LayoutInf"]/*' />
    public HINF LayoutInf;

    /// <include file='SP_FILE_COPY_PARAMS_W.xml' path='doc/member[@name="SP_FILE_COPY_PARAMS_W.SecurityDescriptor"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* SecurityDescriptor;
}
