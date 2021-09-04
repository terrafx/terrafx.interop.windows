// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C405A219-25A2-442E-8743-B845A2CEE93F")]
    [NativeTypeName("struct ISyncMgrConflictResolveInfo : IUnknown")]
    public unsafe partial struct ISyncMgrConflictResolveInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISyncMgrConflictResolveInfo*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrConflictResolveInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISyncMgrConflictResolveInfo*, uint>)(lpVtbl[1]))((ISyncMgrConflictResolveInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISyncMgrConflictResolveInfo*, uint>)(lpVtbl[2]))((ISyncMgrConflictResolveInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIterationInfo([NativeTypeName("UINT *")] uint* pnCurrentConflict, [NativeTypeName("UINT *")] uint* pcConflicts, [NativeTypeName("UINT *")] uint* pcRemainingForApplyToAll)
        {
            return ((delegate* unmanaged<ISyncMgrConflictResolveInfo*, uint*, uint*, uint*, int>)(lpVtbl[3]))((ISyncMgrConflictResolveInfo*)Unsafe.AsPointer(ref this), pnCurrentConflict, pcConflicts, pcRemainingForApplyToAll);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPresenterNextStep(SYNCMGR_PRESENTER_NEXT_STEP* pnPresenterNextStep)
        {
            return ((delegate* unmanaged<ISyncMgrConflictResolveInfo*, SYNCMGR_PRESENTER_NEXT_STEP*, int>)(lpVtbl[4]))((ISyncMgrConflictResolveInfo*)Unsafe.AsPointer(ref this), pnPresenterNextStep);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPresenterChoice(SYNCMGR_PRESENTER_CHOICE* pnPresenterChoice, [NativeTypeName("BOOL *")] int* pfApplyToAll)
        {
            return ((delegate* unmanaged<ISyncMgrConflictResolveInfo*, SYNCMGR_PRESENTER_CHOICE*, int*, int>)(lpVtbl[5]))((ISyncMgrConflictResolveInfo*)Unsafe.AsPointer(ref this), pnPresenterChoice, pfApplyToAll);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemChoiceCount([NativeTypeName("UINT *")] uint* pcChoices)
        {
            return ((delegate* unmanaged<ISyncMgrConflictResolveInfo*, uint*, int>)(lpVtbl[6]))((ISyncMgrConflictResolveInfo*)Unsafe.AsPointer(ref this), pcChoices);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemChoice([NativeTypeName("UINT")] uint iChoice, [NativeTypeName("UINT *")] uint* piChoiceIndex)
        {
            return ((delegate* unmanaged<ISyncMgrConflictResolveInfo*, uint, uint*, int>)(lpVtbl[7]))((ISyncMgrConflictResolveInfo*)Unsafe.AsPointer(ref this), iChoice, piChoiceIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPresenterNextStep(SYNCMGR_PRESENTER_NEXT_STEP nPresenterNextStep)
        {
            return ((delegate* unmanaged<ISyncMgrConflictResolveInfo*, SYNCMGR_PRESENTER_NEXT_STEP, int>)(lpVtbl[8]))((ISyncMgrConflictResolveInfo*)Unsafe.AsPointer(ref this), nPresenterNextStep);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPresenterChoice(SYNCMGR_PRESENTER_CHOICE nPresenterChoice, [NativeTypeName("BOOL")] int fApplyToAll)
        {
            return ((delegate* unmanaged<ISyncMgrConflictResolveInfo*, SYNCMGR_PRESENTER_CHOICE, int, int>)(lpVtbl[9]))((ISyncMgrConflictResolveInfo*)Unsafe.AsPointer(ref this), nPresenterChoice, fApplyToAll);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetItemChoices([NativeTypeName("UINT *")] uint* prgiConflictItemIndexes, [NativeTypeName("UINT")] uint cChoices)
        {
            return ((delegate* unmanaged<ISyncMgrConflictResolveInfo*, uint*, uint, int>)(lpVtbl[10]))((ISyncMgrConflictResolveInfo*)Unsafe.AsPointer(ref this), prgiConflictItemIndexes, cChoices);
        }
    }
}
