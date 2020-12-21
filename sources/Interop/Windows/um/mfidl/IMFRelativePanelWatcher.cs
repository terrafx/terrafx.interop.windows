// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("421AF7F6-573E-4AD0-8FDA-2E57CEDB18C6")]
    [NativeTypeName("struct IMFRelativePanelWatcher : IMFShutdown")]
    public unsafe partial struct IMFRelativePanelWatcher
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFRelativePanelWatcher*, Guid*, void**, int>)(lpVtbl[0]))((IMFRelativePanelWatcher*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFRelativePanelWatcher*, uint>)(lpVtbl[1]))((IMFRelativePanelWatcher*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFRelativePanelWatcher*, uint>)(lpVtbl[2]))((IMFRelativePanelWatcher*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* unmanaged[Stdcall]<IMFRelativePanelWatcher*, int>)(lpVtbl[3]))((IMFRelativePanelWatcher*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetShutdownStatus([NativeTypeName("MFSHUTDOWN_STATUS *")] MFSHUTDOWN_STATUS* pStatus)
        {
            return ((delegate* unmanaged[Stdcall]<IMFRelativePanelWatcher*, MFSHUTDOWN_STATUS*, int>)(lpVtbl[4]))((IMFRelativePanelWatcher*)Unsafe.AsPointer(ref this), pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginGetReport([NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* pState)
        {
            return ((delegate* unmanaged[Stdcall]<IMFRelativePanelWatcher*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[5]))((IMFRelativePanelWatcher*)Unsafe.AsPointer(ref this), pCallback, pState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndGetReport([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult, [NativeTypeName("IMFRelativePanelReport **")] IMFRelativePanelReport** ppRelativePanelReport)
        {
            return ((delegate* unmanaged[Stdcall]<IMFRelativePanelWatcher*, IMFAsyncResult*, IMFRelativePanelReport**, int>)(lpVtbl[6]))((IMFRelativePanelWatcher*)Unsafe.AsPointer(ref this), pResult, ppRelativePanelReport);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetReport([NativeTypeName("IMFRelativePanelReport **")] IMFRelativePanelReport** ppRelativePanelReport)
        {
            return ((delegate* unmanaged[Stdcall]<IMFRelativePanelWatcher*, IMFRelativePanelReport**, int>)(lpVtbl[7]))((IMFRelativePanelWatcher*)Unsafe.AsPointer(ref this), ppRelativePanelReport);
        }
    }
}
