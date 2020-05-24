// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectXShaderCompiler, include/dxc/dxcapi.h, at commit d356a8bc546da38612cac13d1e643de17a0ba38f
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IDxcContainerBuilder
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDxcContainerBuilder* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDxcContainerBuilder* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDxcContainerBuilder* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Load(IDxcContainerBuilder* pThis, [NativeTypeName("IDxcBlob *")] IDxcBlob* pDxilContainerHeader);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddPart(IDxcContainerBuilder* pThis, [NativeTypeName("UINT32")] uint fourCC, [NativeTypeName("IDxcBlob *")] IDxcBlob* pSource);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RemovePart(IDxcContainerBuilder* pThis, [NativeTypeName("UINT32")] uint fourCC);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SerializeContainer(IDxcContainerBuilder* pThis, [NativeTypeName("IDxcOperationResult **")] IDxcOperationResult** ppResult);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDxcContainerBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDxcContainerBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("IDxcBlob *")] IDxcBlob* pDxilContainerHeader)
        {
            return Marshal.GetDelegateForFunctionPointer<_Load>(lpVtbl->Load)((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), pDxilContainerHeader);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddPart([NativeTypeName("UINT32")] uint fourCC, [NativeTypeName("IDxcBlob *")] IDxcBlob* pSource)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddPart>(lpVtbl->AddPart)((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), fourCC, pSource);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemovePart([NativeTypeName("UINT32")] uint fourCC)
        {
            return Marshal.GetDelegateForFunctionPointer<_RemovePart>(lpVtbl->RemovePart)((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), fourCC);
        }

        [return: NativeTypeName("HRESULT")]
        public int SerializeContainer([NativeTypeName("IDxcOperationResult **")] IDxcOperationResult** ppResult)
        {
            return Marshal.GetDelegateForFunctionPointer<_SerializeContainer>(lpVtbl->SerializeContainer)((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), ppResult);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IDxcBlob *) __attribute__((stdcall))")]
            public IntPtr Load;

            [NativeTypeName("HRESULT (UINT32, IDxcBlob *) __attribute__((stdcall))")]
            public IntPtr AddPart;

            [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
            public IntPtr RemovePart;

            [NativeTypeName("HRESULT (IDxcOperationResult **) __attribute__((stdcall))")]
            public IntPtr SerializeContainer;
        }
    }
}
