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
        public Vtbl* lpVtbl;

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
            return lpVtbl->QueryInterface((ID2D1Effect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1Effect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1Effect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetPropertyCount()
        {
            return lpVtbl->GetPropertyCount((ID2D1Effect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyName([NativeTypeName("UINT32")] uint index, [NativeTypeName("PWSTR")] ushort* name, [NativeTypeName("UINT32")] uint nameCount)
        {
            return lpVtbl->GetPropertyName((ID2D1Effect*)Unsafe.AsPointer(ref this), index, name, nameCount);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetPropertyNameLength([NativeTypeName("UINT32")] uint index)
        {
            return lpVtbl->GetPropertyNameLength((ID2D1Effect*)Unsafe.AsPointer(ref this), index);
        }

        public D2D1_PROPERTY_TYPE GetType([NativeTypeName("UINT32")] uint index)
        {
            return lpVtbl->GetType((ID2D1Effect*)Unsafe.AsPointer(ref this), index);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetPropertyIndex([NativeTypeName("PCWSTR")] ushort* name)
        {
            return lpVtbl->GetPropertyIndex((ID2D1Effect*)Unsafe.AsPointer(ref this), name);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValueByName([NativeTypeName("PCWSTR")] ushort* name, D2D1_PROPERTY_TYPE type, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
        {
            return lpVtbl->SetValueByName((ID2D1Effect*)Unsafe.AsPointer(ref this), name, type, data, dataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValue([NativeTypeName("UINT32")] uint index, D2D1_PROPERTY_TYPE type, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
        {
            return lpVtbl->SetValue((ID2D1Effect*)Unsafe.AsPointer(ref this), index, type, data, dataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValueByName([NativeTypeName("PCWSTR")] ushort* name, D2D1_PROPERTY_TYPE type, [NativeTypeName("BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
        {
            return lpVtbl->GetValueByName((ID2D1Effect*)Unsafe.AsPointer(ref this), name, type, data, dataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("UINT32")] uint index, D2D1_PROPERTY_TYPE type, [NativeTypeName("BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
        {
            return lpVtbl->GetValue((ID2D1Effect*)Unsafe.AsPointer(ref this), index, type, data, dataSize);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetValueSize([NativeTypeName("UINT32")] uint index)
        {
            return lpVtbl->GetValueSize((ID2D1Effect*)Unsafe.AsPointer(ref this), index);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSubProperties([NativeTypeName("UINT32")] uint index, [NativeTypeName("ID2D1Properties **")] ID2D1Properties** subProperties)
        {
            return lpVtbl->GetSubProperties((ID2D1Effect*)Unsafe.AsPointer(ref this), index, subProperties);
        }

        public void SetInput([NativeTypeName("UINT32")] uint index, [NativeTypeName("ID2D1Image *")] ID2D1Image* input, [NativeTypeName("BOOL")] int invalidate = 1)
        {
            lpVtbl->SetInput((ID2D1Effect*)Unsafe.AsPointer(ref this), index, input, invalidate);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInputCount([NativeTypeName("UINT32")] uint inputCount)
        {
            return lpVtbl->SetInputCount((ID2D1Effect*)Unsafe.AsPointer(ref this), inputCount);
        }

        public void GetInput([NativeTypeName("UINT32")] uint index, [NativeTypeName("ID2D1Image **")] ID2D1Image** input)
        {
            lpVtbl->GetInput((ID2D1Effect*)Unsafe.AsPointer(ref this), index, input);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetInputCount()
        {
            return lpVtbl->GetInputCount((ID2D1Effect*)Unsafe.AsPointer(ref this));
        }

        public void GetOutput([NativeTypeName("ID2D1Image **")] ID2D1Image** outputImage)
        {
            lpVtbl->GetOutput((ID2D1Effect*)Unsafe.AsPointer(ref this), outputImage);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Effect*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Effect*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Effect*, uint> Release;

            [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Effect*, uint> GetPropertyCount;

            [NativeTypeName("HRESULT (UINT32, PWSTR, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Effect*, uint, ushort*, uint, int> GetPropertyName;

            [NativeTypeName("UINT32 (UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Effect*, uint, uint> GetPropertyNameLength;

            [NativeTypeName("D2D1_PROPERTY_TYPE (UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public new delegate* stdcall<ID2D1Effect*, uint, D2D1_PROPERTY_TYPE> GetType;

            [NativeTypeName("UINT32 (PCWSTR) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Effect*, ushort*, uint> GetPropertyIndex;

            [NativeTypeName("HRESULT (PCWSTR, D2D1_PROPERTY_TYPE, const BYTE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Effect*, ushort*, D2D1_PROPERTY_TYPE, byte*, uint, int> SetValueByName;

            [NativeTypeName("HRESULT (UINT32, D2D1_PROPERTY_TYPE, const BYTE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Effect*, uint, D2D1_PROPERTY_TYPE, byte*, uint, int> SetValue;

            [NativeTypeName("HRESULT (PCWSTR, D2D1_PROPERTY_TYPE, BYTE *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Effect*, ushort*, D2D1_PROPERTY_TYPE, byte*, uint, int> GetValueByName;

            [NativeTypeName("HRESULT (UINT32, D2D1_PROPERTY_TYPE, BYTE *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Effect*, uint, D2D1_PROPERTY_TYPE, byte*, uint, int> GetValue;

            [NativeTypeName("UINT32 (UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Effect*, uint, uint> GetValueSize;

            [NativeTypeName("HRESULT (UINT32, ID2D1Properties **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Effect*, uint, ID2D1Properties**, int> GetSubProperties;

            [NativeTypeName("void (UINT32, ID2D1Image *, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Effect*, uint, ID2D1Image*, int, void> SetInput;

            [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Effect*, uint, int> SetInputCount;

            [NativeTypeName("void (UINT32, ID2D1Image **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Effect*, uint, ID2D1Image**, void> GetInput;

            [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Effect*, uint> GetInputCount;

            [NativeTypeName("void (ID2D1Image **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Effect*, ID2D1Image**, void> GetOutput;
        }
    }
}
