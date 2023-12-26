// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo"]/*' />
[Guid("7C1305C4-99F9-41AC-8904-AB055D654926")]
[NativeTypeName("struct IStorageProviderSyncRootInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageProviderSyncRootInfo : IStorageProviderSyncRootInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageProviderSyncRootInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, Guid*, void**, int>)(lpVtbl[0]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, uint>)(lpVtbl[1]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, uint>)(lpVtbl[2]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, HSTRING*, int>)(lpVtbl[4]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, TrustLevel*, int>)(lpVtbl[5]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, HSTRING*, int>)(lpVtbl[6]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.put_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Id(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, HSTRING, int>)(lpVtbl[7]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.get_Context"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Context([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, IBuffer**, int>)(lpVtbl[8]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.put_Context"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Context([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, IBuffer*, int>)(lpVtbl[9]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.get_Path"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Path([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, IStorageFolder**, int>)(lpVtbl[10]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.put_Path"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Path([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, IStorageFolder*, int>)(lpVtbl[11]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.get_DisplayNameResource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_DisplayNameResource(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, HSTRING*, int>)(lpVtbl[12]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.put_DisplayNameResource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_DisplayNameResource(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, HSTRING, int>)(lpVtbl[13]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.get_IconResource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_IconResource(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, HSTRING*, int>)(lpVtbl[14]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.put_IconResource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_IconResource(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, HSTRING, int>)(lpVtbl[15]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.get_HydrationPolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_HydrationPolicy([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderHydrationPolicy *")] StorageProviderHydrationPolicy* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, StorageProviderHydrationPolicy*, int>)(lpVtbl[16]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.put_HydrationPolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_HydrationPolicy([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderHydrationPolicy")] StorageProviderHydrationPolicy value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, StorageProviderHydrationPolicy, int>)(lpVtbl[17]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.get_HydrationPolicyModifier"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_HydrationPolicyModifier([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderHydrationPolicyModifier *")] StorageProviderHydrationPolicyModifier* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, StorageProviderHydrationPolicyModifier*, int>)(lpVtbl[18]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.put_HydrationPolicyModifier"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_HydrationPolicyModifier([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderHydrationPolicyModifier")] StorageProviderHydrationPolicyModifier value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, StorageProviderHydrationPolicyModifier, int>)(lpVtbl[19]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.get_PopulationPolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_PopulationPolicy([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderPopulationPolicy *")] StorageProviderPopulationPolicy* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, StorageProviderPopulationPolicy*, int>)(lpVtbl[20]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.put_PopulationPolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_PopulationPolicy([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderPopulationPolicy")] StorageProviderPopulationPolicy value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, StorageProviderPopulationPolicy, int>)(lpVtbl[21]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.get_InSyncPolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_InSyncPolicy([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderInSyncPolicy *")] StorageProviderInSyncPolicy* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, StorageProviderInSyncPolicy*, int>)(lpVtbl[22]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.put_InSyncPolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_InSyncPolicy([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderInSyncPolicy")] StorageProviderInSyncPolicy value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, StorageProviderInSyncPolicy, int>)(lpVtbl[23]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.get_HardlinkPolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_HardlinkPolicy([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderHardlinkPolicy *")] StorageProviderHardlinkPolicy* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, StorageProviderHardlinkPolicy*, int>)(lpVtbl[24]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.put_HardlinkPolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_HardlinkPolicy([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderHardlinkPolicy")] StorageProviderHardlinkPolicy value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, StorageProviderHardlinkPolicy, int>)(lpVtbl[25]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.get_ShowSiblingsAsGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_ShowSiblingsAsGroup([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, byte*, int>)(lpVtbl[26]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.put_ShowSiblingsAsGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_ShowSiblingsAsGroup([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, byte, int>)(lpVtbl[27]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.get_Version"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_Version(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, HSTRING*, int>)(lpVtbl[28]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.put_Version"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_Version(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, HSTRING, int>)(lpVtbl[29]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.get_ProtectionMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_ProtectionMode([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderProtectionMode *")] StorageProviderProtectionMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, StorageProviderProtectionMode*, int>)(lpVtbl[30]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.put_ProtectionMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_ProtectionMode([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderProtectionMode")] StorageProviderProtectionMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, StorageProviderProtectionMode, int>)(lpVtbl[31]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.get_AllowPinning"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_AllowPinning([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, byte*, int>)(lpVtbl[32]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.put_AllowPinning"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_AllowPinning([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, byte, int>)(lpVtbl[33]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.get_StorageProviderItemPropertyDefinitions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_StorageProviderItemPropertyDefinitions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CProvider__CStorageProviderItemPropertyDefinition_t **")] IVector<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, IVector<IntPtr>**, int>)(lpVtbl[34]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.get_RecycleBinUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_RecycleBinUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, IUriRuntimeClass**, int>)(lpVtbl[35]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderSyncRootInfo.xml' path='doc/member[@name="IStorageProviderSyncRootInfo.put_RecycleBinUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT put_RecycleBinUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo*, IUriRuntimeClass*, int>)(lpVtbl[36]))((IStorageProviderSyncRootInfo*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Id(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_Context([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(9)]
        HRESULT put_Context([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value);

        [VtblIndex(10)]
        HRESULT get_Path([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value);

        [VtblIndex(11)]
        HRESULT put_Path([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* value);

        [VtblIndex(12)]
        HRESULT get_DisplayNameResource(HSTRING* value);

        [VtblIndex(13)]
        HRESULT put_DisplayNameResource(HSTRING value);

        [VtblIndex(14)]
        HRESULT get_IconResource(HSTRING* value);

        [VtblIndex(15)]
        HRESULT put_IconResource(HSTRING value);

        [VtblIndex(16)]
        HRESULT get_HydrationPolicy([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderHydrationPolicy *")] StorageProviderHydrationPolicy* value);

        [VtblIndex(17)]
        HRESULT put_HydrationPolicy([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderHydrationPolicy")] StorageProviderHydrationPolicy value);

        [VtblIndex(18)]
        HRESULT get_HydrationPolicyModifier([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderHydrationPolicyModifier *")] StorageProviderHydrationPolicyModifier* value);

        [VtblIndex(19)]
        HRESULT put_HydrationPolicyModifier([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderHydrationPolicyModifier")] StorageProviderHydrationPolicyModifier value);

        [VtblIndex(20)]
        HRESULT get_PopulationPolicy([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderPopulationPolicy *")] StorageProviderPopulationPolicy* value);

        [VtblIndex(21)]
        HRESULT put_PopulationPolicy([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderPopulationPolicy")] StorageProviderPopulationPolicy value);

        [VtblIndex(22)]
        HRESULT get_InSyncPolicy([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderInSyncPolicy *")] StorageProviderInSyncPolicy* value);

        [VtblIndex(23)]
        HRESULT put_InSyncPolicy([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderInSyncPolicy")] StorageProviderInSyncPolicy value);

        [VtblIndex(24)]
        HRESULT get_HardlinkPolicy([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderHardlinkPolicy *")] StorageProviderHardlinkPolicy* value);

        [VtblIndex(25)]
        HRESULT put_HardlinkPolicy([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderHardlinkPolicy")] StorageProviderHardlinkPolicy value);

        [VtblIndex(26)]
        HRESULT get_ShowSiblingsAsGroup([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(27)]
        HRESULT put_ShowSiblingsAsGroup([NativeTypeName("boolean")] byte value);

        [VtblIndex(28)]
        HRESULT get_Version(HSTRING* value);

        [VtblIndex(29)]
        HRESULT put_Version(HSTRING value);

        [VtblIndex(30)]
        HRESULT get_ProtectionMode([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderProtectionMode *")] StorageProviderProtectionMode* value);

        [VtblIndex(31)]
        HRESULT put_ProtectionMode([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderProtectionMode")] StorageProviderProtectionMode value);

        [VtblIndex(32)]
        HRESULT get_AllowPinning([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(33)]
        HRESULT put_AllowPinning([NativeTypeName("boolean")] byte value);

        [VtblIndex(34)]
        HRESULT get_StorageProviderItemPropertyDefinitions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CProvider__CStorageProviderItemPropertyDefinition_t **")] IVector<IntPtr>** value);

        [VtblIndex(35)]
        HRESULT get_RecycleBinUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);

        [VtblIndex(36)]
        HRESULT put_RecycleBinUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Id;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> get_Context;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, int> put_Context;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder**, int> get_Path;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder*, int> put_Path;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayNameResource;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_DisplayNameResource;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_IconResource;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_IconResource;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::StorageProviderHydrationPolicy *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageProviderHydrationPolicy*, int> get_HydrationPolicy;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::StorageProviderHydrationPolicy) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageProviderHydrationPolicy, int> put_HydrationPolicy;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::StorageProviderHydrationPolicyModifier *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageProviderHydrationPolicyModifier*, int> get_HydrationPolicyModifier;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::StorageProviderHydrationPolicyModifier) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageProviderHydrationPolicyModifier, int> put_HydrationPolicyModifier;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::StorageProviderPopulationPolicy *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageProviderPopulationPolicy*, int> get_PopulationPolicy;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::StorageProviderPopulationPolicy) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageProviderPopulationPolicy, int> put_PopulationPolicy;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::StorageProviderInSyncPolicy *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageProviderInSyncPolicy*, int> get_InSyncPolicy;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::StorageProviderInSyncPolicy) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageProviderInSyncPolicy, int> put_InSyncPolicy;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::StorageProviderHardlinkPolicy *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageProviderHardlinkPolicy*, int> get_HardlinkPolicy;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::StorageProviderHardlinkPolicy) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageProviderHardlinkPolicy, int> put_HardlinkPolicy;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ShowSiblingsAsGroup;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_ShowSiblingsAsGroup;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Version;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Version;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::StorageProviderProtectionMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageProviderProtectionMode*, int> get_ProtectionMode;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::StorageProviderProtectionMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageProviderProtectionMode, int> put_ProtectionMode;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AllowPinning;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_AllowPinning;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CProvider__CStorageProviderItemPropertyDefinition_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<IntPtr>**, int> get_StorageProviderItemPropertyDefinitions;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_RecycleBinUri;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, int> put_RecycleBinUri;
    }
}
