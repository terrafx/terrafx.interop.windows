// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BA9711BA-5893-4787-A7E1-41277151550B")]
    [NativeTypeName("struct IUserNotification : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUserNotification
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUserNotification*, Guid*, void**, int>)(lpVtbl[0]))((IUserNotification*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUserNotification*, uint>)(lpVtbl[1]))((IUserNotification*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUserNotification*, uint>)(lpVtbl[2]))((IUserNotification*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetBalloonInfo([NativeTypeName("LPCWSTR")] ushort* pszTitle, [NativeTypeName("LPCWSTR")] ushort* pszText, [NativeTypeName("DWORD")] uint dwInfoFlags)
        {
            return ((delegate* unmanaged<IUserNotification*, ushort*, ushort*, uint, int>)(lpVtbl[3]))((IUserNotification*)Unsafe.AsPointer(ref this), pszTitle, pszText, dwInfoFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetBalloonRetry([NativeTypeName("DWORD")] uint dwShowTime, [NativeTypeName("DWORD")] uint dwInterval, [NativeTypeName("UINT")] uint cRetryCount)
        {
            return ((delegate* unmanaged<IUserNotification*, uint, uint, uint, int>)(lpVtbl[4]))((IUserNotification*)Unsafe.AsPointer(ref this), dwShowTime, dwInterval, cRetryCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetIconInfo([NativeTypeName("HICON")] IntPtr hIcon, [NativeTypeName("LPCWSTR")] ushort* pszToolTip)
        {
            return ((delegate* unmanaged<IUserNotification*, IntPtr, ushort*, int>)(lpVtbl[5]))((IUserNotification*)Unsafe.AsPointer(ref this), hIcon, pszToolTip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Show(IQueryContinue* pqc, [NativeTypeName("DWORD")] uint dwContinuePollInterval)
        {
            return ((delegate* unmanaged<IUserNotification*, IQueryContinue*, uint, int>)(lpVtbl[6]))((IUserNotification*)Unsafe.AsPointer(ref this), pqc, dwContinuePollInterval);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT PlaySoundW([NativeTypeName("LPCWSTR")] ushort* pszSoundName)
        {
            return ((delegate* unmanaged<IUserNotification*, ushort*, int>)(lpVtbl[7]))((IUserNotification*)Unsafe.AsPointer(ref this), pszSoundName);
        }
    }
}
