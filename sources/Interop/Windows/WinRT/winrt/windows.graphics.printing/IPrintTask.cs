// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintTask.xml' path='doc/member[@name="IPrintTask"]/*' />
[Guid("61D80247-6CF6-4FAD-84E2-A5E82E2D4CEB")]
[NativeTypeName("struct IPrintTask : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintTask : IPrintTask.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintTask));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTask*, Guid*, void**, int>)(lpVtbl[0]))((IPrintTask*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTask*, uint>)(lpVtbl[1]))((IPrintTask*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTask*, uint>)(lpVtbl[2]))((IPrintTask*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTask*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintTask*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTask*, HSTRING*, int>)(lpVtbl[4]))((IPrintTask*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTask*, TrustLevel*, int>)(lpVtbl[5]))((IPrintTask*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintTask.xml' path='doc/member[@name="IPrintTask.get_Properties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Properties([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackagePropertySet **")] IDataPackagePropertySet** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTask*, IDataPackagePropertySet**, int>)(lpVtbl[6]))((IPrintTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTask.xml' path='doc/member[@name="IPrintTask.get_Source"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Source([NativeTypeName("ABI::Windows::Graphics::Printing::IPrintDocumentSource **")] IPrintDocumentSource** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTask*, IPrintDocumentSource**, int>)(lpVtbl[7]))((IPrintTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTask.xml' path='doc/member[@name="IPrintTask.get_Options"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Options([NativeTypeName("ABI::Windows::Graphics::Printing::IPrintTaskOptionsCore **")] IPrintTaskOptionsCore** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTask*, IPrintTaskOptionsCore**, int>)(lpVtbl[8]))((IPrintTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTask.xml' path='doc/member[@name="IPrintTask.add_Previewing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_Previewing([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CPrintTask_IInspectable_t *")] ITypedEventHandler<Pointer<IPrintTask>, Pointer<IInspectable>>* eventHandler, EventRegistrationToken* eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTask*, ITypedEventHandler<Pointer<IPrintTask>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IPrintTask*)Unsafe.AsPointer(ref this), eventHandler, eventCookie);
    }

    /// <include file='IPrintTask.xml' path='doc/member[@name="IPrintTask.remove_Previewing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_Previewing(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTask*, EventRegistrationToken, int>)(lpVtbl[10]))((IPrintTask*)Unsafe.AsPointer(ref this), eventCookie);
    }

    /// <include file='IPrintTask.xml' path='doc/member[@name="IPrintTask.add_Submitting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_Submitting([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CPrintTask_IInspectable_t *")] ITypedEventHandler<Pointer<IPrintTask>, Pointer<IInspectable>>* eventHandler, EventRegistrationToken* eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTask*, ITypedEventHandler<Pointer<IPrintTask>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[11]))((IPrintTask*)Unsafe.AsPointer(ref this), eventHandler, eventCookie);
    }

    /// <include file='IPrintTask.xml' path='doc/member[@name="IPrintTask.remove_Submitting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_Submitting(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTask*, EventRegistrationToken, int>)(lpVtbl[12]))((IPrintTask*)Unsafe.AsPointer(ref this), eventCookie);
    }

    /// <include file='IPrintTask.xml' path='doc/member[@name="IPrintTask.add_Progressing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_Progressing([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CPrintTask_Windows__CGraphics__CPrinting__CPrintTaskProgressingEventArgs_t *")] ITypedEventHandler<Pointer<IPrintTask>, Pointer<IPrintTaskProgressingEventArgs>>* eventHandler, EventRegistrationToken* eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTask*, ITypedEventHandler<Pointer<IPrintTask>, Pointer<IPrintTaskProgressingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[13]))((IPrintTask*)Unsafe.AsPointer(ref this), eventHandler, eventCookie);
    }

    /// <include file='IPrintTask.xml' path='doc/member[@name="IPrintTask.remove_Progressing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_Progressing(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTask*, EventRegistrationToken, int>)(lpVtbl[14]))((IPrintTask*)Unsafe.AsPointer(ref this), eventCookie);
    }

    /// <include file='IPrintTask.xml' path='doc/member[@name="IPrintTask.add_Completed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT add_Completed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CPrintTask_Windows__CGraphics__CPrinting__CPrintTaskCompletedEventArgs_t *")] ITypedEventHandler<Pointer<IPrintTask>, Pointer<IPrintTaskCompletedEventArgs>>* eventHandler, EventRegistrationToken* eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTask*, ITypedEventHandler<Pointer<IPrintTask>, Pointer<IPrintTaskCompletedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[15]))((IPrintTask*)Unsafe.AsPointer(ref this), eventHandler, eventCookie);
    }

    /// <include file='IPrintTask.xml' path='doc/member[@name="IPrintTask.remove_Completed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT remove_Completed(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTask*, EventRegistrationToken, int>)(lpVtbl[16]))((IPrintTask*)Unsafe.AsPointer(ref this), eventCookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Properties([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackagePropertySet **")] IDataPackagePropertySet** value);

        [VtblIndex(7)]
        HRESULT get_Source([NativeTypeName("ABI::Windows::Graphics::Printing::IPrintDocumentSource **")] IPrintDocumentSource** value);

        [VtblIndex(8)]
        HRESULT get_Options([NativeTypeName("ABI::Windows::Graphics::Printing::IPrintTaskOptionsCore **")] IPrintTaskOptionsCore** value);

        [VtblIndex(9)]
        HRESULT add_Previewing([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CPrintTask_IInspectable_t *")] ITypedEventHandler<Pointer<IPrintTask>, Pointer<IInspectable>>* eventHandler, EventRegistrationToken* eventCookie);

        [VtblIndex(10)]
        HRESULT remove_Previewing(EventRegistrationToken eventCookie);

        [VtblIndex(11)]
        HRESULT add_Submitting([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CPrintTask_IInspectable_t *")] ITypedEventHandler<Pointer<IPrintTask>, Pointer<IInspectable>>* eventHandler, EventRegistrationToken* eventCookie);

        [VtblIndex(12)]
        HRESULT remove_Submitting(EventRegistrationToken eventCookie);

        [VtblIndex(13)]
        HRESULT add_Progressing([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CPrintTask_Windows__CGraphics__CPrinting__CPrintTaskProgressingEventArgs_t *")] ITypedEventHandler<Pointer<IPrintTask>, Pointer<IPrintTaskProgressingEventArgs>>* eventHandler, EventRegistrationToken* eventCookie);

        [VtblIndex(14)]
        HRESULT remove_Progressing(EventRegistrationToken eventCookie);

        [VtblIndex(15)]
        HRESULT add_Completed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CPrintTask_Windows__CGraphics__CPrinting__CPrintTaskCompletedEventArgs_t *")] ITypedEventHandler<Pointer<IPrintTask>, Pointer<IPrintTaskCompletedEventArgs>>* eventHandler, EventRegistrationToken* eventCookie);

        [VtblIndex(16)]
        HRESULT remove_Completed(EventRegistrationToken eventCookie);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IDataPackagePropertySet **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDataPackagePropertySet**, int> get_Properties;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::IPrintDocumentSource **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintDocumentSource**, int> get_Source;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::IPrintTaskOptionsCore **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintTaskOptionsCore**, int> get_Options;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CPrintTask_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPrintTask>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_Previewing;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Previewing;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CPrintTask_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPrintTask>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_Submitting;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Submitting;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CPrintTask_Windows__CGraphics__CPrinting__CPrintTaskProgressingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPrintTask>, Pointer<IPrintTaskProgressingEventArgs>>*, EventRegistrationToken*, int> add_Progressing;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Progressing;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CPrintTask_Windows__CGraphics__CPrinting__CPrintTaskCompletedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPrintTask>, Pointer<IPrintTaskCompletedEventArgs>>*, EventRegistrationToken*, int> add_Completed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Completed;
    }
}
