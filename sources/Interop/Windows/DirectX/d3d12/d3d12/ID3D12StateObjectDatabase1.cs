// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12StateObjectDatabase1.xml' path='doc/member[@name="ID3D12StateObjectDatabase1"]/*' />
[Guid("C700E43F-47A6-4EC6-AD83-F275400231AF")]
[NativeTypeName("struct ID3D12StateObjectDatabase1 : ID3D12StateObjectDatabase")]
[NativeInheritance("ID3D12StateObjectDatabase")]
public unsafe partial struct ID3D12StateObjectDatabase1 : ID3D12StateObjectDatabase1.Interface, INativeGuid
{
    /// <include file='ID3D12StateObjectDatabase1.xml' path='doc/member[@name="ID3D12StateObjectDatabase1.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12StateObjectDatabase1);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabase1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12StateObjectDatabase1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabase1*, uint>)(lpVtbl[1]))((ID3D12StateObjectDatabase1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabase1*, uint>)(lpVtbl[2]))((ID3D12StateObjectDatabase1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12StateObjectDatabase.SetApplicationDesc" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetApplicationDesc([NativeTypeName("const D3D12_APPLICATION_DESC *")] D3D12_APPLICATION_DESC* pApplicationDesc)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabase1*, D3D12_APPLICATION_DESC*, int>)(lpVtbl[3]))((ID3D12StateObjectDatabase1*)Unsafe.AsPointer(ref this), pApplicationDesc);
    }

    /// <inheritdoc cref="ID3D12StateObjectDatabase.GetApplicationDesc" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetApplicationDesc([NativeTypeName("D3D12ApplicationDescFunc")] delegate* unmanaged<D3D12_APPLICATION_DESC*, void*, void> CallbackFunc, void* pContext)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabase1*, delegate* unmanaged<D3D12_APPLICATION_DESC*, void*, void>, void*, int>)(lpVtbl[4]))((ID3D12StateObjectDatabase1*)Unsafe.AsPointer(ref this), CallbackFunc, pContext);
    }

    /// <inheritdoc cref="ID3D12StateObjectDatabase.StorePipelineStateDesc" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT StorePipelineStateDesc([NativeTypeName("const void *")] void* pKey, uint KeySize, uint Version, [NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC *")] D3D12_PIPELINE_STATE_STREAM_DESC* pDesc)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabase1*, void*, uint, uint, D3D12_PIPELINE_STATE_STREAM_DESC*, int>)(lpVtbl[5]))((ID3D12StateObjectDatabase1*)Unsafe.AsPointer(ref this), pKey, KeySize, Version, pDesc);
    }

    /// <inheritdoc cref="ID3D12StateObjectDatabase.FindPipelineStateDesc" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindPipelineStateDesc([NativeTypeName("const void *")] void* pKey, uint KeySize, [NativeTypeName("D3D12PipelineStateFunc")] delegate* unmanaged<void*, uint, uint, D3D12_PIPELINE_STATE_STREAM_DESC*, void*, void> CallbackFunc, void* pContext)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabase1*, void*, uint, delegate* unmanaged<void*, uint, uint, D3D12_PIPELINE_STATE_STREAM_DESC*, void*, void>, void*, int>)(lpVtbl[6]))((ID3D12StateObjectDatabase1*)Unsafe.AsPointer(ref this), pKey, KeySize, CallbackFunc, pContext);
    }

    /// <inheritdoc cref="ID3D12StateObjectDatabase.StoreStateObjectDesc" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT StoreStateObjectDesc([NativeTypeName("const void *")] void* pKey, uint KeySize, uint Version, [NativeTypeName("const D3D12_STATE_OBJECT_DESC *")] D3D12_STATE_OBJECT_DESC* pDesc, [NativeTypeName("const void *")] void* pStateObjectToGrowFromKey, uint StateObjectToGrowFromKeySize)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabase1*, void*, uint, uint, D3D12_STATE_OBJECT_DESC*, void*, uint, int>)(lpVtbl[7]))((ID3D12StateObjectDatabase1*)Unsafe.AsPointer(ref this), pKey, KeySize, Version, pDesc, pStateObjectToGrowFromKey, StateObjectToGrowFromKeySize);
    }

    /// <inheritdoc cref="ID3D12StateObjectDatabase.FindStateObjectDesc" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FindStateObjectDesc([NativeTypeName("const void *")] void* pKey, uint KeySize, [NativeTypeName("D3D12StateObjectFunc")] delegate* unmanaged<void*, uint, uint, D3D12_STATE_OBJECT_DESC*, void*, uint, void*, void> CallbackFunc, void* pContext)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabase1*, void*, uint, delegate* unmanaged<void*, uint, uint, D3D12_STATE_OBJECT_DESC*, void*, uint, void*, void>, void*, int>)(lpVtbl[8]))((ID3D12StateObjectDatabase1*)Unsafe.AsPointer(ref this), pKey, KeySize, CallbackFunc, pContext);
    }

    /// <inheritdoc cref="ID3D12StateObjectDatabase.FindObjectVersion" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FindObjectVersion([NativeTypeName("const void *")] void* pKey, uint KeySize, uint* pVersion)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabase1*, void*, uint, uint*, int>)(lpVtbl[9]))((ID3D12StateObjectDatabase1*)Unsafe.AsPointer(ref this), pKey, KeySize, pVersion);
    }

    /// <include file='ID3D12StateObjectDatabase1.xml' path='doc/member[@name="ID3D12StateObjectDatabase1.EnumeratePipelineStates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT EnumeratePipelineStates([NativeTypeName("D3D12EnumeratePipelineStateFunc")] delegate* unmanaged<D3D12_DATABASE_GROUP_KEY*, uint*, uint, D3D12_DATABASE_PIPELINE_STATE_KEY*, void*, BOOL> CallbackFunc, void* pContext)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabase1*, delegate* unmanaged<D3D12_DATABASE_GROUP_KEY*, uint*, uint, D3D12_DATABASE_PIPELINE_STATE_KEY*, void*, BOOL>, void*, int>)(lpVtbl[10]))((ID3D12StateObjectDatabase1*)Unsafe.AsPointer(ref this), CallbackFunc, pContext);
    }

    /// <include file='ID3D12StateObjectDatabase1.xml' path='doc/member[@name="ID3D12StateObjectDatabase1.EnumerateStateObjects"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT EnumerateStateObjects([NativeTypeName("D3D12EnumerateStateObjectFunc")] delegate* unmanaged<D3D12_DATABASE_GROUP_KEY*, uint*, uint, D3D12_DATABASE_STATE_OBJECT_KEY*, void*, BOOL> CallbackFunc, void* pContext)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabase1*, delegate* unmanaged<D3D12_DATABASE_GROUP_KEY*, uint*, uint, D3D12_DATABASE_STATE_OBJECT_KEY*, void*, BOOL>, void*, int>)(lpVtbl[11]))((ID3D12StateObjectDatabase1*)Unsafe.AsPointer(ref this), CallbackFunc, pContext);
    }

    /// <include file='ID3D12StateObjectDatabase1.xml' path='doc/member[@name="ID3D12StateObjectDatabase1.GetStateObjectDependencies"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetStateObjectDependencies([NativeTypeName("const D3D12_DATABASE_GROUP_KEY *")] D3D12_DATABASE_GROUP_KEY* pGroupKey, [NativeTypeName("const D3D12_DATABASE_STATE_OBJECT_KEY *")] D3D12_DATABASE_STATE_OBJECT_KEY* pStateObjectKey, [NativeTypeName("D3D12StateObjectDependenciesFunc")] delegate* unmanaged<D3D12_DATABASE_STATE_OBJECT_KEY*, uint, D3D12_DATABASE_STATE_OBJECT_KEY*, void*, void> CallbackFunc, void* pContext)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabase1*, D3D12_DATABASE_GROUP_KEY*, D3D12_DATABASE_STATE_OBJECT_KEY*, delegate* unmanaged<D3D12_DATABASE_STATE_OBJECT_KEY*, uint, D3D12_DATABASE_STATE_OBJECT_KEY*, void*, void>, void*, int>)(lpVtbl[12]))((ID3D12StateObjectDatabase1*)Unsafe.AsPointer(ref this), pGroupKey, pStateObjectKey, CallbackFunc, pContext);
    }

    /// <include file='ID3D12StateObjectDatabase1.xml' path='doc/member[@name="ID3D12StateObjectDatabase1.SetApplicationDesc1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetApplicationDesc1([NativeTypeName("const D3D12_APPLICATION_DESC *")] D3D12_APPLICATION_DESC* pApplicationDesc, [NativeTypeName("const GUID &")] Guid* AppId)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabase1*, D3D12_APPLICATION_DESC*, Guid*, int>)(lpVtbl[13]))((ID3D12StateObjectDatabase1*)Unsafe.AsPointer(ref this), pApplicationDesc, AppId);
    }

    /// <include file='ID3D12StateObjectDatabase1.xml' path='doc/member[@name="ID3D12StateObjectDatabase1.GetApplicationDesc1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetApplicationDesc1([NativeTypeName("D3D12ApplicationDescFunc1")] delegate* unmanaged<D3D12_APPLICATION_DESC*, Guid*, void*, void> CallbackFunc, void* pContext)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabase1*, delegate* unmanaged<D3D12_APPLICATION_DESC*, Guid*, void*, void>, void*, int>)(lpVtbl[14]))((ID3D12StateObjectDatabase1*)Unsafe.AsPointer(ref this), CallbackFunc, pContext);
    }

    /// <include file='ID3D12StateObjectDatabase1.xml' path='doc/member[@name="ID3D12StateObjectDatabase1.FindPipelineStateDesc1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT FindPipelineStateDesc1([NativeTypeName("const D3D12_DATABASE_GROUP_KEY *")] D3D12_DATABASE_GROUP_KEY* pGroupKey, [NativeTypeName("const D3D12_DATABASE_PIPELINE_STATE_KEY *")] D3D12_DATABASE_PIPELINE_STATE_KEY* pPipelineStateKey, D3D12_FIND_PIPELINE_STATE_DESC_FLAGS Flags, [NativeTypeName("D3D12PipelineStateFunc1")] delegate* unmanaged<D3D12_DATABASE_GROUP_KEY*, uint*, uint, D3D12_DATABASE_PIPELINE_STATE_KEY*, D3D12_PIPELINE_STATE_STREAM_DESC*, void*, void> CallbackFunc, [NativeTypeName("D3D12CreateRootSignatureFunc")] delegate* unmanaged<D3D12_DATABASE_ROOT_SIGNATURE_KEY*, void*, nuint, ID3D12RootSignature**, void*, HRESULT> pfnCreateRootSignature, [NativeTypeName("D3D12LookupRootSignatureFunc")] delegate* unmanaged<D3D12_DATABASE_ROOT_SIGNATURE_KEY*, ID3D12RootSignature**, void*, HRESULT> pfnLookupRootSignature, void* pContext)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabase1*, D3D12_DATABASE_GROUP_KEY*, D3D12_DATABASE_PIPELINE_STATE_KEY*, D3D12_FIND_PIPELINE_STATE_DESC_FLAGS, delegate* unmanaged<D3D12_DATABASE_GROUP_KEY*, uint*, uint, D3D12_DATABASE_PIPELINE_STATE_KEY*, D3D12_PIPELINE_STATE_STREAM_DESC*, void*, void>, delegate* unmanaged<D3D12_DATABASE_ROOT_SIGNATURE_KEY*, void*, nuint, ID3D12RootSignature**, void*, HRESULT>, delegate* unmanaged<D3D12_DATABASE_ROOT_SIGNATURE_KEY*, ID3D12RootSignature**, void*, HRESULT>, void*, int>)(lpVtbl[15]))((ID3D12StateObjectDatabase1*)Unsafe.AsPointer(ref this), pGroupKey, pPipelineStateKey, Flags, CallbackFunc, pfnCreateRootSignature, pfnLookupRootSignature, pContext);
    }

    /// <include file='ID3D12StateObjectDatabase1.xml' path='doc/member[@name="ID3D12StateObjectDatabase1.FindStateObjectDesc1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT FindStateObjectDesc1([NativeTypeName("const D3D12_DATABASE_GROUP_KEY *")] D3D12_DATABASE_GROUP_KEY* pGroupKey, [NativeTypeName("const D3D12_DATABASE_STATE_OBJECT_KEY *")] D3D12_DATABASE_STATE_OBJECT_KEY* pStateObjectKey, D3D12_FIND_STATE_OBJECT_DESC_FLAGS Flags, [NativeTypeName("D3D12StateObjectFunc1")] delegate* unmanaged<D3D12_DATABASE_GROUP_KEY*, uint*, uint, D3D12_DATABASE_STATE_OBJECT_KEY*, D3D12_STATE_OBJECT_DESC*, D3D12_DATABASE_STATE_OBJECT_KEY*, D3D12_DATABASE_GROUP_KEY*, void*, void> CallbackFunc, [NativeTypeName("D3D12LookupStateObjectFunc")] delegate* unmanaged<D3D12_DATABASE_STATE_OBJECT_KEY*, D3D12_DATABASE_GROUP_KEY*, IUnknown**, void*, HRESULT> pfnLookupStateObject, [NativeTypeName("D3D12CreateRootSignatureFunc")] delegate* unmanaged<D3D12_DATABASE_ROOT_SIGNATURE_KEY*, void*, nuint, ID3D12RootSignature**, void*, HRESULT> pfnCreateRootSignature, [NativeTypeName("D3D12LookupRootSignatureFunc")] delegate* unmanaged<D3D12_DATABASE_ROOT_SIGNATURE_KEY*, ID3D12RootSignature**, void*, HRESULT> pfnLookupRootSignature, void* pContext)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabase1*, D3D12_DATABASE_GROUP_KEY*, D3D12_DATABASE_STATE_OBJECT_KEY*, D3D12_FIND_STATE_OBJECT_DESC_FLAGS, delegate* unmanaged<D3D12_DATABASE_GROUP_KEY*, uint*, uint, D3D12_DATABASE_STATE_OBJECT_KEY*, D3D12_STATE_OBJECT_DESC*, D3D12_DATABASE_STATE_OBJECT_KEY*, D3D12_DATABASE_GROUP_KEY*, void*, void>, delegate* unmanaged<D3D12_DATABASE_STATE_OBJECT_KEY*, D3D12_DATABASE_GROUP_KEY*, IUnknown**, void*, HRESULT>, delegate* unmanaged<D3D12_DATABASE_ROOT_SIGNATURE_KEY*, void*, nuint, ID3D12RootSignature**, void*, HRESULT>, delegate* unmanaged<D3D12_DATABASE_ROOT_SIGNATURE_KEY*, ID3D12RootSignature**, void*, HRESULT>, void*, int>)(lpVtbl[16]))((ID3D12StateObjectDatabase1*)Unsafe.AsPointer(ref this), pGroupKey, pStateObjectKey, Flags, CallbackFunc, pfnLookupStateObject, pfnCreateRootSignature, pfnLookupRootSignature, pContext);
    }

    /// <include file='ID3D12StateObjectDatabase1.xml' path='doc/member[@name="ID3D12StateObjectDatabase1.GetPipelineStateDescCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetPipelineStateDescCount(uint* pCount)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabase1*, uint*, int>)(lpVtbl[17]))((ID3D12StateObjectDatabase1*)Unsafe.AsPointer(ref this), pCount);
    }

    /// <include file='ID3D12StateObjectDatabase1.xml' path='doc/member[@name="ID3D12StateObjectDatabase1.GetStateObjectDescCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetStateObjectDescCount(uint* pCount)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabase1*, uint*, int>)(lpVtbl[18]))((ID3D12StateObjectDatabase1*)Unsafe.AsPointer(ref this), pCount);
    }

    /// <include file='ID3D12StateObjectDatabase1.xml' path='doc/member[@name="ID3D12StateObjectDatabase1.BeginTransaction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT BeginTransaction(D3D12_TRANSACTION_TYPE Type)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabase1*, D3D12_TRANSACTION_TYPE, int>)(lpVtbl[19]))((ID3D12StateObjectDatabase1*)Unsafe.AsPointer(ref this), Type);
    }

    /// <include file='ID3D12StateObjectDatabase1.xml' path='doc/member[@name="ID3D12StateObjectDatabase1.CommitTransaction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT CommitTransaction()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabase1*, int>)(lpVtbl[20]))((ID3D12StateObjectDatabase1*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12StateObjectDatabase1.xml' path='doc/member[@name="ID3D12StateObjectDatabase1.RollbackTransaction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT RollbackTransaction()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabase1*, int>)(lpVtbl[21]))((ID3D12StateObjectDatabase1*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12StateObjectDatabase1.xml' path='doc/member[@name="ID3D12StateObjectDatabase1.IsTransactionActive"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public BOOL IsTransactionActive()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabase1*, int>)(lpVtbl[22]))((ID3D12StateObjectDatabase1*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12StateObjectDatabase1.xml' path='doc/member[@name="ID3D12StateObjectDatabase1.Checkpoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT Checkpoint(D3D12_CHECKPOINT_MODE CheckpointMode, D3D12_JOURNAL_MODE JournalMode, D3D12_JOURNAL_MODE* pPreviousJournalMode)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabase1*, D3D12_CHECKPOINT_MODE, D3D12_JOURNAL_MODE, D3D12_JOURNAL_MODE*, int>)(lpVtbl[23]))((ID3D12StateObjectDatabase1*)Unsafe.AsPointer(ref this), CheckpointMode, JournalMode, pPreviousJournalMode);
    }

    /// <include file='ID3D12StateObjectDatabase1.xml' path='doc/member[@name="ID3D12StateObjectDatabase1.StorePipelineStateDesc1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT StorePipelineStateDesc1([NativeTypeName("const D3D12_DATABASE_GROUP_KEY *")] D3D12_DATABASE_GROUP_KEY* pGroupKeys, [NativeTypeName("const UINT *")] uint* pVersions, uint NumGroupKeys, [NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC *")] D3D12_PIPELINE_STATE_STREAM_DESC* pDesc)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabase1*, D3D12_DATABASE_GROUP_KEY*, uint*, uint, D3D12_PIPELINE_STATE_STREAM_DESC*, int>)(lpVtbl[24]))((ID3D12StateObjectDatabase1*)Unsafe.AsPointer(ref this), pGroupKeys, pVersions, NumGroupKeys, pDesc);
    }

    /// <include file='ID3D12StateObjectDatabase1.xml' path='doc/member[@name="ID3D12StateObjectDatabase1.StoreStateObjectDesc1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT StoreStateObjectDesc1([NativeTypeName("const D3D12_DATABASE_GROUP_KEY *")] D3D12_DATABASE_GROUP_KEY* pGroupKeys, [NativeTypeName("const UINT *")] uint* pVersions, uint NumGroupKeys, [NativeTypeName("const D3D12_STATE_OBJECT_DESC *")] D3D12_STATE_OBJECT_DESC* pDesc, [NativeTypeName("const D3D12_DATABASE_GROUP_KEY *")] D3D12_DATABASE_GROUP_KEY* pStateObjectToGrowFromGroupKey, IUnknown* pCreatedObject, IUnknown* pStateObjectToGrowFrom)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabase1*, D3D12_DATABASE_GROUP_KEY*, uint*, uint, D3D12_STATE_OBJECT_DESC*, D3D12_DATABASE_GROUP_KEY*, IUnknown*, IUnknown*, int>)(lpVtbl[25]))((ID3D12StateObjectDatabase1*)Unsafe.AsPointer(ref this), pGroupKeys, pVersions, NumGroupKeys, pDesc, pStateObjectToGrowFromGroupKey, pCreatedObject, pStateObjectToGrowFrom);
    }

    public interface Interface : ID3D12StateObjectDatabase.Interface
    {
        [VtblIndex(13)]
        HRESULT SetApplicationDesc1([NativeTypeName("const D3D12_APPLICATION_DESC *")] D3D12_APPLICATION_DESC* pApplicationDesc, [NativeTypeName("const GUID &")] Guid* AppId);

        [VtblIndex(17)]
        HRESULT GetPipelineStateDescCount(uint* pCount);

        [VtblIndex(18)]
        HRESULT GetStateObjectDescCount(uint* pCount);

        [VtblIndex(19)]
        HRESULT BeginTransaction(D3D12_TRANSACTION_TYPE Type);

        [VtblIndex(20)]
        HRESULT CommitTransaction();

        [VtblIndex(21)]
        HRESULT RollbackTransaction();

        [VtblIndex(22)]
        BOOL IsTransactionActive();

        [VtblIndex(23)]
        HRESULT Checkpoint(D3D12_CHECKPOINT_MODE CheckpointMode, D3D12_JOURNAL_MODE JournalMode, D3D12_JOURNAL_MODE* pPreviousJournalMode);

        [VtblIndex(24)]
        HRESULT StorePipelineStateDesc1([NativeTypeName("const D3D12_DATABASE_GROUP_KEY *")] D3D12_DATABASE_GROUP_KEY* pGroupKeys, [NativeTypeName("const UINT *")] uint* pVersions, uint NumGroupKeys, [NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC *")] D3D12_PIPELINE_STATE_STREAM_DESC* pDesc);

        [VtblIndex(25)]
        HRESULT StoreStateObjectDesc1([NativeTypeName("const D3D12_DATABASE_GROUP_KEY *")] D3D12_DATABASE_GROUP_KEY* pGroupKeys, [NativeTypeName("const UINT *")] uint* pVersions, uint NumGroupKeys, [NativeTypeName("const D3D12_STATE_OBJECT_DESC *")] D3D12_STATE_OBJECT_DESC* pDesc, [NativeTypeName("const D3D12_DATABASE_GROUP_KEY *")] D3D12_DATABASE_GROUP_KEY* pStateObjectToGrowFromGroupKey, IUnknown* pCreatedObject, IUnknown* pStateObjectToGrowFrom);
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

        [NativeTypeName("HRESULT (const D3D12_APPLICATION_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_APPLICATION_DESC*, int> SetApplicationDesc;

        [NativeTypeName("HRESULT (D3D12ApplicationDescFunc, void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, delegate* unmanaged<D3D12_APPLICATION_DESC*, void*, void>, void*, int> GetApplicationDesc;

        [NativeTypeName("HRESULT (const void *, UINT, UINT, const D3D12_PIPELINE_STATE_STREAM_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, uint, D3D12_PIPELINE_STATE_STREAM_DESC*, int> StorePipelineStateDesc;

        [NativeTypeName("HRESULT (const void *, UINT, D3D12PipelineStateFunc, void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, delegate* unmanaged<void*, uint, uint, D3D12_PIPELINE_STATE_STREAM_DESC*, void*, void>, void*, int> FindPipelineStateDesc;

        [NativeTypeName("HRESULT (const void *, UINT, UINT, const D3D12_STATE_OBJECT_DESC *, const void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, uint, D3D12_STATE_OBJECT_DESC*, void*, uint, int> StoreStateObjectDesc;

        [NativeTypeName("HRESULT (const void *, UINT, D3D12StateObjectFunc, void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, delegate* unmanaged<void*, uint, uint, D3D12_STATE_OBJECT_DESC*, void*, uint, void*, void>, void*, int> FindStateObjectDesc;

        [NativeTypeName("HRESULT (const void *, UINT, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, uint*, int> FindObjectVersion;

        [NativeTypeName("HRESULT (D3D12EnumeratePipelineStateFunc, void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, delegate* unmanaged<D3D12_DATABASE_GROUP_KEY*, uint*, uint, D3D12_DATABASE_PIPELINE_STATE_KEY*, void*, BOOL>, void*, int> EnumeratePipelineStates;

        [NativeTypeName("HRESULT (D3D12EnumerateStateObjectFunc, void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, delegate* unmanaged<D3D12_DATABASE_GROUP_KEY*, uint*, uint, D3D12_DATABASE_STATE_OBJECT_KEY*, void*, BOOL>, void*, int> EnumerateStateObjects;

        [NativeTypeName("HRESULT (const D3D12_DATABASE_GROUP_KEY *, const D3D12_DATABASE_STATE_OBJECT_KEY *, D3D12StateObjectDependenciesFunc, void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_DATABASE_GROUP_KEY*, D3D12_DATABASE_STATE_OBJECT_KEY*, delegate* unmanaged<D3D12_DATABASE_STATE_OBJECT_KEY*, uint, D3D12_DATABASE_STATE_OBJECT_KEY*, void*, void>, void*, int> GetStateObjectDependencies;

        [NativeTypeName("HRESULT (const D3D12_APPLICATION_DESC *, const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_APPLICATION_DESC*, Guid*, int> SetApplicationDesc1;

        [NativeTypeName("HRESULT (D3D12ApplicationDescFunc1, void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, delegate* unmanaged<D3D12_APPLICATION_DESC*, Guid*, void*, void>, void*, int> GetApplicationDesc1;

        [NativeTypeName("HRESULT (const D3D12_DATABASE_GROUP_KEY *, const D3D12_DATABASE_PIPELINE_STATE_KEY *, D3D12_FIND_PIPELINE_STATE_DESC_FLAGS, D3D12PipelineStateFunc1, D3D12CreateRootSignatureFunc, D3D12LookupRootSignatureFunc, void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_DATABASE_GROUP_KEY*, D3D12_DATABASE_PIPELINE_STATE_KEY*, D3D12_FIND_PIPELINE_STATE_DESC_FLAGS, delegate* unmanaged<D3D12_DATABASE_GROUP_KEY*, uint*, uint, D3D12_DATABASE_PIPELINE_STATE_KEY*, D3D12_PIPELINE_STATE_STREAM_DESC*, void*, void>, delegate* unmanaged<D3D12_DATABASE_ROOT_SIGNATURE_KEY*, void*, nuint, ID3D12RootSignature**, void*, HRESULT>, delegate* unmanaged<D3D12_DATABASE_ROOT_SIGNATURE_KEY*, ID3D12RootSignature**, void*, HRESULT>, void*, int> FindPipelineStateDesc1;

        [NativeTypeName("HRESULT (const D3D12_DATABASE_GROUP_KEY *, const D3D12_DATABASE_STATE_OBJECT_KEY *, D3D12_FIND_STATE_OBJECT_DESC_FLAGS, D3D12StateObjectFunc1, D3D12LookupStateObjectFunc, D3D12CreateRootSignatureFunc, D3D12LookupRootSignatureFunc, void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_DATABASE_GROUP_KEY*, D3D12_DATABASE_STATE_OBJECT_KEY*, D3D12_FIND_STATE_OBJECT_DESC_FLAGS, delegate* unmanaged<D3D12_DATABASE_GROUP_KEY*, uint*, uint, D3D12_DATABASE_STATE_OBJECT_KEY*, D3D12_STATE_OBJECT_DESC*, D3D12_DATABASE_STATE_OBJECT_KEY*, D3D12_DATABASE_GROUP_KEY*, void*, void>, delegate* unmanaged<D3D12_DATABASE_STATE_OBJECT_KEY*, D3D12_DATABASE_GROUP_KEY*, IUnknown**, void*, HRESULT>, delegate* unmanaged<D3D12_DATABASE_ROOT_SIGNATURE_KEY*, void*, nuint, ID3D12RootSignature**, void*, HRESULT>, delegate* unmanaged<D3D12_DATABASE_ROOT_SIGNATURE_KEY*, ID3D12RootSignature**, void*, HRESULT>, void*, int> FindStateObjectDesc1;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetPipelineStateDescCount;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetStateObjectDescCount;

        [NativeTypeName("HRESULT (D3D12_TRANSACTION_TYPE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_TRANSACTION_TYPE, int> BeginTransaction;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> CommitTransaction;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RollbackTransaction;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> IsTransactionActive;

        [NativeTypeName("HRESULT (D3D12_CHECKPOINT_MODE, D3D12_JOURNAL_MODE, D3D12_JOURNAL_MODE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_CHECKPOINT_MODE, D3D12_JOURNAL_MODE, D3D12_JOURNAL_MODE*, int> Checkpoint;

        [NativeTypeName("HRESULT (const D3D12_DATABASE_GROUP_KEY *, const UINT *, UINT, const D3D12_PIPELINE_STATE_STREAM_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_DATABASE_GROUP_KEY*, uint*, uint, D3D12_PIPELINE_STATE_STREAM_DESC*, int> StorePipelineStateDesc1;

        [NativeTypeName("HRESULT (const D3D12_DATABASE_GROUP_KEY *, const UINT *, UINT, const D3D12_STATE_OBJECT_DESC *, const D3D12_DATABASE_GROUP_KEY *, IUnknown *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_DATABASE_GROUP_KEY*, uint*, uint, D3D12_STATE_OBJECT_DESC*, D3D12_DATABASE_GROUP_KEY*, IUnknown*, IUnknown*, int> StoreStateObjectDesc1;
    }
}
