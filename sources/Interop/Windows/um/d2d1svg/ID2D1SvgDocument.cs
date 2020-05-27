// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("86B88E4D-AFA4-4D7B-88E4-68A51C4A0AEC")]
    public unsafe partial struct ID2D1SvgDocument
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1SvgDocument* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1SvgDocument* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1SvgDocument* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetFactory(ID2D1SvgDocument* pThis, [NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetViewportSize(ID2D1SvgDocument* pThis, [NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F viewportSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("D2D1_SIZE_F")]
        public delegate D2D_SIZE_F* _GetViewportSize(ID2D1SvgDocument* pThis, D2D_SIZE_F* _result);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetRoot(ID2D1SvgDocument* pThis, [NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* root);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetRoot(ID2D1SvgDocument* pThis, [NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** root);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FindElementById(ID2D1SvgDocument* pThis, [NativeTypeName("PCWSTR")] ushort* id, [NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** svgElement);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Serialize(ID2D1SvgDocument* pThis, [NativeTypeName("IStream *")] IStream* outputXmlStream, [NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* subtree = null);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Deserialize(ID2D1SvgDocument* pThis, [NativeTypeName("IStream *")] IStream* inputXmlStream, [NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** subtree);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePaint(ID2D1SvgDocument* pThis, D2D1_SVG_PAINT_TYPE paintType, [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color, [NativeTypeName("PCWSTR")] ushort* id, [NativeTypeName("ID2D1SvgPaint **")] ID2D1SvgPaint** paint);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateStrokeDashArray(ID2D1SvgDocument* pThis, [NativeTypeName("const D2D1_SVG_LENGTH *")] D2D1_SVG_LENGTH* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("ID2D1SvgStrokeDashArray **")] ID2D1SvgStrokeDashArray** strokeDashArray);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePointCollection(ID2D1SvgDocument* pThis, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount, [NativeTypeName("ID2D1SvgPointCollection **")] ID2D1SvgPointCollection** pointCollection);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePathData(ID2D1SvgDocument* pThis, [NativeTypeName("const FLOAT *")] float* segmentData, [NativeTypeName("UINT32")] uint segmentDataCount, [NativeTypeName("const D2D1_SVG_PATH_COMMAND *")] D2D1_SVG_PATH_COMMAND* commands, [NativeTypeName("UINT32")] uint commandsCount, [NativeTypeName("ID2D1SvgPathData **")] ID2D1SvgPathData** pathData);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1SvgDocument*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1SvgDocument*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), factory);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetViewportSize([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F viewportSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetViewportSize>(lpVtbl->SetViewportSize)((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), viewportSize);
        }

        [return: NativeTypeName("D2D1_SIZE_F")]
        public D2D_SIZE_F GetViewportSize()
        {
            D2D_SIZE_F result;
            return *Marshal.GetDelegateForFunctionPointer<_GetViewportSize>(lpVtbl->GetViewportSize)((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), &result);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRoot([NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* root)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetRoot>(lpVtbl->SetRoot)((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), root);
        }

        public void GetRoot([NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** root)
        {
            Marshal.GetDelegateForFunctionPointer<_GetRoot>(lpVtbl->GetRoot)((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), root);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindElementById([NativeTypeName("PCWSTR")] ushort* id, [NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** svgElement)
        {
            return Marshal.GetDelegateForFunctionPointer<_FindElementById>(lpVtbl->FindElementById)((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), id, svgElement);
        }

        [return: NativeTypeName("HRESULT")]
        public int Serialize([NativeTypeName("IStream *")] IStream* outputXmlStream, [NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* subtree = null)
        {
            return Marshal.GetDelegateForFunctionPointer<_Serialize>(lpVtbl->Serialize)((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), outputXmlStream, subtree);
        }

        [return: NativeTypeName("HRESULT")]
        public int Deserialize([NativeTypeName("IStream *")] IStream* inputXmlStream, [NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** subtree)
        {
            return Marshal.GetDelegateForFunctionPointer<_Deserialize>(lpVtbl->Deserialize)((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), inputXmlStream, subtree);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePaint(D2D1_SVG_PAINT_TYPE paintType, [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color, [NativeTypeName("PCWSTR")] ushort* id, [NativeTypeName("ID2D1SvgPaint **")] ID2D1SvgPaint** paint)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreatePaint>(lpVtbl->CreatePaint)((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), paintType, color, id, paint);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStrokeDashArray([NativeTypeName("const D2D1_SVG_LENGTH *")] D2D1_SVG_LENGTH* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("ID2D1SvgStrokeDashArray **")] ID2D1SvgStrokeDashArray** strokeDashArray)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateStrokeDashArray>(lpVtbl->CreateStrokeDashArray)((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), dashes, dashesCount, strokeDashArray);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePointCollection([NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount, [NativeTypeName("ID2D1SvgPointCollection **")] ID2D1SvgPointCollection** pointCollection)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreatePointCollection>(lpVtbl->CreatePointCollection)((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), points, pointsCount, pointCollection);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePathData([NativeTypeName("const FLOAT *")] float* segmentData, [NativeTypeName("UINT32")] uint segmentDataCount, [NativeTypeName("const D2D1_SVG_PATH_COMMAND *")] D2D1_SVG_PATH_COMMAND* commands, [NativeTypeName("UINT32")] uint commandsCount, [NativeTypeName("ID2D1SvgPathData **")] ID2D1SvgPathData** pathData)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreatePathData>(lpVtbl->CreatePathData)((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), segmentData, segmentDataCount, commands, commandsCount, pathData);
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

            [NativeTypeName("HRESULT (D2D1_SIZE_F) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetViewportSize;

            [NativeTypeName("D2D1_SIZE_F () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetViewportSize;

            [NativeTypeName("HRESULT (ID2D1SvgElement *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetRoot;

            [NativeTypeName("void (ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetRoot;

            [NativeTypeName("HRESULT (PCWSTR, ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr FindElementById;

            [NativeTypeName("HRESULT (IStream *, ID2D1SvgElement *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Serialize;

            [NativeTypeName("HRESULT (IStream *, ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Deserialize;

            [NativeTypeName("HRESULT (D2D1_SVG_PAINT_TYPE, const D2D1_COLOR_F *, PCWSTR, ID2D1SvgPaint **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreatePaint;

            [NativeTypeName("HRESULT (const D2D1_SVG_LENGTH *, UINT32, ID2D1SvgStrokeDashArray **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateStrokeDashArray;

            [NativeTypeName("HRESULT (const D2D1_POINT_2F *, UINT32, ID2D1SvgPointCollection **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreatePointCollection;

            [NativeTypeName("HRESULT (const FLOAT *, UINT32, const D2D1_SVG_PATH_COMMAND *, UINT32, ID2D1SvgPathData **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreatePathData;
        }
    }
}
