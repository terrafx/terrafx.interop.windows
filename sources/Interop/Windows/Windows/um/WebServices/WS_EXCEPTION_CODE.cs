// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum WS_EXCEPTION_CODE
    {
        WS_EXCEPTION_CODE_USAGE_FAILURE = unchecked((int)(0xC03D0000)),
        WS_EXCEPTION_CODE_INTERNAL_FAILURE = unchecked((int)(0xc03d0001)),
    }
}
