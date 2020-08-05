// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("72755049-5FF7-435D-8348-4BE97CFA6C7C")]
    [NativeTypeName("struct IDWriteFontFileEnumerator : IUnknown")]
    public unsafe partial struct IDWriteFontFileEnumerator
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteFontFileEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontFileEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteFontFileEnumerator*, uint>)(lpVtbl[1]))((IDWriteFontFileEnumerator*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteFontFileEnumerator*, uint>)(lpVtbl[2]))((IDWriteFontFileEnumerator*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int MoveNext([NativeTypeName("BOOL *")] int* hasCurrentFile)
        {
            return ((delegate* stdcall<IDWriteFontFileEnumerator*, int*, int>)(lpVtbl[3]))((IDWriteFontFileEnumerator*)Unsafe.AsPointer(ref this), hasCurrentFile);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentFontFile([NativeTypeName("IDWriteFontFile **")] IDWriteFontFile** fontFile)
        {
            return ((delegate* stdcall<IDWriteFontFileEnumerator*, IDWriteFontFile**, int>)(lpVtbl[4]))((IDWriteFontFileEnumerator*)Unsafe.AsPointer(ref this), fontFile);
        }
    }
}
