// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ILauncherStatics5.xml' path='doc/member[@name="ILauncherStatics5"]/*' />
[Guid("5B24EF84-D895-5FEA-9153-1AC49AED9BA9")]
[NativeTypeName("struct ILauncherStatics5 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILauncherStatics5 : ILauncherStatics5.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILauncherStatics5));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics5*, Guid*, void**, int>)(lpVtbl[0]))((ILauncherStatics5*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics5*, uint>)(lpVtbl[1]))((ILauncherStatics5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics5*, uint>)(lpVtbl[2]))((ILauncherStatics5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics5*, uint*, Guid**, int>)(lpVtbl[3]))((ILauncherStatics5*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics5*, HSTRING*, int>)(lpVtbl[4]))((ILauncherStatics5*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics5*, TrustLevel*, int>)(lpVtbl[5]))((ILauncherStatics5*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ILauncherStatics5.xml' path='doc/member[@name="ILauncherStatics5.LaunchFolderPathAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT LaunchFolderPathAsync(HSTRING path, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics5*, HSTRING, IAsyncOperation<bool>**, int>)(lpVtbl[6]))((ILauncherStatics5*)Unsafe.AsPointer(ref this), path, operation);
    }

    /// <include file='ILauncherStatics5.xml' path='doc/member[@name="ILauncherStatics5.LaunchFolderPathWithOptionsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT LaunchFolderPathWithOptionsAsync(HSTRING path, [NativeTypeName("ABI::Windows::System::IFolderLauncherOptions *")] IFolderLauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics5*, HSTRING, IFolderLauncherOptions*, IAsyncOperation<bool>**, int>)(lpVtbl[7]))((ILauncherStatics5*)Unsafe.AsPointer(ref this), path, options, operation);
    }

    /// <include file='ILauncherStatics5.xml' path='doc/member[@name="ILauncherStatics5.LaunchFolderPathForUserAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT LaunchFolderPathForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING path, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics5*, IUser*, HSTRING, IAsyncOperation<bool>**, int>)(lpVtbl[8]))((ILauncherStatics5*)Unsafe.AsPointer(ref this), user, path, operation);
    }

    /// <include file='ILauncherStatics5.xml' path='doc/member[@name="ILauncherStatics5.LaunchFolderPathWithOptionsForUserAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT LaunchFolderPathWithOptionsForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING path, [NativeTypeName("ABI::Windows::System::IFolderLauncherOptions *")] IFolderLauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherStatics5*, IUser*, HSTRING, IFolderLauncherOptions*, IAsyncOperation<bool>**, int>)(lpVtbl[9]))((ILauncherStatics5*)Unsafe.AsPointer(ref this), user, path, options, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT LaunchFolderPathAsync(HSTRING path, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(7)]
        HRESULT LaunchFolderPathWithOptionsAsync(HSTRING path, [NativeTypeName("ABI::Windows::System::IFolderLauncherOptions *")] IFolderLauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(8)]
        HRESULT LaunchFolderPathForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING path, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(9)]
        HRESULT LaunchFolderPathWithOptionsForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING path, [NativeTypeName("ABI::Windows::System::IFolderLauncherOptions *")] IFolderLauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<bool>**, int> LaunchFolderPathAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::System::IFolderLauncherOptions *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IFolderLauncherOptions*, IAsyncOperation<bool>**, int> LaunchFolderPathWithOptionsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, HSTRING, IAsyncOperation<bool>**, int> LaunchFolderPathForUserAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, HSTRING, ABI::Windows::System::IFolderLauncherOptions *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, HSTRING, IFolderLauncherOptions*, IAsyncOperation<bool>**, int> LaunchFolderPathWithOptionsForUserAsync;
    }
}
