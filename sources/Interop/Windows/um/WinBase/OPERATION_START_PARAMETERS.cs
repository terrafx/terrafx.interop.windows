// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.0")]
    public partial struct OPERATION_START_PARAMETERS
    {
        [NativeTypeName("ULONG")]
        public uint Version;

        [NativeTypeName("OPERATION_ID")]
        public uint OperationId;

        [NativeTypeName("ULONG")]
        public uint Flags;
    }
}
