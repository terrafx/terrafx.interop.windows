// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum TAPE_DRIVE_PROBLEM_TYPE
    {
        TapeDriveProblemNone,
        TapeDriveReadWriteWarning,
        TapeDriveReadWriteError,
        TapeDriveReadWarning,
        TapeDriveWriteWarning,
        TapeDriveReadError,
        TapeDriveWriteError,
        TapeDriveHardwareError,
        TapeDriveUnsupportedMedia,
        TapeDriveScsiConnectionError,
        TapeDriveTimetoClean,
        TapeDriveCleanDriveNow,
        TapeDriveMediaLifeExpired,
        TapeDriveSnappedTape,
    }
}
