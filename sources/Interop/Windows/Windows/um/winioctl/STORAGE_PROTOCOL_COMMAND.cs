// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows10.0")]
public unsafe partial struct STORAGE_PROTOCOL_COMMAND
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Length;

    public STORAGE_PROTOCOL_TYPE ProtocolType;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORD")]
    public uint ReturnStatus;

    [NativeTypeName("DWORD")]
    public uint ErrorCode;

    [NativeTypeName("DWORD")]
    public uint CommandLength;

    [NativeTypeName("DWORD")]
    public uint ErrorInfoLength;

    [NativeTypeName("DWORD")]
    public uint DataToDeviceTransferLength;

    [NativeTypeName("DWORD")]
    public uint DataFromDeviceTransferLength;

    [NativeTypeName("DWORD")]
    public uint TimeOutValue;

    [NativeTypeName("DWORD")]
    public uint ErrorInfoOffset;

    [NativeTypeName("DWORD")]
    public uint DataToDeviceBufferOffset;

    [NativeTypeName("DWORD")]
    public uint DataFromDeviceBufferOffset;

    [NativeTypeName("DWORD")]
    public uint CommandSpecific;

    [NativeTypeName("DWORD")]
    public uint Reserved0;

    [NativeTypeName("DWORD")]
    public uint FixedProtocolReturnData;

    [NativeTypeName("DWORD [3]")]
    public fixed uint Reserved1[3];

    [NativeTypeName("BYTE [1]")]
    public fixed byte Command[1];
}
