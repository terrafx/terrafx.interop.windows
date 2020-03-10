// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B499923B-7029-478F-A8B3-432C7C5F5312")]
    public unsafe partial struct ID2D1Ink
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1Ink* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1Ink* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1Ink* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1Ink* pThis, [NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetStartPoint(ID2D1Ink* pThis, [NativeTypeName("const D2D1_INK_POINT *")] D2D1_INK_POINT* startPoint);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_INK_POINT* _GetStartPoint(ID2D1Ink* pThis, D2D1_INK_POINT* _result);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddSegments(ID2D1Ink* pThis, [NativeTypeName("const D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segments, [NativeTypeName("UINT32")] uint segmentsCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RemoveSegmentsAtEnd(ID2D1Ink* pThis, [NativeTypeName("UINT32")] uint segmentsCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSegments(ID2D1Ink* pThis, [NativeTypeName("UINT32")] uint startSegment, [NativeTypeName("const D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segments, [NativeTypeName("UINT32")] uint segmentsCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSegmentAtEnd(ID2D1Ink* pThis, [NativeTypeName("const D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segment);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetSegmentCount(ID2D1Ink* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSegments(ID2D1Ink* pThis, [NativeTypeName("UINT32")] uint startSegment, [NativeTypeName("D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segments, [NativeTypeName("UINT32")] uint segmentsCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _StreamAsGeometry(ID2D1Ink* pThis, [NativeTypeName("ID2D1InkStyle *")] ID2D1InkStyle* inkStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("ID2D1SimplifiedGeometrySink *")] ID2D1SimplifiedGeometrySink* geometrySink);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBounds(ID2D1Ink* pThis, [NativeTypeName("ID2D1InkStyle *")] ID2D1InkStyle* inkStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds);

        [return: NativeTypeName("HRESULT")]
        public int StreamAsGeometry([NativeTypeName("ID2D1InkStyle *")] ID2D1InkStyle* inkStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("ID2D1SimplifiedGeometrySink *")] ID2D1SimplifiedGeometrySink* geometrySink)
        {
            return StreamAsGeometry(inkStyle, worldTransform, (0.25f), geometrySink);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1Ink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1Ink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1Ink*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)((ID2D1Ink*)Unsafe.AsPointer(ref this), factory);
        }

        public void SetStartPoint([NativeTypeName("const D2D1_INK_POINT *")] D2D1_INK_POINT* startPoint)
        {
            Marshal.GetDelegateForFunctionPointer<_SetStartPoint>(lpVtbl->SetStartPoint)((ID2D1Ink*)Unsafe.AsPointer(ref this), startPoint);
        }

        public D2D1_INK_POINT GetStartPoint()
        {
            D2D1_INK_POINT result;
            return *Marshal.GetDelegateForFunctionPointer<_GetStartPoint>(lpVtbl->GetStartPoint)((ID2D1Ink*)Unsafe.AsPointer(ref this), &result);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddSegments([NativeTypeName("const D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segments, [NativeTypeName("UINT32")] uint segmentsCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddSegments>(lpVtbl->AddSegments)((ID2D1Ink*)Unsafe.AsPointer(ref this), segments, segmentsCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveSegmentsAtEnd([NativeTypeName("UINT32")] uint segmentsCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_RemoveSegmentsAtEnd>(lpVtbl->RemoveSegmentsAtEnd)((ID2D1Ink*)Unsafe.AsPointer(ref this), segmentsCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSegments([NativeTypeName("UINT32")] uint startSegment, [NativeTypeName("const D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segments, [NativeTypeName("UINT32")] uint segmentsCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetSegments>(lpVtbl->SetSegments)((ID2D1Ink*)Unsafe.AsPointer(ref this), startSegment, segments, segmentsCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSegmentAtEnd([NativeTypeName("const D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segment)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetSegmentAtEnd>(lpVtbl->SetSegmentAtEnd)((ID2D1Ink*)Unsafe.AsPointer(ref this), segment);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetSegmentCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSegmentCount>(lpVtbl->GetSegmentCount)((ID2D1Ink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSegments([NativeTypeName("UINT32")] uint startSegment, [NativeTypeName("D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segments, [NativeTypeName("UINT32")] uint segmentsCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSegments>(lpVtbl->GetSegments)((ID2D1Ink*)Unsafe.AsPointer(ref this), startSegment, segments, segmentsCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int StreamAsGeometry([NativeTypeName("ID2D1InkStyle *")] ID2D1InkStyle* inkStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("ID2D1SimplifiedGeometrySink *")] ID2D1SimplifiedGeometrySink* geometrySink)
        {
            return Marshal.GetDelegateForFunctionPointer<_StreamAsGeometry>(lpVtbl->StreamAsGeometry)((ID2D1Ink*)Unsafe.AsPointer(ref this), inkStyle, worldTransform, flatteningTolerance, geometrySink);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBounds([NativeTypeName("ID2D1InkStyle *")] ID2D1InkStyle* inkStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBounds>(lpVtbl->GetBounds)((ID2D1Ink*)Unsafe.AsPointer(ref this), inkStyle, worldTransform, bounds);
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

            [NativeTypeName("void (const D2D1_INK_POINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetStartPoint;

            [NativeTypeName("D2D1_INK_POINT () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetStartPoint;

            [NativeTypeName("HRESULT (const D2D1_INK_BEZIER_SEGMENT *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr AddSegments;

            [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr RemoveSegmentsAtEnd;

            [NativeTypeName("HRESULT (UINT32, const D2D1_INK_BEZIER_SEGMENT *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetSegments;

            [NativeTypeName("HRESULT (const D2D1_INK_BEZIER_SEGMENT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetSegmentAtEnd;

            [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetSegmentCount;

            [NativeTypeName("HRESULT (UINT32, D2D1_INK_BEZIER_SEGMENT *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetSegments;

            [NativeTypeName("HRESULT (ID2D1InkStyle *, const D2D1_MATRIX_3X2_F *, FLOAT, ID2D1SimplifiedGeometrySink *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr StreamAsGeometry;

            [NativeTypeName("HRESULT (ID2D1InkStyle *, const D2D1_MATRIX_3X2_F *, D2D1_RECT_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetBounds;
        }
    }
}
