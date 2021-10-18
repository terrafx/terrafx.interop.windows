// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct IP_ADAPTER_DNS_SUFFIX
    {
        [NativeTypeName("struct _IP_ADAPTER_DNS_SUFFIX *")]
        public IP_ADAPTER_DNS_SUFFIX* Next;

        [NativeTypeName("WCHAR [256]")]
        public fixed ushort String[256];
    }
}
