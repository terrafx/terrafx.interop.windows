// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/asyncinfo.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT;

[Guid("00000036-0000-0000-C000-000000000046")]
[NativeTypeName("struct IAsyncInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAsyncInfo : IAsyncInfo.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAsyncInfo*, Guid*, void**, int>)(lpVtbl[0]))((IAsyncInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAsyncInfo*, uint>)(lpVtbl[1]))((IAsyncInfo*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAsyncInfo*, uint>)(lpVtbl[2]))((IAsyncInfo*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IAsyncInfo*, uint*, Guid**, int>)(lpVtbl[3]))((IAsyncInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAsyncInfo*, HSTRING*, int>)(lpVtbl[4]))((IAsyncInfo*)Unsafe.AsPointer(ref this), className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAsyncInfo*, TrustLevel*, int>)(lpVtbl[5]))((IAsyncInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id([NativeTypeName("unsigned int *")] uint* id)
    {
        return ((delegate* unmanaged<IAsyncInfo*, uint*, int>)(lpVtbl[6]))((IAsyncInfo*)Unsafe.AsPointer(ref this), id);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Foundation::AsyncStatus *")] AsyncStatus* status)
    {
        return ((delegate* unmanaged<IAsyncInfo*, AsyncStatus*, int>)(lpVtbl[7]))((IAsyncInfo*)Unsafe.AsPointer(ref this), status);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ErrorCode(HRESULT* errorCode)
    {
        return ((delegate* unmanaged<IAsyncInfo*, HRESULT*, int>)(lpVtbl[8]))((IAsyncInfo*)Unsafe.AsPointer(ref this), errorCode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Cancel()
    {
        return ((delegate* unmanaged<IAsyncInfo*, int>)(lpVtbl[9]))((IAsyncInfo*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<IAsyncInfo*, int>)(lpVtbl[10]))((IAsyncInfo*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id([NativeTypeName("unsigned int *")] uint* id);

        [VtblIndex(7)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Foundation::AsyncStatus *")] AsyncStatus* status);

        [VtblIndex(8)]
        HRESULT get_ErrorCode(HRESULT* errorCode);

        [VtblIndex(9)]
        HRESULT Cancel();

        [VtblIndex(10)]
        HRESULT Close();
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAsyncInfo*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAsyncInfo*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAsyncInfo*, uint> Release;

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAsyncInfo*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAsyncInfo*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAsyncInfo*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (unsigned int *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAsyncInfo*, uint*, int> get_Id;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::AsyncStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAsyncInfo*, AsyncStatus*, int> get_Status;

        [NativeTypeName("HRESULT (HRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAsyncInfo*, HRESULT*, int> get_ErrorCode;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IAsyncInfo*, int> Cancel;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IAsyncInfo*, int> Close;
    }
}
