// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("d2c21b26-8350-4bdc-976a-331ce6f4c54c")]
    public unsafe partial struct IDxcContainerReflection
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDxcContainerReflection* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDxcContainerReflection* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDxcContainerReflection* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Load(IDxcContainerReflection* pThis, [NativeTypeName("IDxcBlob *")] IDxcBlob* pContainer);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPartCount(IDxcContainerReflection* pThis, [NativeTypeName("UINT32 *")] uint* pResult);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPartKind(IDxcContainerReflection* pThis, [NativeTypeName("UINT32")] uint idx, [NativeTypeName("UINT32 *")] uint* pResult);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPartContent(IDxcContainerReflection* pThis, [NativeTypeName("UINT32")] uint idx, [NativeTypeName("IDxcBlob **")] IDxcBlob** ppResult);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FindFirstPartKind(IDxcContainerReflection* pThis, [NativeTypeName("UINT32")] uint kind, [NativeTypeName("UINT32 *")] uint* pResult);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPartReflection(IDxcContainerReflection* pThis, [NativeTypeName("UINT32")] uint idx, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** ppvObject);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDxcContainerReflection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDxcContainerReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDxcContainerReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("IDxcBlob *")] IDxcBlob* pContainer)
        {
            return Marshal.GetDelegateForFunctionPointer<_Load>(lpVtbl->Load)((IDxcContainerReflection*)Unsafe.AsPointer(ref this), pContainer);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPartCount([NativeTypeName("UINT32 *")] uint* pResult)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPartCount>(lpVtbl->GetPartCount)((IDxcContainerReflection*)Unsafe.AsPointer(ref this), pResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPartKind([NativeTypeName("UINT32")] uint idx, [NativeTypeName("UINT32 *")] uint* pResult)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPartKind>(lpVtbl->GetPartKind)((IDxcContainerReflection*)Unsafe.AsPointer(ref this), idx, pResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPartContent([NativeTypeName("UINT32")] uint idx, [NativeTypeName("IDxcBlob **")] IDxcBlob** ppResult)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPartContent>(lpVtbl->GetPartContent)((IDxcContainerReflection*)Unsafe.AsPointer(ref this), idx, ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindFirstPartKind([NativeTypeName("UINT32")] uint kind, [NativeTypeName("UINT32 *")] uint* pResult)
        {
            return Marshal.GetDelegateForFunctionPointer<_FindFirstPartKind>(lpVtbl->FindFirstPartKind)((IDxcContainerReflection*)Unsafe.AsPointer(ref this), kind, pResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPartReflection([NativeTypeName("UINT32")] uint idx, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPartReflection>(lpVtbl->GetPartReflection)((IDxcContainerReflection*)Unsafe.AsPointer(ref this), idx, iid, ppvObject);
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

            [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
            public IntPtr GetPartCount;

            [NativeTypeName("HRESULT (UINT32, UINT32 *) __attribute__((stdcall))")]
            public IntPtr GetPartKind;

            [NativeTypeName("HRESULT (UINT32, IDxcBlob **) __attribute__((stdcall))")]
            public IntPtr GetPartContent;

            [NativeTypeName("HRESULT (UINT32, UINT32 *) __attribute__((stdcall))")]
            public IntPtr FindFirstPartKind;

            [NativeTypeName("HRESULT (UINT32, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr GetPartReflection;
        }
    }
}
