// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct SCM_PD_RUNTIME_FW_ACTIVATION_INFO
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        public SCM_PD_LAST_FW_ACTIVATION_STATUS LastFirmwareActivationStatus;

        public SCM_PD_FIRMWARE_ACTIVATION_STATE FirmwareActivationState;
    }
}
