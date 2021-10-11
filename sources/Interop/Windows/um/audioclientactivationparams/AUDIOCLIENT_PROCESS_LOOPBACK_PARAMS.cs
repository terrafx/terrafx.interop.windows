// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/audioclientactivationparams.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct AUDIOCLIENT_PROCESS_LOOPBACK_PARAMS
    {
        [NativeTypeName("DWORD")]
        public uint TargetProcessId;

        public PROCESS_LOOPBACK_MODE ProcessLoopbackMode;
    }
}
