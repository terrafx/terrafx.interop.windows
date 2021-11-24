// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public unsafe partial struct POWERBROADCAST_SETTING
{
    public Guid PowerSetting;

    [NativeTypeName("DWORD")]
    public uint DataLength;

    [NativeTypeName("UCHAR [1]")]
    public fixed byte Data[1];
}
