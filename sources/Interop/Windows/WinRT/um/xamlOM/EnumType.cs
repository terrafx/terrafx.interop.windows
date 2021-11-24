// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT;

[SupportedOSPlatform("windows10.0")]
public unsafe partial struct EnumType
{
    [NativeTypeName("BSTR")]
    public ushort* Name;

    public SAFEARRAY* ValueInts;

    public SAFEARRAY* ValueStrings;
}
