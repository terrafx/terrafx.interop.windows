// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct WS_PARAMETER_DESCRIPTION
    {
        public WS_PARAMETER_TYPE parameterType;

        [NativeTypeName("USHORT")]
        public ushort inputMessageIndex;

        [NativeTypeName("USHORT")]
        public ushort outputMessageIndex;
    }
}
