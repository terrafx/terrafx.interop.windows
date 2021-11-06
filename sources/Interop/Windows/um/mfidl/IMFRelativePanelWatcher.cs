// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("421AF7F6-573E-4AD0-8FDA-2E57CEDB18C6")]
    [NativeTypeName("struct IMFRelativePanelWatcher : IMFShutdown")]
    [NativeInheritance("IMFShutdown")]
    public unsafe partial struct IMFRelativePanelWatcher : IMFRelativePanelWatcher.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFRelativePanelWatcher*, Guid*, void**, int>)(lpVtbl[0]))((IMFRelativePanelWatcher*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFRelativePanelWatcher*, uint>)(lpVtbl[1]))((IMFRelativePanelWatcher*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFRelativePanelWatcher*, uint>)(lpVtbl[2]))((IMFRelativePanelWatcher*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Shutdown()
        {
            return ((delegate* unmanaged<IMFRelativePanelWatcher*, int>)(lpVtbl[3]))((IMFRelativePanelWatcher*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetShutdownStatus(MFSHUTDOWN_STATUS* pStatus)
        {
            return ((delegate* unmanaged<IMFRelativePanelWatcher*, MFSHUTDOWN_STATUS*, int>)(lpVtbl[4]))((IMFRelativePanelWatcher*)Unsafe.AsPointer(ref this), pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT BeginGetReport(IMFAsyncCallback* pCallback, IUnknown* pState)
        {
            return ((delegate* unmanaged<IMFRelativePanelWatcher*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[5]))((IMFRelativePanelWatcher*)Unsafe.AsPointer(ref this), pCallback, pState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT EndGetReport(IMFAsyncResult* pResult, IMFRelativePanelReport** ppRelativePanelReport)
        {
            return ((delegate* unmanaged<IMFRelativePanelWatcher*, IMFAsyncResult*, IMFRelativePanelReport**, int>)(lpVtbl[6]))((IMFRelativePanelWatcher*)Unsafe.AsPointer(ref this), pResult, ppRelativePanelReport);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetReport(IMFRelativePanelReport** ppRelativePanelReport)
        {
            return ((delegate* unmanaged<IMFRelativePanelWatcher*, IMFRelativePanelReport**, int>)(lpVtbl[7]))((IMFRelativePanelWatcher*)Unsafe.AsPointer(ref this), ppRelativePanelReport);
        }

        public interface Interface : IMFShutdown.Interface
        {
            [VtblIndex(5)]
            HRESULT BeginGetReport(IMFAsyncCallback* pCallback, IUnknown* pState);

            [VtblIndex(6)]
            HRESULT EndGetReport(IMFAsyncResult* pResult, IMFRelativePanelReport** ppRelativePanelReport);

            [VtblIndex(7)]
            HRESULT GetReport(IMFRelativePanelReport** ppRelativePanelReport);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFRelativePanelWatcher*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFRelativePanelWatcher*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFRelativePanelWatcher*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFRelativePanelWatcher*, int> Shutdown;

            [NativeTypeName("HRESULT (MFSHUTDOWN_STATUS *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFRelativePanelWatcher*, MFSHUTDOWN_STATUS*, int> GetShutdownStatus;

            [NativeTypeName("HRESULT (IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFRelativePanelWatcher*, IMFAsyncCallback*, IUnknown*, int> BeginGetReport;

            [NativeTypeName("HRESULT (IMFAsyncResult *, IMFRelativePanelReport **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFRelativePanelWatcher*, IMFAsyncResult*, IMFRelativePanelReport**, int> EndGetReport;

            [NativeTypeName("HRESULT (IMFRelativePanelReport **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFRelativePanelWatcher*, IMFRelativePanelReport**, int> GetReport;
        }
    }
}
