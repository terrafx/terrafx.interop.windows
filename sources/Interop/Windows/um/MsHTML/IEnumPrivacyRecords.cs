// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F844-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IEnumPrivacyRecords : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumPrivacyRecords
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumPrivacyRecords*, Guid*, void**, int>)(lpVtbl[0]))((IEnumPrivacyRecords*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumPrivacyRecords*, uint>)(lpVtbl[1]))((IEnumPrivacyRecords*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumPrivacyRecords*, uint>)(lpVtbl[2]))((IEnumPrivacyRecords*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumPrivacyRecords*, int>)(lpVtbl[3]))((IEnumPrivacyRecords*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("ULONG *")] uint* pSize)
        {
            return ((delegate* unmanaged<IEnumPrivacyRecords*, uint*, int>)(lpVtbl[4]))((IEnumPrivacyRecords*)Unsafe.AsPointer(ref this), pSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivacyImpacted([NativeTypeName("BOOL *")] int* pState)
        {
            return ((delegate* unmanaged<IEnumPrivacyRecords*, int*, int>)(lpVtbl[5]))((IEnumPrivacyRecords*)Unsafe.AsPointer(ref this), pState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("BSTR *")] ushort** pbstrUrl, [NativeTypeName("BSTR *")] ushort** pbstrPolicyRef, [NativeTypeName("LONG *")] int* pdwReserved, [NativeTypeName("DWORD *")] uint* pdwPrivacyFlags)
        {
            return ((delegate* unmanaged<IEnumPrivacyRecords*, ushort**, ushort**, int*, uint*, int>)(lpVtbl[6]))((IEnumPrivacyRecords*)Unsafe.AsPointer(ref this), pbstrUrl, pbstrPolicyRef, pdwReserved, pdwPrivacyFlags);
        }
    }
}
