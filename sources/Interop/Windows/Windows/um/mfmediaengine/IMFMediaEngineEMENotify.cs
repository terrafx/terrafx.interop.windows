// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMFMediaEngineEMENotify.xml' path='doc/member[@name="IMFMediaEngineEMENotify"]/*' />
[Guid("9E184D15-CDB7-4F86-B49E-566689F4A601")]
[NativeTypeName("struct IMFMediaEngineEMENotify : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMediaEngineEMENotify : IMFMediaEngineEMENotify.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaEngineEMENotify));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMediaEngineEMENotify*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineEMENotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMediaEngineEMENotify*, uint>)(lpVtbl[1]))((IMFMediaEngineEMENotify*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMediaEngineEMENotify*, uint>)(lpVtbl[2]))((IMFMediaEngineEMENotify*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngineEMENotify.xml' path='doc/member[@name="IMFMediaEngineEMENotify.Encrypted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void Encrypted([NativeTypeName("const BYTE *")] byte* pbInitData, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("BSTR")] char* bstrInitDataType)
    {
        ((delegate* unmanaged[MemberFunction]<IMFMediaEngineEMENotify*, byte*, uint, char*, void>)(lpVtbl[3]))((IMFMediaEngineEMENotify*)Unsafe.AsPointer(ref this), pbInitData, cb, bstrInitDataType);
    }

    /// <include file='IMFMediaEngineEMENotify.xml' path='doc/member[@name="IMFMediaEngineEMENotify.WaitingForKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void WaitingForKey()
    {
        ((delegate* unmanaged[MemberFunction]<IMFMediaEngineEMENotify*, void>)(lpVtbl[4]))((IMFMediaEngineEMENotify*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void Encrypted([NativeTypeName("const BYTE *")] byte* pbInitData, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("BSTR")] char* bstrInitDataType);

        [VtblIndex(4)]
        void WaitingForKey();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("void (const BYTE *, DWORD, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, uint, char*, void> Encrypted;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> WaitingForKey;
    }
}
