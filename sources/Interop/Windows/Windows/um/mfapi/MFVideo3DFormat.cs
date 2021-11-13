// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows8.0")]
    public enum MFVideo3DFormat
    {
        MFVideo3DSampleFormat_BaseView = 0,
        MFVideo3DSampleFormat_MultiView = 1,
        MFVideo3DSampleFormat_Packed_LeftRight = 2,
        MFVideo3DSampleFormat_Packed_TopBottom = 3,
    }
}
