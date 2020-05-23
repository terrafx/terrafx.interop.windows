// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F1C0CA52-92A3-4F00-B4CE-F35691EFD9D9")]
    public unsafe partial struct ID2D1SvgStrokeDashArray
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1SvgStrokeDashArray* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1SvgStrokeDashArray* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1SvgStrokeDashArray* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1SvgStrokeDashArray* pThis, [NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetElement(ID2D1SvgStrokeDashArray* pThis, [NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** element);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Clone(ID2D1SvgStrokeDashArray* pThis, [NativeTypeName("ID2D1SvgAttribute **")] ID2D1SvgAttribute** attribute);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RemoveDashesAtEnd(ID2D1SvgStrokeDashArray* pThis, [NativeTypeName("UINT32")] uint dashesCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UpdateDashes(ID2D1SvgStrokeDashArray* pThis, [NativeTypeName("const FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UpdateDashes1(ID2D1SvgStrokeDashArray* pThis, [NativeTypeName("const D2D1_SVG_LENGTH *")] D2D1_SVG_LENGTH* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDashes(ID2D1SvgStrokeDashArray* pThis, [NativeTypeName("FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDashes1(ID2D1SvgStrokeDashArray* pThis, [NativeTypeName("D2D1_SVG_LENGTH *")] D2D1_SVG_LENGTH* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetDashesCount(ID2D1SvgStrokeDashArray* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), factory);
        }

        public void GetElement([NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** element)
        {
            Marshal.GetDelegateForFunctionPointer<_GetElement>(lpVtbl->GetElement)((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), element);
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("ID2D1SvgAttribute **")] ID2D1SvgAttribute** attribute)
        {
            return Marshal.GetDelegateForFunctionPointer<_Clone>(lpVtbl->Clone)((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), attribute);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveDashesAtEnd([NativeTypeName("UINT32")] uint dashesCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_RemoveDashesAtEnd>(lpVtbl->RemoveDashesAtEnd)((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), dashesCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateDashes([NativeTypeName("const FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            return Marshal.GetDelegateForFunctionPointer<_UpdateDashes>(lpVtbl->UpdateDashes)((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), dashes, dashesCount, startIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateDashes([NativeTypeName("const D2D1_SVG_LENGTH *")] D2D1_SVG_LENGTH* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            return Marshal.GetDelegateForFunctionPointer<_UpdateDashes1>(lpVtbl->UpdateDashes1)((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), dashes, dashesCount, startIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDashes([NativeTypeName("FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDashes>(lpVtbl->GetDashes)((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), dashes, dashesCount, startIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDashes([NativeTypeName("D2D1_SVG_LENGTH *")] D2D1_SVG_LENGTH* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDashes1>(lpVtbl->GetDashes1)((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), dashes, dashesCount, startIndex);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetDashesCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDashesCount>(lpVtbl->GetDashesCount)((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this));
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

            [NativeTypeName("void (ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetElement;

            [NativeTypeName("HRESULT (ID2D1SvgAttribute **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Clone;

            [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr RemoveDashesAtEnd;

            [NativeTypeName("HRESULT (const FLOAT *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr UpdateDashes;

            [NativeTypeName("HRESULT (const D2D1_SVG_LENGTH *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr UpdateDashes1;

            [NativeTypeName("HRESULT (FLOAT *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDashes;

            [NativeTypeName("HRESULT (D2D1_SVG_LENGTH *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDashes1;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDashesCount;
        }
    }
}
