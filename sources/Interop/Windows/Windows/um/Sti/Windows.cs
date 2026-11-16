// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Sti.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StiCreateInstanceW"]/*' />
    [DllImport("sti", ExactSpelling = true)]
    public static extern HRESULT StiCreateInstanceW(HINSTANCE hinst, [NativeTypeName("DWORD")] uint dwVer, [NativeTypeName("struct IStillImageW **")] IStillImageW** ppSti, [NativeTypeName("LPUNKNOWN")] IUnknown* punkOuter);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STIEDFL_ALLDEVICES"]/*' />
    [NativeTypeName("#define STIEDFL_ALLDEVICES 0x00000000")]
    public const int STIEDFL_ALLDEVICES = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STIEDFL_ATTACHEDONLY"]/*' />
    [NativeTypeName("#define STIEDFL_ATTACHEDONLY 0x00000001")]
    public const int STIEDFL_ATTACHEDONLY = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StiCreateInstance"]/*' />
    [NativeTypeName("#define StiCreateInstance StiCreateInstanceW")]
    public static delegate*<HINSTANCE, uint, IStillImageW**, IUnknown*, HRESULT> StiCreateInstance => &StiCreateInstanceW;
}
