// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum IMAGEHLP_EXTENDED_OPTIONS
{
    SYMOPT_EX_DISABLEACCESSTIMEUPDATE,
    SYMOPT_EX_LASTVALIDDEBUGDIRECTORY,
    SYMOPT_EX_NOIMPLICITPATTERNSEARCH,
    SYMOPT_EX_NEVERLOADSYMBOLS,
    SYMOPT_EX_MAX,
}
