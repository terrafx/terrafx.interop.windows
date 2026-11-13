// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWiaItem.xml' path='doc/member[@name="IWiaItem"]/*' />
[Guid("4DB1AD10-3391-11D2-9A33-00C04FA36145")]
[NativeTypeName("struct IWiaItem : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWiaItem : IWiaItem.Interface, INativeGuid
{
    /// <include file='IWiaItem.xml' path='doc/member[@name="IWiaItem.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWiaItem);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem*, Guid*, void**, int>)(lpVtbl[0]))((IWiaItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem*, uint>)(lpVtbl[1]))((IWiaItem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem*, uint>)(lpVtbl[2]))((IWiaItem*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWiaItem.xml' path='doc/member[@name="IWiaItem.GetItemType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetItemType([NativeTypeName("LONG *")] int* pItemType)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem*, int*, int>)(lpVtbl[3]))((IWiaItem*)Unsafe.AsPointer(ref this), pItemType);
    }

    /// <include file='IWiaItem.xml' path='doc/member[@name="IWiaItem.AnalyzeItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AnalyzeItem([NativeTypeName("LONG")] int lFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem*, int, int>)(lpVtbl[4]))((IWiaItem*)Unsafe.AsPointer(ref this), lFlags);
    }

    /// <include file='IWiaItem.xml' path='doc/member[@name="IWiaItem.EnumChildItems"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EnumChildItems(IEnumWiaItem** ppIEnumWiaItem)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem*, IEnumWiaItem**, int>)(lpVtbl[5]))((IWiaItem*)Unsafe.AsPointer(ref this), ppIEnumWiaItem);
    }

    /// <include file='IWiaItem.xml' path='doc/member[@name="IWiaItem.DeleteItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT DeleteItem([NativeTypeName("LONG")] int lFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem*, int, int>)(lpVtbl[6]))((IWiaItem*)Unsafe.AsPointer(ref this), lFlags);
    }

    /// <include file='IWiaItem.xml' path='doc/member[@name="IWiaItem.CreateChildItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateChildItem([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrItemName, [NativeTypeName("BSTR")] char* bstrFullItemName, IWiaItem** ppIWiaItem)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem*, int, char*, char*, IWiaItem**, int>)(lpVtbl[7]))((IWiaItem*)Unsafe.AsPointer(ref this), lFlags, bstrItemName, bstrFullItemName, ppIWiaItem);
    }

    /// <include file='IWiaItem.xml' path='doc/member[@name="IWiaItem.EnumRegisterEventInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT EnumRegisterEventInfo([NativeTypeName("LONG")] int lFlags, [NativeTypeName("const GUID *")] Guid* pEventGUID, IEnumWIA_DEV_CAPS** ppIEnum)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem*, int, Guid*, IEnumWIA_DEV_CAPS**, int>)(lpVtbl[8]))((IWiaItem*)Unsafe.AsPointer(ref this), lFlags, pEventGUID, ppIEnum);
    }

    /// <include file='IWiaItem.xml' path='doc/member[@name="IWiaItem.FindItemByName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FindItemByName([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrFullItemName, IWiaItem** ppIWiaItem)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem*, int, char*, IWiaItem**, int>)(lpVtbl[9]))((IWiaItem*)Unsafe.AsPointer(ref this), lFlags, bstrFullItemName, ppIWiaItem);
    }

    /// <include file='IWiaItem.xml' path='doc/member[@name="IWiaItem.DeviceDlg"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT DeviceDlg(HWND hwndParent, [NativeTypeName("LONG")] int lFlags, [NativeTypeName("LONG")] int lIntent, [NativeTypeName("LONG *")] int* plItemCount, IWiaItem*** ppIWiaItem)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem*, HWND, int, int, int*, IWiaItem***, int>)(lpVtbl[10]))((IWiaItem*)Unsafe.AsPointer(ref this), hwndParent, lFlags, lIntent, plItemCount, ppIWiaItem);
    }

    /// <include file='IWiaItem.xml' path='doc/member[@name="IWiaItem.DeviceCommand"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT DeviceCommand([NativeTypeName("LONG")] int lFlags, [NativeTypeName("const GUID *")] Guid* pCmdGUID, IWiaItem** pIWiaItem)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem*, int, Guid*, IWiaItem**, int>)(lpVtbl[11]))((IWiaItem*)Unsafe.AsPointer(ref this), lFlags, pCmdGUID, pIWiaItem);
    }

    /// <include file='IWiaItem.xml' path='doc/member[@name="IWiaItem.GetRootItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetRootItem(IWiaItem** ppIWiaItem)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem*, IWiaItem**, int>)(lpVtbl[12]))((IWiaItem*)Unsafe.AsPointer(ref this), ppIWiaItem);
    }

    /// <include file='IWiaItem.xml' path='doc/member[@name="IWiaItem.EnumDeviceCapabilities"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT EnumDeviceCapabilities([NativeTypeName("LONG")] int lFlags, IEnumWIA_DEV_CAPS** ppIEnumWIA_DEV_CAPS)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem*, int, IEnumWIA_DEV_CAPS**, int>)(lpVtbl[13]))((IWiaItem*)Unsafe.AsPointer(ref this), lFlags, ppIEnumWIA_DEV_CAPS);
    }

    /// <include file='IWiaItem.xml' path='doc/member[@name="IWiaItem.DumpItemData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT DumpItemData([NativeTypeName("BSTR *")] char** bstrData)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem*, char**, int>)(lpVtbl[14]))((IWiaItem*)Unsafe.AsPointer(ref this), bstrData);
    }

    /// <include file='IWiaItem.xml' path='doc/member[@name="IWiaItem.DumpDrvItemData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT DumpDrvItemData([NativeTypeName("BSTR *")] char** bstrData)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem*, char**, int>)(lpVtbl[15]))((IWiaItem*)Unsafe.AsPointer(ref this), bstrData);
    }

    /// <include file='IWiaItem.xml' path='doc/member[@name="IWiaItem.DumpTreeItemData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT DumpTreeItemData([NativeTypeName("BSTR *")] char** bstrData)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem*, char**, int>)(lpVtbl[16]))((IWiaItem*)Unsafe.AsPointer(ref this), bstrData);
    }

    /// <include file='IWiaItem.xml' path='doc/member[@name="IWiaItem.Diagnostic"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT Diagnostic([NativeTypeName("ULONG")] uint ulSize, byte* pBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem*, uint, byte*, int>)(lpVtbl[17]))((IWiaItem*)Unsafe.AsPointer(ref this), ulSize, pBuffer);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetItemType([NativeTypeName("LONG *")] int* pItemType);

        [VtblIndex(4)]
        HRESULT AnalyzeItem([NativeTypeName("LONG")] int lFlags);

        [VtblIndex(5)]
        HRESULT EnumChildItems(IEnumWiaItem** ppIEnumWiaItem);

        [VtblIndex(6)]
        HRESULT DeleteItem([NativeTypeName("LONG")] int lFlags);

        [VtblIndex(7)]
        HRESULT CreateChildItem([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrItemName, [NativeTypeName("BSTR")] char* bstrFullItemName, IWiaItem** ppIWiaItem);

        [VtblIndex(8)]
        HRESULT EnumRegisterEventInfo([NativeTypeName("LONG")] int lFlags, [NativeTypeName("const GUID *")] Guid* pEventGUID, IEnumWIA_DEV_CAPS** ppIEnum);

        [VtblIndex(9)]
        HRESULT FindItemByName([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrFullItemName, IWiaItem** ppIWiaItem);

        [VtblIndex(10)]
        HRESULT DeviceDlg(HWND hwndParent, [NativeTypeName("LONG")] int lFlags, [NativeTypeName("LONG")] int lIntent, [NativeTypeName("LONG *")] int* plItemCount, IWiaItem*** ppIWiaItem);

        [VtblIndex(11)]
        HRESULT DeviceCommand([NativeTypeName("LONG")] int lFlags, [NativeTypeName("const GUID *")] Guid* pCmdGUID, IWiaItem** pIWiaItem);

        [VtblIndex(12)]
        HRESULT GetRootItem(IWiaItem** ppIWiaItem);

        [VtblIndex(13)]
        HRESULT EnumDeviceCapabilities([NativeTypeName("LONG")] int lFlags, IEnumWIA_DEV_CAPS** ppIEnumWIA_DEV_CAPS);

        [VtblIndex(14)]
        HRESULT DumpItemData([NativeTypeName("BSTR *")] char** bstrData);

        [VtblIndex(15)]
        HRESULT DumpDrvItemData([NativeTypeName("BSTR *")] char** bstrData);

        [VtblIndex(16)]
        HRESULT DumpTreeItemData([NativeTypeName("BSTR *")] char** bstrData);

        [VtblIndex(17)]
        HRESULT Diagnostic([NativeTypeName("ULONG")] uint ulSize, byte* pBuffer);
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

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> GetItemType;

        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> AnalyzeItem;

        [NativeTypeName("HRESULT (IEnumWiaItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEnumWiaItem**, int> EnumChildItems;

        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> DeleteItem;

        [NativeTypeName("HRESULT (LONG, BSTR, BSTR, IWiaItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, char*, char*, IWiaItem**, int> CreateChildItem;

        [NativeTypeName("HRESULT (LONG, const GUID *, IEnumWIA_DEV_CAPS **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, IEnumWIA_DEV_CAPS**, int> EnumRegisterEventInfo;

        [NativeTypeName("HRESULT (LONG, BSTR, IWiaItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, char*, IWiaItem**, int> FindItemByName;

        [NativeTypeName("HRESULT (HWND, LONG, LONG, LONG *, IWiaItem ***) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND, int, int, int*, IWiaItem***, int> DeviceDlg;

        [NativeTypeName("HRESULT (LONG, const GUID *, IWiaItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, IWiaItem**, int> DeviceCommand;

        [NativeTypeName("HRESULT (IWiaItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWiaItem**, int> GetRootItem;

        [NativeTypeName("HRESULT (LONG, IEnumWIA_DEV_CAPS **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, IEnumWIA_DEV_CAPS**, int> EnumDeviceCapabilities;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> DumpItemData;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> DumpDrvItemData;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> DumpTreeItemData;

        [NativeTypeName("HRESULT (ULONG, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> Diagnostic;
    }
}
