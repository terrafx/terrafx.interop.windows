// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D2D1;
using static TerraFX.Interop.D2D1_SVG_ATTRIBUTE_POD_TYPE;

namespace TerraFX.Interop
{
    [Guid("AC7B67A6-183E-49C1-A823-0EBE40B0DB29")]
    public unsafe partial struct ID2D1SvgElement
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1SvgElement* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1SvgElement* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1SvgElement* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1SvgElement* pThis, [NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDocument(ID2D1SvgElement* pThis, [NativeTypeName("ID2D1SvgDocument **")] ID2D1SvgDocument** document);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTagName(ID2D1SvgElement* pThis, [NativeTypeName("PWSTR")] ushort* name, [NativeTypeName("UINT32")] uint nameCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetTagNameLength(ID2D1SvgElement* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsTextContent(ID2D1SvgElement* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetParent(ID2D1SvgElement* pThis, [NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** parent);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _HasChildren(ID2D1SvgElement* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFirstChild(ID2D1SvgElement* pThis, [NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** child);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetLastChild(ID2D1SvgElement* pThis, [NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** child);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPreviousChild(ID2D1SvgElement* pThis, [NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* referenceChild, [NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** previousChild);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetNextChild(ID2D1SvgElement* pThis, [NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* referenceChild, [NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** nextChild);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InsertChildBefore(ID2D1SvgElement* pThis, [NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* newChild, [NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* referenceChild);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AppendChild(ID2D1SvgElement* pThis, [NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* newChild);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReplaceChild(ID2D1SvgElement* pThis, [NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* newChild, [NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* oldChild);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RemoveChild(ID2D1SvgElement* pThis, [NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* oldChild);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateChild(ID2D1SvgElement* pThis, [NativeTypeName("PCWSTR")] ushort* tagName, [NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** newChild);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsAttributeSpecified(ID2D1SvgElement* pThis, [NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("BOOL *")] int* inherited);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetSpecifiedAttributeCount(ID2D1SvgElement* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSpecifiedAttributeName(ID2D1SvgElement* pThis, [NativeTypeName("UINT32")] uint index, [NativeTypeName("PWSTR")] ushort* name, [NativeTypeName("UINT32")] uint nameCount, [NativeTypeName("BOOL *")] int* inherited);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSpecifiedAttributeNameLength(ID2D1SvgElement* pThis, [NativeTypeName("UINT32")] uint index, [NativeTypeName("UINT32 *")] uint* nameLength, [NativeTypeName("BOOL *")] int* inherited);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RemoveAttribute(ID2D1SvgElement* pThis, [NativeTypeName("PCWSTR")] ushort* name);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTextValue(ID2D1SvgElement* pThis, [NativeTypeName("const WCHAR *")] ushort* name, [NativeTypeName("UINT32")] uint nameCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTextValue(ID2D1SvgElement* pThis, [NativeTypeName("PWSTR")] ushort* name, [NativeTypeName("UINT32")] uint nameCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetTextValueLength(ID2D1SvgElement* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetAttributeValue(ID2D1SvgElement* pThis, [NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, [NativeTypeName("PCWSTR")] ushort* value);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAttributeValue(ID2D1SvgElement* pThis, [NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, [NativeTypeName("PWSTR")] ushort* value, [NativeTypeName("UINT32")] uint valueCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAttributeValueLength(ID2D1SvgElement* pThis, [NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, [NativeTypeName("UINT32 *")] uint* valueLength);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetAttributeValue1(ID2D1SvgElement* pThis, [NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_POD_TYPE type, [NativeTypeName("const void *")] void* value, [NativeTypeName("UINT32")] uint valueSizeInBytes);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAttributeValue1(ID2D1SvgElement* pThis, [NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_POD_TYPE type, [NativeTypeName("void *")] void* value, [NativeTypeName("UINT32")] uint valueSizeInBytes);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetAttributeValue2(ID2D1SvgElement* pThis, [NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("ID2D1SvgAttribute *")] ID2D1SvgAttribute* value);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAttributeValue2(ID2D1SvgElement* pThis, [NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** value);

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("FLOAT")] float value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_FLOAT, &value, sizeof(float));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("FLOAT *")] float* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_FLOAT, value, unchecked((uint)sizeof(float)));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("const D2D1_COLOR_F &")] DXGI_RGBA* value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_COLOR, &value, unchecked((uint)sizeof(DXGI_RGBA)));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_COLOR_F *")] DXGI_RGBA* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_COLOR, value, unchecked((uint)sizeof(DXGI_RGBA)));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_FILL_MODE value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_FILL_MODE, &value, sizeof(D2D1_FILL_MODE));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_FILL_MODE *")] D2D1_FILL_MODE* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_FILL_MODE, value, sizeof(D2D1_FILL_MODE));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_DISPLAY value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_DISPLAY, &value, sizeof(D2D1_SVG_DISPLAY));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_SVG_DISPLAY *")] D2D1_SVG_DISPLAY* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_DISPLAY, value, sizeof(D2D1_SVG_DISPLAY));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_OVERFLOW value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_OVERFLOW, &value, sizeof(D2D1_SVG_OVERFLOW));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_SVG_OVERFLOW *")] D2D1_SVG_OVERFLOW* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_OVERFLOW, value, sizeof(D2D1_SVG_OVERFLOW));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_LINE_JOIN value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_JOIN, &value, sizeof(D2D1_SVG_LINE_JOIN));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_SVG_LINE_JOIN *")] D2D1_SVG_LINE_JOIN* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_JOIN, value, sizeof(D2D1_SVG_LINE_JOIN));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_LINE_CAP value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_CAP, &value, sizeof(D2D1_SVG_LINE_CAP));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_SVG_LINE_CAP *")] D2D1_SVG_LINE_CAP* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_CAP, value, sizeof(D2D1_SVG_LINE_CAP));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_VISIBILITY value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_VISIBILITY, &value, sizeof(D2D1_SVG_VISIBILITY));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_SVG_VISIBILITY *")] D2D1_SVG_VISIBILITY* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_VISIBILITY, value, sizeof(D2D1_SVG_VISIBILITY));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_MATRIX, value, unchecked((uint)sizeof(D2D_MATRIX_3X2_F)));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_UNIT_TYPE value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_UNIT_TYPE, &value, sizeof(D2D1_SVG_UNIT_TYPE));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_SVG_UNIT_TYPE *")] D2D1_SVG_UNIT_TYPE* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_UNIT_TYPE, value, sizeof(D2D1_SVG_UNIT_TYPE));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_EXTEND_MODE value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_EXTEND_MODE, &value, sizeof(D2D1_EXTEND_MODE));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_EXTEND_MODE *")] D2D1_EXTEND_MODE* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_EXTEND_MODE, value, sizeof(D2D1_EXTEND_MODE));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_SVG_PRESERVE_ASPECT_RATIO *")] D2D1_SVG_PRESERVE_ASPECT_RATIO* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_PRESERVE_ASPECT_RATIO, value, unchecked((uint)sizeof(D2D1_SVG_PRESERVE_ASPECT_RATIO)));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_SVG_LENGTH *")] D2D1_SVG_LENGTH* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_LENGTH, value, unchecked((uint)sizeof(D2D1_SVG_LENGTH)));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("ID2D1SvgAttribute **")] ID2D1SvgAttribute** value)
        {
            var iid = IID_ID2D1SvgAttribute;
            return GetAttributeValue(name, &iid, (void**)value);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("ID2D1SvgPaint **")] ID2D1SvgPaint** value)
        {
            var iid = IID_ID2D1SvgPaint;
            return GetAttributeValue(name, &iid, (void**)value);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("ID2D1SvgStrokeDashArray **")] ID2D1SvgStrokeDashArray** value)
        {
            var iid = IID_ID2D1SvgStrokeDashArray;
            return GetAttributeValue(name, &iid, (void**)value);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("ID2D1SvgPointCollection **")] ID2D1SvgPointCollection** value)
        {
            var iid = IID_ID2D1SvgPointCollection;
            return GetAttributeValue(name, &iid, (void**)value);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("ID2D1SvgPathData **")] ID2D1SvgPathData** value)
        {
            var iid = IID_ID2D1SvgPathData;
            return GetAttributeValue(name, &iid, (void**)value);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1SvgElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)((ID2D1SvgElement*)Unsafe.AsPointer(ref this), factory);
        }

        public void GetDocument([NativeTypeName("ID2D1SvgDocument **")] ID2D1SvgDocument** document)
        {
            Marshal.GetDelegateForFunctionPointer<_GetDocument>(lpVtbl->GetDocument)((ID2D1SvgElement*)Unsafe.AsPointer(ref this), document);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTagName([NativeTypeName("PWSTR")] ushort* name, [NativeTypeName("UINT32")] uint nameCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTagName>(lpVtbl->GetTagName)((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, nameCount);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetTagNameLength()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTagNameLength>(lpVtbl->GetTagNameLength)((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int IsTextContent()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsTextContent>(lpVtbl->IsTextContent)((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
        }

        public void GetParent([NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** parent)
        {
            Marshal.GetDelegateForFunctionPointer<_GetParent>(lpVtbl->GetParent)((ID2D1SvgElement*)Unsafe.AsPointer(ref this), parent);
        }

        [return: NativeTypeName("BOOL")]
        public int HasChildren()
        {
            return Marshal.GetDelegateForFunctionPointer<_HasChildren>(lpVtbl->HasChildren)((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
        }

        public void GetFirstChild([NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** child)
        {
            Marshal.GetDelegateForFunctionPointer<_GetFirstChild>(lpVtbl->GetFirstChild)((ID2D1SvgElement*)Unsafe.AsPointer(ref this), child);
        }

        public void GetLastChild([NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** child)
        {
            Marshal.GetDelegateForFunctionPointer<_GetLastChild>(lpVtbl->GetLastChild)((ID2D1SvgElement*)Unsafe.AsPointer(ref this), child);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPreviousChild([NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* referenceChild, [NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** previousChild)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPreviousChild>(lpVtbl->GetPreviousChild)((ID2D1SvgElement*)Unsafe.AsPointer(ref this), referenceChild, previousChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNextChild([NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* referenceChild, [NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** nextChild)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetNextChild>(lpVtbl->GetNextChild)((ID2D1SvgElement*)Unsafe.AsPointer(ref this), referenceChild, nextChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int InsertChildBefore([NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* newChild, [NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* referenceChild)
        {
            return Marshal.GetDelegateForFunctionPointer<_InsertChildBefore>(lpVtbl->InsertChildBefore)((ID2D1SvgElement*)Unsafe.AsPointer(ref this), newChild, referenceChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int AppendChild([NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* newChild)
        {
            return Marshal.GetDelegateForFunctionPointer<_AppendChild>(lpVtbl->AppendChild)((ID2D1SvgElement*)Unsafe.AsPointer(ref this), newChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReplaceChild([NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* newChild, [NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* oldChild)
        {
            return Marshal.GetDelegateForFunctionPointer<_ReplaceChild>(lpVtbl->ReplaceChild)((ID2D1SvgElement*)Unsafe.AsPointer(ref this), newChild, oldChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveChild([NativeTypeName("ID2D1SvgElement *")] ID2D1SvgElement* oldChild)
        {
            return Marshal.GetDelegateForFunctionPointer<_RemoveChild>(lpVtbl->RemoveChild)((ID2D1SvgElement*)Unsafe.AsPointer(ref this), oldChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateChild([NativeTypeName("PCWSTR")] ushort* tagName, [NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** newChild)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateChild>(lpVtbl->CreateChild)((ID2D1SvgElement*)Unsafe.AsPointer(ref this), tagName, newChild);
        }

        [return: NativeTypeName("BOOL")]
        public int IsAttributeSpecified([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("BOOL *")] int* inherited)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsAttributeSpecified>(lpVtbl->IsAttributeSpecified)((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, inherited);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetSpecifiedAttributeCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSpecifiedAttributeCount>(lpVtbl->GetSpecifiedAttributeCount)((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSpecifiedAttributeName([NativeTypeName("UINT32")] uint index, [NativeTypeName("PWSTR")] ushort* name, [NativeTypeName("UINT32")] uint nameCount, [NativeTypeName("BOOL *")] int* inherited)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSpecifiedAttributeName>(lpVtbl->GetSpecifiedAttributeName)((ID2D1SvgElement*)Unsafe.AsPointer(ref this), index, name, nameCount, inherited);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSpecifiedAttributeNameLength([NativeTypeName("UINT32")] uint index, [NativeTypeName("UINT32 *")] uint* nameLength, [NativeTypeName("BOOL *")] int* inherited)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSpecifiedAttributeNameLength>(lpVtbl->GetSpecifiedAttributeNameLength)((ID2D1SvgElement*)Unsafe.AsPointer(ref this), index, nameLength, inherited);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveAttribute([NativeTypeName("PCWSTR")] ushort* name)
        {
            return Marshal.GetDelegateForFunctionPointer<_RemoveAttribute>(lpVtbl->RemoveAttribute)((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTextValue([NativeTypeName("const WCHAR *")] ushort* name, [NativeTypeName("UINT32")] uint nameCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTextValue>(lpVtbl->SetTextValue)((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, nameCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTextValue([NativeTypeName("PWSTR")] ushort* name, [NativeTypeName("UINT32")] uint nameCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTextValue>(lpVtbl->GetTextValue)((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, nameCount);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetTextValueLength()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTextValueLength>(lpVtbl->GetTextValueLength)((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, [NativeTypeName("PCWSTR")] ushort* value)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetAttributeValue>(lpVtbl->SetAttributeValue)((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, type, value);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, [NativeTypeName("PWSTR")] ushort* value, [NativeTypeName("UINT32")] uint valueCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAttributeValue>(lpVtbl->GetAttributeValue)((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, type, value, valueCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValueLength([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, [NativeTypeName("UINT32 *")] uint* valueLength)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAttributeValueLength>(lpVtbl->GetAttributeValueLength)((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, type, valueLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_POD_TYPE type, [NativeTypeName("const void *")] void* value, [NativeTypeName("UINT32")] uint valueSizeInBytes)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetAttributeValue1>(lpVtbl->SetAttributeValue1)((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, type, value, valueSizeInBytes);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_POD_TYPE type, [NativeTypeName("void *")] void* value, [NativeTypeName("UINT32")] uint valueSizeInBytes)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAttributeValue1>(lpVtbl->GetAttributeValue1)((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, type, value, valueSizeInBytes);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("ID2D1SvgAttribute *")] ID2D1SvgAttribute* value)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetAttributeValue2>(lpVtbl->SetAttributeValue2)((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, value);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** value)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAttributeValue2>(lpVtbl->GetAttributeValue2)((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, riid, value);
        }
































        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFactory;

            [NativeTypeName("void (ID2D1SvgDocument **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDocument;

            [NativeTypeName("HRESULT (PWSTR, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetTagName;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetTagNameLength;

            [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr IsTextContent;

            [NativeTypeName("void (ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetParent;

            [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr HasChildren;

            [NativeTypeName("void (ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFirstChild;

            [NativeTypeName("void (ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetLastChild;

            [NativeTypeName("HRESULT (ID2D1SvgElement *, ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPreviousChild;

            [NativeTypeName("HRESULT (ID2D1SvgElement *, ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetNextChild;

            [NativeTypeName("HRESULT (ID2D1SvgElement *, ID2D1SvgElement *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr InsertChildBefore;

            [NativeTypeName("HRESULT (ID2D1SvgElement *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr AppendChild;

            [NativeTypeName("HRESULT (ID2D1SvgElement *, ID2D1SvgElement *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr ReplaceChild;

            [NativeTypeName("HRESULT (ID2D1SvgElement *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr RemoveChild;

            [NativeTypeName("HRESULT (PCWSTR, ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateChild;

            [NativeTypeName("BOOL (PCWSTR, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr IsAttributeSpecified;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetSpecifiedAttributeCount;

            [NativeTypeName("HRESULT (UINT32, PWSTR, UINT32, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetSpecifiedAttributeName;

            [NativeTypeName("HRESULT (UINT32, UINT32 *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetSpecifiedAttributeNameLength;

            [NativeTypeName("HRESULT (PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr RemoveAttribute;

            [NativeTypeName("HRESULT (const WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTextValue;

            [NativeTypeName("HRESULT (PWSTR, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetTextValue;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetTextValueLength;

            [NativeTypeName("HRESULT (PCWSTR, D2D1_SVG_ATTRIBUTE_STRING_TYPE, PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetAttributeValue;

            [NativeTypeName("HRESULT (PCWSTR, D2D1_SVG_ATTRIBUTE_STRING_TYPE, PWSTR, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetAttributeValue;

            [NativeTypeName("HRESULT (PCWSTR, D2D1_SVG_ATTRIBUTE_STRING_TYPE, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetAttributeValueLength;

            [NativeTypeName("HRESULT (PCWSTR, D2D1_SVG_ATTRIBUTE_POD_TYPE, const void *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetAttributeValue1;

            [NativeTypeName("HRESULT (PCWSTR, D2D1_SVG_ATTRIBUTE_POD_TYPE, void *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetAttributeValue1;

            [NativeTypeName("HRESULT (PCWSTR, ID2D1SvgAttribute *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetAttributeValue2;

            [NativeTypeName("HRESULT (PCWSTR, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetAttributeValue2;































        }
    }
}
