// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct WS_XML_UINT64_TEXT
    {
        public WS_XML_TEXT text;

        [NativeTypeName("unsigned long long")]
        public ulong value;
    }
}
