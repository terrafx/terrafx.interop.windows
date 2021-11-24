// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mediaobj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct DMO_OUTPUT_DATA_BUFFER
{
    public IMediaBuffer* pBuffer;

    [NativeTypeName("DWORD")]
    public uint dwStatus;

    [NativeTypeName("REFERENCE_TIME")]
    public long rtTimestamp;

    [NativeTypeName("REFERENCE_TIME")]
    public long rtTimelength;
}
