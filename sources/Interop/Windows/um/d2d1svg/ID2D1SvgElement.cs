// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1svg.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Interface for all SVG elements.</summary>
    [Guid("AC7B67A6-183E-49C1-A823-0EBE40B0DB29")]
    public unsafe struct ID2D1SvgElement
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1SvgElement* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1SvgElement* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1SvgElement* This);

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1SvgElement* This, ID2D1Factory** factory);

        /// <summary>Gets the document that contains this element. Returns null if the element has been removed from the tree.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDocument(ID2D1SvgElement* This, ID2D1SvgDocument** document);

        /// <summary>Gets the tag name.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTagName(ID2D1SvgElement* This, [NativeTypeName("PWSTR")] char* name, [NativeTypeName("UINT32")] uint nameCount);

        /// <summary>Gets the string length of the tag name. The returned string length does not include room for the null terminator.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetTagNameLength(ID2D1SvgElement* This);

        /// <summary>Returns TRUE if this element represents text content, e.g. the content of a 'title' or 'desc' element. Text content does not have a tag name.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsTextContent(ID2D1SvgElement* This);

        /// <summary>Gets the parent element.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetParent(ID2D1SvgElement* This, ID2D1SvgElement** parent);

        /// <summary>Returns whether this element has children.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _HasChildren(ID2D1SvgElement* This);

        /// <summary>Gets the first child of this element.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFirstChild(ID2D1SvgElement* This, ID2D1SvgElement** child);

        /// <summary>Gets the last child of this element.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetLastChild(ID2D1SvgElement* This, ID2D1SvgElement** child);

        /// <summary>Gets the previous sibling of the referenceChild element.</summary>
        /// <param name="referenceChild">The referenceChild must be an immediate child of this element.</param>
        /// <param name="previousChild">The output previousChild element will be non-null if the referenceChild has a previous sibling. If the referenceChild is the first child, the output is null.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPreviousChild(ID2D1SvgElement* This, ID2D1SvgElement* referenceChild, ID2D1SvgElement** previousChild);

        /// <summary>Gets the next sibling of the referenceChild element.</summary>
        /// <param name="referenceChild">The referenceChild must be an immediate child of this element.</param>
        /// <param name="nextChild">The output nextChild element will be non-null if the referenceChild has a next sibling. If the referenceChild is the last child, the output is null.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetNextChild(ID2D1SvgElement* This, ID2D1SvgElement* referenceChild, ID2D1SvgElement** nextChild);

        /// <summary>Inserts newChild as a child of this element, before the referenceChild element. If the newChild element already has a parent, it is removed from this parent as part of the insertion. Returns an error if this element cannot accept children of the type of newChild. Returns an error if the newChild is an ancestor of this element.</summary>
        /// <param name="newChild">The element to be inserted.</param>
        /// <param name="referenceChild">The element that the child should be inserted before. If referenceChild is null, the newChild is placed as the last child. If referenceChild is non-null, it must be an immediate child of this element.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InsertChildBefore(ID2D1SvgElement* This, ID2D1SvgElement* newChild, ID2D1SvgElement* referenceChild = null);

        /// <summary>Appends newChild to the list of children. If the newChild element already has a parent, it is removed from this parent as part of the append operation. Returns an error if this element cannot accept children of the type of newChild. Returns an error if the newChild is an ancestor of this element.</summary>
        /// <param name="newChild">The element to be appended.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AppendChild(ID2D1SvgElement* This, ID2D1SvgElement* newChild);

        /// <summary>Replaces the oldChild element with the newChild. This operation removes the oldChild from the tree. If the newChild element already has a parent, it is removed from this parent as part of the replace operation. Returns an error if this element cannot accept children of the type of newChild. Returns an error if the newChild is an ancestor of this element.</summary>
        /// <param name="newChild">The element to be inserted.</param>
        /// <param name="oldChild">The child element to be replaced. The oldChild element must be an immediate child of this element.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReplaceChild(ID2D1SvgElement* This, ID2D1SvgElement* newChild, ID2D1SvgElement* oldChild);

        /// <summary>Removes the oldChild from the tree. Children of oldChild remain children of oldChild.</summary>
        /// <param name="oldChild">The child element to be removed. The oldChild element must be an immediate child of this element.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RemoveChild(ID2D1SvgElement* This, ID2D1SvgElement* oldChild);

        /// <summary>Creates an element from a tag name. The element is appended to the list of children. Returns an error if this element cannot accept children of the specified type.</summary>
        /// <param name="tagName">The tag name of the new child. A NULL tagName or an empty string is interpreted to be a text content element.</param>
        /// <param name="newChild">The new child element.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateChild(ID2D1SvgElement* This, [Optional, NativeTypeName("PCWSTR")] char* tagName, ID2D1SvgElement** newChild);

        /// <summary>Returns true if the attribute is explicitly set on the element or if it is present within an inline style. Returns FALSE if the attribute is not a valid attribute on this element.</summary>
        /// <param name="name">The name of the attribute.</param>
        /// <param name="inherited">Outputs whether the attribute is set to the 'inherit' value.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsAttributeSpecified(ID2D1SvgElement* This, [NativeTypeName("PCWSTR")] char* name, [NativeTypeName("BOOL")] int* inherited = null);

        /// <summary>Returns the number of specified attributes on this element. Attributes are only considered specified if they are explicitly set on the element or present within an inline style. Properties that receive their value through CSS inheritance are not considered specified. An attribute can become specified if it is set through a method call. It can become unspecified if it is removed via RemoveAttribute.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetSpecifiedAttributeCount(ID2D1SvgElement* This);

        /// <summary>Gets the name of the specified attribute at the given index.</summary>
        /// <param name="index">The specified index of the attribute.</param>
        /// <param name="name">Outputs the name of the attribute.</param>
        /// <param name="inherited">Outputs whether the attribute is set to the 'inherit' value.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSpecifiedAttributeName(ID2D1SvgElement* This, [NativeTypeName("UINT32")] uint index, [NativeTypeName("PWSTR")] char* name, [NativeTypeName("UINT32")] uint nameCount, [NativeTypeName("BOOL")] int* inherited = null);

        /// <summary>Gets the string length of the name of the specified attribute at the given index. The output string length does not include room for the null terminator.</summary>
        /// <param name="index">The specified index of the attribute.</param>
        /// <param name="nameLength">Outputs the string length of the name of the specified attribute.</param>
        /// <param name="inherited">Outputs whether the attribute is set to the 'inherit' value.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSpecifiedAttributeNameLength(ID2D1SvgElement* This, [NativeTypeName("UINT32")] uint index, [NativeTypeName("UINT32")] uint* nameLength, [NativeTypeName("BOOL")] int* inherited = null);

        /// <summary>Removes the attribute from this element. Also removes this attribute from within an inline style if present. Returns an error if the attribute name is not valid on this element.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RemoveAttribute(ID2D1SvgElement* This, [NativeTypeName("PCWSTR")] char* name);

        /// <summary>Sets the value of a text content element.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTextValue(ID2D1SvgElement* This, [NativeTypeName("WCHAR[]")] char* name, [NativeTypeName("UINT32")] uint nameCount);

        /// <summary>Gets the value of a text content element.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTextValue(ID2D1SvgElement* This, [NativeTypeName("PWSTR")] char* name, [NativeTypeName("UINT32")] uint nameCount);

        /// <summary>Gets the length of the text content value. The returned string length does not include room for the null terminator.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetTextValueLength(ID2D1SvgElement* This);

        /// <summary>Sets an attribute of this element using a string. Returns an error if the attribute name is not valid on this element. Returns an error if the attribute cannot be expressed as the specified type.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetAttributeValue(ID2D1SvgElement* This, [NativeTypeName("PCWSTR")] char* name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, [NativeTypeName("PCWSTR")] char* value);

        /// <summary>Gets an attribute of this element as a string. Returns an error if the attribute is not specified. Returns an error if the attribute name is not valid on this element. Returns an error if the attribute cannot be expressed as the specified string type.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAttributeValue(ID2D1SvgElement* This, [NativeTypeName("PCWSTR")] char* name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, [NativeTypeName("PWSTR")] char* value, [NativeTypeName("UINT32")] uint valueCount);

        /// <summary>Gets the string length of an attribute of this element. The returned string length does not include room for the null terminator. Returns an error if the attribute is not specified. Returns an error if the attribute name is not valid on this element. Returns an error if the attribute cannot be expressed as the specified string type.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAttributeValueLength(ID2D1SvgElement* This, [NativeTypeName("PCWSTR")] char* name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, [NativeTypeName("UINT32")] uint* valueLength);

        /// <summary>Sets an attribute of this element using a POD type. Returns an error if the attribute name is not valid on this element. Returns an error if the attribute cannot be expressed as the specified type.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetAttributeValue1(ID2D1SvgElement* This, [NativeTypeName("PCWSTR")] char* name, D2D1_SVG_ATTRIBUTE_POD_TYPE type, void* value, [NativeTypeName("UINT32")] uint valueSizeInBytes);

        /// <summary>Gets an attribute of this element as a POD type. Returns an error if the attribute is not specified. Returns an error if the attribute name is not valid on this element. Returns an error if the attribute cannot be expressed as the specified POD type.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAttributeValue1(ID2D1SvgElement* This, [NativeTypeName("PCWSTR")] char* name, D2D1_SVG_ATTRIBUTE_POD_TYPE type, void* value, [NativeTypeName("UINT32")] uint valueSizeInBytes);

        /// <summary>Sets an attribute of this element using an interface. Returns an error if the attribute name is not valid on this element. Returns an error if the attribute cannot be expressed as the specified interface type. Returns an error if the attribute object is already set on an element. A given attribute object may only be set on one element in one attribute location at a time.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetAttributeValue2(ID2D1SvgElement* This, [NativeTypeName("PCWSTR")] char* name, ID2D1SvgAttribute* value);

        /// <summary>Gets an attribute of this element as an interface type. Returns an error if the attribute is not specified. Returns an error if the attribute name is not valid on this element. Returns an error if the attribute cannot be expressed as the specified interface type.</summary>
        /// <param name="riid">The interface ID of the attribute value.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAttributeValue2(ID2D1SvgElement* This, [NativeTypeName("PCWSTR")] char* name, [NativeTypeName("REFIID")] Guid* riid, void** value);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void GetFactory(ID2D1Factory** factory)
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(This, factory);
            }
        }

        public void GetDocument(ID2D1SvgDocument** document)
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetDocument>(lpVtbl->GetDocument)(This, document);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTagName([NativeTypeName("PWSTR")] char* name, [NativeTypeName("UINT32")] uint nameCount)
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTagName>(lpVtbl->GetTagName)(This, name, nameCount);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetTagNameLength()
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTagNameLength>(lpVtbl->GetTagNameLength)(This);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsTextContent()
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsTextContent>(lpVtbl->IsTextContent)(This);
            }
        }

        public void GetParent(ID2D1SvgElement** parent)
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetParent>(lpVtbl->GetParent)(This, parent);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int HasChildren()
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_HasChildren>(lpVtbl->HasChildren)(This);
            }
        }

        public void GetFirstChild(ID2D1SvgElement** child)
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFirstChild>(lpVtbl->GetFirstChild)(This, child);
            }
        }

        public void GetLastChild(ID2D1SvgElement** child)
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetLastChild>(lpVtbl->GetLastChild)(This, child);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPreviousChild(ID2D1SvgElement* referenceChild, ID2D1SvgElement** previousChild)
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPreviousChild>(lpVtbl->GetPreviousChild)(This, referenceChild, previousChild);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNextChild(ID2D1SvgElement* referenceChild, ID2D1SvgElement** nextChild)
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetNextChild>(lpVtbl->GetNextChild)(This, referenceChild, nextChild);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int InsertChildBefore(ID2D1SvgElement* newChild, ID2D1SvgElement* referenceChild = null)
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_InsertChildBefore>(lpVtbl->InsertChildBefore)(This, newChild, referenceChild);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AppendChild(ID2D1SvgElement* newChild)
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AppendChild>(lpVtbl->AppendChild)(This, newChild);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ReplaceChild(ID2D1SvgElement* newChild, ID2D1SvgElement* oldChild)
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ReplaceChild>(lpVtbl->ReplaceChild)(This, newChild, oldChild);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveChild(ID2D1SvgElement* oldChild)
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RemoveChild>(lpVtbl->RemoveChild)(This, oldChild);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateChild([Optional, NativeTypeName("PCWSTR")] char* tagName, ID2D1SvgElement** newChild)
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateChild>(lpVtbl->CreateChild)(This, tagName, newChild);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsAttributeSpecified([NativeTypeName("PCWSTR")] char* name, [NativeTypeName("BOOL")] int* inherited = null)
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsAttributeSpecified>(lpVtbl->IsAttributeSpecified)(This, name, inherited);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetSpecifiedAttributeCount()
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSpecifiedAttributeCount>(lpVtbl->GetSpecifiedAttributeCount)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSpecifiedAttributeName([NativeTypeName("UINT32")] uint index, [NativeTypeName("PWSTR")] char* name, [NativeTypeName("UINT32")] uint nameCount, [NativeTypeName("BOOL")] int* inherited = null)
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSpecifiedAttributeName>(lpVtbl->GetSpecifiedAttributeName)(This, index, name, nameCount, inherited);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSpecifiedAttributeNameLength([NativeTypeName("UINT32")] uint index, [NativeTypeName("UINT32")] uint* nameLength, [NativeTypeName("BOOL")] int* inherited = null)
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSpecifiedAttributeNameLength>(lpVtbl->GetSpecifiedAttributeNameLength)(This, index, nameLength, inherited);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveAttribute([NativeTypeName("PCWSTR")] char* name)
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RemoveAttribute>(lpVtbl->RemoveAttribute)(This, name);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTextValue([NativeTypeName("WCHAR[]")] char* name, [NativeTypeName("UINT32")] uint nameCount)
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetTextValue>(lpVtbl->SetTextValue)(This, name, nameCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTextValue([NativeTypeName("PWSTR")] char* name, [NativeTypeName("UINT32")] uint nameCount)
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTextValue>(lpVtbl->GetTextValue)(This, name, nameCount);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetTextValueLength()
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTextValueLength>(lpVtbl->GetTextValueLength)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] char* name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, [NativeTypeName("PCWSTR")] char* value)
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetAttributeValue>(lpVtbl->SetAttributeValue)(This, name, type, value);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] char* name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, [NativeTypeName("PWSTR")] char* value, [NativeTypeName("UINT32")] uint valueCount)
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetAttributeValue>(lpVtbl->GetAttributeValue)(This, name, type, value, valueCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValueLength([NativeTypeName("PCWSTR")] char* name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, [NativeTypeName("UINT32")] uint* valueLength)
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetAttributeValueLength>(lpVtbl->GetAttributeValueLength)(This, name, type, valueLength);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue1([NativeTypeName("PCWSTR")] char* name, D2D1_SVG_ATTRIBUTE_POD_TYPE type, void* value, [NativeTypeName("UINT32")] uint valueSizeInBytes)
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetAttributeValue1>(lpVtbl->SetAttributeValue1)(This, name, type, value, valueSizeInBytes);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue1([NativeTypeName("PCWSTR")] char* name, D2D1_SVG_ATTRIBUTE_POD_TYPE type, void* value, [NativeTypeName("UINT32")] uint valueSizeInBytes)
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetAttributeValue1>(lpVtbl->GetAttributeValue1)(This, name, type, value, valueSizeInBytes);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue2([NativeTypeName("PCWSTR")] char* name, ID2D1SvgAttribute* value)
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetAttributeValue2>(lpVtbl->SetAttributeValue2)(This, name, value);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue2([NativeTypeName("PCWSTR")] char* name, [NativeTypeName("REFIID")] Guid* riid, void** value)
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetAttributeValue2>(lpVtbl->GetAttributeValue2)(This, name, riid, value);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFactory;

            public IntPtr GetDocument;

            public IntPtr GetTagName;

            public IntPtr GetTagNameLength;

            public IntPtr IsTextContent;

            public IntPtr GetParent;

            public IntPtr HasChildren;

            public IntPtr GetFirstChild;

            public IntPtr GetLastChild;

            public IntPtr GetPreviousChild;

            public IntPtr GetNextChild;

            public IntPtr InsertChildBefore;

            public IntPtr AppendChild;

            public IntPtr ReplaceChild;

            public IntPtr RemoveChild;

            public IntPtr CreateChild;

            public IntPtr IsAttributeSpecified;

            public IntPtr GetSpecifiedAttributeCount;

            public IntPtr GetSpecifiedAttributeName;

            public IntPtr GetSpecifiedAttributeNameLength;

            public IntPtr RemoveAttribute;

            public IntPtr SetTextValue;

            public IntPtr GetTextValue;

            public IntPtr GetTextValueLength;

            public IntPtr SetAttributeValue;

            public IntPtr GetAttributeValue;

            public IntPtr GetAttributeValueLength;

            public IntPtr SetAttributeValue1;

            public IntPtr GetAttributeValue1;

            public IntPtr SetAttributeValue2;

            public IntPtr GetAttributeValue2;
        }
    }
}
