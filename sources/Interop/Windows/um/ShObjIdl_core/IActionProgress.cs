// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("49FF1173-EADC-446D-9285-156453A6431C")]
    [NativeTypeName("struct IActionProgress : IUnknown")]
    public unsafe partial struct IActionProgress
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IActionProgress*, Guid*, void**, int>)(lpVtbl[0]))((IActionProgress*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IActionProgress*, uint>)(lpVtbl[1]))((IActionProgress*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IActionProgress*, uint>)(lpVtbl[2]))((IActionProgress*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Begin(SPACTION action, [NativeTypeName("SPBEGINF")] uint flags)
        {
            return ((delegate* unmanaged<IActionProgress*, SPACTION, uint, int>)(lpVtbl[3]))((IActionProgress*)Unsafe.AsPointer(ref this), action, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateProgress([NativeTypeName("ULONGLONG")] ulong ulCompleted, [NativeTypeName("ULONGLONG")] ulong ulTotal)
        {
            return ((delegate* unmanaged<IActionProgress*, ulong, ulong, int>)(lpVtbl[4]))((IActionProgress*)Unsafe.AsPointer(ref this), ulCompleted, ulTotal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateText(SPTEXT sptext, [NativeTypeName("LPCWSTR")] ushort* pszText, [NativeTypeName("BOOL")] int fMayCompact)
        {
            return ((delegate* unmanaged<IActionProgress*, SPTEXT, ushort*, int, int>)(lpVtbl[5]))((IActionProgress*)Unsafe.AsPointer(ref this), sptext, pszText, fMayCompact);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryCancel([NativeTypeName("BOOL *")] int* pfCancelled)
        {
            return ((delegate* unmanaged<IActionProgress*, int*, int>)(lpVtbl[6]))((IActionProgress*)Unsafe.AsPointer(ref this), pfCancelled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ResetCancel()
        {
            return ((delegate* unmanaged<IActionProgress*, int>)(lpVtbl[7]))((IActionProgress*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int End()
        {
            return ((delegate* unmanaged<IActionProgress*, int>)(lpVtbl[8]))((IActionProgress*)Unsafe.AsPointer(ref this));
        }
    }
}
