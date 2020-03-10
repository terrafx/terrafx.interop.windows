// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FD0ECB6B-91E6-411E-8655-395E760F91B4")]
    public unsafe partial struct ID2D1GdiMetafileSink1
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1GdiMetafileSink1* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1GdiMetafileSink1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1GdiMetafileSink1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ProcessRecord(ID2D1GdiMetafileSink1* pThis, [NativeTypeName("DWORD")] uint recordType, [NativeTypeName("const void *")] void* recordData, [NativeTypeName("DWORD")] uint recordDataSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ProcessRecord1(ID2D1GdiMetafileSink1* pThis, [NativeTypeName("DWORD")] uint recordType, [NativeTypeName("const void *")] void* recordData, [NativeTypeName("DWORD")] uint recordDataSize, [NativeTypeName("UINT32")] uint flags);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1GdiMetafileSink1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1GdiMetafileSink1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1GdiMetafileSink1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ProcessRecord([NativeTypeName("DWORD")] uint recordType, [NativeTypeName("const void *")] void* recordData, [NativeTypeName("DWORD")] uint recordDataSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_ProcessRecord>(lpVtbl->ProcessRecord)((ID2D1GdiMetafileSink1*)Unsafe.AsPointer(ref this), recordType, recordData, recordDataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int ProcessRecord([NativeTypeName("DWORD")] uint recordType, [NativeTypeName("const void *")] void* recordData, [NativeTypeName("DWORD")] uint recordDataSize, [NativeTypeName("UINT32")] uint flags)
        {
            return Marshal.GetDelegateForFunctionPointer<_ProcessRecord1>(lpVtbl->ProcessRecord1)((ID2D1GdiMetafileSink1*)Unsafe.AsPointer(ref this), recordType, recordData, recordDataSize, flags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (DWORD, const void *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr ProcessRecord;

            [NativeTypeName("HRESULT (DWORD, const void *, DWORD, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr ProcessRecord1;
        }
    }
}
