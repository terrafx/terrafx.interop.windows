// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AFFDE9D1-1DF7-4BB7-8A34-0F46251DAB80")]
    public unsafe partial struct ID3D11Fence
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D11Fence* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D11Fence* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D11Fence* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDevice(ID3D11Fence* pThis, [NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(ID3D11Fence* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(ID3D11Fence* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(ID3D11Fence* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSharedHandle(ID3D11Fence* pThis, [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pAttributes, [NativeTypeName("DWORD")] uint dwAccess, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("HANDLE *")] IntPtr* pHandle);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetCompletedValue(ID3D11Fence* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetEventOnCompletion(ID3D11Fence* pThis, [NativeTypeName("UINT64")] ulong Value, [NativeTypeName("HANDLE")] IntPtr hEvent);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D11Fence*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D11Fence*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D11Fence*)Unsafe.AsPointer(ref this));
        }

        public void GetDevice([NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice)
        {
            Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)((ID3D11Fence*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)((ID3D11Fence*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)((ID3D11Fence*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)((ID3D11Fence*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSharedHandle([NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pAttributes, [NativeTypeName("DWORD")] uint dwAccess, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("HANDLE *")] IntPtr* pHandle)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSharedHandle>(lpVtbl->CreateSharedHandle)((ID3D11Fence*)Unsafe.AsPointer(ref this), pAttributes, dwAccess, lpName, pHandle);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetCompletedValue()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCompletedValue>(lpVtbl->GetCompletedValue)((ID3D11Fence*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEventOnCompletion([NativeTypeName("UINT64")] ulong Value, [NativeTypeName("HANDLE")] IntPtr hEvent)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetEventOnCompletion>(lpVtbl->SetEventOnCompletion)((ID3D11Fence*)Unsafe.AsPointer(ref this), Value, hEvent);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("void (ID3D11Device **) __attribute__((stdcall))")]
            public IntPtr GetDevice;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public IntPtr GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public IntPtr SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public IntPtr SetPrivateDataInterface;

            [NativeTypeName("HRESULT (const SECURITY_ATTRIBUTES *, DWORD, LPCWSTR, HANDLE *) __attribute__((stdcall))")]
            public IntPtr CreateSharedHandle;

            [NativeTypeName("UINT64 () __attribute__((stdcall))")]
            public IntPtr GetCompletedValue;

            [NativeTypeName("HRESULT (UINT64, HANDLE) __attribute__((stdcall))")]
            public IntPtr SetEventOnCompletion;
        }
    }
}
