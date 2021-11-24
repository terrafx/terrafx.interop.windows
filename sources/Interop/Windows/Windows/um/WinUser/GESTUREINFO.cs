// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct GESTUREINFO
{
    public uint cbSize;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("DWORD")]
    public uint dwID;

    public HWND hwndTarget;

    public POINTS ptsLocation;

    [NativeTypeName("DWORD")]
    public uint dwInstanceID;

    [NativeTypeName("DWORD")]
    public uint dwSequenceID;

    [NativeTypeName("ULONGLONG")]
    public ulong ullArguments;

    public uint cbExtraArgs;
}
