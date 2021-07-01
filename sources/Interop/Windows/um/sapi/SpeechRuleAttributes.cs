// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.SPCFGRULEATTRIBUTES;

namespace TerraFX.Interop
{
    public enum SpeechRuleAttributes
    {
        SRATopLevel = SPRAF_TopLevel,
        SRADefaultToActive = SPRAF_Active,
        SRAExport = SPRAF_Export,
        SRAImport = SPRAF_Import,
        SRAInterpreter = SPRAF_Interpreter,
        SRADynamic = SPRAF_Dynamic,
        SRARoot = SPRAF_Root,
    }
}
