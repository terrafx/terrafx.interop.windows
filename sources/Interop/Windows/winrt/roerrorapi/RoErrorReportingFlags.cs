// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/roerrorapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using static TerraFX.Interop.RO_ERROR_REPORTING_FLAGS;

namespace TerraFX.Interop
{
    [Flags]
    public enum RoErrorReportingFlags
    {
        None = RO_ERROR_REPORTING_NONE,
        SuppressExceptions = RO_ERROR_REPORTING_SUPPRESSEXCEPTIONS,
        ForceExceptions = RO_ERROR_REPORTING_FORCEEXCEPTIONS,
        UseSetErrorInfo = RO_ERROR_REPORTING_USESETERRORINFO,
        SuppressSetErrorInfo = RO_ERROR_REPORTING_SUPPRESSSETERRORINFO,
    }
}
