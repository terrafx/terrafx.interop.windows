// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowPdlSourceContent.xml' path='doc/member[@name="IPrintWorkflowPdlSourceContent"]/*' />
[Guid("92F7FC41-32B8-56AB-845E-B1E68B3AEDD5")]
[NativeTypeName("struct IPrintWorkflowPdlSourceContent : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowPdlSourceContent : IPrintWorkflowPdlSourceContent.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintWorkflowPdlSourceContent));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlSourceContent*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowPdlSourceContent*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlSourceContent*, uint>)(lpVtbl[1]))((IPrintWorkflowPdlSourceContent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlSourceContent*, uint>)(lpVtbl[2]))((IPrintWorkflowPdlSourceContent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlSourceContent*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowPdlSourceContent*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlSourceContent*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowPdlSourceContent*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlSourceContent*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowPdlSourceContent*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowPdlSourceContent.xml' path='doc/member[@name="IPrintWorkflowPdlSourceContent.get_ContentType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ContentType(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlSourceContent*, HSTRING*, int>)(lpVtbl[6]))((IPrintWorkflowPdlSourceContent*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowPdlSourceContent.xml' path='doc/member[@name="IPrintWorkflowPdlSourceContent.GetInputStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetInputStream([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlSourceContent*, IInputStream**, int>)(lpVtbl[7]))((IPrintWorkflowPdlSourceContent*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPrintWorkflowPdlSourceContent.xml' path='doc/member[@name="IPrintWorkflowPdlSourceContent.GetContentFileAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetContentFileAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlSourceContent*, IAsyncOperation<Pointer<IStorageFile>>**, int>)(lpVtbl[8]))((IPrintWorkflowPdlSourceContent*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ContentType(HSTRING* value);

        [VtblIndex(7)]
        HRESULT GetInputStream([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream** result);

        [VtblIndex(8)]
        HRESULT GetContentFileAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ContentType;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IInputStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInputStream**, int> GetInputStream;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IStorageFile>>**, int> GetContentFileAsync;
    }
}
