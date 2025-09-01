// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMFSourceBufferNotify.xml' path='doc/member[@name="IMFSourceBufferNotify"]/*' />
[Guid("87E47623-2CEB-45D6-9B88-D8520C4DCBBC")]
[NativeTypeName("struct IMFSourceBufferNotify : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IMFSourceBufferNotify : IMFSourceBufferNotify.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMFSourceBufferNotify);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFSourceBufferNotify*, Guid*, void**, int>)(lpVtbl[0]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFSourceBufferNotify*, uint>)(lpVtbl[1]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFSourceBufferNotify*, uint>)(lpVtbl[2]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSourceBufferNotify.xml' path='doc/member[@name="IMFSourceBufferNotify.OnUpdateStart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void OnUpdateStart()
    {
        ((delegate* unmanaged[MemberFunction]<IMFSourceBufferNotify*, void>)(lpVtbl[3]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSourceBufferNotify.xml' path='doc/member[@name="IMFSourceBufferNotify.OnAbort"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void OnAbort()
    {
        ((delegate* unmanaged[MemberFunction]<IMFSourceBufferNotify*, void>)(lpVtbl[4]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSourceBufferNotify.xml' path='doc/member[@name="IMFSourceBufferNotify.OnError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void OnError(HRESULT hr)
    {
        ((delegate* unmanaged[MemberFunction]<IMFSourceBufferNotify*, HRESULT, void>)(lpVtbl[5]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this), hr);
    }

    /// <include file='IMFSourceBufferNotify.xml' path='doc/member[@name="IMFSourceBufferNotify.OnUpdate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void OnUpdate()
    {
        ((delegate* unmanaged[MemberFunction]<IMFSourceBufferNotify*, void>)(lpVtbl[6]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSourceBufferNotify.xml' path='doc/member[@name="IMFSourceBufferNotify.OnUpdateEnd"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void OnUpdateEnd()
    {
        ((delegate* unmanaged[MemberFunction]<IMFSourceBufferNotify*, void>)(lpVtbl[7]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void OnUpdateStart();

        [VtblIndex(4)]
        void OnAbort();

        [VtblIndex(5)]
        void OnError(HRESULT hr);

        [VtblIndex(6)]
        void OnUpdate();

        [VtblIndex(7)]
        void OnUpdateEnd();
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

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> OnUpdateStart;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> OnAbort;

        [NativeTypeName("void (HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT, void> OnError;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> OnUpdate;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> OnUpdateEnd;
    }
}
