// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("6F77C993-D2B1-446E-853E-5912EFC8A286")]
[NativeTypeName("struct ITfPreservedKeyNotifySink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfPreservedKeyNotifySink : ITfPreservedKeyNotifySink.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfPreservedKeyNotifySink*, Guid*, void**, int>)(lpVtbl[0]))((ITfPreservedKeyNotifySink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfPreservedKeyNotifySink*, uint>)(lpVtbl[1]))((ITfPreservedKeyNotifySink*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfPreservedKeyNotifySink*, uint>)(lpVtbl[2]))((ITfPreservedKeyNotifySink*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnUpdated([NativeTypeName("const TF_PRESERVEDKEY *")] TF_PRESERVEDKEY* pprekey)
    {
        return ((delegate* unmanaged<ITfPreservedKeyNotifySink*, TF_PRESERVEDKEY*, int>)(lpVtbl[3]))((ITfPreservedKeyNotifySink*)Unsafe.AsPointer(ref this), pprekey);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnUpdated([NativeTypeName("const TF_PRESERVEDKEY *")] TF_PRESERVEDKEY* pprekey);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ITfPreservedKeyNotifySink*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ITfPreservedKeyNotifySink*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ITfPreservedKeyNotifySink*, uint> Release;

        [NativeTypeName("HRESULT (const TF_PRESERVEDKEY *) __attribute__((stdcall))")]
        public delegate* unmanaged<ITfPreservedKeyNotifySink*, TF_PRESERVEDKEY*, int> OnUpdated;
    }
}
