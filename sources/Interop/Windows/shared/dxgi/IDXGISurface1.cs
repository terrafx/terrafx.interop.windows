// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4AE63092-6327-4C1B-80AE-BFE12EA32B86")]
    public unsafe struct IDXGISurface1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXGISurface1* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXGISurface1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXGISurface1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(IDXGISurface1* This, [NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(IDXGISurface1* This, [NativeTypeName("REFGUID")] Guid* Name, IUnknown* pUnknown = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(IDXGISurface1* This, [NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint* pDataSize, void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetParent(IDXGISurface1* This, [NativeTypeName("REFIID")] Guid* riid, void** ppParent);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDevice(IDXGISurface1* This, [NativeTypeName("REFIID")] Guid* riid, void** ppDevice);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc(IDXGISurface1* This, DXGI_SURFACE_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Map(IDXGISurface1* This, DXGI_MAPPED_RECT* pLockedRect, [NativeTypeName("UINT")] uint MapFlags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Unmap(IDXGISurface1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDC(IDXGISurface1* This, [NativeTypeName("BOOL")] int Discard, [NativeTypeName("HDC")] IntPtr* phdc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReleaseDC(IDXGISurface1* This, RECT* pDirtyRect = null);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDXGISurface1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDXGISurface1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGISurface1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, void* pData)
        {
            fixed (IDXGISurface1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)(This, Name, DataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("REFGUID")] Guid* Name, IUnknown* pUnknown = null)
        {
            fixed (IDXGISurface1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)(This, Name, pUnknown);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint* pDataSize, void* pData)
        {
            fixed (IDXGISurface1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)(This, Name, pDataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("REFIID")] Guid* riid, void** ppParent)
        {
            fixed (IDXGISurface1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetParent>(lpVtbl->GetParent)(This, riid, ppParent);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("REFIID")] Guid* riid, void** ppDevice)
        {
            fixed (IDXGISurface1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)(This, riid, ppDevice);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc(DXGI_SURFACE_DESC* pDesc)
        {
            fixed (IDXGISurface1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)(This, pDesc);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Map(DXGI_MAPPED_RECT* pLockedRect, [NativeTypeName("UINT")] uint MapFlags)
        {
            fixed (IDXGISurface1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Map>(lpVtbl->Map)(This, pLockedRect, MapFlags);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Unmap()
        {
            fixed (IDXGISurface1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Unmap>(lpVtbl->Unmap)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDC([NativeTypeName("BOOL")] int Discard, [NativeTypeName("HDC")] IntPtr* phdc)
        {
            fixed (IDXGISurface1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDC>(lpVtbl->GetDC)(This, Discard, phdc);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseDC(RECT* pDirtyRect = null)
        {
            fixed (IDXGISurface1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ReleaseDC>(lpVtbl->ReleaseDC)(This, pDirtyRect);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr SetPrivateData;

            public IntPtr SetPrivateDataInterface;

            public IntPtr GetPrivateData;

            public IntPtr GetParent;

            public IntPtr GetDevice;

            public IntPtr GetDesc;

            public IntPtr Map;

            public IntPtr Unmap;

            public IntPtr GetDC;

            public IntPtr ReleaseDC;
        }
    }
}
