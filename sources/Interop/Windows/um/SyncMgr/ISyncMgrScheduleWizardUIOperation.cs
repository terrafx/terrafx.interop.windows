// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("459A6C84-21D2-4DDC-8A53-F023A46066F2")]
    [NativeTypeName("struct ISyncMgrScheduleWizardUIOperation : ISyncMgrUIOperation")]
    [NativeInheritance("ISyncMgrUIOperation")]
    public unsafe partial struct ISyncMgrScheduleWizardUIOperation
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISyncMgrScheduleWizardUIOperation*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrScheduleWizardUIOperation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISyncMgrScheduleWizardUIOperation*, uint>)(lpVtbl[1]))((ISyncMgrScheduleWizardUIOperation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISyncMgrScheduleWizardUIOperation*, uint>)(lpVtbl[2]))((ISyncMgrScheduleWizardUIOperation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Run(HWND hwndOwner)
        {
            return ((delegate* unmanaged<ISyncMgrScheduleWizardUIOperation*, HWND, int>)(lpVtbl[3]))((ISyncMgrScheduleWizardUIOperation*)Unsafe.AsPointer(ref this), hwndOwner);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT InitWizard([NativeTypeName("LPCWSTR")] ushort* pszHandlerID)
        {
            return ((delegate* unmanaged<ISyncMgrScheduleWizardUIOperation*, ushort*, int>)(lpVtbl[4]))((ISyncMgrScheduleWizardUIOperation*)Unsafe.AsPointer(ref this), pszHandlerID);
        }
    }
}
