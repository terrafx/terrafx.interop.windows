// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2CD9069E-12E2-11DC-9FED-001143A055F9")]
    public unsafe partial struct ID2D1SimplifiedGeometrySink
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this));
        }

        public void SetFillMode(D2D1_FILL_MODE fillMode)
        {
            lpVtbl->SetFillMode((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this), fillMode);
        }

        public void SetSegmentFlags(D2D1_PATH_SEGMENT vertexFlags)
        {
            lpVtbl->SetSegmentFlags((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this), vertexFlags);
        }

        public void BeginFigure([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F startPoint, D2D1_FIGURE_BEGIN figureBegin)
        {
            lpVtbl->BeginFigure((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this), startPoint, figureBegin);
        }

        public void AddLines([NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount)
        {
            lpVtbl->AddLines((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this), points, pointsCount);
        }

        public void AddBeziers([NativeTypeName("const D2D1_BEZIER_SEGMENT *")] D2D1_BEZIER_SEGMENT* beziers, [NativeTypeName("UINT32")] uint beziersCount)
        {
            lpVtbl->AddBeziers((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this), beziers, beziersCount);
        }

        public void EndFigure(D2D1_FIGURE_END figureEnd)
        {
            lpVtbl->EndFigure((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this), figureEnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return lpVtbl->Close((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SimplifiedGeometrySink*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SimplifiedGeometrySink*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SimplifiedGeometrySink*, uint> Release;

            [NativeTypeName("void (D2D1_FILL_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SimplifiedGeometrySink*, D2D1_FILL_MODE, void> SetFillMode;

            [NativeTypeName("void (D2D1_PATH_SEGMENT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SimplifiedGeometrySink*, D2D1_PATH_SEGMENT, void> SetSegmentFlags;

            [NativeTypeName("void (D2D1_POINT_2F, D2D1_FIGURE_BEGIN) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SimplifiedGeometrySink*, D2D_POINT_2F, D2D1_FIGURE_BEGIN, void> BeginFigure;

            [NativeTypeName("void (const D2D1_POINT_2F *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SimplifiedGeometrySink*, D2D_POINT_2F*, uint, void> AddLines;

            [NativeTypeName("void (const D2D1_BEZIER_SEGMENT *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SimplifiedGeometrySink*, D2D1_BEZIER_SEGMENT*, uint, void> AddBeziers;

            [NativeTypeName("void (D2D1_FIGURE_END) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SimplifiedGeometrySink*, D2D1_FIGURE_END, void> EndFigure;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SimplifiedGeometrySink*, int> Close;
        }
    }
}
