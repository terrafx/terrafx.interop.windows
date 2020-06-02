// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("08256209-099A-4B34-B86D-C22B110E7771")]
    public unsafe partial struct IDWriteLocalizedStrings
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDWriteLocalizedStrings*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDWriteLocalizedStrings*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDWriteLocalizedStrings*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetCount()
        {
            return lpVtbl->GetCount((IDWriteLocalizedStrings*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int FindLocaleName([NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("UINT32 *")] uint* index, [NativeTypeName("BOOL *")] int* exists)
        {
            return lpVtbl->FindLocaleName((IDWriteLocalizedStrings*)Unsafe.AsPointer(ref this), localeName, index, exists);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleNameLength([NativeTypeName("UINT32")] uint index, [NativeTypeName("UINT32 *")] uint* length)
        {
            return lpVtbl->GetLocaleNameLength((IDWriteLocalizedStrings*)Unsafe.AsPointer(ref this), index, length);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("UINT32")] uint index, [NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint size)
        {
            return lpVtbl->GetLocaleName((IDWriteLocalizedStrings*)Unsafe.AsPointer(ref this), index, localeName, size);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStringLength([NativeTypeName("UINT32")] uint index, [NativeTypeName("UINT32 *")] uint* length)
        {
            return lpVtbl->GetStringLength((IDWriteLocalizedStrings*)Unsafe.AsPointer(ref this), index, length);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetString([NativeTypeName("UINT32")] uint index, [NativeTypeName("WCHAR *")] ushort* stringBuffer, [NativeTypeName("UINT32")] uint size)
        {
            return lpVtbl->GetString((IDWriteLocalizedStrings*)Unsafe.AsPointer(ref this), index, stringBuffer, size);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteLocalizedStrings*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteLocalizedStrings*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteLocalizedStrings*, uint> Release;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteLocalizedStrings*, uint> GetCount;

            [NativeTypeName("HRESULT (const WCHAR *, UINT32 *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteLocalizedStrings*, ushort*, uint*, int*, int> FindLocaleName;

            [NativeTypeName("HRESULT (UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteLocalizedStrings*, uint, uint*, int> GetLocaleNameLength;

            [NativeTypeName("HRESULT (UINT32, WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteLocalizedStrings*, uint, ushort*, uint, int> GetLocaleName;

            [NativeTypeName("HRESULT (UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteLocalizedStrings*, uint, uint*, int> GetStringLength;

            [NativeTypeName("HRESULT (UINT32, WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteLocalizedStrings*, uint, ushort*, uint, int> GetString;
        }
    }
}
