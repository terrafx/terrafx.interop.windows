// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMFSampleOutputStream.xml' path='doc/member[@name="IMFSampleOutputStream"]/*' />
[Guid("8FEED468-6F7E-440D-869A-49BDD283AD0D")]
[NativeTypeName("struct IMFSampleOutputStream : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFSampleOutputStream : IMFSampleOutputStream.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSampleOutputStream));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFSampleOutputStream*, Guid*, void**, int>)(lpVtbl[0]))((IMFSampleOutputStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFSampleOutputStream*, uint>)(lpVtbl[1]))((IMFSampleOutputStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFSampleOutputStream*, uint>)(lpVtbl[2]))((IMFSampleOutputStream*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSampleOutputStream.xml' path='doc/member[@name="IMFSampleOutputStream.BeginWriteSample"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BeginWriteSample(IMFSample* pSample, IMFAsyncCallback* pCallback, IUnknown* punkState)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFSampleOutputStream*, IMFSample*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[3]))((IMFSampleOutputStream*)Unsafe.AsPointer(ref this), pSample, pCallback, punkState);
    }

    /// <include file='IMFSampleOutputStream.xml' path='doc/member[@name="IMFSampleOutputStream.EndWriteSample"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EndWriteSample(IMFAsyncResult* pResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFSampleOutputStream*, IMFAsyncResult*, int>)(lpVtbl[4]))((IMFSampleOutputStream*)Unsafe.AsPointer(ref this), pResult);
    }

    /// <include file='IMFSampleOutputStream.xml' path='doc/member[@name="IMFSampleOutputStream.Close"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFSampleOutputStream*, int>)(lpVtbl[5]))((IMFSampleOutputStream*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT BeginWriteSample(IMFSample* pSample, IMFAsyncCallback* pCallback, IUnknown* punkState);

        [VtblIndex(4)]
        HRESULT EndWriteSample(IMFAsyncResult* pResult);

        [VtblIndex(5)]
        HRESULT Close();
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

        [NativeTypeName("HRESULT (IMFSample *, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMFSample*, IMFAsyncCallback*, IUnknown*, int> BeginWriteSample;

        [NativeTypeName("HRESULT (IMFAsyncResult *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMFAsyncResult*, int> EndWriteSample;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Close;
    }
}
