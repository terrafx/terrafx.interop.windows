// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundTransferContentPart.xml' path='doc/member[@name="IBackgroundTransferContentPart"]/*' />
[Guid("E8E15657-D7D1-4ED8-838E-674AC217ACE6")]
[NativeTypeName("struct IBackgroundTransferContentPart : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundTransferContentPart : IBackgroundTransferContentPart.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundTransferContentPart));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferContentPart*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundTransferContentPart*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferContentPart*, uint>)(lpVtbl[1]))((IBackgroundTransferContentPart*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferContentPart*, uint>)(lpVtbl[2]))((IBackgroundTransferContentPart*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferContentPart*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundTransferContentPart*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferContentPart*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundTransferContentPart*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferContentPart*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundTransferContentPart*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundTransferContentPart.xml' path='doc/member[@name="IBackgroundTransferContentPart.SetHeader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetHeader(HSTRING headerName, HSTRING headerValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferContentPart*, HSTRING, HSTRING, int>)(lpVtbl[6]))((IBackgroundTransferContentPart*)Unsafe.AsPointer(ref this), headerName, headerValue);
    }

    /// <include file='IBackgroundTransferContentPart.xml' path='doc/member[@name="IBackgroundTransferContentPart.SetText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetText(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferContentPart*, HSTRING, int>)(lpVtbl[7]))((IBackgroundTransferContentPart*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTransferContentPart.xml' path='doc/member[@name="IBackgroundTransferContentPart.SetFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetFile([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferContentPart*, IStorageFile*, int>)(lpVtbl[8]))((IBackgroundTransferContentPart*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SetHeader(HSTRING headerName, HSTRING headerValue);

        [VtblIndex(7)]
        HRESULT SetText(HSTRING value);

        [VtblIndex(8)]
        HRESULT SetFile([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* value);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, int> SetHeader;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> SetText;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, int> SetFile;
    }
}
