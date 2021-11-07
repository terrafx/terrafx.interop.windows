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
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUserNotification2 : IUserNotification2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUserNotification2*, Guid*, void**, int>)(lpVtbl[0]))((IUserNotification2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUserNotification2*, uint>)(lpVtbl[1]))((IUserNotification2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUserNotification2*, uint>)(lpVtbl[2]))((IUserNotification2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetBalloonInfo([NativeTypeName("LPCWSTR")] ushort* pszTitle, [NativeTypeName("LPCWSTR")] ushort* pszText, [NativeTypeName("DWORD")] uint dwInfoFlags)
        {
            return ((delegate* unmanaged<IUserNotification2*, ushort*, ushort*, uint, int>)(lpVtbl[3]))((IUserNotification2*)Unsafe.AsPointer(ref this), pszTitle, pszText, dwInfoFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetBalloonRetry([NativeTypeName("DWORD")] uint dwShowTime, [NativeTypeName("DWORD")] uint dwInterval, uint cRetryCount)
        {
            return ((delegate* unmanaged<IUserNotification2*, uint, uint, uint, int>)(lpVtbl[4]))((IUserNotification2*)Unsafe.AsPointer(ref this), dwShowTime, dwInterval, cRetryCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetIconInfo(HICON hIcon, [NativeTypeName("LPCWSTR")] ushort* pszToolTip)
        {
            return ((delegate* unmanaged<IUserNotification2*, HICON, ushort*, int>)(lpVtbl[5]))((IUserNotification2*)Unsafe.AsPointer(ref this), hIcon, pszToolTip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Show(IQueryContinue* pqc, [NativeTypeName("DWORD")] uint dwContinuePollInterval, IUserNotificationCallback* pSink)
        {
            return ((delegate* unmanaged<IUserNotification2*, IQueryContinue*, uint, IUserNotificationCallback*, int>)(lpVtbl[6]))((IUserNotification2*)Unsafe.AsPointer(ref this), pqc, dwContinuePollInterval, pSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT PlaySoundW([NativeTypeName("LPCWSTR")] ushort* pszSoundName)
        {
            return ((delegate* unmanaged<IUserNotification2*, ushort*, int>)(lpVtbl[7]))((IUserNotification2*)Unsafe.AsPointer(ref this), pszSoundName);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetBalloonInfo([NativeTypeName("LPCWSTR")] ushort* pszTitle, [NativeTypeName("LPCWSTR")] ushort* pszText, [NativeTypeName("DWORD")] uint dwInfoFlags);

            [VtblIndex(4)]
            HRESULT SetBalloonRetry([NativeTypeName("DWORD")] uint dwShowTime, [NativeTypeName("DWORD")] uint dwInterval, uint cRetryCount);

            [VtblIndex(5)]
            HRESULT SetIconInfo(HICON hIcon, [NativeTypeName("LPCWSTR")] ushort* pszToolTip);

            [VtblIndex(6)]
            HRESULT Show(IQueryContinue* pqc, [NativeTypeName("DWORD")] uint dwContinuePollInterval, IUserNotificationCallback* pSink);

            [VtblIndex(7)]
            HRESULT PlaySoundW([NativeTypeName("LPCWSTR")] ushort* pszSoundName);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUserNotification2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUserNotification2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUserNotification2*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IUserNotification2*, ushort*, ushort*, uint, int> SetBalloonInfo;

            [NativeTypeName("HRESULT (DWORD, DWORD, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IUserNotification2*, uint, uint, uint, int> SetBalloonRetry;

            [NativeTypeName("HRESULT (HICON, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IUserNotification2*, HICON, ushort*, int> SetIconInfo;

            [NativeTypeName("HRESULT (IQueryContinue *, DWORD, IUserNotificationCallback *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUserNotification2*, IQueryContinue*, uint, IUserNotificationCallback*, int> Show;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IUserNotification2*, ushort*, int> PlaySoundW;
        }
    }
}
