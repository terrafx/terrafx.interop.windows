// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct CompileStatusInfo
    {
        [NativeTypeName("long")]
        public int lPhaseError;

        [NativeTypeName("HRESULT")]
        public int hRes;

        [NativeTypeName("long")]
        public int ObjectNum;

        [NativeTypeName("long")]
        public int FirstLine;

        [NativeTypeName("long")]
        public int LastLine;

        [NativeTypeName("DWORD")]
        public uint dwOutFlags;
    }
}
