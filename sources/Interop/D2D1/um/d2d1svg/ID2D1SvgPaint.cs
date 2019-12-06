// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D59BAB0A-68A2-455B-A5DC-9EB2854E2490")]
    public unsafe partial struct ID2D1SvgPaint
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1SvgPaint* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1SvgPaint* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1SvgPaint* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1SvgPaint* pThis, [NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetElement(ID2D1SvgPaint* pThis, [NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** element);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Clone(ID2D1SvgPaint* pThis, [NativeTypeName("ID2D1SvgAttribute **")] ID2D1SvgAttribute** attribute);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPaintType(ID2D1SvgPaint* pThis, D2D1_SVG_PAINT_TYPE paintType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_SVG_PAINT_TYPE _GetPaintType(ID2D1SvgPaint* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetColor(ID2D1SvgPaint* pThis, [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetColor(ID2D1SvgPaint* pThis, [NativeTypeName("D2D1_COLOR_F *")] DXGI_RGBA* color);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetId(ID2D1SvgPaint* pThis, [NativeTypeName("PCWSTR")] ushort* id);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetId(ID2D1SvgPaint* pThis, [NativeTypeName("PWSTR")] ushort* id, [NativeTypeName("UINT32")] uint idCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetIdLength(ID2D1SvgPaint* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1SvgPaint*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1SvgPaint*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), factory);
        }

        public void GetElement([NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** element)
        {
            Marshal.GetDelegateForFunctionPointer<_GetElement>(lpVtbl->GetElement)((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), element);
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("ID2D1SvgAttribute **")] ID2D1SvgAttribute** attribute)
        {
            return Marshal.GetDelegateForFunctionPointer<_Clone>(lpVtbl->Clone)((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), attribute);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPaintType(D2D1_SVG_PAINT_TYPE paintType)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPaintType>(lpVtbl->SetPaintType)((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), paintType);
        }

        public D2D1_SVG_PAINT_TYPE GetPaintType()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPaintType>(lpVtbl->GetPaintType)((ID2D1SvgPaint*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetColor([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetColor>(lpVtbl->SetColor)((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), color);
        }

        public void GetColor([NativeTypeName("D2D1_COLOR_F *")] DXGI_RGBA* color)
        {
            Marshal.GetDelegateForFunctionPointer<_GetColor>(lpVtbl->GetColor)((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), color);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetId([NativeTypeName("PCWSTR")] ushort* id)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetId>(lpVtbl->SetId)((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), id);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetId([NativeTypeName("PWSTR")] ushort* id, [NativeTypeName("UINT32")] uint idCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetId>(lpVtbl->GetId)((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), id, idCount);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetIdLength()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetIdLength>(lpVtbl->GetIdLength)((ID2D1SvgPaint*)Unsafe.AsPointer(ref this));
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

            [NativeTypeName("HRESULT (D2D1_SVG_PAINT_TYPE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetPaintType;

            [NativeTypeName("D2D1_SVG_PAINT_TYPE () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPaintType;

            [NativeTypeName("HRESULT (const D2D1_COLOR_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetColor;

            [NativeTypeName("void (D2D1_COLOR_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetColor;

            [NativeTypeName("HRESULT (PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetId;

            [NativeTypeName("HRESULT (PWSTR, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetId;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetIdLength;
        }
    }
}
