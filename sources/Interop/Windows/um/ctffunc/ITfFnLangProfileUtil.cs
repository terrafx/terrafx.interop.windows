// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A87A8574-A6C1-4E15-99F0-3D3965F548EB")]
    [NativeTypeName("struct ITfFnLangProfileUtil : ITfFunction")]
    [NativeInheritance("ITfFunction")]
    public unsafe partial struct ITfFnLangProfileUtil
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfFnLangProfileUtil*, Guid*, void**, int>)(lpVtbl[0]))((ITfFnLangProfileUtil*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfFnLangProfileUtil*, uint>)(lpVtbl[1]))((ITfFnLangProfileUtil*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfFnLangProfileUtil*, uint>)(lpVtbl[2]))((ITfFnLangProfileUtil*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<ITfFnLangProfileUtil*, ushort**, int>)(lpVtbl[3]))((ITfFnLangProfileUtil*)Unsafe.AsPointer(ref this), pbstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterActiveProfiles()
        {
            return ((delegate* unmanaged<ITfFnLangProfileUtil*, int>)(lpVtbl[4]))((ITfFnLangProfileUtil*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int IsProfileAvailableForLang([NativeTypeName("LANGID")] ushort langid, [NativeTypeName("BOOL *")] int* pfAvailable)
        {
            return ((delegate* unmanaged<ITfFnLangProfileUtil*, ushort, int*, int>)(lpVtbl[5]))((ITfFnLangProfileUtil*)Unsafe.AsPointer(ref this), langid, pfAvailable);
        }
    }
}
