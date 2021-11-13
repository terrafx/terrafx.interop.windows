// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows8.1")]
    public enum MF_MSE_ERROR
    {
        MF_MSE_ERROR_NOERROR = 0,
        MF_MSE_ERROR_NETWORK = 1,
        MF_MSE_ERROR_DECODE = 2,
        MF_MSE_ERROR_UNKNOWN_ERROR = 3,
    }
}
