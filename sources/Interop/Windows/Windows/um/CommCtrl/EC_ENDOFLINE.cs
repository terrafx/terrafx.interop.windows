// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows10.0.17763.0")]
    public enum EC_ENDOFLINE
    {
        EC_ENDOFLINE_DETECTFROMCONTENT = 0,
        EC_ENDOFLINE_CRLF = 1,
        EC_ENDOFLINE_CR = 2,
        EC_ENDOFLINE_LF = 3,
    }
}
