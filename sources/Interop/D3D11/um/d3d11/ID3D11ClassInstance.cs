// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A6CD7FAA-B0B7-4A2F-9436-8662A65797CB")]
    public unsafe partial struct ID3D11ClassInstance
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D11ClassInstance* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D11ClassInstance* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D11ClassInstance* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDevice(ID3D11ClassInstance* pThis, [NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(ID3D11ClassInstance* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(ID3D11ClassInstance* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(ID3D11ClassInstance* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetClassLinkage(ID3D11ClassInstance* pThis, [NativeTypeName("ID3D11ClassLinkage **")] ID3D11ClassLinkage** ppLinkage);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDesc(ID3D11ClassInstance* pThis, [NativeTypeName("D3D11_CLASS_INSTANCE_DESC *")] D3D11_CLASS_INSTANCE_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetInstanceName(ID3D11ClassInstance* pThis, [NativeTypeName("LPSTR")] sbyte* pInstanceName, [NativeTypeName("SIZE_T *")] UIntPtr* pBufferLength);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetTypeName(ID3D11ClassInstance* pThis, [NativeTypeName("LPSTR")] sbyte* pTypeName, [NativeTypeName("SIZE_T *")] UIntPtr* pBufferLength);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D11ClassInstance*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D11ClassInstance*)Unsafe.AsPointer(ref this));
        }

        public void GetDevice([NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice)
        {
            Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), guid, pData);
        }

        public void GetClassLinkage([NativeTypeName("ID3D11ClassLinkage **")] ID3D11ClassLinkage** ppLinkage)
        {
            Marshal.GetDelegateForFunctionPointer<_GetClassLinkage>(lpVtbl->GetClassLinkage)((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), ppLinkage);
        }

        public void GetDesc([NativeTypeName("D3D11_CLASS_INSTANCE_DESC *")] D3D11_CLASS_INSTANCE_DESC* pDesc)
        {
            Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), pDesc);
        }

        public void GetInstanceName([NativeTypeName("LPSTR")] sbyte* pInstanceName, [NativeTypeName("SIZE_T *")] UIntPtr* pBufferLength)
        {
            Marshal.GetDelegateForFunctionPointer<_GetInstanceName>(lpVtbl->GetInstanceName)((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), pInstanceName, pBufferLength);
        }

        public void GetTypeName([NativeTypeName("LPSTR")] sbyte* pTypeName, [NativeTypeName("SIZE_T *")] UIntPtr* pBufferLength)
        {
            Marshal.GetDelegateForFunctionPointer<_GetTypeName>(lpVtbl->GetTypeName)((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), pTypeName, pBufferLength);
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

            [NativeTypeName("void (ID3D11ClassLinkage **) __attribute__((stdcall))")]
            public IntPtr GetClassLinkage;

            [NativeTypeName("void (D3D11_CLASS_INSTANCE_DESC *) __attribute__((stdcall))")]
            public IntPtr GetDesc;

            [NativeTypeName("void (LPSTR, SIZE_T *) __attribute__((stdcall))")]
            public IntPtr GetInstanceName;

            [NativeTypeName("void (LPSTR, SIZE_T *) __attribute__((stdcall))")]
            public IntPtr GetTypeName;
        }
    }
}
