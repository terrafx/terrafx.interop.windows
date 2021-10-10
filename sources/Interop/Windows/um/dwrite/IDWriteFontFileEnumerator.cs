// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("72755049-5FF7-435D-8348-4BE97CFA6C7C")]
    [NativeTypeName("struct IDWriteFontFileEnumerator : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDWriteFontFileEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteFontFileEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontFileEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteFontFileEnumerator*, uint>)(lpVtbl[1]))((IDWriteFontFileEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteFontFileEnumerator*, uint>)(lpVtbl[2]))((IDWriteFontFileEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int MoveNext([NativeTypeName("BOOL *")] int* hasCurrentFile)
        {
            return ((delegate* unmanaged<IDWriteFontFileEnumerator*, int*, int>)(lpVtbl[3]))((IDWriteFontFileEnumerator*)Unsafe.AsPointer(ref this), hasCurrentFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentFontFile(IDWriteFontFile** fontFile)
        {
            return ((delegate* unmanaged<IDWriteFontFileEnumerator*, IDWriteFontFile**, int>)(lpVtbl[4]))((IDWriteFontFileEnumerator*)Unsafe.AsPointer(ref this), fontFile);
        }
    }
}
