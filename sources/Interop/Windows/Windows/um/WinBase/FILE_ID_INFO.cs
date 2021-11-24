// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct FILE_ID_INFO
{
    [NativeTypeName("ULONGLONG")]
    public ulong VolumeSerialNumber;

    public FILE_ID_128 FileId;
}
