// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2CD9069E-12E2-11DC-9FED-001143A055F9")]
    public unsafe partial struct ID2D1SimplifiedGeometrySink
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1SimplifiedGeometrySink* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1SimplifiedGeometrySink* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1SimplifiedGeometrySink* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetFillMode(ID2D1SimplifiedGeometrySink* pThis, D2D1_FILL_MODE fillMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetSegmentFlags(ID2D1SimplifiedGeometrySink* pThis, D2D1_PATH_SEGMENT vertexFlags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _BeginFigure(ID2D1SimplifiedGeometrySink* pThis, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F startPoint, D2D1_FIGURE_BEGIN figureBegin);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _AddLines(ID2D1SimplifiedGeometrySink* pThis, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _AddBeziers(ID2D1SimplifiedGeometrySink* pThis, [NativeTypeName("const D2D1_BEZIER_SEGMENT *")] D2D1_BEZIER_SEGMENT* beziers, [NativeTypeName("UINT32")] uint beziersCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _EndFigure(ID2D1SimplifiedGeometrySink* pThis, D2D1_FIGURE_END figureEnd);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Close(ID2D1SimplifiedGeometrySink* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this));
        }

        public void SetFillMode(D2D1_FILL_MODE fillMode)
        {
            Marshal.GetDelegateForFunctionPointer<_SetFillMode>(lpVtbl->SetFillMode)((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this), fillMode);
        }

        public void SetSegmentFlags(D2D1_PATH_SEGMENT vertexFlags)
        {
            Marshal.GetDelegateForFunctionPointer<_SetSegmentFlags>(lpVtbl->SetSegmentFlags)((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this), vertexFlags);
        }

        public void BeginFigure([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F startPoint, D2D1_FIGURE_BEGIN figureBegin)
        {
            Marshal.GetDelegateForFunctionPointer<_BeginFigure>(lpVtbl->BeginFigure)((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this), startPoint, figureBegin);
        }

        public void AddLines([NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount)
        {
            Marshal.GetDelegateForFunctionPointer<_AddLines>(lpVtbl->AddLines)((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this), points, pointsCount);
        }

        public void AddBeziers([NativeTypeName("const D2D1_BEZIER_SEGMENT *")] D2D1_BEZIER_SEGMENT* beziers, [NativeTypeName("UINT32")] uint beziersCount)
        {
            Marshal.GetDelegateForFunctionPointer<_AddBeziers>(lpVtbl->AddBeziers)((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this), beziers, beziersCount);
        }

        public void EndFigure(D2D1_FIGURE_END figureEnd)
        {
            Marshal.GetDelegateForFunctionPointer<_EndFigure>(lpVtbl->EndFigure)((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this), figureEnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return Marshal.GetDelegateForFunctionPointer<_Close>(lpVtbl->Close)((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("void (D2D1_FILL_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetFillMode;

            [NativeTypeName("void (D2D1_PATH_SEGMENT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetSegmentFlags;

            [NativeTypeName("void (D2D1_POINT_2F, D2D1_FIGURE_BEGIN) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr BeginFigure;

            [NativeTypeName("void (const D2D1_POINT_2F *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr AddLines;

            [NativeTypeName("void (const D2D1_BEZIER_SEGMENT *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr AddBeziers;

            [NativeTypeName("void (D2D1_FIGURE_END) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr EndFigure;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Close;
        }
    }
}
