// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ksmedia.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct KSJACK_SINK_INFORMATION
{
    public KSJACK_SINK_CONNECTIONTYPE ConnType;

    [NativeTypeName("WORD")]
    public ushort ManufacturerId;

    [NativeTypeName("WORD")]
    public ushort ProductId;

    [NativeTypeName("WORD")]
    public ushort AudioLatency;

    public BOOL HDCPCapable;

    public BOOL AICapable;

    [NativeTypeName("UCHAR")]
    public byte SinkDescriptionLength;

    [NativeTypeName("WCHAR [32]")]
    public fixed ushort SinkDescription[32];

    public LUID PortId;
}
