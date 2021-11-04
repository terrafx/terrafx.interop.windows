// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3D73A659-E5D0-4D42-AFC0-5121BA425C8D")]
    [NativeTypeName("struct ICDBurn : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ICDBurn : ICDBurn.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICDBurn*, Guid*, void**, int>)(lpVtbl[0]))((ICDBurn*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICDBurn*, uint>)(lpVtbl[1]))((ICDBurn*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICDBurn*, uint>)(lpVtbl[2]))((ICDBurn*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetRecorderDriveLetter([NativeTypeName("LPWSTR")] ushort* pszDrive, uint cch)
        {
            return ((delegate* unmanaged<ICDBurn*, ushort*, uint, int>)(lpVtbl[3]))((ICDBurn*)Unsafe.AsPointer(ref this), pszDrive, cch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Burn(HWND hwnd)
        {
            return ((delegate* unmanaged<ICDBurn*, HWND, int>)(lpVtbl[4]))((ICDBurn*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT HasRecordableDrive(BOOL* pfHasRecorder)
        {
            return ((delegate* unmanaged<ICDBurn*, BOOL*, int>)(lpVtbl[5]))((ICDBurn*)Unsafe.AsPointer(ref this), pfHasRecorder);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetRecorderDriveLetter([NativeTypeName("LPWSTR")] ushort* pszDrive, uint cch);

            [VtblIndex(4)]
            HRESULT Burn(HWND hwnd);

            [VtblIndex(5)]
            HRESULT HasRecordableDrive(BOOL* pfHasRecorder);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ICDBurn*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICDBurn*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICDBurn*, uint> Release;

            [NativeTypeName("HRESULT (LPWSTR, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ICDBurn*, ushort*, uint, int> GetRecorderDriveLetter;

            [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
            public delegate* unmanaged<ICDBurn*, HWND, int> Burn;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICDBurn*, BOOL*, int> HasRecordableDrive;
        }
    }
}
