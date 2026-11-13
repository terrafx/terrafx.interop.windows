// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWiaDevMgr2.xml' path='doc/member[@name="IWiaDevMgr2"]/*' />
[Guid("79C07CF1-CBDD-41EE-8EC3-F00080CADA7A")]
[NativeTypeName("struct IWiaDevMgr2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWiaDevMgr2 : IWiaDevMgr2.Interface, INativeGuid
{
    /// <include file='IWiaDevMgr2.xml' path='doc/member[@name="IWiaDevMgr2.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWiaDevMgr2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDevMgr2*, Guid*, void**, int>)(lpVtbl[0]))((IWiaDevMgr2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDevMgr2*, uint>)(lpVtbl[1]))((IWiaDevMgr2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDevMgr2*, uint>)(lpVtbl[2]))((IWiaDevMgr2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWiaDevMgr2.xml' path='doc/member[@name="IWiaDevMgr2.EnumDeviceInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EnumDeviceInfo([NativeTypeName("LONG")] int lFlags, IEnumWIA_DEV_INFO** ppIEnum)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDevMgr2*, int, IEnumWIA_DEV_INFO**, int>)(lpVtbl[3]))((IWiaDevMgr2*)Unsafe.AsPointer(ref this), lFlags, ppIEnum);
    }

    /// <include file='IWiaDevMgr2.xml' path='doc/member[@name="IWiaDevMgr2.CreateDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateDevice([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrDeviceID, IWiaItem2** ppWiaItem2Root)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDevMgr2*, int, char*, IWiaItem2**, int>)(lpVtbl[4]))((IWiaDevMgr2*)Unsafe.AsPointer(ref this), lFlags, bstrDeviceID, ppWiaItem2Root);
    }

    /// <include file='IWiaDevMgr2.xml' path='doc/member[@name="IWiaDevMgr2.SelectDeviceDlg"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SelectDeviceDlg(HWND hwndParent, [NativeTypeName("LONG")] int lDeviceType, [NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR *")] char** pbstrDeviceID, IWiaItem2** ppItemRoot)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDevMgr2*, HWND, int, int, char**, IWiaItem2**, int>)(lpVtbl[5]))((IWiaDevMgr2*)Unsafe.AsPointer(ref this), hwndParent, lDeviceType, lFlags, pbstrDeviceID, ppItemRoot);
    }

    /// <include file='IWiaDevMgr2.xml' path='doc/member[@name="IWiaDevMgr2.SelectDeviceDlgID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SelectDeviceDlgID(HWND hwndParent, [NativeTypeName("LONG")] int lDeviceType, [NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR *")] char** pbstrDeviceID)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDevMgr2*, HWND, int, int, char**, int>)(lpVtbl[6]))((IWiaDevMgr2*)Unsafe.AsPointer(ref this), hwndParent, lDeviceType, lFlags, pbstrDeviceID);
    }

    /// <include file='IWiaDevMgr2.xml' path='doc/member[@name="IWiaDevMgr2.RegisterEventCallbackInterface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RegisterEventCallbackInterface([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrDeviceID, [NativeTypeName("const GUID *")] Guid* pEventGUID, IWiaEventCallback* pIWiaEventCallback, IUnknown** pEventObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDevMgr2*, int, char*, Guid*, IWiaEventCallback*, IUnknown**, int>)(lpVtbl[7]))((IWiaDevMgr2*)Unsafe.AsPointer(ref this), lFlags, bstrDeviceID, pEventGUID, pIWiaEventCallback, pEventObject);
    }

    /// <include file='IWiaDevMgr2.xml' path='doc/member[@name="IWiaDevMgr2.RegisterEventCallbackProgram"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RegisterEventCallbackProgram([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrDeviceID, [NativeTypeName("const GUID *")] Guid* pEventGUID, [NativeTypeName("BSTR")] char* bstrFullAppName, [NativeTypeName("BSTR")] char* bstrCommandLineArg, [NativeTypeName("BSTR")] char* bstrName, [NativeTypeName("BSTR")] char* bstrDescription, [NativeTypeName("BSTR")] char* bstrIcon)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDevMgr2*, int, char*, Guid*, char*, char*, char*, char*, char*, int>)(lpVtbl[8]))((IWiaDevMgr2*)Unsafe.AsPointer(ref this), lFlags, bstrDeviceID, pEventGUID, bstrFullAppName, bstrCommandLineArg, bstrName, bstrDescription, bstrIcon);
    }

    /// <include file='IWiaDevMgr2.xml' path='doc/member[@name="IWiaDevMgr2.RegisterEventCallbackCLSID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RegisterEventCallbackCLSID([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrDeviceID, [NativeTypeName("const GUID *")] Guid* pEventGUID, [NativeTypeName("const GUID *")] Guid* pClsID, [NativeTypeName("BSTR")] char* bstrName, [NativeTypeName("BSTR")] char* bstrDescription, [NativeTypeName("BSTR")] char* bstrIcon)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDevMgr2*, int, char*, Guid*, Guid*, char*, char*, char*, int>)(lpVtbl[9]))((IWiaDevMgr2*)Unsafe.AsPointer(ref this), lFlags, bstrDeviceID, pEventGUID, pClsID, bstrName, bstrDescription, bstrIcon);
    }

    /// <include file='IWiaDevMgr2.xml' path='doc/member[@name="IWiaDevMgr2.GetImageDlg"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetImageDlg([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrDeviceID, HWND hwndParent, [NativeTypeName("BSTR")] char* bstrFolderName, [NativeTypeName("BSTR")] char* bstrFilename, [NativeTypeName("LONG *")] int* plNumFiles, [NativeTypeName("BSTR **")] char*** ppbstrFilePaths, IWiaItem2** ppItem)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDevMgr2*, int, char*, HWND, char*, char*, int*, char***, IWiaItem2**, int>)(lpVtbl[10]))((IWiaDevMgr2*)Unsafe.AsPointer(ref this), lFlags, bstrDeviceID, hwndParent, bstrFolderName, bstrFilename, plNumFiles, ppbstrFilePaths, ppItem);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT EnumDeviceInfo([NativeTypeName("LONG")] int lFlags, IEnumWIA_DEV_INFO** ppIEnum);

        [VtblIndex(4)]
        HRESULT CreateDevice([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrDeviceID, IWiaItem2** ppWiaItem2Root);

        [VtblIndex(5)]
        HRESULT SelectDeviceDlg(HWND hwndParent, [NativeTypeName("LONG")] int lDeviceType, [NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR *")] char** pbstrDeviceID, IWiaItem2** ppItemRoot);

        [VtblIndex(6)]
        HRESULT SelectDeviceDlgID(HWND hwndParent, [NativeTypeName("LONG")] int lDeviceType, [NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR *")] char** pbstrDeviceID);

        [VtblIndex(7)]
        HRESULT RegisterEventCallbackInterface([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrDeviceID, [NativeTypeName("const GUID *")] Guid* pEventGUID, IWiaEventCallback* pIWiaEventCallback, IUnknown** pEventObject);

        [VtblIndex(8)]
        HRESULT RegisterEventCallbackProgram([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrDeviceID, [NativeTypeName("const GUID *")] Guid* pEventGUID, [NativeTypeName("BSTR")] char* bstrFullAppName, [NativeTypeName("BSTR")] char* bstrCommandLineArg, [NativeTypeName("BSTR")] char* bstrName, [NativeTypeName("BSTR")] char* bstrDescription, [NativeTypeName("BSTR")] char* bstrIcon);

        [VtblIndex(9)]
        HRESULT RegisterEventCallbackCLSID([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrDeviceID, [NativeTypeName("const GUID *")] Guid* pEventGUID, [NativeTypeName("const GUID *")] Guid* pClsID, [NativeTypeName("BSTR")] char* bstrName, [NativeTypeName("BSTR")] char* bstrDescription, [NativeTypeName("BSTR")] char* bstrIcon);

        [VtblIndex(10)]
        HRESULT GetImageDlg([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrDeviceID, HWND hwndParent, [NativeTypeName("BSTR")] char* bstrFolderName, [NativeTypeName("BSTR")] char* bstrFilename, [NativeTypeName("LONG *")] int* plNumFiles, [NativeTypeName("BSTR **")] char*** ppbstrFilePaths, IWiaItem2** ppItem);
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

        [NativeTypeName("HRESULT (LONG, IEnumWIA_DEV_INFO **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, IEnumWIA_DEV_INFO**, int> EnumDeviceInfo;

        [NativeTypeName("HRESULT (LONG, BSTR, IWiaItem2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, char*, IWiaItem2**, int> CreateDevice;

        [NativeTypeName("HRESULT (HWND, LONG, LONG, BSTR *, IWiaItem2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND, int, int, char**, IWiaItem2**, int> SelectDeviceDlg;

        [NativeTypeName("HRESULT (HWND, LONG, LONG, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND, int, int, char**, int> SelectDeviceDlgID;

        [NativeTypeName("HRESULT (LONG, BSTR, const GUID *, IWiaEventCallback *, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, char*, Guid*, IWiaEventCallback*, IUnknown**, int> RegisterEventCallbackInterface;

        [NativeTypeName("HRESULT (LONG, BSTR, const GUID *, BSTR, BSTR, BSTR, BSTR, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, char*, Guid*, char*, char*, char*, char*, char*, int> RegisterEventCallbackProgram;

        [NativeTypeName("HRESULT (LONG, BSTR, const GUID *, const GUID *, BSTR, BSTR, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, char*, Guid*, Guid*, char*, char*, char*, int> RegisterEventCallbackCLSID;

        [NativeTypeName("HRESULT (LONG, BSTR, HWND, BSTR, BSTR, LONG *, BSTR **, IWiaItem2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, char*, HWND, char*, char*, int*, char***, IWiaItem2**, int> GetImageDlg;
    }
}
