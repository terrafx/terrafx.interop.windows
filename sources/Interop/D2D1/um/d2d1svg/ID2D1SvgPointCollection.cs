// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9DBE4C0D-3572-4DD9-9825-5530813BB712")]
    public unsafe partial struct ID2D1SvgPointCollection
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1SvgPointCollection* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1SvgPointCollection* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1SvgPointCollection* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1SvgPointCollection* pThis, [NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetElement(ID2D1SvgPointCollection* pThis, [NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** element);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Clone(ID2D1SvgPointCollection* pThis, [NativeTypeName("ID2D1SvgAttribute **")] ID2D1SvgAttribute** attribute);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RemovePointsAtEnd(ID2D1SvgPointCollection* pThis, [NativeTypeName("UINT32")] uint pointsCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UpdatePoints(ID2D1SvgPointCollection* pThis, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount, [NativeTypeName("UINT32")] uint startIndex);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPoints(ID2D1SvgPointCollection* pThis, [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount, [NativeTypeName("UINT32")] uint startIndex);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetPointsCount(ID2D1SvgPointCollection* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1SvgPointCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1SvgPointCollection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1SvgPointCollection*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)((ID2D1SvgPointCollection*)Unsafe.AsPointer(ref this), factory);
        }

        public void GetElement([NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** element)
        {
            Marshal.GetDelegateForFunctionPointer<_GetElement>(lpVtbl->GetElement)((ID2D1SvgPointCollection*)Unsafe.AsPointer(ref this), element);
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("ID2D1SvgAttribute **")] ID2D1SvgAttribute** attribute)
        {
            return Marshal.GetDelegateForFunctionPointer<_Clone>(lpVtbl->Clone)((ID2D1SvgPointCollection*)Unsafe.AsPointer(ref this), attribute);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemovePointsAtEnd([NativeTypeName("UINT32")] uint pointsCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_RemovePointsAtEnd>(lpVtbl->RemovePointsAtEnd)((ID2D1SvgPointCollection*)Unsafe.AsPointer(ref this), pointsCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdatePoints([NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount, [NativeTypeName("UINT32")] uint startIndex)
        {
            return Marshal.GetDelegateForFunctionPointer<_UpdatePoints>(lpVtbl->UpdatePoints)((ID2D1SvgPointCollection*)Unsafe.AsPointer(ref this), points, pointsCount, startIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPoints([NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount, [NativeTypeName("UINT32")] uint startIndex)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPoints>(lpVtbl->GetPoints)((ID2D1SvgPointCollection*)Unsafe.AsPointer(ref this), points, pointsCount, startIndex);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetPointsCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPointsCount>(lpVtbl->GetPointsCount)((ID2D1SvgPointCollection*)Unsafe.AsPointer(ref this));
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
            public IntPtr RemovePointsAtEnd;

            [NativeTypeName("HRESULT (const D2D1_POINT_2F *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr UpdatePoints;

            [NativeTypeName("HRESULT (D2D1_POINT_2F *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPoints;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPointsCount;
        }
    }
}
