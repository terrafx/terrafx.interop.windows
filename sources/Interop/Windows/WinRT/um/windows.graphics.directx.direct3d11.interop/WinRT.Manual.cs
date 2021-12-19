// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.graphics.directx.direct3d11.interop.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.DirectX;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.WinRT;

public static unsafe partial class WinRT
{
    public static IInspectable* CreateDirect3DDevice(IDXGISurface* dxgiSurface)
    {
        IInspectable* inspectableSurface;
        Marshal.ThrowExceptionForHR(CreateDirect3D11SurfaceFromDXGISurface(dxgiSurface, &inspectableSurface));
        return inspectableSurface;
    }

    public static HRESULT GetDXGIInterfaceFromObject(IInspectable* @object, Guid* iid, void** p)
    {
        IDirect3DDxgiInterfaceAccess* dxgiInterfaceAccess;

        HRESULT hr = @object->QueryInterface(__uuidof<IDirect3DDxgiInterfaceAccess>(), (void**)&dxgiInterfaceAccess);

        if (SUCCEEDED(hr))
        {
            hr = dxgiInterfaceAccess->GetInterface(iid, p);
        }

        _ = dxgiInterfaceAccess->Release();
        return hr;
    }

    public static HRESULT GetDXGIInterface<DXGI_TYPE>(IInspectable* @object, DXGI_TYPE** dxgi)
        where DXGI_TYPE : unmanaged, IUnknown.Interface
    {
        return GetDXGIInterfaceFromObject(@object, __uuidof<DXGI_TYPE>(), (void**)dxgi);
    }
}
