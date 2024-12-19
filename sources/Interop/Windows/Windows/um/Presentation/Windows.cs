// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreatePresentationFactory"]/*' />
    [DllImport("", ExactSpelling = true)]
    public static extern HRESULT CreatePresentationFactory(IUnknown* d3dDevice, [NativeTypeName("const IID &")] Guid* riid, void** presentationFactory);
}
