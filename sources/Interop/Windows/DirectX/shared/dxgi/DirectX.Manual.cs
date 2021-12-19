// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.DirectX;

public static unsafe partial class DirectX
{
    public static HRESULT D3D_SET_OBJECT_NAME_N_A<TDXGIObject>(TDXGIObject* pObject, uint Chars, sbyte* pName)
        where TDXGIObject : unmanaged, IDXGIObject.Interface
    {
        var guid = WKPDID_D3DDebugObjectName;
        return pObject->SetPrivateData(&guid, Chars, pName);
    }

    public static HRESULT D3D_SET_OBJECT_NAME_A<TDXGIObject>(TDXGIObject* pObject, sbyte* pName)
        where TDXGIObject : unmanaged, IDXGIObject.Interface
    {
        return D3D_SET_OBJECT_NAME_N_A(pObject, (uint)lstrlenA(pName), pName);
    }

    public static HRESULT D3D_SET_OBJECT_NAME_N_W<TDXGIObject>(TDXGIObject* pObject, uint Chars, ushort* pName)
        where TDXGIObject : unmanaged, IDXGIObject.Interface
    {
        var guid = WKPDID_D3DDebugObjectNameW;
        return pObject->SetPrivateData(&guid, Chars * 2, pName);
    }

    public static HRESULT D3D_SET_OBJECT_NAME_W<TDXGIObject>(TDXGIObject* pObject, ushort* pName)
        where TDXGIObject : unmanaged, IDXGIObject.Interface
    {
        return D3D_SET_OBJECT_NAME_N_W(pObject, (uint)lstrlenW(pName), pName);
    }
}
