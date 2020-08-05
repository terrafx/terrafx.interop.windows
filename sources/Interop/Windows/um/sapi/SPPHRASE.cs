// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    [NativeTypeName("struct SPPHRASE : SPPHRASE_53")]
    public partial struct SPPHRASE
    {
        public SPPHRASE_53 __AnonymousBase_sapi_L5576_C34;

        public SPSEMANTICFORMAT SemanticTagFormat;
    }
}
