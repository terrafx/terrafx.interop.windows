// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageFile.xml' path='doc/member[@name="IStorageFile"]/*' />
[Guid("FA3F6186-4214-428C-A64C-14C9AC7315EA")]
[NativeTypeName("struct IStorageFile : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageFile : IStorageFile.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageFile));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFile*, Guid*, void**, int>)(lpVtbl[0]))((IStorageFile*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFile*, uint>)(lpVtbl[1]))((IStorageFile*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFile*, uint>)(lpVtbl[2]))((IStorageFile*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFile*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageFile*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFile*, HSTRING*, int>)(lpVtbl[4]))((IStorageFile*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFile*, TrustLevel*, int>)(lpVtbl[5]))((IStorageFile*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageFile.xml' path='doc/member[@name="IStorageFile.get_FileType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_FileType(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFile*, HSTRING*, int>)(lpVtbl[6]))((IStorageFile*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageFile.xml' path='doc/member[@name="IStorageFile.get_ContentType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ContentType(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFile*, HSTRING*, int>)(lpVtbl[7]))((IStorageFile*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageFile.xml' path='doc/member[@name="IStorageFile.OpenAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT OpenAsync([NativeTypeName("ABI::Windows::Storage::FileAccessMode")] FileAccessMode accessMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **")] IAsyncOperation<Pointer<IRandomAccessStream>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFile*, FileAccessMode, IAsyncOperation<Pointer<IRandomAccessStream>>**, int>)(lpVtbl[8]))((IStorageFile*)Unsafe.AsPointer(ref this), accessMode, operation);
    }

    /// <include file='IStorageFile.xml' path='doc/member[@name="IStorageFile.OpenTransactedWriteAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OpenTransactedWriteAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **")] IAsyncOperation<Pointer<IStorageStreamTransaction>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFile*, IAsyncOperation<Pointer<IStorageStreamTransaction>>**, int>)(lpVtbl[9]))((IStorageFile*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IStorageFile.xml' path='doc/member[@name="IStorageFile.CopyOverloadDefaultNameAndOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CopyOverloadDefaultNameAndOptions([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* destinationFolder, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFile*, IStorageFolder*, IAsyncOperation<Pointer<IStorageFile>>**, int>)(lpVtbl[10]))((IStorageFile*)Unsafe.AsPointer(ref this), destinationFolder, operation);
    }

    /// <include file='IStorageFile.xml' path='doc/member[@name="IStorageFile.CopyOverloadDefaultOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CopyOverloadDefaultOptions([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* destinationFolder, HSTRING desiredNewName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFile*, IStorageFolder*, HSTRING, IAsyncOperation<Pointer<IStorageFile>>**, int>)(lpVtbl[11]))((IStorageFile*)Unsafe.AsPointer(ref this), destinationFolder, desiredNewName, operation);
    }

    /// <include file='IStorageFile.xml' path='doc/member[@name="IStorageFile.CopyOverload"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CopyOverload([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* destinationFolder, HSTRING desiredNewName, [NativeTypeName("ABI::Windows::Storage::NameCollisionOption")] NameCollisionOption option, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFile*, IStorageFolder*, HSTRING, NameCollisionOption, IAsyncOperation<Pointer<IStorageFile>>**, int>)(lpVtbl[12]))((IStorageFile*)Unsafe.AsPointer(ref this), destinationFolder, desiredNewName, option, operation);
    }

    /// <include file='IStorageFile.xml' path='doc/member[@name="IStorageFile.CopyAndReplaceAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CopyAndReplaceAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* fileToReplace, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFile*, IStorageFile*, IAsyncAction**, int>)(lpVtbl[13]))((IStorageFile*)Unsafe.AsPointer(ref this), fileToReplace, operation);
    }

    /// <include file='IStorageFile.xml' path='doc/member[@name="IStorageFile.MoveOverloadDefaultNameAndOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT MoveOverloadDefaultNameAndOptions([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* destinationFolder, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFile*, IStorageFolder*, IAsyncAction**, int>)(lpVtbl[14]))((IStorageFile*)Unsafe.AsPointer(ref this), destinationFolder, operation);
    }

    /// <include file='IStorageFile.xml' path='doc/member[@name="IStorageFile.MoveOverloadDefaultOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT MoveOverloadDefaultOptions([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* destinationFolder, HSTRING desiredNewName, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFile*, IStorageFolder*, HSTRING, IAsyncAction**, int>)(lpVtbl[15]))((IStorageFile*)Unsafe.AsPointer(ref this), destinationFolder, desiredNewName, operation);
    }

    /// <include file='IStorageFile.xml' path='doc/member[@name="IStorageFile.MoveOverload"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT MoveOverload([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* destinationFolder, HSTRING desiredNewName, [NativeTypeName("ABI::Windows::Storage::NameCollisionOption")] NameCollisionOption option, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFile*, IStorageFolder*, HSTRING, NameCollisionOption, IAsyncAction**, int>)(lpVtbl[16]))((IStorageFile*)Unsafe.AsPointer(ref this), destinationFolder, desiredNewName, option, operation);
    }

    /// <include file='IStorageFile.xml' path='doc/member[@name="IStorageFile.MoveAndReplaceAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT MoveAndReplaceAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* fileToReplace, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFile*, IStorageFile*, IAsyncAction**, int>)(lpVtbl[17]))((IStorageFile*)Unsafe.AsPointer(ref this), fileToReplace, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FileType(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_ContentType(HSTRING* value);

        [VtblIndex(8)]
        HRESULT OpenAsync([NativeTypeName("ABI::Windows::Storage::FileAccessMode")] FileAccessMode accessMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **")] IAsyncOperation<Pointer<IRandomAccessStream>>** operation);

        [VtblIndex(9)]
        HRESULT OpenTransactedWriteAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **")] IAsyncOperation<Pointer<IStorageStreamTransaction>>** operation);

        [VtblIndex(10)]
        HRESULT CopyOverloadDefaultNameAndOptions([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* destinationFolder, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation);

        [VtblIndex(11)]
        HRESULT CopyOverloadDefaultOptions([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* destinationFolder, HSTRING desiredNewName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation);

        [VtblIndex(12)]
        HRESULT CopyOverload([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* destinationFolder, HSTRING desiredNewName, [NativeTypeName("ABI::Windows::Storage::NameCollisionOption")] NameCollisionOption option, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation);

        [VtblIndex(13)]
        HRESULT CopyAndReplaceAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* fileToReplace, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(14)]
        HRESULT MoveOverloadDefaultNameAndOptions([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* destinationFolder, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(15)]
        HRESULT MoveOverloadDefaultOptions([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* destinationFolder, HSTRING desiredNewName, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(16)]
        HRESULT MoveOverload([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* destinationFolder, HSTRING desiredNewName, [NativeTypeName("ABI::Windows::Storage::NameCollisionOption")] NameCollisionOption option, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(17)]
        HRESULT MoveAndReplaceAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* fileToReplace, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_FileType;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ContentType;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::FileAccessMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FileAccessMode, IAsyncOperation<Pointer<IRandomAccessStream>>**, int> OpenAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IStorageStreamTransaction>>**, int> OpenTransactedWriteAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder*, IAsyncOperation<Pointer<IStorageFile>>**, int> CopyOverloadDefaultNameAndOptions;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder*, HSTRING, IAsyncOperation<Pointer<IStorageFile>>**, int> CopyOverloadDefaultOptions;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder *, HSTRING, ABI::Windows::Storage::NameCollisionOption, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder*, HSTRING, NameCollisionOption, IAsyncOperation<Pointer<IStorageFile>>**, int> CopyOverload;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IAsyncAction**, int> CopyAndReplaceAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder*, IAsyncAction**, int> MoveOverloadDefaultNameAndOptions;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder *, HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder*, HSTRING, IAsyncAction**, int> MoveOverloadDefaultOptions;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder *, HSTRING, ABI::Windows::Storage::NameCollisionOption, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder*, HSTRING, NameCollisionOption, IAsyncAction**, int> MoveOverload;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IAsyncAction**, int> MoveAndReplaceAsync;
    }
}
