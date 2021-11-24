// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct CSV_QUERY_VETO_FILE_DIRECT_IO_OUTPUT
{
    [NativeTypeName("DWORDLONG")]
    public ulong VetoedFromAltitudeIntegral;

    [NativeTypeName("DWORDLONG")]
    public ulong VetoedFromAltitudeDecimal;

    [NativeTypeName("WCHAR [256]")]
    public fixed ushort Reason[256];
}
