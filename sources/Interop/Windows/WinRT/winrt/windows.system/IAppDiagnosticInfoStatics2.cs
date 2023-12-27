// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppDiagnosticInfoStatics2.xml' path='doc/member[@name="IAppDiagnosticInfoStatics2"]/*' />
[Guid("05B24B86-1000-4C90-BB9F-7235071C50FE")]
[NativeTypeName("struct IAppDiagnosticInfoStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppDiagnosticInfoStatics2 : IAppDiagnosticInfoStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppDiagnosticInfoStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IAppDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoStatics2*, uint>)(lpVtbl[1]))((IAppDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoStatics2*, uint>)(lpVtbl[2]))((IAppDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IAppDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoStatics2*, HSTRING*, int>)(lpVtbl[4]))((IAppDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IAppDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppDiagnosticInfoStatics2.xml' path='doc/member[@name="IAppDiagnosticInfoStatics2.CreateWatcher"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateWatcher([NativeTypeName("ABI::Windows::System::IAppDiagnosticInfoWatcher **")] IAppDiagnosticInfoWatcher** watcher)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoStatics2*, IAppDiagnosticInfoWatcher**, int>)(lpVtbl[6]))((IAppDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), watcher);
    }

    /// <include file='IAppDiagnosticInfoStatics2.xml' path='doc/member[@name="IAppDiagnosticInfoStatics2.RequestAccessAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestAccessAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CDiagnosticAccessStatus_t **")] IAsyncOperation<DiagnosticAccessStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoStatics2*, IAsyncOperation<DiagnosticAccessStatus>**, int>)(lpVtbl[7]))((IAppDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IAppDiagnosticInfoStatics2.xml' path='doc/member[@name="IAppDiagnosticInfoStatics2.RequestInfoForPackageAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RequestInfoForPackageAsync(HSTRING packageFamilyName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CSystem__CAppDiagnosticInfo_t **")] IAsyncOperation<Pointer<IVector<Pointer<IAppDiagnosticInfo>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoStatics2*, HSTRING, IAsyncOperation<Pointer<IVector<Pointer<IAppDiagnosticInfo>>>>**, int>)(lpVtbl[8]))((IAppDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), packageFamilyName, operation);
    }

    /// <include file='IAppDiagnosticInfoStatics2.xml' path='doc/member[@name="IAppDiagnosticInfoStatics2.RequestInfoForAppAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestInfoForAppAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CSystem__CAppDiagnosticInfo_t **")] IAsyncOperation<Pointer<IVector<Pointer<IAppDiagnosticInfo>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoStatics2*, IAsyncOperation<Pointer<IVector<Pointer<IAppDiagnosticInfo>>>>**, int>)(lpVtbl[9]))((IAppDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IAppDiagnosticInfoStatics2.xml' path='doc/member[@name="IAppDiagnosticInfoStatics2.RequestInfoForAppUserModelId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RequestInfoForAppUserModelId(HSTRING appUserModelId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CSystem__CAppDiagnosticInfo_t **")] IAsyncOperation<Pointer<IVector<Pointer<IAppDiagnosticInfo>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoStatics2*, HSTRING, IAsyncOperation<Pointer<IVector<Pointer<IAppDiagnosticInfo>>>>**, int>)(lpVtbl[10]))((IAppDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), appUserModelId, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateWatcher([NativeTypeName("ABI::Windows::System::IAppDiagnosticInfoWatcher **")] IAppDiagnosticInfoWatcher** watcher);

        [VtblIndex(7)]
        HRESULT RequestAccessAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CDiagnosticAccessStatus_t **")] IAsyncOperation<DiagnosticAccessStatus>** operation);

        [VtblIndex(8)]
        HRESULT RequestInfoForPackageAsync(HSTRING packageFamilyName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CSystem__CAppDiagnosticInfo_t **")] IAsyncOperation<Pointer<IVector<Pointer<IAppDiagnosticInfo>>>>** operation);

        [VtblIndex(9)]
        HRESULT RequestInfoForAppAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CSystem__CAppDiagnosticInfo_t **")] IAsyncOperation<Pointer<IVector<Pointer<IAppDiagnosticInfo>>>>** operation);

        [VtblIndex(10)]
        HRESULT RequestInfoForAppUserModelId(HSTRING appUserModelId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CSystem__CAppDiagnosticInfo_t **")] IAsyncOperation<Pointer<IVector<Pointer<IAppDiagnosticInfo>>>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::IAppDiagnosticInfoWatcher **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppDiagnosticInfoWatcher**, int> CreateWatcher;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CDiagnosticAccessStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<DiagnosticAccessStatus>**, int> RequestAccessAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CSystem__CAppDiagnosticInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IVector<Pointer<IAppDiagnosticInfo>>>>**, int> RequestInfoForPackageAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CSystem__CAppDiagnosticInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVector<Pointer<IAppDiagnosticInfo>>>>**, int> RequestInfoForAppAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CSystem__CAppDiagnosticInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IVector<Pointer<IAppDiagnosticInfo>>>>**, int> RequestInfoForAppUserModelId;
    }
}
