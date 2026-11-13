// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWiaItem2.xml' path='doc/member[@name="IWiaItem2"]/*' />
[Guid("6CBA0075-1287-407D-9B77-CF0E030435CC")]
[NativeTypeName("struct IWiaItem2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWiaItem2 : IWiaItem2.Interface, INativeGuid
{
    /// <include file='IWiaItem2.xml' path='doc/member[@name="IWiaItem2.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWiaItem2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem2*, Guid*, void**, int>)(lpVtbl[0]))((IWiaItem2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem2*, uint>)(lpVtbl[1]))((IWiaItem2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem2*, uint>)(lpVtbl[2]))((IWiaItem2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWiaItem2.xml' path='doc/member[@name="IWiaItem2.CreateChildItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateChildItem([NativeTypeName("LONG")] int lItemFlags, [NativeTypeName("LONG")] int lCreationFlags, [NativeTypeName("BSTR")] char* bstrItemName, IWiaItem2** ppIWiaItem2)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem2*, int, int, char*, IWiaItem2**, int>)(lpVtbl[3]))((IWiaItem2*)Unsafe.AsPointer(ref this), lItemFlags, lCreationFlags, bstrItemName, ppIWiaItem2);
    }

    /// <include file='IWiaItem2.xml' path='doc/member[@name="IWiaItem2.DeleteItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT DeleteItem([NativeTypeName("LONG")] int lFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem2*, int, int>)(lpVtbl[4]))((IWiaItem2*)Unsafe.AsPointer(ref this), lFlags);
    }

    /// <include file='IWiaItem2.xml' path='doc/member[@name="IWiaItem2.EnumChildItems"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EnumChildItems([NativeTypeName("const GUID *")] Guid* pCategoryGUID, IEnumWiaItem2** ppIEnumWiaItem2)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem2*, Guid*, IEnumWiaItem2**, int>)(lpVtbl[5]))((IWiaItem2*)Unsafe.AsPointer(ref this), pCategoryGUID, ppIEnumWiaItem2);
    }

    /// <include file='IWiaItem2.xml' path='doc/member[@name="IWiaItem2.FindItemByName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindItemByName([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrFullItemName, IWiaItem2** ppIWiaItem2)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem2*, int, char*, IWiaItem2**, int>)(lpVtbl[6]))((IWiaItem2*)Unsafe.AsPointer(ref this), lFlags, bstrFullItemName, ppIWiaItem2);
    }

    /// <include file='IWiaItem2.xml' path='doc/member[@name="IWiaItem2.GetItemCategory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetItemCategory(Guid* pItemCategoryGUID)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem2*, Guid*, int>)(lpVtbl[7]))((IWiaItem2*)Unsafe.AsPointer(ref this), pItemCategoryGUID);
    }

    /// <include file='IWiaItem2.xml' path='doc/member[@name="IWiaItem2.GetItemType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetItemType([NativeTypeName("LONG *")] int* pItemType)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem2*, int*, int>)(lpVtbl[8]))((IWiaItem2*)Unsafe.AsPointer(ref this), pItemType);
    }

    /// <include file='IWiaItem2.xml' path='doc/member[@name="IWiaItem2.DeviceDlg"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT DeviceDlg([NativeTypeName("LONG")] int lFlags, HWND hwndParent, [NativeTypeName("BSTR")] char* bstrFolderName, [NativeTypeName("BSTR")] char* bstrFilename, [NativeTypeName("LONG *")] int* plNumFiles, [NativeTypeName("BSTR **")] char*** ppbstrFilePaths, IWiaItem2** ppItem)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem2*, int, HWND, char*, char*, int*, char***, IWiaItem2**, int>)(lpVtbl[9]))((IWiaItem2*)Unsafe.AsPointer(ref this), lFlags, hwndParent, bstrFolderName, bstrFilename, plNumFiles, ppbstrFilePaths, ppItem);
    }

    /// <include file='IWiaItem2.xml' path='doc/member[@name="IWiaItem2.DeviceCommand"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT DeviceCommand([NativeTypeName("LONG")] int lFlags, [NativeTypeName("const GUID *")] Guid* pCmdGUID, IWiaItem2** ppIWiaItem2)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem2*, int, Guid*, IWiaItem2**, int>)(lpVtbl[10]))((IWiaItem2*)Unsafe.AsPointer(ref this), lFlags, pCmdGUID, ppIWiaItem2);
    }

    /// <include file='IWiaItem2.xml' path='doc/member[@name="IWiaItem2.EnumDeviceCapabilities"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT EnumDeviceCapabilities([NativeTypeName("LONG")] int lFlags, IEnumWIA_DEV_CAPS** ppIEnumWIA_DEV_CAPS)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem2*, int, IEnumWIA_DEV_CAPS**, int>)(lpVtbl[11]))((IWiaItem2*)Unsafe.AsPointer(ref this), lFlags, ppIEnumWIA_DEV_CAPS);
    }

    /// <include file='IWiaItem2.xml' path='doc/member[@name="IWiaItem2.CheckExtension"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CheckExtension([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrName, [NativeTypeName("const IID &")] Guid* riidExtensionInterface, BOOL* pbExtensionExists)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem2*, int, char*, Guid*, BOOL*, int>)(lpVtbl[12]))((IWiaItem2*)Unsafe.AsPointer(ref this), lFlags, bstrName, riidExtensionInterface, pbExtensionExists);
    }

    /// <include file='IWiaItem2.xml' path='doc/member[@name="IWiaItem2.GetExtension"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetExtension([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrName, [NativeTypeName("const IID &")] Guid* riidExtensionInterface, void** ppOut)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem2*, int, char*, Guid*, void**, int>)(lpVtbl[13]))((IWiaItem2*)Unsafe.AsPointer(ref this), lFlags, bstrName, riidExtensionInterface, ppOut);
    }

    /// <include file='IWiaItem2.xml' path='doc/member[@name="IWiaItem2.GetParentItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetParentItem(IWiaItem2** ppIWiaItem2)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem2*, IWiaItem2**, int>)(lpVtbl[14]))((IWiaItem2*)Unsafe.AsPointer(ref this), ppIWiaItem2);
    }

    /// <include file='IWiaItem2.xml' path='doc/member[@name="IWiaItem2.GetRootItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetRootItem(IWiaItem2** ppIWiaItem2)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem2*, IWiaItem2**, int>)(lpVtbl[15]))((IWiaItem2*)Unsafe.AsPointer(ref this), ppIWiaItem2);
    }

    /// <include file='IWiaItem2.xml' path='doc/member[@name="IWiaItem2.GetPreviewComponent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetPreviewComponent([NativeTypeName("LONG")] int lFlags, IWiaPreview** ppWiaPreview)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem2*, int, IWiaPreview**, int>)(lpVtbl[16]))((IWiaItem2*)Unsafe.AsPointer(ref this), lFlags, ppWiaPreview);
    }

    /// <include file='IWiaItem2.xml' path='doc/member[@name="IWiaItem2.EnumRegisterEventInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT EnumRegisterEventInfo([NativeTypeName("LONG")] int lFlags, [NativeTypeName("const GUID *")] Guid* pEventGUID, IEnumWIA_DEV_CAPS** ppIEnum)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem2*, int, Guid*, IEnumWIA_DEV_CAPS**, int>)(lpVtbl[17]))((IWiaItem2*)Unsafe.AsPointer(ref this), lFlags, pEventGUID, ppIEnum);
    }

    /// <include file='IWiaItem2.xml' path='doc/member[@name="IWiaItem2.Diagnostic"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT Diagnostic([NativeTypeName("ULONG")] uint ulSize, byte* pBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItem2*, uint, byte*, int>)(lpVtbl[18]))((IWiaItem2*)Unsafe.AsPointer(ref this), ulSize, pBuffer);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateChildItem([NativeTypeName("LONG")] int lItemFlags, [NativeTypeName("LONG")] int lCreationFlags, [NativeTypeName("BSTR")] char* bstrItemName, IWiaItem2** ppIWiaItem2);

        [VtblIndex(4)]
        HRESULT DeleteItem([NativeTypeName("LONG")] int lFlags);

        [VtblIndex(5)]
        HRESULT EnumChildItems([NativeTypeName("const GUID *")] Guid* pCategoryGUID, IEnumWiaItem2** ppIEnumWiaItem2);

        [VtblIndex(6)]
        HRESULT FindItemByName([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrFullItemName, IWiaItem2** ppIWiaItem2);

        [VtblIndex(7)]
        HRESULT GetItemCategory(Guid* pItemCategoryGUID);

        [VtblIndex(8)]
        HRESULT GetItemType([NativeTypeName("LONG *")] int* pItemType);

        [VtblIndex(9)]
        HRESULT DeviceDlg([NativeTypeName("LONG")] int lFlags, HWND hwndParent, [NativeTypeName("BSTR")] char* bstrFolderName, [NativeTypeName("BSTR")] char* bstrFilename, [NativeTypeName("LONG *")] int* plNumFiles, [NativeTypeName("BSTR **")] char*** ppbstrFilePaths, IWiaItem2** ppItem);

        [VtblIndex(10)]
        HRESULT DeviceCommand([NativeTypeName("LONG")] int lFlags, [NativeTypeName("const GUID *")] Guid* pCmdGUID, IWiaItem2** ppIWiaItem2);

        [VtblIndex(11)]
        HRESULT EnumDeviceCapabilities([NativeTypeName("LONG")] int lFlags, IEnumWIA_DEV_CAPS** ppIEnumWIA_DEV_CAPS);

        [VtblIndex(12)]
        HRESULT CheckExtension([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrName, [NativeTypeName("const IID &")] Guid* riidExtensionInterface, BOOL* pbExtensionExists);

        [VtblIndex(13)]
        HRESULT GetExtension([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrName, [NativeTypeName("const IID &")] Guid* riidExtensionInterface, void** ppOut);

        [VtblIndex(14)]
        HRESULT GetParentItem(IWiaItem2** ppIWiaItem2);

        [VtblIndex(15)]
        HRESULT GetRootItem(IWiaItem2** ppIWiaItem2);

        [VtblIndex(16)]
        HRESULT GetPreviewComponent([NativeTypeName("LONG")] int lFlags, IWiaPreview** ppWiaPreview);

        [VtblIndex(17)]
        HRESULT EnumRegisterEventInfo([NativeTypeName("LONG")] int lFlags, [NativeTypeName("const GUID *")] Guid* pEventGUID, IEnumWIA_DEV_CAPS** ppIEnum);

        [VtblIndex(18)]
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

        [NativeTypeName("HRESULT (LONG, LONG, BSTR, IWiaItem2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, char*, IWiaItem2**, int> CreateChildItem;

        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> DeleteItem;

        [NativeTypeName("HRESULT (const GUID *, IEnumWiaItem2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, IEnumWiaItem2**, int> EnumChildItems;

        [NativeTypeName("HRESULT (LONG, BSTR, IWiaItem2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, char*, IWiaItem2**, int> FindItemByName;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetItemCategory;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> GetItemType;

        [NativeTypeName("HRESULT (LONG, HWND, BSTR, BSTR, LONG *, BSTR **, IWiaItem2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, HWND, char*, char*, int*, char***, IWiaItem2**, int> DeviceDlg;

        [NativeTypeName("HRESULT (LONG, const GUID *, IWiaItem2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, IWiaItem2**, int> DeviceCommand;

        [NativeTypeName("HRESULT (LONG, IEnumWIA_DEV_CAPS **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, IEnumWIA_DEV_CAPS**, int> EnumDeviceCapabilities;

        [NativeTypeName("HRESULT (LONG, BSTR, const IID &, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, char*, Guid*, BOOL*, int> CheckExtension;

        [NativeTypeName("HRESULT (LONG, BSTR, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, char*, Guid*, void**, int> GetExtension;

        [NativeTypeName("HRESULT (IWiaItem2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWiaItem2**, int> GetParentItem;

        [NativeTypeName("HRESULT (IWiaItem2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWiaItem2**, int> GetRootItem;

        [NativeTypeName("HRESULT (LONG, IWiaPreview **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, IWiaPreview**, int> GetPreviewComponent;

        [NativeTypeName("HRESULT (LONG, const GUID *, IEnumWIA_DEV_CAPS **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, IEnumWIA_DEV_CAPS**, int> EnumRegisterEventInfo;

        [NativeTypeName("HRESULT (ULONG, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> Diagnostic;
    }
}
