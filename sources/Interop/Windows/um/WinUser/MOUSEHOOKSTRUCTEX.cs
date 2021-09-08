// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [NativeTypeName("struct tagMOUSEHOOKSTRUCTEX : tagMOUSEHOOKSTRUCT")]
    [NativeInheritance("tagMOUSEHOOKSTRUCT")]
    public partial struct MOUSEHOOKSTRUCTEX
    {
        public MOUSEHOOKSTRUCT Base;

        [NativeTypeName("DWORD")]
        public uint mouseData;
    }
}
