// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C095E4F4-BB98-43D6-9745-4D1B84EC9888")]
    public unsafe partial struct ID2D1SvgPathData
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1SvgPathData*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1SvgPathData*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            lpVtbl->GetFactory((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), factory);
        }

        public void GetElement([NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** element)
        {
            lpVtbl->GetElement((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), element);
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("ID2D1SvgAttribute **")] ID2D1SvgAttribute** attribute)
        {
            return lpVtbl->Clone((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), attribute);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveSegmentDataAtEnd([NativeTypeName("UINT32")] uint dataCount)
        {
            return lpVtbl->RemoveSegmentDataAtEnd((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), dataCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateSegmentData([NativeTypeName("const FLOAT *")] float* data, [NativeTypeName("UINT32")] uint dataCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            return lpVtbl->UpdateSegmentData((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), data, dataCount, startIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSegmentData([NativeTypeName("FLOAT *")] float* data, [NativeTypeName("UINT32")] uint dataCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            return lpVtbl->GetSegmentData((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), data, dataCount, startIndex);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetSegmentDataCount()
        {
            return lpVtbl->GetSegmentDataCount((ID2D1SvgPathData*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveCommandsAtEnd([NativeTypeName("UINT32")] uint commandsCount)
        {
            return lpVtbl->RemoveCommandsAtEnd((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), commandsCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateCommands([NativeTypeName("const D2D1_SVG_PATH_COMMAND *")] D2D1_SVG_PATH_COMMAND* commands, [NativeTypeName("UINT32")] uint commandsCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            return lpVtbl->UpdateCommands((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), commands, commandsCount, startIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCommands([NativeTypeName("D2D1_SVG_PATH_COMMAND *")] D2D1_SVG_PATH_COMMAND* commands, [NativeTypeName("UINT32")] uint commandsCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            return lpVtbl->GetCommands((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), commands, commandsCount, startIndex);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetCommandsCount()
        {
            return lpVtbl->GetCommandsCount((ID2D1SvgPathData*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePathGeometry(D2D1_FILL_MODE fillMode, [NativeTypeName("ID2D1PathGeometry1 **")] ID2D1PathGeometry1** pathGeometry)
        {
            return lpVtbl->CreatePathGeometry((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), fillMode, pathGeometry);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPathData*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPathData*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPathData*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPathData*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("void (ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPathData*, ID2D1SvgElement**, void> GetElement;

            [NativeTypeName("HRESULT (ID2D1SvgAttribute **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPathData*, ID2D1SvgAttribute**, int> Clone;

            [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPathData*, uint, int> RemoveSegmentDataAtEnd;

            [NativeTypeName("HRESULT (const FLOAT *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPathData*, float*, uint, uint, int> UpdateSegmentData;

            [NativeTypeName("HRESULT (FLOAT *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPathData*, float*, uint, uint, int> GetSegmentData;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPathData*, uint> GetSegmentDataCount;

            [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPathData*, uint, int> RemoveCommandsAtEnd;

            [NativeTypeName("HRESULT (const D2D1_SVG_PATH_COMMAND *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPathData*, D2D1_SVG_PATH_COMMAND*, uint, uint, int> UpdateCommands;

            [NativeTypeName("HRESULT (D2D1_SVG_PATH_COMMAND *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPathData*, D2D1_SVG_PATH_COMMAND*, uint, uint, int> GetCommands;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPathData*, uint> GetCommandsCount;

            [NativeTypeName("HRESULT (D2D1_FILL_MODE, ID2D1PathGeometry1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SvgPathData*, D2D1_FILL_MODE, ID2D1PathGeometry1**, int> CreatePathGeometry;
        }
    }
}
