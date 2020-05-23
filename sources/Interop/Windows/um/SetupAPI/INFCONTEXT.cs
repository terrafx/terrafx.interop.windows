// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct INFCONTEXT
    {
        [NativeTypeName("PVOID")]
        public void* Inf;

        [NativeTypeName("PVOID")]
        public void* CurrentInf;

        [NativeTypeName("UINT")]
        public uint Section;

        [NativeTypeName("UINT")]
        public uint Line;
    }
}
