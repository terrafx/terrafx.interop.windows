// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows8.0")]
public enum MF2DBuffer_LockFlags
{
    MF2DBuffer_LockFlags_LockTypeMask = ((0x1 | 0x2) | 0x3),
    MF2DBuffer_LockFlags_Read = 0x1,
    MF2DBuffer_LockFlags_Write = 0x2,
    MF2DBuffer_LockFlags_ReadWrite = 0x3,
    MF2DBuffer_LockFlags_ForceDWORD = 0x7fffffff,
}
