// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct CSV_QUERY_VOLUME_REDIRECT_STATE
{
    [NativeTypeName("DWORD")]
    public uint MdsNodeId;

    [NativeTypeName("DWORD")]
    public uint DsNodeId;

    [NativeTypeName("BOOLEAN")]
    public byte IsDiskConnected;

    [NativeTypeName("BOOLEAN")]
    public byte ClusterEnableDirectIo;

    public CSVFS_DISK_CONNECTIVITY DiskConnectivity;
}
