// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWiaDevMgr.xml' path='doc/member[@name="IWiaDevMgr"]/*' />
[Guid("5EB2502A-8CF1-11D1-BF92-0060081ED811")]
[NativeTypeName("struct IWiaDevMgr : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWiaDevMgr : IWiaDevMgr.Interface, INativeGuid
{
    /// <include file='IWiaDevMgr.xml' path='doc/member[@name="IWiaDevMgr.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWiaDevMgr);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDevMgr*, Guid*, void**, int>)(lpVtbl[0]))((IWiaDevMgr*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDevMgr*, uint>)(lpVtbl[1]))((IWiaDevMgr*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDevMgr*, uint>)(lpVtbl[2]))((IWiaDevMgr*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWiaDevMgr.xml' path='doc/member[@name="IWiaDevMgr.EnumDeviceInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EnumDeviceInfo([NativeTypeName("LONG")] int lFlag, IEnumWIA_DEV_INFO** ppIEnum)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDevMgr*, int, IEnumWIA_DEV_INFO**, int>)(lpVtbl[3]))((IWiaDevMgr*)Unsafe.AsPointer(ref this), lFlag, ppIEnum);
    }

    /// <include file='IWiaDevMgr.xml' path='doc/member[@name="IWiaDevMgr.CreateDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateDevice([NativeTypeName("BSTR")] char* bstrDeviceID, IWiaItem** ppWiaItemRoot)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDevMgr*, char*, IWiaItem**, int>)(lpVtbl[4]))((IWiaDevMgr*)Unsafe.AsPointer(ref this), bstrDeviceID, ppWiaItemRoot);
    }

    /// <include file='IWiaDevMgr.xml' path='doc/member[@name="IWiaDevMgr.SelectDeviceDlg"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SelectDeviceDlg(HWND hwndParent, [NativeTypeName("LONG")] int lDeviceType, [NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR *")] char** pbstrDeviceID, IWiaItem** ppItemRoot)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDevMgr*, HWND, int, int, char**, IWiaItem**, int>)(lpVtbl[5]))((IWiaDevMgr*)Unsafe.AsPointer(ref this), hwndParent, lDeviceType, lFlags, pbstrDeviceID, ppItemRoot);
    }

    /// <include file='IWiaDevMgr.xml' path='doc/member[@name="IWiaDevMgr.SelectDeviceDlgID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SelectDeviceDlgID(HWND hwndParent, [NativeTypeName("LONG")] int lDeviceType, [NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR *")] char** pbstrDeviceID)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDevMgr*, HWND, int, int, char**, int>)(lpVtbl[6]))((IWiaDevMgr*)Unsafe.AsPointer(ref this), hwndParent, lDeviceType, lFlags, pbstrDeviceID);
    }

    /// <include file='IWiaDevMgr.xml' path='doc/member[@name="IWiaDevMgr.GetImageDlg"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetImageDlg(HWND hwndParent, [NativeTypeName("LONG")] int lDeviceType, [NativeTypeName("LONG")] int lFlags, [NativeTypeName("LONG")] int lIntent, IWiaItem* pItemRoot, [NativeTypeName("BSTR")] char* bstrFilename, Guid* pguidFormat)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDevMgr*, HWND, int, int, int, IWiaItem*, char*, Guid*, int>)(lpVtbl[7]))((IWiaDevMgr*)Unsafe.AsPointer(ref this), hwndParent, lDeviceType, lFlags, lIntent, pItemRoot, bstrFilename, pguidFormat);
    }

    /// <include file='IWiaDevMgr.xml' path='doc/member[@name="IWiaDevMgr.RegisterEventCallbackProgram"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RegisterEventCallbackProgram([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrDeviceID, [NativeTypeName("const GUID *")] Guid* pEventGUID, [NativeTypeName("BSTR")] char* bstrCommandline, [NativeTypeName("BSTR")] char* bstrName, [NativeTypeName("BSTR")] char* bstrDescription, [NativeTypeName("BSTR")] char* bstrIcon)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDevMgr*, int, char*, Guid*, char*, char*, char*, char*, int>)(lpVtbl[8]))((IWiaDevMgr*)Unsafe.AsPointer(ref this), lFlags, bstrDeviceID, pEventGUID, bstrCommandline, bstrName, bstrDescription, bstrIcon);
    }

    /// <include file='IWiaDevMgr.xml' path='doc/member[@name="IWiaDevMgr.RegisterEventCallbackInterface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RegisterEventCallbackInterface([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrDeviceID, [NativeTypeName("const GUID *")] Guid* pEventGUID, IWiaEventCallback* pIWiaEventCallback, IUnknown** pEventObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDevMgr*, int, char*, Guid*, IWiaEventCallback*, IUnknown**, int>)(lpVtbl[9]))((IWiaDevMgr*)Unsafe.AsPointer(ref this), lFlags, bstrDeviceID, pEventGUID, pIWiaEventCallback, pEventObject);
    }

    /// <include file='IWiaDevMgr.xml' path='doc/member[@name="IWiaDevMgr.RegisterEventCallbackCLSID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RegisterEventCallbackCLSID([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrDeviceID, [NativeTypeName("const GUID *")] Guid* pEventGUID, [NativeTypeName("const GUID *")] Guid* pClsID, [NativeTypeName("BSTR")] char* bstrName, [NativeTypeName("BSTR")] char* bstrDescription, [NativeTypeName("BSTR")] char* bstrIcon)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDevMgr*, int, char*, Guid*, Guid*, char*, char*, char*, int>)(lpVtbl[10]))((IWiaDevMgr*)Unsafe.AsPointer(ref this), lFlags, bstrDeviceID, pEventGUID, pClsID, bstrName, bstrDescription, bstrIcon);
    }

    /// <include file='IWiaDevMgr.xml' path='doc/member[@name="IWiaDevMgr.AddDeviceDlg"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT AddDeviceDlg(HWND hwndParent, [NativeTypeName("LONG")] int lFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDevMgr*, HWND, int, int>)(lpVtbl[11]))((IWiaDevMgr*)Unsafe.AsPointer(ref this), hwndParent, lFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT EnumDeviceInfo([NativeTypeName("LONG")] int lFlag, IEnumWIA_DEV_INFO** ppIEnum);

        [VtblIndex(4)]
        HRESULT CreateDevice([NativeTypeName("BSTR")] char* bstrDeviceID, IWiaItem** ppWiaItemRoot);

        [VtblIndex(5)]
        HRESULT SelectDeviceDlg(HWND hwndParent, [NativeTypeName("LONG")] int lDeviceType, [NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR *")] char** pbstrDeviceID, IWiaItem** ppItemRoot);

        [VtblIndex(6)]
        HRESULT SelectDeviceDlgID(HWND hwndParent, [NativeTypeName("LONG")] int lDeviceType, [NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR *")] char** pbstrDeviceID);

        [VtblIndex(7)]
        HRESULT GetImageDlg(HWND hwndParent, [NativeTypeName("LONG")] int lDeviceType, [NativeTypeName("LONG")] int lFlags, [NativeTypeName("LONG")] int lIntent, IWiaItem* pItemRoot, [NativeTypeName("BSTR")] char* bstrFilename, Guid* pguidFormat);

        [VtblIndex(8)]
        HRESULT RegisterEventCallbackProgram([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrDeviceID, [NativeTypeName("const GUID *")] Guid* pEventGUID, [NativeTypeName("BSTR")] char* bstrCommandline, [NativeTypeName("BSTR")] char* bstrName, [NativeTypeName("BSTR")] char* bstrDescription, [NativeTypeName("BSTR")] char* bstrIcon);

        [VtblIndex(9)]
        HRESULT RegisterEventCallbackInterface([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrDeviceID, [NativeTypeName("const GUID *")] Guid* pEventGUID, IWiaEventCallback* pIWiaEventCallback, IUnknown** pEventObject);

        [VtblIndex(10)]
        HRESULT RegisterEventCallbackCLSID([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrDeviceID, [NativeTypeName("const GUID *")] Guid* pEventGUID, [NativeTypeName("const GUID *")] Guid* pClsID, [NativeTypeName("BSTR")] char* bstrName, [NativeTypeName("BSTR")] char* bstrDescription, [NativeTypeName("BSTR")] char* bstrIcon);

        [VtblIndex(11)]
        HRESULT AddDeviceDlg(HWND hwndParent, [NativeTypeName("LONG")] int lFlags);
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

        [NativeTypeName("HRESULT (BSTR, IWiaItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, IWiaItem**, int> CreateDevice;

        [NativeTypeName("HRESULT (HWND, LONG, LONG, BSTR *, IWiaItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND, int, int, char**, IWiaItem**, int> SelectDeviceDlg;

        [NativeTypeName("HRESULT (HWND, LONG, LONG, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND, int, int, char**, int> SelectDeviceDlgID;

        [NativeTypeName("HRESULT (HWND, LONG, LONG, LONG, IWiaItem *, BSTR, GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND, int, int, int, IWiaItem*, char*, Guid*, int> GetImageDlg;

        [NativeTypeName("HRESULT (LONG, BSTR, const GUID *, BSTR, BSTR, BSTR, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, char*, Guid*, char*, char*, char*, char*, int> RegisterEventCallbackProgram;

        [NativeTypeName("HRESULT (LONG, BSTR, const GUID *, IWiaEventCallback *, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, char*, Guid*, IWiaEventCallback*, IUnknown**, int> RegisterEventCallbackInterface;

        [NativeTypeName("HRESULT (LONG, BSTR, const GUID *, const GUID *, BSTR, BSTR, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, char*, Guid*, Guid*, char*, char*, char*, int> RegisterEventCallbackCLSID;

        [NativeTypeName("HRESULT (HWND, LONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND, int, int> AddDeviceDlg;
    }
}
