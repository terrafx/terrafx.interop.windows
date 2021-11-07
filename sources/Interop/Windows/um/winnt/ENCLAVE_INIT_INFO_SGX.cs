// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows10.0")]
    public unsafe partial struct ENCLAVE_INIT_INFO_SGX
    {
        [NativeTypeName("BYTE [1808]")]
        public fixed byte SigStruct[1808];

        [NativeTypeName("BYTE [240]")]
        public fixed byte Reserved1[240];

        [NativeTypeName("BYTE [304]")]
        public fixed byte EInitToken[304];

        [NativeTypeName("BYTE [1744]")]
        public fixed byte Reserved2[1744];
    }
}
