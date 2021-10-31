// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EBBC7C04-315E-11D2-B62F-006097DF5BD4")]
    [NativeTypeName("struct IProgressDialog : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IProgressDialog
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IProgressDialog*, Guid*, void**, int>)(lpVtbl[0]))((IProgressDialog*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IProgressDialog*, uint>)(lpVtbl[1]))((IProgressDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IProgressDialog*, uint>)(lpVtbl[2]))((IProgressDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT StartProgressDialog(HWND hwndParent, IUnknown* punkEnableModless, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCVOID")] void* pvResevered)
        {
            return ((delegate* unmanaged<IProgressDialog*, HWND, IUnknown*, uint, void*, int>)(lpVtbl[3]))((IProgressDialog*)Unsafe.AsPointer(ref this), hwndParent, punkEnableModless, dwFlags, pvResevered);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT StopProgressDialog()
        {
            return ((delegate* unmanaged<IProgressDialog*, int>)(lpVtbl[4]))((IProgressDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetTitle([NativeTypeName("PCWSTR")] ushort* pwzTitle)
        {
            return ((delegate* unmanaged<IProgressDialog*, ushort*, int>)(lpVtbl[5]))((IProgressDialog*)Unsafe.AsPointer(ref this), pwzTitle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetAnimation(HINSTANCE hInstAnimation, uint idAnimation)
        {
            return ((delegate* unmanaged<IProgressDialog*, HINSTANCE, uint, int>)(lpVtbl[6]))((IProgressDialog*)Unsafe.AsPointer(ref this), hInstAnimation, idAnimation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public BOOL HasUserCancelled()
        {
            return ((delegate* unmanaged<IProgressDialog*, int>)(lpVtbl[7]))((IProgressDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetProgress([NativeTypeName("DWORD")] uint dwCompleted, [NativeTypeName("DWORD")] uint dwTotal)
        {
            return ((delegate* unmanaged<IProgressDialog*, uint, uint, int>)(lpVtbl[8]))((IProgressDialog*)Unsafe.AsPointer(ref this), dwCompleted, dwTotal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetProgress64([NativeTypeName("ULONGLONG")] ulong ullCompleted, [NativeTypeName("ULONGLONG")] ulong ullTotal)
        {
            return ((delegate* unmanaged<IProgressDialog*, ulong, ulong, int>)(lpVtbl[9]))((IProgressDialog*)Unsafe.AsPointer(ref this), ullCompleted, ullTotal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetLine([NativeTypeName("DWORD")] uint dwLineNum, [NativeTypeName("PCWSTR")] ushort* pwzString, BOOL fCompactPath, [NativeTypeName("LPCVOID")] void* pvResevered)
        {
            return ((delegate* unmanaged<IProgressDialog*, uint, ushort*, BOOL, void*, int>)(lpVtbl[10]))((IProgressDialog*)Unsafe.AsPointer(ref this), dwLineNum, pwzString, fCompactPath, pvResevered);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetCancelMsg([NativeTypeName("PCWSTR")] ushort* pwzCancelMsg, [NativeTypeName("LPCVOID")] void* pvResevered)
        {
            return ((delegate* unmanaged<IProgressDialog*, ushort*, void*, int>)(lpVtbl[11]))((IProgressDialog*)Unsafe.AsPointer(ref this), pwzCancelMsg, pvResevered);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT Timer([NativeTypeName("DWORD")] uint dwTimerAction, [NativeTypeName("LPCVOID")] void* pvResevered)
        {
            return ((delegate* unmanaged<IProgressDialog*, uint, void*, int>)(lpVtbl[12]))((IProgressDialog*)Unsafe.AsPointer(ref this), dwTimerAction, pvResevered);
        }
    }
}
