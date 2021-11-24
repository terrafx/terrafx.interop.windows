// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mssip.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public partial struct MS_ADDINFO_CATALOGMEMBER
{
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    [NativeTypeName("struct CRYPTCATSTORE_ *")]
    public IntPtr pStore;

    [NativeTypeName("struct CRYPTCATMEMBER_ *")]
    public IntPtr pMember;
}
