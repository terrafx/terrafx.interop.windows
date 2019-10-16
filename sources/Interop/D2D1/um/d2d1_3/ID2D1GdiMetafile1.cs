// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2E69F9E8-DD3F-4BF9-95BA-C04F49D788DF")]
    public unsafe partial struct ID2D1GdiMetafile1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1GdiMetafile1* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1GdiMetafile1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1GdiMetafile1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1GdiMetafile1* pThis, [NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Stream(ID2D1GdiMetafile1* pThis, [NativeTypeName("ID2D1GdiMetafileSink *")] ID2D1GdiMetafileSink* sink);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBounds(ID2D1GdiMetafile1* pThis, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDpi(ID2D1GdiMetafile1* pThis, [NativeTypeName("FLOAT *")] float* dpiX, [NativeTypeName("FLOAT *")] float* dpiY);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSourceBounds(ID2D1GdiMetafile1* pThis, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1GdiMetafile1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1GdiMetafile1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1GdiMetafile1*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)((ID2D1GdiMetafile1*)Unsafe.AsPointer(ref this), factory);
        }

        [return: NativeTypeName("HRESULT")]
        public int Stream([NativeTypeName("ID2D1GdiMetafileSink *")] ID2D1GdiMetafileSink* sink)
        {
            return Marshal.GetDelegateForFunctionPointer<_Stream>(lpVtbl->Stream)((ID2D1GdiMetafile1*)Unsafe.AsPointer(ref this), sink);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBounds([NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBounds>(lpVtbl->GetBounds)((ID2D1GdiMetafile1*)Unsafe.AsPointer(ref this), bounds);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDpi([NativeTypeName("FLOAT *")] float* dpiX, [NativeTypeName("FLOAT *")] float* dpiY)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDpi>(lpVtbl->GetDpi)((ID2D1GdiMetafile1*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSourceBounds([NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSourceBounds>(lpVtbl->GetSourceBounds)((ID2D1GdiMetafile1*)Unsafe.AsPointer(ref this), bounds);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFactory;

            [NativeTypeName("HRESULT (ID2D1GdiMetafileSink *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Stream;

            [NativeTypeName("HRESULT (D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetBounds;

            [NativeTypeName("HRESULT (FLOAT *, FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDpi;

            [NativeTypeName("HRESULT (D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetSourceBounds;
        }
    }
}
