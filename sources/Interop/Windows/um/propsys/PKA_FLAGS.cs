// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum PKA_FLAGS
    {
        PKA_SET = 0,
        PKA_APPEND = (PKA_SET + 1),
        PKA_DELETE = (PKA_APPEND + 1),
    }
}
