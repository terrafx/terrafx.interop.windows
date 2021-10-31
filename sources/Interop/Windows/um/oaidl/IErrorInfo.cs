// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1CF2B120-547D-101B-8E65-08002B2BD119")]
    [NativeTypeName("struct IErrorInfo : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IErrorInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IErrorInfo*, Guid*, void**, int>)(lpVtbl[0]))((IErrorInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IErrorInfo*, uint>)(lpVtbl[1]))((IErrorInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IErrorInfo*, uint>)(lpVtbl[2]))((IErrorInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetGUID(Guid* pGUID)
        {
            return ((delegate* unmanaged<IErrorInfo*, Guid*, int>)(lpVtbl[3]))((IErrorInfo*)Unsafe.AsPointer(ref this), pGUID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetSource([NativeTypeName("BSTR *")] ushort** pBstrSource)
        {
            return ((delegate* unmanaged<IErrorInfo*, ushort**, int>)(lpVtbl[4]))((IErrorInfo*)Unsafe.AsPointer(ref this), pBstrSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pBstrDescription)
        {
            return ((delegate* unmanaged<IErrorInfo*, ushort**, int>)(lpVtbl[5]))((IErrorInfo*)Unsafe.AsPointer(ref this), pBstrDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetHelpFile([NativeTypeName("BSTR *")] ushort** pBstrHelpFile)
        {
            return ((delegate* unmanaged<IErrorInfo*, ushort**, int>)(lpVtbl[6]))((IErrorInfo*)Unsafe.AsPointer(ref this), pBstrHelpFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetHelpContext([NativeTypeName("DWORD *")] uint* pdwHelpContext)
        {
            return ((delegate* unmanaged<IErrorInfo*, uint*, int>)(lpVtbl[7]))((IErrorInfo*)Unsafe.AsPointer(ref this), pdwHelpContext);
        }
    }
}
