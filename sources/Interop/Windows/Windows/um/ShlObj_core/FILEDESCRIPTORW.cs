// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct FILEDESCRIPTORW
{
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("CLSID")]
    public Guid clsid;

    [NativeTypeName("SIZEL")]
    public SIZE sizel;

    public POINTL pointl;

    [NativeTypeName("DWORD")]
    public uint dwFileAttributes;

    public FILETIME ftCreationTime;

    public FILETIME ftLastAccessTime;

    public FILETIME ftLastWriteTime;

    [NativeTypeName("DWORD")]
    public uint nFileSizeHigh;

    [NativeTypeName("DWORD")]
    public uint nFileSizeLow;

    [NativeTypeName("WCHAR [260]")]
    public fixed ushort cFileName[260];
}
