// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct WS_UNIQUE_ID_DESCRIPTION
    {
        [NativeTypeName("ULONG")]
        public uint minCharCount;

        [NativeTypeName("ULONG")]
        public uint maxCharCount;
    }
}
