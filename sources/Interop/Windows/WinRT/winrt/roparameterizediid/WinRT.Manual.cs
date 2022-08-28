// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/roparameterizediid.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

public static unsafe partial class WinRT
{
    public static _Locator Locator(delegate*<ushort*, IRoSimpleMetaDataBuilder*, int> fn)
    {
        return new _Locator(fn);
    }
}
