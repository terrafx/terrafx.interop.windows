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
    public unsafe partial struct ICDBurn
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int GetRecorderDriveLetter([NativeTypeName("LPWSTR")] ushort* pszDrive, [NativeTypeName("UINT")] uint cch)
        {
            return ((delegate* unmanaged<ICDBurn*, ushort*, uint, int>)(lpVtbl[3]))((ICDBurn*)Unsafe.AsPointer(ref this), pszDrive, cch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Burn([NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* unmanaged<ICDBurn*, IntPtr, int>)(lpVtbl[4]))((ICDBurn*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int HasRecordableDrive(BOOL* pfHasRecorder)
        {
            return ((delegate* unmanaged<ICDBurn*, BOOL*, int>)(lpVtbl[5]))((ICDBurn*)Unsafe.AsPointer(ref this), pfHasRecorder);
        }
    }
}
