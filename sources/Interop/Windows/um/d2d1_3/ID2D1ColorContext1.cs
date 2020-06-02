// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1AB42875-C57F-4BE9-BD85-9CD78D6F55EE")]
    public unsafe partial struct ID2D1ColorContext1
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1ColorContext1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1ColorContext1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1ColorContext1*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            lpVtbl->GetFactory((ID2D1ColorContext1*)Unsafe.AsPointer(ref this), factory);
        }

        public D2D1_COLOR_SPACE GetColorSpace()
        {
            return lpVtbl->GetColorSpace((ID2D1ColorContext1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetProfileSize()
        {
            return lpVtbl->GetProfileSize((ID2D1ColorContext1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProfile([NativeTypeName("BYTE *")] byte* profile, [NativeTypeName("UINT32")] uint profileSize)
        {
            return lpVtbl->GetProfile((ID2D1ColorContext1*)Unsafe.AsPointer(ref this), profile, profileSize);
        }

        public D2D1_COLOR_CONTEXT_TYPE GetColorContextType()
        {
            return lpVtbl->GetColorContextType((ID2D1ColorContext1*)Unsafe.AsPointer(ref this));
        }

        public DXGI_COLOR_SPACE_TYPE GetDXGIColorSpace()
        {
            return lpVtbl->GetDXGIColorSpace((ID2D1ColorContext1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSimpleColorProfile([NativeTypeName("D2D1_SIMPLE_COLOR_PROFILE *")] D2D1_SIMPLE_COLOR_PROFILE* simpleProfile)
        {
            return lpVtbl->GetSimpleColorProfile((ID2D1ColorContext1*)Unsafe.AsPointer(ref this), simpleProfile);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ColorContext1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ColorContext1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ColorContext1*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ColorContext1*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("D2D1_COLOR_SPACE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ColorContext1*, D2D1_COLOR_SPACE> GetColorSpace;

            [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ColorContext1*, uint> GetProfileSize;

            [NativeTypeName("HRESULT (BYTE *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ColorContext1*, byte*, uint, int> GetProfile;

            [NativeTypeName("D2D1_COLOR_CONTEXT_TYPE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ColorContext1*, D2D1_COLOR_CONTEXT_TYPE> GetColorContextType;

            [NativeTypeName("DXGI_COLOR_SPACE_TYPE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ColorContext1*, DXGI_COLOR_SPACE_TYPE> GetDXGIColorSpace;

            [NativeTypeName("HRESULT (D2D1_SIMPLE_COLOR_PROFILE *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ColorContext1*, D2D1_SIMPLE_COLOR_PROFILE*, int> GetSimpleColorProfile;
        }
    }
}
