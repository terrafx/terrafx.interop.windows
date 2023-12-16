// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.Direct3DCreate9"]/*' />
    [DllImport("d3d9", ExactSpelling = true)]
    public static extern IDirect3D9* Direct3DCreate9(uint SDKVersion);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DPERF_BeginEvent"]/*' />
    [DllImport("d3d9", ExactSpelling = true)]
    public static extern int D3DPERF_BeginEvent([NativeTypeName("D3DCOLOR")] uint col, [NativeTypeName("LPCWSTR")] char* wszName);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DPERF_EndEvent"]/*' />
    [DllImport("d3d9", ExactSpelling = true)]
    public static extern int D3DPERF_EndEvent();

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DPERF_SetMarker"]/*' />
    [DllImport("d3d9", ExactSpelling = true)]
    public static extern void D3DPERF_SetMarker([NativeTypeName("D3DCOLOR")] uint col, [NativeTypeName("LPCWSTR")] char* wszName);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DPERF_SetRegion"]/*' />
    [DllImport("d3d9", ExactSpelling = true)]
    public static extern void D3DPERF_SetRegion([NativeTypeName("D3DCOLOR")] uint col, [NativeTypeName("LPCWSTR")] char* wszName);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DPERF_QueryRepeatFrame"]/*' />
    [DllImport("d3d9", ExactSpelling = true)]
    public static extern BOOL D3DPERF_QueryRepeatFrame();

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DPERF_SetOptions"]/*' />
    [DllImport("d3d9", ExactSpelling = true)]
    public static extern void D3DPERF_SetOptions([NativeTypeName("DWORD")] uint dwOptions);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DPERF_GetStatus"]/*' />
    [DllImport("d3d9", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint D3DPERF_GetStatus();

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.Direct3DCreate9Ex"]/*' />
    [DllImport("d3d9", ExactSpelling = true)]
    public static extern HRESULT Direct3DCreate9Ex(uint SDKVersion, IDirect3D9Ex** param1);

    [NativeTypeName("#define DIRECT3D_VERSION 0x0900")]
    public const int DIRECT3D_VERSION = 0x0900;

    [NativeTypeName("#define D3D9b_SDK_VERSION 31")]
    public const int D3D9b_SDK_VERSION = 31;

    [NativeTypeName("#define D3DSPD_IUNKNOWN 0x00000001L")]
    public const int D3DSPD_IUNKNOWN = 0x00000001;

    [NativeTypeName("#define D3DADAPTER_DEFAULT 0")]
    public const int D3DADAPTER_DEFAULT = 0;

    [NativeTypeName("#define _FACD3D 0x876")]
    public const int _FACD3D = 0x876;
}
