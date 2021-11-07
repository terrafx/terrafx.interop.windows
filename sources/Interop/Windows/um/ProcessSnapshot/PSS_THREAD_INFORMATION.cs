// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.1")]
    public partial struct PSS_THREAD_INFORMATION
    {
        [NativeTypeName("DWORD")]
        public uint ThreadsCaptured;

        [NativeTypeName("DWORD")]
        public uint ContextLength;
    }
}
