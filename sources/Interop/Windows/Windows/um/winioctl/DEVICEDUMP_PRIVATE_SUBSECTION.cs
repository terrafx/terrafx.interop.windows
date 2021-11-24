// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct DEVICEDUMP_PRIVATE_SUBSECTION
{
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    public GP_LOG_PAGE_DESCRIPTOR GPLogId;

    [NativeTypeName("BYTE [1]")]
    public fixed byte bData[1];
}
