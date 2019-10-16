// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AF671749-D241-4DB8-8E41-DCC2E5C1A438")]
    public unsafe partial struct ID2D1SvgGlyphStyle
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1SvgGlyphStyle* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1SvgGlyphStyle* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1SvgGlyphStyle* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1SvgGlyphStyle* pThis, [NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFill(ID2D1SvgGlyphStyle* pThis, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFill(ID2D1SvgGlyphStyle* pThis, [NativeTypeName("ID2D1Brush **")] ID2D1Brush** brush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetStroke(ID2D1SvgGlyphStyle* pThis, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth, [NativeTypeName("const FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("FLOAT")] float dashOffset);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetStrokeDashesCount(ID2D1SvgGlyphStyle* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetStroke(ID2D1SvgGlyphStyle* pThis, [NativeTypeName("ID2D1Brush **")] ID2D1Brush** brush, [NativeTypeName("FLOAT *")] float* strokeWidth, [NativeTypeName("FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("FLOAT *")] float* dashOffset);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), factory);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFill([NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFill>(lpVtbl->SetFill)((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), brush);
        }

        public void GetFill([NativeTypeName("ID2D1Brush **")] ID2D1Brush** brush)
        {
            Marshal.GetDelegateForFunctionPointer<_GetFill>(lpVtbl->GetFill)((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), brush);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStroke([NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth, [NativeTypeName("const FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("FLOAT")] float dashOffset)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetStroke>(lpVtbl->SetStroke)((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), brush, strokeWidth, dashes, dashesCount, dashOffset);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetStrokeDashesCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetStrokeDashesCount>(lpVtbl->GetStrokeDashesCount)((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this));
        }

        public void GetStroke([NativeTypeName("ID2D1Brush **")] ID2D1Brush** brush, [NativeTypeName("FLOAT *")] float* strokeWidth, [NativeTypeName("FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("FLOAT *")] float* dashOffset)
        {
            Marshal.GetDelegateForFunctionPointer<_GetStroke>(lpVtbl->GetStroke)((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), brush, strokeWidth, dashes, dashesCount, dashOffset);
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

            [NativeTypeName("HRESULT (ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetFill;

            [NativeTypeName("void (ID2D1Brush **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFill;

            [NativeTypeName("HRESULT (ID2D1Brush *, FLOAT, const FLOAT *, UINT32, FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetStroke;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetStrokeDashesCount;

            [NativeTypeName("void (ID2D1Brush **, FLOAT *, FLOAT *, UINT32, FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetStroke;
        }
    }
}
