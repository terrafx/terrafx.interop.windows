// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum STORAGE_PORT_CODE_SET
{
    StoragePortCodeSetReserved = 0,
    StoragePortCodeSetStorport = 1,
    StoragePortCodeSetSCSIport = 2,
    StoragePortCodeSetSpaceport = 3,
    StoragePortCodeSetATAport = 4,
    StoragePortCodeSetUSBport = 5,
    StoragePortCodeSetSBP2port = 6,
    StoragePortCodeSetSDport = 7,
}
