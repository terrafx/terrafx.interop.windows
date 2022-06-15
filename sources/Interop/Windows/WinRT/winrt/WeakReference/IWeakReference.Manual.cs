// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/WeakReference.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.WinRT;

public unsafe partial struct IWeakReference
{
    public int Resolve<T>(T** objectReference)
        where T : unmanaged, IInspectable.Interface
    {
        return Resolve(__uuidof<T>(), (IInspectable**)objectReference);
    }
}
