// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A0638C2B-6465-4395-9AE7-A321A9FD2856")]
    [NativeTypeName("struct IMFAudioPolicy : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFAudioPolicy : IMFAudioPolicy.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFAudioPolicy*, Guid*, void**, int>)(lpVtbl[0]))((IMFAudioPolicy*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFAudioPolicy*, uint>)(lpVtbl[1]))((IMFAudioPolicy*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFAudioPolicy*, uint>)(lpVtbl[2]))((IMFAudioPolicy*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetGroupingParam([NativeTypeName("const GUID &")] Guid* rguidClass)
        {
            return ((delegate* unmanaged<IMFAudioPolicy*, Guid*, int>)(lpVtbl[3]))((IMFAudioPolicy*)Unsafe.AsPointer(ref this), rguidClass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetGroupingParam(Guid* pguidClass)
        {
            return ((delegate* unmanaged<IMFAudioPolicy*, Guid*, int>)(lpVtbl[4]))((IMFAudioPolicy*)Unsafe.AsPointer(ref this), pguidClass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetDisplayName([NativeTypeName("LPCWSTR")] ushort* pszName)
        {
            return ((delegate* unmanaged<IMFAudioPolicy*, ushort*, int>)(lpVtbl[5]))((IMFAudioPolicy*)Unsafe.AsPointer(ref this), pszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetDisplayName([NativeTypeName("LPWSTR *")] ushort** pszName)
        {
            return ((delegate* unmanaged<IMFAudioPolicy*, ushort**, int>)(lpVtbl[6]))((IMFAudioPolicy*)Unsafe.AsPointer(ref this), pszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetIconPath([NativeTypeName("LPCWSTR")] ushort* pszPath)
        {
            return ((delegate* unmanaged<IMFAudioPolicy*, ushort*, int>)(lpVtbl[7]))((IMFAudioPolicy*)Unsafe.AsPointer(ref this), pszPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetIconPath([NativeTypeName("LPWSTR *")] ushort** pszPath)
        {
            return ((delegate* unmanaged<IMFAudioPolicy*, ushort**, int>)(lpVtbl[8]))((IMFAudioPolicy*)Unsafe.AsPointer(ref this), pszPath);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetGroupingParam([NativeTypeName("const GUID &")] Guid* rguidClass);

            [VtblIndex(4)]
            HRESULT GetGroupingParam(Guid* pguidClass);

            [VtblIndex(5)]
            HRESULT SetDisplayName([NativeTypeName("LPCWSTR")] ushort* pszName);

            [VtblIndex(6)]
            HRESULT GetDisplayName([NativeTypeName("LPWSTR *")] ushort** pszName);

            [VtblIndex(7)]
            HRESULT SetIconPath([NativeTypeName("LPCWSTR")] ushort* pszPath);

            [VtblIndex(8)]
            HRESULT GetIconPath([NativeTypeName("LPWSTR *")] ushort** pszPath);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFAudioPolicy*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFAudioPolicy*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFAudioPolicy*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFAudioPolicy*, Guid*, int> SetGroupingParam;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFAudioPolicy*, Guid*, int> GetGroupingParam;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFAudioPolicy*, ushort*, int> SetDisplayName;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFAudioPolicy*, ushort**, int> GetDisplayName;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFAudioPolicy*, ushort*, int> SetIconPath;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFAudioPolicy*, ushort**, int> GetIconPath;
        }
    }
}
