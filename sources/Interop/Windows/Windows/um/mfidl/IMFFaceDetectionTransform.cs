// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMFFaceDetectionTransform.xml' path='doc/member[@name="IMFFaceDetectionTransform"]/*' />
[Guid("DDD59578-D0E7-46E2-BE8C-1CE76AD147C0")]
[NativeTypeName("struct IMFFaceDetectionTransform : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFFaceDetectionTransform : IMFFaceDetectionTransform.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFFaceDetectionTransform));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFFaceDetectionTransform*, Guid*, void**, int>)(lpVtbl[0]))((IMFFaceDetectionTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFFaceDetectionTransform*, uint>)(lpVtbl[1]))((IMFFaceDetectionTransform*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFFaceDetectionTransform*, uint>)(lpVtbl[2]))((IMFFaceDetectionTransform*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFFaceDetectionTransform.xml' path='doc/member[@name="IMFFaceDetectionTransform.SetDetectionCallback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetDetectionCallback(IMFFaceDetectionTransformCallback* callback, void** callbackToken)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFFaceDetectionTransform*, IMFFaceDetectionTransformCallback*, void**, int>)(lpVtbl[3]))((IMFFaceDetectionTransform*)Unsafe.AsPointer(ref this), callback, callbackToken);
    }

    /// <include file='IMFFaceDetectionTransform.xml' path='doc/member[@name="IMFFaceDetectionTransform.ClearDetectionCallback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ClearDetectionCallback(void* callbackToken)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFFaceDetectionTransform*, void*, int>)(lpVtbl[4]))((IMFFaceDetectionTransform*)Unsafe.AsPointer(ref this), callbackToken);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetDetectionCallback(IMFFaceDetectionTransformCallback* callback, void** callbackToken);

        [VtblIndex(4)]
        HRESULT ClearDetectionCallback(void* callbackToken);
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

        [NativeTypeName("HRESULT (IMFFaceDetectionTransformCallback *, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMFFaceDetectionTransformCallback*, void**, int> SetDetectionCallback;

        [NativeTypeName("HRESULT (void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, int> ClearDetectionCallback;
    }
}
