// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.wallet.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem"]/*' />
[Guid("20B54BE8-118D-4EC4-996C-B963E7BD3E74")]
[NativeTypeName("struct IWalletItem : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
public unsafe partial struct IWalletItem : IWalletItem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWalletItem);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, Guid*, void**, int>)(lpVtbl[0]))((IWalletItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, uint>)(lpVtbl[1]))((IWalletItem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, uint>)(lpVtbl[2]))((IWalletItem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, uint*, Guid**, int>)(lpVtbl[3]))((IWalletItem*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, HSTRING*, int>)(lpVtbl[4]))((IWalletItem*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, TrustLevel*, int>)(lpVtbl[5]))((IWalletItem*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, HSTRING*, int>)(lpVtbl[6]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.put_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_DisplayName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, HSTRING, int>)(lpVtbl[7]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, HSTRING*, int>)(lpVtbl[8]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_IsAcknowledged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_IsAcknowledged([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, byte*, int>)(lpVtbl[9]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.put_IsAcknowledged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_IsAcknowledged([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, byte, int>)(lpVtbl[10]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_IssuerDisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_IssuerDisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, HSTRING*, int>)(lpVtbl[11]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.put_IssuerDisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_IssuerDisplayName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, HSTRING, int>)(lpVtbl[12]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_LastUpdated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_LastUpdated([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, IReference<DateTime>**, int>)(lpVtbl[13]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.put_LastUpdated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_LastUpdated([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, IReference<DateTime>*, int>)(lpVtbl[14]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletItemKind *")] WalletItemKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, WalletItemKind*, int>)(lpVtbl[15]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_Barcode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_Barcode([NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletBarcode **")] IWalletBarcode** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, IWalletBarcode**, int>)(lpVtbl[16]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.put_Barcode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_Barcode([NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletBarcode *")] IWalletBarcode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, IWalletBarcode*, int>)(lpVtbl[17]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_ExpirationDate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_ExpirationDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, IReference<DateTime>**, int>)(lpVtbl[18]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.put_ExpirationDate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_ExpirationDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, IReference<DateTime>*, int>)(lpVtbl[19]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_Logo159x159"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_Logo159x159([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, IRandomAccessStreamReference**, int>)(lpVtbl[20]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.put_Logo159x159"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_Logo159x159([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, IRandomAccessStreamReference*, int>)(lpVtbl[21]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_Logo336x336"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_Logo336x336([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, IRandomAccessStreamReference**, int>)(lpVtbl[22]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.put_Logo336x336"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_Logo336x336([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, IRandomAccessStreamReference*, int>)(lpVtbl[23]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_Logo99x99"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_Logo99x99([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, IRandomAccessStreamReference**, int>)(lpVtbl[24]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.put_Logo99x99"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_Logo99x99([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, IRandomAccessStreamReference*, int>)(lpVtbl[25]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_DisplayMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_DisplayMessage(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, HSTRING*, int>)(lpVtbl[26]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.put_DisplayMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_DisplayMessage(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, HSTRING, int>)(lpVtbl[27]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_IsDisplayMessageLaunchable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_IsDisplayMessageLaunchable([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, byte*, int>)(lpVtbl[28]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.put_IsDisplayMessageLaunchable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_IsDisplayMessageLaunchable([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, byte, int>)(lpVtbl[29]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_LogoText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_LogoText(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, HSTRING*, int>)(lpVtbl[30]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.put_LogoText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_LogoText(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, HSTRING, int>)(lpVtbl[31]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_HeaderColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_HeaderColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, Color*, int>)(lpVtbl[32]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.put_HeaderColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_HeaderColor([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, Color, int>)(lpVtbl[33]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_BodyColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_BodyColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, Color*, int>)(lpVtbl[34]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.put_BodyColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_BodyColor([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, Color, int>)(lpVtbl[35]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_HeaderFontColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_HeaderFontColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, Color*, int>)(lpVtbl[36]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.put_HeaderFontColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_HeaderFontColor([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, Color, int>)(lpVtbl[37]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_BodyFontColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_BodyFontColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, Color*, int>)(lpVtbl[38]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.put_BodyFontColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_BodyFontColor([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, Color, int>)(lpVtbl[39]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_HeaderBackgroundImage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_HeaderBackgroundImage([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, IRandomAccessStreamReference**, int>)(lpVtbl[40]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.put_HeaderBackgroundImage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_HeaderBackgroundImage([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, IRandomAccessStreamReference*, int>)(lpVtbl[41]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_BodyBackgroundImage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_BodyBackgroundImage([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, IRandomAccessStreamReference**, int>)(lpVtbl[42]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.put_BodyBackgroundImage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_BodyBackgroundImage([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, IRandomAccessStreamReference*, int>)(lpVtbl[43]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_LogoImage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_LogoImage([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, IRandomAccessStreamReference**, int>)(lpVtbl[44]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.put_LogoImage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_LogoImage([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, IRandomAccessStreamReference*, int>)(lpVtbl[45]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_PromotionalImage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_PromotionalImage([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, IRandomAccessStreamReference**, int>)(lpVtbl[46]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.put_PromotionalImage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_PromotionalImage([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, IRandomAccessStreamReference*, int>)(lpVtbl[47]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_RelevantDate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_RelevantDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, IReference<DateTime>**, int>)(lpVtbl[48]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.put_RelevantDate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_RelevantDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, IReference<DateTime>*, int>)(lpVtbl[49]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_RelevantDateDisplayMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_RelevantDateDisplayMessage(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, HSTRING*, int>)(lpVtbl[50]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.put_RelevantDateDisplayMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_RelevantDateDisplayMessage(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, HSTRING, int>)(lpVtbl[51]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_TransactionHistory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_TransactionHistory([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CApplicationModel__CWallet__CWalletTransaction_t **")] IMap<HSTRING, Pointer<IWalletTransaction>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, IMap<HSTRING, Pointer<IWalletTransaction>>**, int>)(lpVtbl[52]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_RelevantLocations"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_RelevantLocations([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CApplicationModel__CWallet__CWalletRelevantLocation_t **")] IMap<HSTRING, Pointer<IWalletRelevantLocation>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, IMap<HSTRING, Pointer<IWalletRelevantLocation>>**, int>)(lpVtbl[53]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_IsMoreTransactionHistoryLaunchable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_IsMoreTransactionHistoryLaunchable([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, byte*, int>)(lpVtbl[54]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.put_IsMoreTransactionHistoryLaunchable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_IsMoreTransactionHistoryLaunchable([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, byte, int>)(lpVtbl[55]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_DisplayProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_DisplayProperties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CApplicationModel__CWallet__CWalletItemCustomProperty_t **")] IMap<HSTRING, Pointer<IWalletItemCustomProperty>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, IMap<HSTRING, Pointer<IWalletItemCustomProperty>>**, int>)(lpVtbl[56]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItem.xml' path='doc/member[@name="IWalletItem.get_Verbs"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_Verbs([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CApplicationModel__CWallet__CWalletVerb_t **")] IMap<HSTRING, Pointer<IWalletVerb>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItem*, IMap<HSTRING, Pointer<IWalletVerb>>**, int>)(lpVtbl[57]))((IWalletItem*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(7)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_DisplayName(HSTRING value);

        [VtblIndex(8)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(9)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_IsAcknowledged([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_IsAcknowledged([NativeTypeName("boolean")] byte value);

        [VtblIndex(11)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_IssuerDisplayName(HSTRING* value);

        [VtblIndex(12)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_IssuerDisplayName(HSTRING value);

        [VtblIndex(13)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_LastUpdated([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);

        [VtblIndex(14)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_LastUpdated([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value);

        [VtblIndex(15)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletItemKind *")] WalletItemKind* value);

        [VtblIndex(16)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_Barcode([NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletBarcode **")] IWalletBarcode** value);

        [VtblIndex(17)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_Barcode([NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletBarcode *")] IWalletBarcode* value);

        [VtblIndex(18)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_ExpirationDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);

        [VtblIndex(19)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_ExpirationDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value);

        [VtblIndex(20)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_Logo159x159([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value);

        [VtblIndex(21)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_Logo159x159([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value);

        [VtblIndex(22)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_Logo336x336([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value);

        [VtblIndex(23)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_Logo336x336([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value);

        [VtblIndex(24)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_Logo99x99([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value);

        [VtblIndex(25)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_Logo99x99([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value);

        [VtblIndex(26)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_DisplayMessage(HSTRING* value);

        [VtblIndex(27)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_DisplayMessage(HSTRING value);

        [VtblIndex(28)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_IsDisplayMessageLaunchable([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(29)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_IsDisplayMessageLaunchable([NativeTypeName("boolean")] byte value);

        [VtblIndex(30)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_LogoText(HSTRING* value);

        [VtblIndex(31)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_LogoText(HSTRING value);

        [VtblIndex(32)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_HeaderColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(33)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_HeaderColor([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(34)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_BodyColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(35)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_BodyColor([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(36)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_HeaderFontColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(37)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_HeaderFontColor([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(38)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_BodyFontColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(39)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_BodyFontColor([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(40)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_HeaderBackgroundImage([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value);

        [VtblIndex(41)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_HeaderBackgroundImage([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value);

        [VtblIndex(42)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_BodyBackgroundImage([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value);

        [VtblIndex(43)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_BodyBackgroundImage([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value);

        [VtblIndex(44)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_LogoImage([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value);

        [VtblIndex(45)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_LogoImage([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value);

        [VtblIndex(46)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_PromotionalImage([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value);

        [VtblIndex(47)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_PromotionalImage([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value);

        [VtblIndex(48)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_RelevantDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);

        [VtblIndex(49)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_RelevantDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value);

        [VtblIndex(50)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_RelevantDateDisplayMessage(HSTRING* value);

        [VtblIndex(51)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_RelevantDateDisplayMessage(HSTRING value);

        [VtblIndex(52)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_TransactionHistory([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CApplicationModel__CWallet__CWalletTransaction_t **")] IMap<HSTRING, Pointer<IWalletTransaction>>** value);

        [VtblIndex(53)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_RelevantLocations([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CApplicationModel__CWallet__CWalletRelevantLocation_t **")] IMap<HSTRING, Pointer<IWalletRelevantLocation>>** value);

        [VtblIndex(54)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_IsMoreTransactionHistoryLaunchable([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(55)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_IsMoreTransactionHistoryLaunchable([NativeTypeName("boolean")] byte value);

        [VtblIndex(56)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_DisplayProperties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CApplicationModel__CWallet__CWalletItemCustomProperty_t **")] IMap<HSTRING, Pointer<IWalletItemCustomProperty>>** value);

        [VtblIndex(57)]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_Verbs([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CApplicationModel__CWallet__CWalletVerb_t **")] IMap<HSTRING, Pointer<IWalletVerb>>** value);
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
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_DisplayName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsAcknowledged;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsAcknowledged;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_IssuerDisplayName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_IssuerDisplayName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_LastUpdated;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>*, int> put_LastUpdated;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Wallet::WalletItemKind *) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WalletItemKind*, int> get_Kind;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Wallet::IWalletBarcode **) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWalletBarcode**, int> get_Barcode;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Wallet::IWalletBarcode *) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWalletBarcode*, int> put_Barcode;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_ExpirationDate;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>*, int> put_ExpirationDate;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference**, int> get_Logo159x159;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference*, int> put_Logo159x159;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference**, int> get_Logo336x336;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference*, int> put_Logo336x336;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference**, int> get_Logo99x99;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference*, int> put_Logo99x99;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayMessage;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_DisplayMessage;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsDisplayMessageLaunchable;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsDisplayMessageLaunchable;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_LogoText;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_LogoText;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color*, int> get_HeaderColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color, int> put_HeaderColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color*, int> get_BodyColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color, int> put_BodyColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color*, int> get_HeaderFontColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color, int> put_HeaderFontColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color*, int> get_BodyFontColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color, int> put_BodyFontColor;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference**, int> get_HeaderBackgroundImage;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference*, int> put_HeaderBackgroundImage;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference**, int> get_BodyBackgroundImage;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference*, int> put_BodyBackgroundImage;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference**, int> get_LogoImage;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference*, int> put_LogoImage;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference**, int> get_PromotionalImage;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference*, int> put_PromotionalImage;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_RelevantDate;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>*, int> put_RelevantDate;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RelevantDateDisplayMessage;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_RelevantDateDisplayMessage;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CApplicationModel__CWallet__CWalletTransaction_t **) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMap<HSTRING, Pointer<IWalletTransaction>>**, int> get_TransactionHistory;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CApplicationModel__CWallet__CWalletRelevantLocation_t **) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMap<HSTRING, Pointer<IWalletRelevantLocation>>**, int> get_RelevantLocations;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsMoreTransactionHistoryLaunchable;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsMoreTransactionHistoryLaunchable;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CApplicationModel__CWallet__CWalletItemCustomProperty_t **) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMap<HSTRING, Pointer<IWalletItemCustomProperty>>**, int> get_DisplayProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CApplicationModel__CWallet__CWalletVerb_t **) __attribute__((stdcall))")]
        [Obsolete("IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMap<HSTRING, Pointer<IWalletVerb>>**, int> get_Verbs;
    }
}
