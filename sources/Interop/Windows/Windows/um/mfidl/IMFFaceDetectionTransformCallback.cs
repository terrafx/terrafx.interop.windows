// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMFFaceDetectionTransformCallback.xml' path='doc/member[@name="IMFFaceDetectionTransformCallback"]/*' />
[Guid("0BFD1ADE-0421-4909-ACB7-7A7125416881")]
[NativeTypeName("struct IMFFaceDetectionTransformCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFFaceDetectionTransformCallback : IMFFaceDetectionTransformCallback.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFFaceDetectionTransformCallback));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFFaceDetectionTransformCallback*, Guid*, void**, int>)(lpVtbl[0]))((IMFFaceDetectionTransformCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFFaceDetectionTransformCallback*, uint>)(lpVtbl[1]))((IMFFaceDetectionTransformCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFFaceDetectionTransformCallback*, uint>)(lpVtbl[2]))((IMFFaceDetectionTransformCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFFaceDetectionTransformCallback.xml' path='doc/member[@name="IMFFaceDetectionTransformCallback.OnFaceDetectionResult"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void OnFaceDetectionResult([NativeTypeName("ULONG")] uint countOfBounds, DetectedFaceBound* detectedFaceBounds)
    {
        ((delegate* unmanaged[MemberFunction]<IMFFaceDetectionTransformCallback*, uint, DetectedFaceBound*, void>)(lpVtbl[3]))((IMFFaceDetectionTransformCallback*)Unsafe.AsPointer(ref this), countOfBounds, detectedFaceBounds);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void OnFaceDetectionResult([NativeTypeName("ULONG")] uint countOfBounds, DetectedFaceBound* detectedFaceBounds);
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

        [NativeTypeName("void (ULONG, DetectedFaceBound *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, DetectedFaceBound*, void> OnFaceDetectionResult;
    }
}
