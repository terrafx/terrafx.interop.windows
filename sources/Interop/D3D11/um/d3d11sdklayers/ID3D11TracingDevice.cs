// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1911C771-1587-413E-A7E0-FB26C3DE0268")]
    public unsafe partial struct ID3D11TracingDevice
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D11TracingDevice* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D11TracingDevice* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D11TracingDevice* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetShaderTrackingOptionsByType(ID3D11TracingDevice* pThis, [NativeTypeName("UINT")] uint ResourceTypeFlags, [NativeTypeName("UINT")] uint Options);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetShaderTrackingOptions(ID3D11TracingDevice* pThis, [NativeTypeName("IUnknown *")] IUnknown* pShader, [NativeTypeName("UINT")] uint Options);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D11TracingDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D11TracingDevice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D11TracingDevice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetShaderTrackingOptionsByType([NativeTypeName("UINT")] uint ResourceTypeFlags, [NativeTypeName("UINT")] uint Options)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetShaderTrackingOptionsByType>(lpVtbl->SetShaderTrackingOptionsByType)((ID3D11TracingDevice*)Unsafe.AsPointer(ref this), ResourceTypeFlags, Options);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetShaderTrackingOptions([NativeTypeName("IUnknown *")] IUnknown* pShader, [NativeTypeName("UINT")] uint Options)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetShaderTrackingOptions>(lpVtbl->SetShaderTrackingOptions)((ID3D11TracingDevice*)Unsafe.AsPointer(ref this), pShader, Options);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (UINT, UINT) __attribute__((stdcall))")]
            public IntPtr SetShaderTrackingOptionsByType;

            [NativeTypeName("HRESULT (IUnknown *, UINT) __attribute__((stdcall))")]
            public IntPtr SetShaderTrackingOptions;
        }
    }
}
