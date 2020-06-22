// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("421AF7F6-573E-4AD0-8FDA-2E57CEDB18C6")]
    public unsafe partial struct IMFRelativePanelWatcher
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFRelativePanelWatcher*, Guid*, void**, int>)(lpVtbl[0]))((IMFRelativePanelWatcher*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFRelativePanelWatcher*, uint>)(lpVtbl[1]))((IMFRelativePanelWatcher*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFRelativePanelWatcher*, uint>)(lpVtbl[2]))((IMFRelativePanelWatcher*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* stdcall<IMFRelativePanelWatcher*, int>)(lpVtbl[3]))((IMFRelativePanelWatcher*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetShutdownStatus([NativeTypeName("MFSHUTDOWN_STATUS *")] MFSHUTDOWN_STATUS* pStatus)
        {
            return ((delegate* stdcall<IMFRelativePanelWatcher*, MFSHUTDOWN_STATUS*, int>)(lpVtbl[4]))((IMFRelativePanelWatcher*)Unsafe.AsPointer(ref this), pStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginGetReport([NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* pState)
        {
            return ((delegate* stdcall<IMFRelativePanelWatcher*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[5]))((IMFRelativePanelWatcher*)Unsafe.AsPointer(ref this), pCallback, pState);
        }

        [return: NativeTypeName("HRESULT")]
        public int EndGetReport([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult, [NativeTypeName("IMFRelativePanelReport **")] IMFRelativePanelReport** ppRelativePanelReport)
        {
            return ((delegate* stdcall<IMFRelativePanelWatcher*, IMFAsyncResult*, IMFRelativePanelReport**, int>)(lpVtbl[6]))((IMFRelativePanelWatcher*)Unsafe.AsPointer(ref this), pResult, ppRelativePanelReport);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetReport([NativeTypeName("IMFRelativePanelReport **")] IMFRelativePanelReport** ppRelativePanelReport)
        {
            return ((delegate* stdcall<IMFRelativePanelWatcher*, IMFRelativePanelReport**, int>)(lpVtbl[7]))((IMFRelativePanelWatcher*)Unsafe.AsPointer(ref this), ppRelativePanelReport);
        }
    }
}
