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
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID2D1SvgPathData*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID2D1SvgPathData*, uint>)(lpVtbl[1]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID2D1SvgPathData*, uint>)(lpVtbl[2]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* stdcall<ID2D1SvgPathData*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), factory);
        }

        public void GetElement([NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** element)
        {
            ((delegate* stdcall<ID2D1SvgPathData*, ID2D1SvgElement**, void>)(lpVtbl[4]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), element);
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("ID2D1SvgAttribute **")] ID2D1SvgAttribute** attribute)
        {
            return ((delegate* stdcall<ID2D1SvgPathData*, ID2D1SvgAttribute**, int>)(lpVtbl[5]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), attribute);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveSegmentDataAtEnd([NativeTypeName("UINT32")] uint dataCount)
        {
            return ((delegate* stdcall<ID2D1SvgPathData*, uint, int>)(lpVtbl[6]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), dataCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateSegmentData([NativeTypeName("const FLOAT *")] float* data, [NativeTypeName("UINT32")] uint dataCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            return ((delegate* stdcall<ID2D1SvgPathData*, float*, uint, uint, int>)(lpVtbl[7]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), data, dataCount, startIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSegmentData([NativeTypeName("FLOAT *")] float* data, [NativeTypeName("UINT32")] uint dataCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            return ((delegate* stdcall<ID2D1SvgPathData*, float*, uint, uint, int>)(lpVtbl[8]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), data, dataCount, startIndex);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetSegmentDataCount()
        {
            return ((delegate* stdcall<ID2D1SvgPathData*, uint>)(lpVtbl[9]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveCommandsAtEnd([NativeTypeName("UINT32")] uint commandsCount)
        {
            return ((delegate* stdcall<ID2D1SvgPathData*, uint, int>)(lpVtbl[10]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), commandsCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateCommands([NativeTypeName("const D2D1_SVG_PATH_COMMAND *")] D2D1_SVG_PATH_COMMAND* commands, [NativeTypeName("UINT32")] uint commandsCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            return ((delegate* stdcall<ID2D1SvgPathData*, D2D1_SVG_PATH_COMMAND*, uint, uint, int>)(lpVtbl[11]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), commands, commandsCount, startIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCommands([NativeTypeName("D2D1_SVG_PATH_COMMAND *")] D2D1_SVG_PATH_COMMAND* commands, [NativeTypeName("UINT32")] uint commandsCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            return ((delegate* stdcall<ID2D1SvgPathData*, D2D1_SVG_PATH_COMMAND*, uint, uint, int>)(lpVtbl[12]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), commands, commandsCount, startIndex);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetCommandsCount()
        {
            return ((delegate* stdcall<ID2D1SvgPathData*, uint>)(lpVtbl[13]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePathGeometry(D2D1_FILL_MODE fillMode, [NativeTypeName("ID2D1PathGeometry1 **")] ID2D1PathGeometry1** pathGeometry)
        {
            return ((delegate* stdcall<ID2D1SvgPathData*, D2D1_FILL_MODE, ID2D1PathGeometry1**, int>)(lpVtbl[14]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), fillMode, pathGeometry);
        }
    }
}
