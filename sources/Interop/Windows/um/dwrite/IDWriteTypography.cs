// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("55F1112B-1DC2-4B3C-9541-F46894ED85B6")]
    public unsafe partial struct IDWriteTypography
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDWriteTypography*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDWriteTypography*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDWriteTypography*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFontFeature(DWRITE_FONT_FEATURE fontFeature)
        {
            return lpVtbl->AddFontFeature((IDWriteTypography*)Unsafe.AsPointer(ref this), fontFeature);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontFeatureCount()
        {
            return lpVtbl->GetFontFeatureCount((IDWriteTypography*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFeature([NativeTypeName("UINT32")] uint fontFeatureIndex, [NativeTypeName("DWRITE_FONT_FEATURE *")] DWRITE_FONT_FEATURE* fontFeature)
        {
            return lpVtbl->GetFontFeature((IDWriteTypography*)Unsafe.AsPointer(ref this), fontFeatureIndex, fontFeature);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTypography*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTypography*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTypography*, uint> Release;

            [NativeTypeName("HRESULT (DWRITE_FONT_FEATURE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTypography*, DWRITE_FONT_FEATURE, int> AddFontFeature;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTypography*, uint> GetFontFeatureCount;

            [NativeTypeName("HRESULT (UINT32, DWRITE_FONT_FEATURE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTypography*, uint, DWRITE_FONT_FEATURE*, int> GetFontFeature;
        }
    }
}
