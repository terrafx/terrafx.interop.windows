// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D2D1_PROPERTY_TYPE;

namespace TerraFX.Interop
{
    [Guid("28211A43-7D89-476F-8181-2D6159B220AD")]
    public unsafe partial struct ID2D1Effect
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int SetValueByName([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
        {
            return SetValueByName(name, D2D1_PROPERTY_TYPE_UNKNOWN, data, dataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValue([NativeTypeName("UINT32")] uint index, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
        {
            return SetValue(index, D2D1_PROPERTY_TYPE_UNKNOWN, data, dataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValueByName([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
        {
            return GetValueByName(name, D2D1_PROPERTY_TYPE_UNKNOWN, data, dataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("UINT32")] uint index, [NativeTypeName("BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
        {
            return GetValue(index, D2D1_PROPERTY_TYPE_UNKNOWN, data, dataSize);
        }

        public void SetInputEffect([NativeTypeName("UINT32")] uint index, [NativeTypeName("ID2D1Effect *")] ID2D1Effect* inputEffect, [NativeTypeName("BOOL")] int invalidate = 1)
        {
            ID2D1Image* output = null;

            if (inputEffect != null)
            {
                inputEffect->GetOutput(&output);
            }

            SetInput(index, output, invalidate);
            if (output != null)
            {
                output->Release();
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID2D1Effect*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1Effect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID2D1Effect*, uint>)(lpVtbl[1]))((ID2D1Effect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID2D1Effect*, uint>)(lpVtbl[2]))((ID2D1Effect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetPropertyCount()
        {
            return ((delegate* stdcall<ID2D1Effect*, uint>)(lpVtbl[3]))((ID2D1Effect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyName([NativeTypeName("UINT32")] uint index, [NativeTypeName("PWSTR")] ushort* name, [NativeTypeName("UINT32")] uint nameCount)
        {
            return ((delegate* stdcall<ID2D1Effect*, uint, ushort*, uint, int>)(lpVtbl[4]))((ID2D1Effect*)Unsafe.AsPointer(ref this), index, name, nameCount);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetPropertyNameLength([NativeTypeName("UINT32")] uint index)
        {
            return ((delegate* stdcall<ID2D1Effect*, uint, uint>)(lpVtbl[5]))((ID2D1Effect*)Unsafe.AsPointer(ref this), index);
        }

        public D2D1_PROPERTY_TYPE GetType([NativeTypeName("UINT32")] uint index)
        {
            return ((delegate* stdcall<ID2D1Effect*, uint, D2D1_PROPERTY_TYPE>)(lpVtbl[6]))((ID2D1Effect*)Unsafe.AsPointer(ref this), index);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetPropertyIndex([NativeTypeName("PCWSTR")] ushort* name)
        {
            return ((delegate* stdcall<ID2D1Effect*, ushort*, uint>)(lpVtbl[7]))((ID2D1Effect*)Unsafe.AsPointer(ref this), name);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValueByName([NativeTypeName("PCWSTR")] ushort* name, D2D1_PROPERTY_TYPE type, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
        {
            return ((delegate* stdcall<ID2D1Effect*, ushort*, D2D1_PROPERTY_TYPE, byte*, uint, int>)(lpVtbl[8]))((ID2D1Effect*)Unsafe.AsPointer(ref this), name, type, data, dataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValue([NativeTypeName("UINT32")] uint index, D2D1_PROPERTY_TYPE type, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
        {
            return ((delegate* stdcall<ID2D1Effect*, uint, D2D1_PROPERTY_TYPE, byte*, uint, int>)(lpVtbl[9]))((ID2D1Effect*)Unsafe.AsPointer(ref this), index, type, data, dataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValueByName([NativeTypeName("PCWSTR")] ushort* name, D2D1_PROPERTY_TYPE type, [NativeTypeName("BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
        {
            return ((delegate* stdcall<ID2D1Effect*, ushort*, D2D1_PROPERTY_TYPE, byte*, uint, int>)(lpVtbl[10]))((ID2D1Effect*)Unsafe.AsPointer(ref this), name, type, data, dataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("UINT32")] uint index, D2D1_PROPERTY_TYPE type, [NativeTypeName("BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
        {
            return ((delegate* stdcall<ID2D1Effect*, uint, D2D1_PROPERTY_TYPE, byte*, uint, int>)(lpVtbl[11]))((ID2D1Effect*)Unsafe.AsPointer(ref this), index, type, data, dataSize);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetValueSize([NativeTypeName("UINT32")] uint index)
        {
            return ((delegate* stdcall<ID2D1Effect*, uint, uint>)(lpVtbl[12]))((ID2D1Effect*)Unsafe.AsPointer(ref this), index);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSubProperties([NativeTypeName("UINT32")] uint index, [NativeTypeName("ID2D1Properties **")] ID2D1Properties** subProperties)
        {
            return ((delegate* stdcall<ID2D1Effect*, uint, ID2D1Properties**, int>)(lpVtbl[13]))((ID2D1Effect*)Unsafe.AsPointer(ref this), index, subProperties);
        }

        public void SetInput([NativeTypeName("UINT32")] uint index, [NativeTypeName("ID2D1Image *")] ID2D1Image* input, [NativeTypeName("BOOL")] int invalidate = 1)
        {
            ((delegate* stdcall<ID2D1Effect*, uint, ID2D1Image*, int, void>)(lpVtbl[14]))((ID2D1Effect*)Unsafe.AsPointer(ref this), index, input, invalidate);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInputCount([NativeTypeName("UINT32")] uint inputCount)
        {
            return ((delegate* stdcall<ID2D1Effect*, uint, int>)(lpVtbl[15]))((ID2D1Effect*)Unsafe.AsPointer(ref this), inputCount);
        }

        public void GetInput([NativeTypeName("UINT32")] uint index, [NativeTypeName("ID2D1Image **")] ID2D1Image** input)
        {
            ((delegate* stdcall<ID2D1Effect*, uint, ID2D1Image**, void>)(lpVtbl[16]))((ID2D1Effect*)Unsafe.AsPointer(ref this), index, input);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetInputCount()
        {
            return ((delegate* stdcall<ID2D1Effect*, uint>)(lpVtbl[17]))((ID2D1Effect*)Unsafe.AsPointer(ref this));
        }

        public void GetOutput([NativeTypeName("ID2D1Image **")] ID2D1Image** outputImage)
        {
            ((delegate* stdcall<ID2D1Effect*, ID2D1Image**, void>)(lpVtbl[18]))((ID2D1Effect*)Unsafe.AsPointer(ref this), outputImage);
        }
    }
}
