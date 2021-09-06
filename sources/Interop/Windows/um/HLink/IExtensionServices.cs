// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/HLink.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9CB-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IExtensionServices : IUnknown")]
    public unsafe partial struct IExtensionServices
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IExtensionServices*, Guid*, void**, int>)(lpVtbl[0]))((IExtensionServices*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IExtensionServices*, uint>)(lpVtbl[1]))((IExtensionServices*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IExtensionServices*, uint>)(lpVtbl[2]))((IExtensionServices*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAdditionalHeaders([NativeTypeName("LPCWSTR")] ushort* pwzAdditionalHeaders)
        {
            return ((delegate* unmanaged<IExtensionServices*, ushort*, int>)(lpVtbl[3]))((IExtensionServices*)Unsafe.AsPointer(ref this), pwzAdditionalHeaders);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAuthenticateData([NativeTypeName("HWND")] IntPtr phwnd, [NativeTypeName("LPCWSTR")] ushort* pwzUsername, [NativeTypeName("LPCWSTR")] ushort* pwzPassword)
        {
            return ((delegate* unmanaged<IExtensionServices*, IntPtr, ushort*, ushort*, int>)(lpVtbl[4]))((IExtensionServices*)Unsafe.AsPointer(ref this), phwnd, pwzUsername, pwzPassword);
        }
    }
}
