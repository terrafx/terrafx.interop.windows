// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRecordLimitationExceededEventHandler.xml' path='doc/member[@name="IRecordLimitationExceededEventHandler"]/*' />
[Guid("3FAE8F2E-4FE1-4FFD-AABA-E1F1337D4E53")]
[NativeTypeName("struct IRecordLimitationExceededEventHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IRecordLimitationExceededEventHandler : IRecordLimitationExceededEventHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRecordLimitationExceededEventHandler));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRecordLimitationExceededEventHandler*, Guid*, void**, int>)(lpVtbl[0]))((IRecordLimitationExceededEventHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRecordLimitationExceededEventHandler*, uint>)(lpVtbl[1]))((IRecordLimitationExceededEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRecordLimitationExceededEventHandler*, uint>)(lpVtbl[2]))((IRecordLimitationExceededEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRecordLimitationExceededEventHandler.xml' path='doc/member[@name="IRecordLimitationExceededEventHandler.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke([NativeTypeName("ABI::Windows::Media::Capture::IMediaCapture *")] IMediaCapture* sender)
    {
        return ((delegate* unmanaged[MemberFunction]<IRecordLimitationExceededEventHandler*, IMediaCapture*, int>)(lpVtbl[3]))((IRecordLimitationExceededEventHandler*)Unsafe.AsPointer(ref this), sender);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke([NativeTypeName("ABI::Windows::Media::Capture::IMediaCapture *")] IMediaCapture* sender);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IMediaCapture *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaCapture*, int> Invoke;
    }
}
