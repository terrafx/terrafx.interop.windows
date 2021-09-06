// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("215913CC-57EB-4FAB-AB5A-E5FA7BEA2A6C")]
    [NativeTypeName("struct IUserNotification2 : IUnknown")]
    public unsafe partial struct IUserNotification2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUserNotification2*, Guid*, void**, int>)(lpVtbl[0]))((IUserNotification2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUserNotification2*, uint>)(lpVtbl[1]))((IUserNotification2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUserNotification2*, uint>)(lpVtbl[2]))((IUserNotification2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBalloonInfo([NativeTypeName("LPCWSTR")] ushort* pszTitle, [NativeTypeName("LPCWSTR")] ushort* pszText, [NativeTypeName("DWORD")] uint dwInfoFlags)
        {
            return ((delegate* unmanaged<IUserNotification2*, ushort*, ushort*, uint, int>)(lpVtbl[3]))((IUserNotification2*)Unsafe.AsPointer(ref this), pszTitle, pszText, dwInfoFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBalloonRetry([NativeTypeName("DWORD")] uint dwShowTime, [NativeTypeName("DWORD")] uint dwInterval, [NativeTypeName("UINT")] uint cRetryCount)
        {
            return ((delegate* unmanaged<IUserNotification2*, uint, uint, uint, int>)(lpVtbl[4]))((IUserNotification2*)Unsafe.AsPointer(ref this), dwShowTime, dwInterval, cRetryCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetIconInfo([NativeTypeName("HICON")] IntPtr hIcon, [NativeTypeName("LPCWSTR")] ushort* pszToolTip)
        {
            return ((delegate* unmanaged<IUserNotification2*, IntPtr, ushort*, int>)(lpVtbl[5]))((IUserNotification2*)Unsafe.AsPointer(ref this), hIcon, pszToolTip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Show(IQueryContinue* pqc, [NativeTypeName("DWORD")] uint dwContinuePollInterval, IUserNotificationCallback* pSink)
        {
            return ((delegate* unmanaged<IUserNotification2*, IQueryContinue*, uint, IUserNotificationCallback*, int>)(lpVtbl[6]))((IUserNotification2*)Unsafe.AsPointer(ref this), pqc, dwContinuePollInterval, pSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PlaySoundW([NativeTypeName("LPCWSTR")] ushort* pszSoundName)
        {
            return ((delegate* unmanaged<IUserNotification2*, ushort*, int>)(lpVtbl[7]))((IUserNotification2*)Unsafe.AsPointer(ref this), pszSoundName);
        }
    }
}
