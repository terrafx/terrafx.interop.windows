// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d11.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3C9C5B51-995D-48D1-9B8D-FA5CAEDED65C")]
    public unsafe partial struct ID3D11VideoDecoder
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D11VideoDecoder* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D11VideoDecoder* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D11VideoDecoder* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDevice(ID3D11VideoDecoder* pThis, [NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(ID3D11VideoDecoder* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(ID3D11VideoDecoder* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(ID3D11VideoDecoder* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCreationParameters(ID3D11VideoDecoder* pThis, [NativeTypeName("D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pVideoDesc, [NativeTypeName("D3D11_VIDEO_DECODER_CONFIG *")] D3D11_VIDEO_DECODER_CONFIG* pConfig);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDriverHandle(ID3D11VideoDecoder* pThis, [NativeTypeName("HANDLE *")] void** pDriverHandle);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D11VideoDecoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D11VideoDecoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D11VideoDecoder*)Unsafe.AsPointer(ref this));
        }

        public void GetDevice([NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice)
        {
            Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)((ID3D11VideoDecoder*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)((ID3D11VideoDecoder*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)((ID3D11VideoDecoder*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)((ID3D11VideoDecoder*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCreationParameters([NativeTypeName("D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pVideoDesc, [NativeTypeName("D3D11_VIDEO_DECODER_CONFIG *")] D3D11_VIDEO_DECODER_CONFIG* pConfig)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCreationParameters>(lpVtbl->GetCreationParameters)((ID3D11VideoDecoder*)Unsafe.AsPointer(ref this), pVideoDesc, pConfig);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDriverHandle([NativeTypeName("HANDLE *")] void** pDriverHandle)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDriverHandle>(lpVtbl->GetDriverHandle)((ID3D11VideoDecoder*)Unsafe.AsPointer(ref this), pDriverHandle);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **)")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG ()")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG ()")]
            public IntPtr Release;

            [NativeTypeName("void (ID3D11Device **)")]
            public IntPtr GetDevice;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *)")]
            public IntPtr GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *)")]
            public IntPtr SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *)")]
            public IntPtr SetPrivateDataInterface;

            [NativeTypeName("HRESULT (D3D11_VIDEO_DECODER_DESC *, D3D11_VIDEO_DECODER_CONFIG *)")]
            public IntPtr GetCreationParameters;

            [NativeTypeName("HRESULT (HANDLE *)")]
            public IntPtr GetDriverHandle;
        }
    }
}
