// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows8.0")]
    public unsafe partial struct CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE
    {
        [NativeTypeName("PVOID")]
        public void* pValue;

        [NativeTypeName("DWORD")]
        public uint ValueLength;
    }
}
