// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.graphics.directx.direct3d11.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static readonly Guid IID_IDirect3DDxgiInterfaceAccess = new Guid(0xA9B3D012, 0x3DF2, 0x4EE3, 0xB8, 0xD1, 0x86, 0x95, 0xF4, 0x57, 0xD3, 0xC1);
    
        public static IInspectable* CreateDirect3DDevice(IDXGISurface* dxgiSurface)
        {
            IInspectable* inspectableSurface;
            Marshal.ThrowExceptionForHR(CreateDirect3D11SurfaceFromDXGISurface(dxgiSurface, &inspectableSurface));
            return inspectableSurface;
        }

        public static int GetDXGIInterfaceFromObject(IInspectable* @object, Guid* iid, void** p)
        {
            IDirect3DDxgiInterfaceAccess* dxgiInterfaceAccess;

            var dxgi_iid = IID_IDirect3DDxgiInterfaceAccess;
            int hr = @object->QueryInterface(&dxgi_iid, (void**) &dxgiInterfaceAccess);

            if (SUCCEEDED(hr))
            {
                hr = dxgiInterfaceAccess->GetInterface(iid, p);
            }

            dxgiInterfaceAccess->Release();
            return hr;
        }

        public static int GetDXGIInterface<DXGI_TYPE>(IInspectable* @object, DXGI_TYPE** dxgi)
            where DXGI_TYPE : unmanaged
        {
            var guid = typeof(DXGI_TYPE).GUID;
            return GetDXGIInterfaceFromObject(@object, &guid, (void**) dxgi);
        }
    }
}
