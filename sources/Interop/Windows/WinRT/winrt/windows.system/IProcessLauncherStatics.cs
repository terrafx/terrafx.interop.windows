// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IProcessLauncherStatics.xml' path='doc/member[@name="IProcessLauncherStatics"]/*' />
[Guid("33AB66E7-2D0E-448B-A6A0-C13C3836D09C")]
[NativeTypeName("struct IProcessLauncherStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProcessLauncherStatics : IProcessLauncherStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProcessLauncherStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessLauncherStatics*, Guid*, void**, int>)(lpVtbl[0]))((IProcessLauncherStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessLauncherStatics*, uint>)(lpVtbl[1]))((IProcessLauncherStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessLauncherStatics*, uint>)(lpVtbl[2]))((IProcessLauncherStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessLauncherStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IProcessLauncherStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessLauncherStatics*, HSTRING*, int>)(lpVtbl[4]))((IProcessLauncherStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessLauncherStatics*, TrustLevel*, int>)(lpVtbl[5]))((IProcessLauncherStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProcessLauncherStatics.xml' path='doc/member[@name="IProcessLauncherStatics.RunToCompletionAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RunToCompletionAsync(HSTRING fileName, HSTRING args, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CProcessLauncherResult_t **")] IAsyncOperation<IntPtr>** asyncOperationResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessLauncherStatics*, HSTRING, HSTRING, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IProcessLauncherStatics*)Unsafe.AsPointer(ref this), fileName, args, asyncOperationResult);
    }

    /// <include file='IProcessLauncherStatics.xml' path='doc/member[@name="IProcessLauncherStatics.RunToCompletionAsyncWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RunToCompletionAsyncWithOptions(HSTRING fileName, HSTRING args, [NativeTypeName("ABI::Windows::System::IProcessLauncherOptions *")] IProcessLauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CProcessLauncherResult_t **")] IAsyncOperation<IntPtr>** asyncOperationResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessLauncherStatics*, HSTRING, HSTRING, IProcessLauncherOptions*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IProcessLauncherStatics*)Unsafe.AsPointer(ref this), fileName, args, options, asyncOperationResult);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RunToCompletionAsync(HSTRING fileName, HSTRING args, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CProcessLauncherResult_t **")] IAsyncOperation<IntPtr>** asyncOperationResult);

        [VtblIndex(7)]
        HRESULT RunToCompletionAsyncWithOptions(HSTRING fileName, HSTRING args, [NativeTypeName("ABI::Windows::System::IProcessLauncherOptions *")] IProcessLauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CProcessLauncherResult_t **")] IAsyncOperation<IntPtr>** asyncOperationResult);
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

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CProcessLauncherResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IAsyncOperation<IntPtr>**, int> RunToCompletionAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::System::IProcessLauncherOptions *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CProcessLauncherResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IProcessLauncherOptions*, IAsyncOperation<IntPtr>**, int> RunToCompletionAsyncWithOptions;
    }
}
