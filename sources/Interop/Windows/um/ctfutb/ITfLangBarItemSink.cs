// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("57DBE1A0-DE25-11D2-AFDD-00105A2799B5")]
    [NativeTypeName("struct ITfLangBarItemSink : IUnknown")]
    public unsafe partial struct ITfLangBarItemSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfLangBarItemSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfLangBarItemSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfLangBarItemSink*, uint>)(lpVtbl[1]))((ITfLangBarItemSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfLangBarItemSink*, uint>)(lpVtbl[2]))((ITfLangBarItemSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnUpdate([NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITfLangBarItemSink*, uint, int>)(lpVtbl[3]))((ITfLangBarItemSink*)Unsafe.AsPointer(ref this), dwFlags);
        }
    }
}
