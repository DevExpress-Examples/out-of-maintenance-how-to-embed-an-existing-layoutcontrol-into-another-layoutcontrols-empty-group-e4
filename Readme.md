<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128632953/12.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4444)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to embed an existing layoutControl into another layoutControl's empty group


<p>This example demonstrates how to embed an existing layoutControl into another layoutControl's empty group</p>


<h3>Description</h3>

<p>To put the LayoutControl in LayoutControlGroup of another layout, use the LayoutControlGroup.AddItem method. This method receives a LayoutControlItem object. Thus, at first we need to create a new LayoutControlItem instance, put LayoutControl1 in the Control property of the item, and after this call the LayoutControlGroup.AddItem method.</p>

<br/>


