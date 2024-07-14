// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Gdiplus;

/// <include file='ImageCodecInfo.xml' path='doc/member[@name="ImageCodecInfo"]/*' />
public unsafe partial struct ImageCodecInfo
{
    /// <include file='ImageCodecInfo.xml' path='doc/member[@name="ImageCodecInfo.Clsid"]/*' />
    [NativeTypeName("CLSID")]
    public Guid Clsid;

    /// <include file='ImageCodecInfo.xml' path='doc/member[@name="ImageCodecInfo.FormatID"]/*' />
    public Guid FormatID;

    /// <include file='ImageCodecInfo.xml' path='doc/member[@name="ImageCodecInfo.CodecName"]/*' />
    [NativeTypeName("const WCHAR *")]
    public char* CodecName;

    /// <include file='ImageCodecInfo.xml' path='doc/member[@name="ImageCodecInfo.DllName"]/*' />
    [NativeTypeName("const WCHAR *")]
    public char* DllName;

    /// <include file='ImageCodecInfo.xml' path='doc/member[@name="ImageCodecInfo.FormatDescription"]/*' />
    [NativeTypeName("const WCHAR *")]
    public char* FormatDescription;

    /// <include file='ImageCodecInfo.xml' path='doc/member[@name="ImageCodecInfo.FilenameExtension"]/*' />
    [NativeTypeName("const WCHAR *")]
    public char* FilenameExtension;

    /// <include file='ImageCodecInfo.xml' path='doc/member[@name="ImageCodecInfo.MimeType"]/*' />
    [NativeTypeName("const WCHAR *")]
    public char* MimeType;

    /// <include file='ImageCodecInfo.xml' path='doc/member[@name="ImageCodecInfo.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='ImageCodecInfo.xml' path='doc/member[@name="ImageCodecInfo.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='ImageCodecInfo.xml' path='doc/member[@name="ImageCodecInfo.SigCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint SigCount;

    /// <include file='ImageCodecInfo.xml' path='doc/member[@name="ImageCodecInfo.SigSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint SigSize;

    /// <include file='ImageCodecInfo.xml' path='doc/member[@name="ImageCodecInfo.SigPattern"]/*' />
    [NativeTypeName("const BYTE *")]
    public byte* SigPattern;

    /// <include file='ImageCodecInfo.xml' path='doc/member[@name="ImageCodecInfo.SigMask"]/*' />
    [NativeTypeName("const BYTE *")]
    public byte* SigMask;
}
